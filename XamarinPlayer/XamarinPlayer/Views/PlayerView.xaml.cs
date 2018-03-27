﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPlayer.Services;

namespace XamarinPlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerView : ContentPage
    {
        private readonly int DefaultTimeout = 5000;
        private readonly TimeSpan UpdateInterval = TimeSpan.FromMilliseconds(100);
        private readonly TimeSpan DefaultSeekTime = TimeSpan.FromSeconds(20);

        private IPlayerService _playerService;
        private int _hideTime;
        private bool _isPageDisappeared = false;
        private bool _isShowing = false;
        private bool _errorOccured = false;

        public static readonly BindableProperty ContentSourceProperty = BindableProperty.Create("ContentSource", typeof(object), typeof(PlayerView), null);
        public object ContentSource
        {
            set { SetValue(ContentSourceProperty, value); }
            get { return (object)GetValue(ContentSourceProperty); }
        }

        public PlayerView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            _playerService = DependencyService.Get<IPlayerService>(DependencyFetchTarget.NewInstance);
            _playerService.StateChanged += OnPlayerStateChanged;

            PlayButton.Clicked += (s, e) => { Play(); };

            BackButton.Clicked += (s, e) => { Rewind(); };

            ForwardButton.Clicked += (s, e) => { Forward(); };

            SettingsButton.Clicked += (s, e) => { HandleSettings(); };

            PropertyChanged += PlayerViewPropertyChanged;
            
            MessagingCenter.Subscribe<IKeyEventSender, string>(this, "KeyDown", (s, e) => { KeyEventHandler(e); });
        }

        private void Play()
        {
            if (_playerService.State == PlayerState.Playing)
                _playerService.Pause();
            else
                _playerService.Start();
        }

        private void KeyEventHandler(string e)
        {
            if (e.Contains("Back"))
            {
                if (_playerService.State < PlayerState.Playing ||
                    _playerService.State >= PlayerState.Playing && !Controller.IsVisible)
                {
                    Navigation.RemovePage(this);
                }
                else
                {
                    if (Settings.IsVisible)
                        Settings.IsVisible = false;
                    else
                        Hide();
                }
            }
            else
            {
                Show();

                if (e.Contains("Play") && _playerService.State == PlayerState.Paused)
                {
                    _playerService.Start();
                }
                else if (e.Contains("Pause") && _playerService.State == PlayerState.Playing)
                {
                    _playerService.Pause();
                }
                else if (e.Contains("Stop"))
                {
                    Navigation.RemovePage(this);
                }
                else if (e.Contains("Next"))
                {
                    Forward();
                }
                else if (e.Contains("Rewind"))
                {
                    Rewind();
                }
                else if (e.Contains("Blue"))
                {
                    HandleSettings();
                }
            }
        }

        private void HandleSettings()
        {
            Settings.IsVisible = !Settings.IsVisible;
            if (Settings.IsVisible)
            {
                if (AudioTrack.ItemsSource == null)
                    BindStreamPicker(AudioTrack, StreamDescription.StreamType.Audio);
                if (VideoQuality.ItemsSource == null)
                    BindStreamPicker(VideoQuality, StreamDescription.StreamType.Video);

                AudioTrack.Focus();
            }
        }

        private void BindStreamPicker(Picker picker, StreamDescription.StreamType streamType)
        {
            var streams = _playerService.GetStreamsDescription(streamType);
            picker.ItemsSource = streams;
            picker.ItemDisplayBinding = new Binding("Description");
            picker.SelectedIndex = 0;

            for (var i = 0; i < streams.Count; ++i)
            {
                if (streams[i].Default)
                {
                    picker.SelectedIndex = i;
                    break;
                }
            }

            picker.SelectedIndexChanged += (sender, args) =>
            {
                if (picker.SelectedIndex != -1)
                {
                    var stream = (StreamDescription)picker.ItemsSource[picker.SelectedIndex];

                    _playerService.ChangeActiveStream(stream);
                }
            };
        }

        private void Forward()
        {
            if (!_playerService.IsSeekingSupported || _playerService.State < PlayerState.Playing)
                return;

            if (_playerService.Duration - _playerService.CurrentPosition < DefaultSeekTime)
                _playerService.SeekTo(_playerService.Duration);
            else
                _playerService.SeekTo(_playerService.CurrentPosition + DefaultSeekTime);
        }

        private void Rewind()
        {
            if (!_playerService.IsSeekingSupported || _playerService.State < PlayerState.Playing)
                return;

            if (_playerService.CurrentPosition < DefaultSeekTime)
                _playerService.SeekTo(TimeSpan.Zero);
            else
                _playerService.SeekTo(_playerService.CurrentPosition - DefaultSeekTime);
        }

        public void Show()
        {
            Show(DefaultTimeout);
        }

        public void Show(int timeout)
        {
            if (!_isShowing)
            {
                PlayButton.Focus();
                _isShowing = true;
            }
            Controller.IsVisible = true;
            _hideTime = timeout;
        }

        public void Hide()
        {
            Controller.IsVisible = false;
            _isShowing = false;
        }

        private void PlayerViewPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("ContentSource"))
            {
                if (ContentSource == null)
                    return;

                _playerService.SetSource(ContentSource);
            }
        }

        private void OnPlaybackCompleted()
        {
            if (!_errorOccured)
            {
                // Schedule closing the page on the next event loop. Give application time to finish
                // playbackCompleted event handling
                Device.StartTimer(TimeSpan.FromMilliseconds(0), () =>
                {
                    Navigation.RemovePage(this);

                    return false;
                });
                
            }
            else
            {
                // TODO: display an error
                UpdatePlayTime();
                Show();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            PlayButton.Focus();
            Device.StartTimer(UpdateInterval, UpdatePlayerControl);
        }

        protected override void OnDisappearing()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(0), () =>
            {
                _playerService.Dispose();
                _playerService = null;

                return false;
            });
            MessagingCenter.Unsubscribe<IKeyEventSender, string>(this, "KeyDown");
            _isPageDisappeared = true;

            base.OnDisappearing();
        }

        void OnTapGestureRecognizerControllerTapped(object sender, EventArgs args)
        {
            Hide();
        }

        void OnTapGestureRecognizerViewTapped(object sender, EventArgs args)
        {
            Show();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void OnPlayerStateChanged(object sender, PlayerStateChangedEventArgs e)
        {
            if (e.State == PlayerState.Completed)
            {
                OnPlaybackCompleted();
            }
            else if (e.State == PlayerState.Error)
            {
                BackButton.IsEnabled = false;
                ForwardButton.IsEnabled = false;
                PlayButton.IsEnabled = false;
                SettingsButton.IsEnabled = false;

                _errorOccured = true;
            }
            else if (e.State == PlayerState.Prepared)
            {
                if (_playerService.IsSeekingSupported)
                {
                    BackButton.IsEnabled = true;
                    ForwardButton.IsEnabled = true;
                }

                PlayButton.IsEnabled = true;
                SettingsButton.IsEnabled = true;
                PlayButton.Focus();

                _playerService.Start();
                Show();
            }
            else if (e.State == PlayerState.Playing)
            {
                PlayImage.Source = ImageSource.FromFile("btn_viewer_control_pause_normal.png");
            }
            else if (e.State == PlayerState.Paused)
            {
                PlayImage.Source = ImageSource.FromFile("btn_viewer_control_play_normal.png");
            }
            else if (e.State == PlayerState.Stopped)
            {
                PlayImage.Source = ImageSource.FromFile("btn_viewer_control_play_normal.png");
            }
        }

        private string GetFormattedTime(TimeSpan time)
        {
            if (time.TotalHours > 1)
                return time.ToString(@"hh\:mm\:ss");
            else
                return time.ToString(@"mm\:ss");
        }

        private bool UpdatePlayerControl()
        {
            if (_isPageDisappeared)
                return false;

            Device.BeginInvokeOnMainThread(() => {
                if (_playerService.State < PlayerState.Playing)
                {
                    return;
                }

                UpdatePlayTime();
                UpdateSubtitles();

                if (Settings.IsVisible)
                    return;

                if (_hideTime > 0)
                {
                    _hideTime -= (int)UpdateInterval.TotalMilliseconds;
                    if (_hideTime <= 0)
                    {
                        Hide();
                    }
                }
            });

            return true;
        }

        private void UpdatePlayTime()
        {
            CurrentTime.Text = GetFormattedTime(_playerService.CurrentPosition);
            TotalTime.Text = GetFormattedTime(_playerService.Duration);

            if (_playerService.Duration.TotalMilliseconds > 0)
                Progressbar.Progress = _playerService.CurrentPosition.TotalMilliseconds / _playerService.Duration.TotalMilliseconds;
            else
                Progressbar.Progress = 0;
        }

        private void UpdateSubtitles()
        {
            // FIXME: implement
        }
    }
}
