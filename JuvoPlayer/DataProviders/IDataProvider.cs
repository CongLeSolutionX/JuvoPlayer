/*!
 * https://github.com/SamsungDForum/JuvoPlayer
 * Copyright 2018, Samsung Electronics Co., Ltd
 * Licensed under the MIT license
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using JuvoPlayer.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JuvoPlayer.Subtitles;

namespace JuvoPlayer.DataProviders
{
    public interface IDataProvider : IDisposable
    {
        void OnDataStateChanged(DataRequest request);
        void OnChangeActiveStream(StreamDescription stream);
        void OnDeactivateStream(StreamType streamType);
        void OnStateChanged(PlayerState state);
        void OnStopped();
        void OnTimeUpdated(TimeSpan time);
        void OnBufferingStateChanged(bool bufferingState);

        Task<TimeSpan> Seek(TimeSpan time, CancellationToken token);

        bool IsDataAvailable();
        bool IsSeekingSupported();
        void Start();
        Cue CurrentCue { get; }
        List<StreamDescription> GetStreamsDescription(StreamType streamType);

        IObservable<TimeSpan> ClipDurationChanged();
        IObservable<DRMInitData> DRMInitDataFound();
        IObservable<DRMDescription> SetDrmConfiguration();
        IObservable<StreamConfig> StreamConfigReady();
        IObservable<Packet> PacketReady();
        IObservable<string> StreamError();
        IObservable<bool> BufferingStateChanged();
    }
}
