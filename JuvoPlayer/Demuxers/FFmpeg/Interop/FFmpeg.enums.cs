namespace JuvoPlayer.Demuxers.FFmpeg.Interop
{
    internal enum AVActiveFormatDescription : int
    {
        @AV_AFD_SAME = 8,
        @AV_AFD_4_3 = 9,
        @AV_AFD_16_9 = 10,
        @AV_AFD_14_9 = 11,
        @AV_AFD_4_3_SP_14_9 = 13,
        @AV_AFD_16_9_SP_14_9 = 14,
        @AV_AFD_SP_4_3 = 15,
    }

    internal enum AVAppToDevMessageType : int
    {
        @AV_APP_TO_DEV_NONE = 1313820229,
        @AV_APP_TO_DEV_WINDOW_SIZE = 1195724621,
        @AV_APP_TO_DEV_WINDOW_REPAINT = 1380274241,
        @AV_APP_TO_DEV_PAUSE = 1346458912,
        @AV_APP_TO_DEV_PLAY = 1347174745,
        @AV_APP_TO_DEV_TOGGLE_PAUSE = 1346458964,
        @AV_APP_TO_DEV_SET_VOLUME = 1398165324,
        @AV_APP_TO_DEV_MUTE = 541939028,
        @AV_APP_TO_DEV_UNMUTE = 1431131476,
        @AV_APP_TO_DEV_TOGGLE_MUTE = 1414354260,
        @AV_APP_TO_DEV_GET_VOLUME = 1196838732,
        @AV_APP_TO_DEV_GET_MUTE = 1196250452,
    }

    internal enum AVAudioServiceType : int
    {
        @AV_AUDIO_SERVICE_TYPE_MAIN = 0,
        @AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
        @AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
        @AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
        @AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
        @AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
        @AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
        @AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
        @AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
        @AV_AUDIO_SERVICE_TYPE_NB = 9,
    }

    internal enum AVChromaLocation : int
    {
        @AVCHROMA_LOC_UNSPECIFIED = 0,
        @AVCHROMA_LOC_LEFT = 1,
        @AVCHROMA_LOC_CENTER = 2,
        @AVCHROMA_LOC_TOPLEFT = 3,
        @AVCHROMA_LOC_TOP = 4,
        @AVCHROMA_LOC_BOTTOMLEFT = 5,
        @AVCHROMA_LOC_BOTTOM = 6,
        @AVCHROMA_LOC_NB = 7,
    }

    internal enum AVClassCategory : int
    {
        @AV_CLASS_CATEGORY_NA = 0,
        @AV_CLASS_CATEGORY_INPUT = 1,
        @AV_CLASS_CATEGORY_OUTPUT = 2,
        @AV_CLASS_CATEGORY_MUXER = 3,
        @AV_CLASS_CATEGORY_DEMUXER = 4,
        @AV_CLASS_CATEGORY_ENCODER = 5,
        @AV_CLASS_CATEGORY_DECODER = 6,
        @AV_CLASS_CATEGORY_FILTER = 7,
        @AV_CLASS_CATEGORY_BITSTREAM_FILTER = 8,
        @AV_CLASS_CATEGORY_SWSCALER = 9,
        @AV_CLASS_CATEGORY_SWRESAMPLER = 10,
        @AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT = 40,
        @AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT = 41,
        @AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT = 42,
        @AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT = 43,
        @AV_CLASS_CATEGORY_DEVICE_OUTPUT = 44,
        @AV_CLASS_CATEGORY_DEVICE_INPUT = 45,
        @AV_CLASS_CATEGORY_NB = 46,
    }

    internal enum AVCodecID : int
    {
        @AV_CODEC_ID_NONE = 0,
        @AV_CODEC_ID_MPEG1VIDEO = 1,
        @AV_CODEC_ID_MPEG2VIDEO = 2,
        @AV_CODEC_ID_MPEG2VIDEO_XVMC = 3,
        @AV_CODEC_ID_H261 = 4,
        @AV_CODEC_ID_H263 = 5,
        @AV_CODEC_ID_RV10 = 6,
        @AV_CODEC_ID_RV20 = 7,
        @AV_CODEC_ID_MJPEG = 8,
        @AV_CODEC_ID_MJPEGB = 9,
        @AV_CODEC_ID_LJPEG = 10,
        @AV_CODEC_ID_SP5X = 11,
        @AV_CODEC_ID_JPEGLS = 12,
        @AV_CODEC_ID_MPEG4 = 13,
        @AV_CODEC_ID_RAWVIDEO = 14,
        @AV_CODEC_ID_MSMPEG4V1 = 15,
        @AV_CODEC_ID_MSMPEG4V2 = 16,
        @AV_CODEC_ID_MSMPEG4V3 = 17,
        @AV_CODEC_ID_WMV1 = 18,
        @AV_CODEC_ID_WMV2 = 19,
        @AV_CODEC_ID_H263P = 20,
        @AV_CODEC_ID_H263I = 21,
        @AV_CODEC_ID_FLV1 = 22,
        @AV_CODEC_ID_SVQ1 = 23,
        @AV_CODEC_ID_SVQ3 = 24,
        @AV_CODEC_ID_DVVIDEO = 25,
        @AV_CODEC_ID_HUFFYUV = 26,
        @AV_CODEC_ID_CYUV = 27,
        @AV_CODEC_ID_H264 = 28,
        @AV_CODEC_ID_INDEO3 = 29,
        @AV_CODEC_ID_VP3 = 30,
        @AV_CODEC_ID_THEORA = 31,
        @AV_CODEC_ID_ASV1 = 32,
        @AV_CODEC_ID_ASV2 = 33,
        @AV_CODEC_ID_FFV1 = 34,
        @AV_CODEC_ID_4XM = 35,
        @AV_CODEC_ID_VCR1 = 36,
        @AV_CODEC_ID_CLJR = 37,
        @AV_CODEC_ID_MDEC = 38,
        @AV_CODEC_ID_ROQ = 39,
        @AV_CODEC_ID_INTERPLAY_VIDEO = 40,
        @AV_CODEC_ID_XAN_WC3 = 41,
        @AV_CODEC_ID_XAN_WC4 = 42,
        @AV_CODEC_ID_RPZA = 43,
        @AV_CODEC_ID_CINEPAK = 44,
        @AV_CODEC_ID_WS_VQA = 45,
        @AV_CODEC_ID_MSRLE = 46,
        @AV_CODEC_ID_MSVIDEO1 = 47,
        @AV_CODEC_ID_IDCIN = 48,
        @AV_CODEC_ID_8BPS = 49,
        @AV_CODEC_ID_SMC = 50,
        @AV_CODEC_ID_FLIC = 51,
        @AV_CODEC_ID_TRUEMOTION1 = 52,
        @AV_CODEC_ID_VMDVIDEO = 53,
        @AV_CODEC_ID_MSZH = 54,
        @AV_CODEC_ID_ZLIB = 55,
        @AV_CODEC_ID_QTRLE = 56,
        @AV_CODEC_ID_TSCC = 57,
        @AV_CODEC_ID_ULTI = 58,
        @AV_CODEC_ID_QDRAW = 59,
        @AV_CODEC_ID_VIXL = 60,
        @AV_CODEC_ID_QPEG = 61,
        @AV_CODEC_ID_PNG = 62,
        @AV_CODEC_ID_PPM = 63,
        @AV_CODEC_ID_PBM = 64,
        @AV_CODEC_ID_PGM = 65,
        @AV_CODEC_ID_PGMYUV = 66,
        @AV_CODEC_ID_PAM = 67,
        @AV_CODEC_ID_FFVHUFF = 68,
        @AV_CODEC_ID_RV30 = 69,
        @AV_CODEC_ID_RV40 = 70,
        @AV_CODEC_ID_VC1 = 71,
        @AV_CODEC_ID_WMV3 = 72,
        @AV_CODEC_ID_LOCO = 73,
        @AV_CODEC_ID_WNV1 = 74,
        @AV_CODEC_ID_AASC = 75,
        @AV_CODEC_ID_INDEO2 = 76,
        @AV_CODEC_ID_FRAPS = 77,
        @AV_CODEC_ID_TRUEMOTION2 = 78,
        @AV_CODEC_ID_BMP = 79,
        @AV_CODEC_ID_CSCD = 80,
        @AV_CODEC_ID_MMVIDEO = 81,
        @AV_CODEC_ID_ZMBV = 82,
        @AV_CODEC_ID_AVS = 83,
        @AV_CODEC_ID_SMACKVIDEO = 84,
        @AV_CODEC_ID_NUV = 85,
        @AV_CODEC_ID_KMVC = 86,
        @AV_CODEC_ID_FLASHSV = 87,
        @AV_CODEC_ID_CAVS = 88,
        @AV_CODEC_ID_JPEG2000 = 89,
        @AV_CODEC_ID_VMNC = 90,
        @AV_CODEC_ID_VP5 = 91,
        @AV_CODEC_ID_VP6 = 92,
        @AV_CODEC_ID_VP6F = 93,
        @AV_CODEC_ID_TARGA = 94,
        @AV_CODEC_ID_DSICINVIDEO = 95,
        @AV_CODEC_ID_TIERTEXSEQVIDEO = 96,
        @AV_CODEC_ID_TIFF = 97,
        @AV_CODEC_ID_GIF = 98,
        @AV_CODEC_ID_DXA = 99,
        @AV_CODEC_ID_DNXHD = 100,
        @AV_CODEC_ID_THP = 101,
        @AV_CODEC_ID_SGI = 102,
        @AV_CODEC_ID_C93 = 103,
        @AV_CODEC_ID_BETHSOFTVID = 104,
        @AV_CODEC_ID_PTX = 105,
        @AV_CODEC_ID_TXD = 106,
        @AV_CODEC_ID_VP6A = 107,
        @AV_CODEC_ID_AMV = 108,
        @AV_CODEC_ID_VB = 109,
        @AV_CODEC_ID_PCX = 110,
        @AV_CODEC_ID_SUNRAST = 111,
        @AV_CODEC_ID_INDEO4 = 112,
        @AV_CODEC_ID_INDEO5 = 113,
        @AV_CODEC_ID_MIMIC = 114,
        @AV_CODEC_ID_RL2 = 115,
        @AV_CODEC_ID_ESCAPE124 = 116,
        @AV_CODEC_ID_DIRAC = 117,
        @AV_CODEC_ID_BFI = 118,
        @AV_CODEC_ID_CMV = 119,
        @AV_CODEC_ID_MOTIONPIXELS = 120,
        @AV_CODEC_ID_TGV = 121,
        @AV_CODEC_ID_TGQ = 122,
        @AV_CODEC_ID_TQI = 123,
        @AV_CODEC_ID_AURA = 124,
        @AV_CODEC_ID_AURA2 = 125,
        @AV_CODEC_ID_V210X = 126,
        @AV_CODEC_ID_TMV = 127,
        @AV_CODEC_ID_V210 = 128,
        @AV_CODEC_ID_DPX = 129,
        @AV_CODEC_ID_MAD = 130,
        @AV_CODEC_ID_FRWU = 131,
        @AV_CODEC_ID_FLASHSV2 = 132,
        @AV_CODEC_ID_CDGRAPHICS = 133,
        @AV_CODEC_ID_R210 = 134,
        @AV_CODEC_ID_ANM = 135,
        @AV_CODEC_ID_BINKVIDEO = 136,
        @AV_CODEC_ID_IFF_ILBM = 137,
        @AV_CODEC_ID_KGV1 = 138,
        @AV_CODEC_ID_YOP = 139,
        @AV_CODEC_ID_VP8 = 140,
        @AV_CODEC_ID_PICTOR = 141,
        @AV_CODEC_ID_ANSI = 142,
        @AV_CODEC_ID_A64_MULTI = 143,
        @AV_CODEC_ID_A64_MULTI5 = 144,
        @AV_CODEC_ID_R10K = 145,
        @AV_CODEC_ID_MXPEG = 146,
        @AV_CODEC_ID_LAGARITH = 147,
        @AV_CODEC_ID_PRORES = 148,
        @AV_CODEC_ID_JV = 149,
        @AV_CODEC_ID_DFA = 150,
        @AV_CODEC_ID_WMV3IMAGE = 151,
        @AV_CODEC_ID_VC1IMAGE = 152,
        @AV_CODEC_ID_UTVIDEO = 153,
        @AV_CODEC_ID_BMV_VIDEO = 154,
        @AV_CODEC_ID_VBLE = 155,
        @AV_CODEC_ID_DXTORY = 156,
        @AV_CODEC_ID_V410 = 157,
        @AV_CODEC_ID_XWD = 158,
        @AV_CODEC_ID_CDXL = 159,
        @AV_CODEC_ID_XBM = 160,
        @AV_CODEC_ID_ZEROCODEC = 161,
        @AV_CODEC_ID_MSS1 = 162,
        @AV_CODEC_ID_MSA1 = 163,
        @AV_CODEC_ID_TSCC2 = 164,
        @AV_CODEC_ID_MTS2 = 165,
        @AV_CODEC_ID_CLLC = 166,
        @AV_CODEC_ID_MSS2 = 167,
        @AV_CODEC_ID_VP9 = 168,
        @AV_CODEC_ID_AIC = 169,
        @AV_CODEC_ID_ESCAPE130 = 170,
        @AV_CODEC_ID_G2M = 171,
        @AV_CODEC_ID_WEBP = 172,
        @AV_CODEC_ID_HNM4_VIDEO = 173,
        @AV_CODEC_ID_HEVC = 174,
        @AV_CODEC_ID_FIC = 175,
        @AV_CODEC_ID_ALIAS_PIX = 176,
        @AV_CODEC_ID_BRENDER_PIX = 177,
        @AV_CODEC_ID_PAF_VIDEO = 178,
        @AV_CODEC_ID_EXR = 179,
        @AV_CODEC_ID_VP7 = 180,
        @AV_CODEC_ID_SANM = 181,
        @AV_CODEC_ID_SGIRLE = 182,
        @AV_CODEC_ID_MVC1 = 183,
        @AV_CODEC_ID_MVC2 = 184,
        @AV_CODEC_ID_HQX = 185,
        @AV_CODEC_ID_TDSC = 186,
        @AV_CODEC_ID_HQ_HQA = 187,
        @AV_CODEC_ID_HAP = 188,
        @AV_CODEC_ID_DDS = 189,
        @AV_CODEC_ID_DXV = 190,
        @AV_CODEC_ID_SCREENPRESSO = 191,
        @AV_CODEC_ID_RSCC = 192,
        @AV_CODEC_ID_Y41P = 32768,
        @AV_CODEC_ID_AVRP = 32769,
        @AV_CODEC_ID_012V = 32770,
        @AV_CODEC_ID_AVUI = 32771,
        @AV_CODEC_ID_AYUV = 32772,
        @AV_CODEC_ID_TARGA_Y216 = 32773,
        @AV_CODEC_ID_V308 = 32774,
        @AV_CODEC_ID_V408 = 32775,
        @AV_CODEC_ID_YUV4 = 32776,
        @AV_CODEC_ID_AVRN = 32777,
        @AV_CODEC_ID_CPIA = 32778,
        @AV_CODEC_ID_XFACE = 32779,
        @AV_CODEC_ID_SNOW = 32780,
        @AV_CODEC_ID_SMVJPEG = 32781,
        @AV_CODEC_ID_APNG = 32782,
        @AV_CODEC_ID_DAALA = 32783,
        @AV_CODEC_ID_CFHD = 32784,
        @AV_CODEC_ID_TRUEMOTION2RT = 32785,
        @AV_CODEC_ID_M101 = 32786,
        @AV_CODEC_ID_MAGICYUV = 32787,
        @AV_CODEC_ID_SHEERVIDEO = 32788,
        @AV_CODEC_ID_YLC = 32789,
        @AV_CODEC_ID_PSD = 32790,
        @AV_CODEC_ID_PIXLET = 32791,
        @AV_CODEC_ID_SPEEDHQ = 32792,
        @AV_CODEC_ID_FMVC = 32793,
        @AV_CODEC_ID_SCPR = 32794,
        @AV_CODEC_ID_CLEARVIDEO = 32795,
        @AV_CODEC_ID_XPM = 32796,
        @AV_CODEC_ID_AV1 = 32797,
        @AV_CODEC_ID_FIRST_AUDIO = 65536,
        @AV_CODEC_ID_PCM_S16LE = 65536,
        @AV_CODEC_ID_PCM_S16BE = 65537,
        @AV_CODEC_ID_PCM_U16LE = 65538,
        @AV_CODEC_ID_PCM_U16BE = 65539,
        @AV_CODEC_ID_PCM_S8 = 65540,
        @AV_CODEC_ID_PCM_U8 = 65541,
        @AV_CODEC_ID_PCM_MULAW = 65542,
        @AV_CODEC_ID_PCM_ALAW = 65543,
        @AV_CODEC_ID_PCM_S32LE = 65544,
        @AV_CODEC_ID_PCM_S32BE = 65545,
        @AV_CODEC_ID_PCM_U32LE = 65546,
        @AV_CODEC_ID_PCM_U32BE = 65547,
        @AV_CODEC_ID_PCM_S24LE = 65548,
        @AV_CODEC_ID_PCM_S24BE = 65549,
        @AV_CODEC_ID_PCM_U24LE = 65550,
        @AV_CODEC_ID_PCM_U24BE = 65551,
        @AV_CODEC_ID_PCM_S24DAUD = 65552,
        @AV_CODEC_ID_PCM_ZORK = 65553,
        @AV_CODEC_ID_PCM_S16LE_PLANAR = 65554,
        @AV_CODEC_ID_PCM_DVD = 65555,
        @AV_CODEC_ID_PCM_F32BE = 65556,
        @AV_CODEC_ID_PCM_F32LE = 65557,
        @AV_CODEC_ID_PCM_F64BE = 65558,
        @AV_CODEC_ID_PCM_F64LE = 65559,
        @AV_CODEC_ID_PCM_BLURAY = 65560,
        @AV_CODEC_ID_PCM_LXF = 65561,
        @AV_CODEC_ID_S302M = 65562,
        @AV_CODEC_ID_PCM_S8_PLANAR = 65563,
        @AV_CODEC_ID_PCM_S24LE_PLANAR = 65564,
        @AV_CODEC_ID_PCM_S32LE_PLANAR = 65565,
        @AV_CODEC_ID_PCM_S16BE_PLANAR = 65566,
        @AV_CODEC_ID_PCM_S64LE = 67584,
        @AV_CODEC_ID_PCM_S64BE = 67585,
        @AV_CODEC_ID_PCM_F16LE = 67586,
        @AV_CODEC_ID_PCM_F24LE = 67587,
        @AV_CODEC_ID_ADPCM_IMA_QT = 69632,
        @AV_CODEC_ID_ADPCM_IMA_WAV = 69633,
        @AV_CODEC_ID_ADPCM_IMA_DK3 = 69634,
        @AV_CODEC_ID_ADPCM_IMA_DK4 = 69635,
        @AV_CODEC_ID_ADPCM_IMA_WS = 69636,
        @AV_CODEC_ID_ADPCM_IMA_SMJPEG = 69637,
        @AV_CODEC_ID_ADPCM_MS = 69638,
        @AV_CODEC_ID_ADPCM_4XM = 69639,
        @AV_CODEC_ID_ADPCM_XA = 69640,
        @AV_CODEC_ID_ADPCM_ADX = 69641,
        @AV_CODEC_ID_ADPCM_EA = 69642,
        @AV_CODEC_ID_ADPCM_G726 = 69643,
        @AV_CODEC_ID_ADPCM_CT = 69644,
        @AV_CODEC_ID_ADPCM_SWF = 69645,
        @AV_CODEC_ID_ADPCM_YAMAHA = 69646,
        @AV_CODEC_ID_ADPCM_SBPRO_4 = 69647,
        @AV_CODEC_ID_ADPCM_SBPRO_3 = 69648,
        @AV_CODEC_ID_ADPCM_SBPRO_2 = 69649,
        @AV_CODEC_ID_ADPCM_THP = 69650,
        @AV_CODEC_ID_ADPCM_IMA_AMV = 69651,
        @AV_CODEC_ID_ADPCM_EA_R1 = 69652,
        @AV_CODEC_ID_ADPCM_EA_R3 = 69653,
        @AV_CODEC_ID_ADPCM_EA_R2 = 69654,
        @AV_CODEC_ID_ADPCM_IMA_EA_SEAD = 69655,
        @AV_CODEC_ID_ADPCM_IMA_EA_EACS = 69656,
        @AV_CODEC_ID_ADPCM_EA_XAS = 69657,
        @AV_CODEC_ID_ADPCM_EA_MAXIS_XA = 69658,
        @AV_CODEC_ID_ADPCM_IMA_ISS = 69659,
        @AV_CODEC_ID_ADPCM_G722 = 69660,
        @AV_CODEC_ID_ADPCM_IMA_APC = 69661,
        @AV_CODEC_ID_ADPCM_VIMA = 69662,
        @AV_CODEC_ID_VIMA = 69662,
        @AV_CODEC_ID_ADPCM_AFC = 71680,
        @AV_CODEC_ID_ADPCM_IMA_OKI = 71681,
        @AV_CODEC_ID_ADPCM_DTK = 71682,
        @AV_CODEC_ID_ADPCM_IMA_RAD = 71683,
        @AV_CODEC_ID_ADPCM_G726LE = 71684,
        @AV_CODEC_ID_ADPCM_THP_LE = 71685,
        @AV_CODEC_ID_ADPCM_PSX = 71686,
        @AV_CODEC_ID_ADPCM_AICA = 71687,
        @AV_CODEC_ID_ADPCM_IMA_DAT4 = 71688,
        @AV_CODEC_ID_ADPCM_MTAF = 71689,
        @AV_CODEC_ID_AMR_NB = 73728,
        @AV_CODEC_ID_AMR_WB = 73729,
        @AV_CODEC_ID_RA_144 = 77824,
        @AV_CODEC_ID_RA_288 = 77825,
        @AV_CODEC_ID_ROQ_DPCM = 81920,
        @AV_CODEC_ID_INTERPLAY_DPCM = 81921,
        @AV_CODEC_ID_XAN_DPCM = 81922,
        @AV_CODEC_ID_SOL_DPCM = 81923,
        @AV_CODEC_ID_SDX2_DPCM = 83968,
        @AV_CODEC_ID_MP2 = 86016,
        @AV_CODEC_ID_MP3 = 86017,
        @AV_CODEC_ID_AAC = 86018,
        @AV_CODEC_ID_AC3 = 86019,
        @AV_CODEC_ID_DTS = 86020,
        @AV_CODEC_ID_VORBIS = 86021,
        @AV_CODEC_ID_DVAUDIO = 86022,
        @AV_CODEC_ID_WMAV1 = 86023,
        @AV_CODEC_ID_WMAV2 = 86024,
        @AV_CODEC_ID_MACE3 = 86025,
        @AV_CODEC_ID_MACE6 = 86026,
        @AV_CODEC_ID_VMDAUDIO = 86027,
        @AV_CODEC_ID_FLAC = 86028,
        @AV_CODEC_ID_MP3ADU = 86029,
        @AV_CODEC_ID_MP3ON4 = 86030,
        @AV_CODEC_ID_SHORTEN = 86031,
        @AV_CODEC_ID_ALAC = 86032,
        @AV_CODEC_ID_WESTWOOD_SND1 = 86033,
        @AV_CODEC_ID_GSM = 86034,
        @AV_CODEC_ID_QDM2 = 86035,
        @AV_CODEC_ID_COOK = 86036,
        @AV_CODEC_ID_TRUESPEECH = 86037,
        @AV_CODEC_ID_TTA = 86038,
        @AV_CODEC_ID_SMACKAUDIO = 86039,
        @AV_CODEC_ID_QCELP = 86040,
        @AV_CODEC_ID_WAVPACK = 86041,
        @AV_CODEC_ID_DSICINAUDIO = 86042,
        @AV_CODEC_ID_IMC = 86043,
        @AV_CODEC_ID_MUSEPACK7 = 86044,
        @AV_CODEC_ID_MLP = 86045,
        @AV_CODEC_ID_GSM_MS = 86046,
        @AV_CODEC_ID_ATRAC3 = 86047,
        @AV_CODEC_ID_VOXWARE = 86048,
        @AV_CODEC_ID_APE = 86049,
        @AV_CODEC_ID_NELLYMOSER = 86050,
        @AV_CODEC_ID_MUSEPACK8 = 86051,
        @AV_CODEC_ID_SPEEX = 86052,
        @AV_CODEC_ID_WMAVOICE = 86053,
        @AV_CODEC_ID_WMAPRO = 86054,
        @AV_CODEC_ID_WMALOSSLESS = 86055,
        @AV_CODEC_ID_ATRAC3P = 86056,
        @AV_CODEC_ID_EAC3 = 86057,
        @AV_CODEC_ID_SIPR = 86058,
        @AV_CODEC_ID_MP1 = 86059,
        @AV_CODEC_ID_TWINVQ = 86060,
        @AV_CODEC_ID_TRUEHD = 86061,
        @AV_CODEC_ID_MP4ALS = 86062,
        @AV_CODEC_ID_ATRAC1 = 86063,
        @AV_CODEC_ID_BINKAUDIO_RDFT = 86064,
        @AV_CODEC_ID_BINKAUDIO_DCT = 86065,
        @AV_CODEC_ID_AAC_LATM = 86066,
        @AV_CODEC_ID_QDMC = 86067,
        @AV_CODEC_ID_CELT = 86068,
        @AV_CODEC_ID_G723_1 = 86069,
        @AV_CODEC_ID_G729 = 86070,
        @AV_CODEC_ID_8SVX_EXP = 86071,
        @AV_CODEC_ID_8SVX_FIB = 86072,
        @AV_CODEC_ID_BMV_AUDIO = 86073,
        @AV_CODEC_ID_RALF = 86074,
        @AV_CODEC_ID_IAC = 86075,
        @AV_CODEC_ID_ILBC = 86076,
        @AV_CODEC_ID_OPUS = 86077,
        @AV_CODEC_ID_COMFORT_NOISE = 86078,
        @AV_CODEC_ID_TAK = 86079,
        @AV_CODEC_ID_METASOUND = 86080,
        @AV_CODEC_ID_PAF_AUDIO = 86081,
        @AV_CODEC_ID_ON2AVC = 86082,
        @AV_CODEC_ID_DSS_SP = 86083,
        @AV_CODEC_ID_FFWAVESYNTH = 88064,
        @AV_CODEC_ID_SONIC = 88065,
        @AV_CODEC_ID_SONIC_LS = 88066,
        @AV_CODEC_ID_EVRC = 88067,
        @AV_CODEC_ID_SMV = 88068,
        @AV_CODEC_ID_DSD_LSBF = 88069,
        @AV_CODEC_ID_DSD_MSBF = 88070,
        @AV_CODEC_ID_DSD_LSBF_PLANAR = 88071,
        @AV_CODEC_ID_DSD_MSBF_PLANAR = 88072,
        @AV_CODEC_ID_4GV = 88073,
        @AV_CODEC_ID_INTERPLAY_ACM = 88074,
        @AV_CODEC_ID_XMA1 = 88075,
        @AV_CODEC_ID_XMA2 = 88076,
        @AV_CODEC_ID_DST = 88077,
        @AV_CODEC_ID_ATRAC3AL = 88078,
        @AV_CODEC_ID_ATRAC3PAL = 88079,
        @AV_CODEC_ID_FIRST_SUBTITLE = 94208,
        @AV_CODEC_ID_DVD_SUBTITLE = 94208,
        @AV_CODEC_ID_DVB_SUBTITLE = 94209,
        @AV_CODEC_ID_TEXT = 94210,
        @AV_CODEC_ID_XSUB = 94211,
        @AV_CODEC_ID_SSA = 94212,
        @AV_CODEC_ID_MOV_TEXT = 94213,
        @AV_CODEC_ID_HDMV_PGS_SUBTITLE = 94214,
        @AV_CODEC_ID_DVB_TELETEXT = 94215,
        @AV_CODEC_ID_SRT = 94216,
        @AV_CODEC_ID_MICRODVD = 96256,
        @AV_CODEC_ID_EIA_608 = 96257,
        @AV_CODEC_ID_JACOSUB = 96258,
        @AV_CODEC_ID_SAMI = 96259,
        @AV_CODEC_ID_REALTEXT = 96260,
        @AV_CODEC_ID_STL = 96261,
        @AV_CODEC_ID_SUBVIEWER1 = 96262,
        @AV_CODEC_ID_SUBVIEWER = 96263,
        @AV_CODEC_ID_SUBRIP = 96264,
        @AV_CODEC_ID_WEBVTT = 96265,
        @AV_CODEC_ID_MPL2 = 96266,
        @AV_CODEC_ID_VPLAYER = 96267,
        @AV_CODEC_ID_PJS = 96268,
        @AV_CODEC_ID_ASS = 96269,
        @AV_CODEC_ID_HDMV_TEXT_SUBTITLE = 96270,
        @AV_CODEC_ID_FIRST_UNKNOWN = 98304,
        @AV_CODEC_ID_TTF = 98304,
        @AV_CODEC_ID_SCTE_35 = 98305,
        @AV_CODEC_ID_BINTEXT = 100352,
        @AV_CODEC_ID_XBIN = 100353,
        @AV_CODEC_ID_IDF = 100354,
        @AV_CODEC_ID_OTF = 100355,
        @AV_CODEC_ID_SMPTE_KLV = 100356,
        @AV_CODEC_ID_DVD_NAV = 100357,
        @AV_CODEC_ID_TIMED_ID3 = 100358,
        @AV_CODEC_ID_BIN_DATA = 100359,
        @AV_CODEC_ID_PROBE = 102400,
        @AV_CODEC_ID_MPEG2TS = 131072,
        @AV_CODEC_ID_MPEG4SYSTEMS = 131073,
        @AV_CODEC_ID_FFMETADATA = 135168,
        @AV_CODEC_ID_WRAPPED_AVFRAME = 135169,
    }

    internal enum AVColorPrimaries : int
    {
        @AVCOL_PRI_RESERVED0 = 0,
        @AVCOL_PRI_BT709 = 1,
        @AVCOL_PRI_UNSPECIFIED = 2,
        @AVCOL_PRI_RESERVED = 3,
        @AVCOL_PRI_BT470M = 4,
        @AVCOL_PRI_BT470BG = 5,
        @AVCOL_PRI_SMPTE170M = 6,
        @AVCOL_PRI_SMPTE240M = 7,
        @AVCOL_PRI_FILM = 8,
        @AVCOL_PRI_BT2020 = 9,
        @AVCOL_PRI_SMPTE428 = 10,
        @AVCOL_PRI_SMPTEST428_1 = 10,
        @AVCOL_PRI_SMPTE431 = 11,
        @AVCOL_PRI_SMPTE432 = 12,
        @AVCOL_PRI_JEDEC_P22 = 22,
        @AVCOL_PRI_NB = 23,
    }

    internal enum AVColorRange : int
    {
        @AVCOL_RANGE_UNSPECIFIED = 0,
        @AVCOL_RANGE_MPEG = 1,
        @AVCOL_RANGE_JPEG = 2,
        @AVCOL_RANGE_NB = 3,
    }

    internal enum AVColorSpace : int
    {
        @AVCOL_SPC_RGB = 0,
        @AVCOL_SPC_BT709 = 1,
        @AVCOL_SPC_UNSPECIFIED = 2,
        @AVCOL_SPC_RESERVED = 3,
        @AVCOL_SPC_FCC = 4,
        @AVCOL_SPC_BT470BG = 5,
        @AVCOL_SPC_SMPTE170M = 6,
        @AVCOL_SPC_SMPTE240M = 7,
        @AVCOL_SPC_YCGCO = 8,
        @AVCOL_SPC_YCOCG = 8,
        @AVCOL_SPC_BT2020_NCL = 9,
        @AVCOL_SPC_BT2020_CL = 10,
        @AVCOL_SPC_SMPTE2085 = 11,
        @AVCOL_SPC_NB = 12,
    }

    internal enum AVColorTransferCharacteristic : int
    {
        @AVCOL_TRC_RESERVED0 = 0,
        @AVCOL_TRC_BT709 = 1,
        @AVCOL_TRC_UNSPECIFIED = 2,
        @AVCOL_TRC_RESERVED = 3,
        @AVCOL_TRC_GAMMA22 = 4,
        @AVCOL_TRC_GAMMA28 = 5,
        @AVCOL_TRC_SMPTE170M = 6,
        @AVCOL_TRC_SMPTE240M = 7,
        @AVCOL_TRC_LINEAR = 8,
        @AVCOL_TRC_LOG = 9,
        @AVCOL_TRC_LOG_SQRT = 10,
        @AVCOL_TRC_IEC61966_2_4 = 11,
        @AVCOL_TRC_BT1361_ECG = 12,
        @AVCOL_TRC_IEC61966_2_1 = 13,
        @AVCOL_TRC_BT2020_10 = 14,
        @AVCOL_TRC_BT2020_12 = 15,
        @AVCOL_TRC_SMPTE2084 = 16,
        @AVCOL_TRC_SMPTEST2084 = 16,
        @AVCOL_TRC_SMPTE428 = 17,
        @AVCOL_TRC_SMPTEST428_1 = 17,
        @AVCOL_TRC_ARIB_STD_B67 = 18,
        @AVCOL_TRC_NB = 19,
    }

    internal enum AVDevToAppMessageType : int
    {
        @AV_DEV_TO_APP_NONE = 1313820229,
        @AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = 1111708229,
        @AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = 1112560197,
        @AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = 1111771475,
        @AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = 1111770451,
        @AV_DEV_TO_APP_BUFFER_OVERFLOW = 1112491596,
        @AV_DEV_TO_APP_BUFFER_UNDERFLOW = 1112884812,
        @AV_DEV_TO_APP_BUFFER_READABLE = 1112687648,
        @AV_DEV_TO_APP_BUFFER_WRITABLE = 1113018912,
        @AV_DEV_TO_APP_MUTE_STATE_CHANGED = 1129141588,
        @AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = 1129729868,
    }

    internal enum AVDiscard : int
    {
        @AVDISCARD_NONE = -16,
        @AVDISCARD_DEFAULT = 0,
        @AVDISCARD_NONREF = 8,
        @AVDISCARD_BIDIR = 16,
        @AVDISCARD_NONINTRA = 24,
        @AVDISCARD_NONKEY = 32,
        @AVDISCARD_ALL = 48,
    }

    internal enum AVDurationEstimationMethod : int
    {
        @AVFMT_DURATION_FROM_PTS = 0,
        @AVFMT_DURATION_FROM_STREAM = 1,
        @AVFMT_DURATION_FROM_BITRATE = 2,
    }

    internal enum AVFieldOrder : int
    {
        @AV_FIELD_UNKNOWN = 0,
        @AV_FIELD_PROGRESSIVE = 1,
        @AV_FIELD_TT = 2,
        @AV_FIELD_BB = 3,
        @AV_FIELD_TB = 4,
        @AV_FIELD_BT = 5,
    }

    internal enum AVFilterLink_init_state : int
    {
        @AVLINK_UNINIT = 0,
        @AVLINK_STARTINIT = 1,
        @AVLINK_INIT = 2,
    }

    internal enum AVFrameSideDataType : int
    {
        @AV_FRAME_DATA_PANSCAN = 0,
        @AV_FRAME_DATA_A53_CC = 1,
        @AV_FRAME_DATA_STEREO3D = 2,
        @AV_FRAME_DATA_MATRIXENCODING = 3,
        @AV_FRAME_DATA_DOWNMIX_INFO = 4,
        @AV_FRAME_DATA_REPLAYGAIN = 5,
        @AV_FRAME_DATA_DISPLAYMATRIX = 6,
        @AV_FRAME_DATA_AFD = 7,
        @AV_FRAME_DATA_MOTION_VECTORS = 8,
        @AV_FRAME_DATA_SKIP_SAMPLES = 9,
        @AV_FRAME_DATA_AUDIO_SERVICE_TYPE = 10,
        @AV_FRAME_DATA_MASTERING_DISPLAY_METADATA = 11,
        @AV_FRAME_DATA_GOP_TIMECODE = 12,
        @AV_FRAME_DATA_SPHERICAL = 13,
    }

    internal enum AVIODataMarkerType : int
    {
        @AVIO_DATA_MARKER_HEADER = 0,
        @AVIO_DATA_MARKER_SYNC_POINT = 1,
        @AVIO_DATA_MARKER_BOUNDARY_POINT = 2,
        @AVIO_DATA_MARKER_UNKNOWN = 3,
        @AVIO_DATA_MARKER_TRAILER = 4,
    }

    internal enum AVIODirEntryType : int
    {
        @AVIO_ENTRY_UNKNOWN = 0,
        @AVIO_ENTRY_BLOCK_DEVICE = 1,
        @AVIO_ENTRY_CHARACTER_DEVICE = 2,
        @AVIO_ENTRY_DIRECTORY = 3,
        @AVIO_ENTRY_NAMED_PIPE = 4,
        @AVIO_ENTRY_SYMBOLIC_LINK = 5,
        @AVIO_ENTRY_SOCKET = 6,
        @AVIO_ENTRY_FILE = 7,
        @AVIO_ENTRY_SERVER = 8,
        @AVIO_ENTRY_SHARE = 9,
        @AVIO_ENTRY_WORKGROUP = 10,
    }

    internal enum AVLockOp : int
    {
        @AV_LOCK_CREATE = 0,
        @AV_LOCK_OBTAIN = 1,
        @AV_LOCK_RELEASE = 2,
        @AV_LOCK_DESTROY = 3,
    }

    internal enum AVMatrixEncoding : int
    {
        @AV_MATRIX_ENCODING_NONE = 0,
        @AV_MATRIX_ENCODING_DOLBY = 1,
        @AV_MATRIX_ENCODING_DPLII = 2,
        @AV_MATRIX_ENCODING_DPLIIX = 3,
        @AV_MATRIX_ENCODING_DPLIIZ = 4,
        @AV_MATRIX_ENCODING_DOLBYEX = 5,
        @AV_MATRIX_ENCODING_DOLBYHEADPHONE = 6,
        @AV_MATRIX_ENCODING_NB = 7,
    }

    internal enum AVMediaType : int
    {
        @AVMEDIA_TYPE_UNKNOWN = -1,
        @AVMEDIA_TYPE_VIDEO = 0,
        @AVMEDIA_TYPE_AUDIO = 1,
        @AVMEDIA_TYPE_DATA = 2,
        @AVMEDIA_TYPE_SUBTITLE = 3,
        @AVMEDIA_TYPE_ATTACHMENT = 4,
        @AVMEDIA_TYPE_NB = 5,
    }

    internal enum AVOptionType : int
    {
        @AV_OPT_TYPE_FLAGS = 0,
        @AV_OPT_TYPE_INT = 1,
        @AV_OPT_TYPE_INT64 = 2,
        @AV_OPT_TYPE_DOUBLE = 3,
        @AV_OPT_TYPE_FLOAT = 4,
        @AV_OPT_TYPE_STRING = 5,
        @AV_OPT_TYPE_RATIONAL = 6,
        @AV_OPT_TYPE_BINARY = 7,
        @AV_OPT_TYPE_DICT = 8,
        @AV_OPT_TYPE_UINT64 = 9,
        @AV_OPT_TYPE_CONST = 128,
        @AV_OPT_TYPE_IMAGE_SIZE = 1397316165,
        @AV_OPT_TYPE_PIXEL_FMT = 1346784596,
        @AV_OPT_TYPE_SAMPLE_FMT = 1397116244,
        @AV_OPT_TYPE_VIDEO_RATE = 1448231252,
        @AV_OPT_TYPE_DURATION = 1146442272,
        @AV_OPT_TYPE_COLOR = 1129270354,
        @AV_OPT_TYPE_CHANNEL_LAYOUT = 1128811585,
        @AV_OPT_TYPE_BOOL = 1112493900,
    }

    internal enum AVPacketSideDataType : int
    {
        @AV_PKT_DATA_PALETTE = 0,
        @AV_PKT_DATA_NEW_EXTRADATA = 1,
        @AV_PKT_DATA_PARAM_CHANGE = 2,
        @AV_PKT_DATA_H263_MB_INFO = 3,
        @AV_PKT_DATA_REPLAYGAIN = 4,
        @AV_PKT_DATA_DISPLAYMATRIX = 5,
        @AV_PKT_DATA_STEREO3D = 6,
        @AV_PKT_DATA_AUDIO_SERVICE_TYPE = 7,
        @AV_PKT_DATA_QUALITY_STATS = 8,
        @AV_PKT_DATA_FALLBACK_TRACK = 9,
        @AV_PKT_DATA_CPB_PROPERTIES = 10,
        @AV_PKT_DATA_SKIP_SAMPLES = 70,
        @AV_PKT_DATA_JP_DUALMONO = 71,
        @AV_PKT_DATA_STRINGS_METADATA = 72,
        @AV_PKT_DATA_SUBTITLE_POSITION = 73,
        @AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL = 74,
        @AV_PKT_DATA_WEBVTT_IDENTIFIER = 75,
        @AV_PKT_DATA_WEBVTT_SETTINGS = 76,
        @AV_PKT_DATA_METADATA_UPDATE = 77,
        @AV_PKT_DATA_MPEGTS_STREAM_ID = 78,
        @AV_PKT_DATA_MASTERING_DISPLAY_METADATA = 79,
        @AV_PKT_DATA_SPHERICAL = 80,
        @AV_PKT_DATA_CONTENT_LIGHT_LEVEL = 81,
        @AV_PKT_DATA_A53_CC = 82,
        @AV_PKT_DATA_ENCRYPT_INFO = 83,
        @AV_PKT_DATA_NB = 84,
    }

    internal enum AVPictureStructure : int
    {
        @AV_PICTURE_STRUCTURE_UNKNOWN = 0,
        @AV_PICTURE_STRUCTURE_TOP_FIELD = 1,
        @AV_PICTURE_STRUCTURE_BOTTOM_FIELD = 2,
        @AV_PICTURE_STRUCTURE_FRAME = 3,
    }

    internal enum AVPictureType : int
    {
        @AV_PICTURE_TYPE_NONE = 0,
        @AV_PICTURE_TYPE_I = 1,
        @AV_PICTURE_TYPE_P = 2,
        @AV_PICTURE_TYPE_B = 3,
        @AV_PICTURE_TYPE_S = 4,
        @AV_PICTURE_TYPE_SI = 5,
        @AV_PICTURE_TYPE_SP = 6,
        @AV_PICTURE_TYPE_BI = 7,
    }

    internal enum AVPixelFormat : int
    {
        @AV_PIX_FMT_NONE = -1,
        @AV_PIX_FMT_YUV420P = 0,
        @AV_PIX_FMT_YUYV422 = 1,
        @AV_PIX_FMT_RGB24 = 2,
        @AV_PIX_FMT_BGR24 = 3,
        @AV_PIX_FMT_YUV422P = 4,
        @AV_PIX_FMT_YUV444P = 5,
        @AV_PIX_FMT_YUV410P = 6,
        @AV_PIX_FMT_YUV411P = 7,
        @AV_PIX_FMT_GRAY8 = 8,
        @AV_PIX_FMT_MONOWHITE = 9,
        @AV_PIX_FMT_MONOBLACK = 10,
        @AV_PIX_FMT_PAL8 = 11,
        @AV_PIX_FMT_YUVJ420P = 12,
        @AV_PIX_FMT_YUVJ422P = 13,
        @AV_PIX_FMT_YUVJ444P = 14,
        @AV_PIX_FMT_XVMC_MPEG2_MC = 15,
        @AV_PIX_FMT_XVMC_MPEG2_IDCT = 16,
        @AV_PIX_FMT_XVMC = 16,
        @AV_PIX_FMT_UYVY422 = 17,
        @AV_PIX_FMT_UYYVYY411 = 18,
        @AV_PIX_FMT_BGR8 = 19,
        @AV_PIX_FMT_BGR4 = 20,
        @AV_PIX_FMT_BGR4_BYTE = 21,
        @AV_PIX_FMT_RGB8 = 22,
        @AV_PIX_FMT_RGB4 = 23,
        @AV_PIX_FMT_RGB4_BYTE = 24,
        @AV_PIX_FMT_NV12 = 25,
        @AV_PIX_FMT_NV21 = 26,
        @AV_PIX_FMT_ARGB = 27,
        @AV_PIX_FMT_RGBA = 28,
        @AV_PIX_FMT_ABGR = 29,
        @AV_PIX_FMT_BGRA = 30,
        @AV_PIX_FMT_GRAY16BE = 31,
        @AV_PIX_FMT_GRAY16LE = 32,
        @AV_PIX_FMT_YUV440P = 33,
        @AV_PIX_FMT_YUVJ440P = 34,
        @AV_PIX_FMT_YUVA420P = 35,
        @AV_PIX_FMT_VDPAU_H264 = 36,
        @AV_PIX_FMT_VDPAU_MPEG1 = 37,
        @AV_PIX_FMT_VDPAU_MPEG2 = 38,
        @AV_PIX_FMT_VDPAU_WMV3 = 39,
        @AV_PIX_FMT_VDPAU_VC1 = 40,
        @AV_PIX_FMT_RGB48BE = 41,
        @AV_PIX_FMT_RGB48LE = 42,
        @AV_PIX_FMT_RGB565BE = 43,
        @AV_PIX_FMT_RGB565LE = 44,
        @AV_PIX_FMT_RGB555BE = 45,
        @AV_PIX_FMT_RGB555LE = 46,
        @AV_PIX_FMT_BGR565BE = 47,
        @AV_PIX_FMT_BGR565LE = 48,
        @AV_PIX_FMT_BGR555BE = 49,
        @AV_PIX_FMT_BGR555LE = 50,
        @AV_PIX_FMT_VAAPI_MOCO = 51,
        @AV_PIX_FMT_VAAPI_IDCT = 52,
        @AV_PIX_FMT_VAAPI_VLD = 53,
        @AV_PIX_FMT_VAAPI = 53,
        @AV_PIX_FMT_YUV420P16LE = 54,
        @AV_PIX_FMT_YUV420P16BE = 55,
        @AV_PIX_FMT_YUV422P16LE = 56,
        @AV_PIX_FMT_YUV422P16BE = 57,
        @AV_PIX_FMT_YUV444P16LE = 58,
        @AV_PIX_FMT_YUV444P16BE = 59,
        @AV_PIX_FMT_VDPAU_MPEG4 = 60,
        @AV_PIX_FMT_DXVA2_VLD = 61,
        @AV_PIX_FMT_RGB444LE = 62,
        @AV_PIX_FMT_RGB444BE = 63,
        @AV_PIX_FMT_BGR444LE = 64,
        @AV_PIX_FMT_BGR444BE = 65,
        @AV_PIX_FMT_YA8 = 66,
        @AV_PIX_FMT_Y400A = 66,
        @AV_PIX_FMT_GRAY8A = 66,
        @AV_PIX_FMT_BGR48BE = 67,
        @AV_PIX_FMT_BGR48LE = 68,
        @AV_PIX_FMT_YUV420P9BE = 69,
        @AV_PIX_FMT_YUV420P9LE = 70,
        @AV_PIX_FMT_YUV420P10BE = 71,
        @AV_PIX_FMT_YUV420P10LE = 72,
        @AV_PIX_FMT_YUV422P10BE = 73,
        @AV_PIX_FMT_YUV422P10LE = 74,
        @AV_PIX_FMT_YUV444P9BE = 75,
        @AV_PIX_FMT_YUV444P9LE = 76,
        @AV_PIX_FMT_YUV444P10BE = 77,
        @AV_PIX_FMT_YUV444P10LE = 78,
        @AV_PIX_FMT_YUV422P9BE = 79,
        @AV_PIX_FMT_YUV422P9LE = 80,
        @AV_PIX_FMT_VDA_VLD = 81,
        @AV_PIX_FMT_GBRP = 82,
        @AV_PIX_FMT_GBR24P = 82,
        @AV_PIX_FMT_GBRP9BE = 83,
        @AV_PIX_FMT_GBRP9LE = 84,
        @AV_PIX_FMT_GBRP10BE = 85,
        @AV_PIX_FMT_GBRP10LE = 86,
        @AV_PIX_FMT_GBRP16BE = 87,
        @AV_PIX_FMT_GBRP16LE = 88,
        @AV_PIX_FMT_YUVA422P = 89,
        @AV_PIX_FMT_YUVA444P = 90,
        @AV_PIX_FMT_YUVA420P9BE = 91,
        @AV_PIX_FMT_YUVA420P9LE = 92,
        @AV_PIX_FMT_YUVA422P9BE = 93,
        @AV_PIX_FMT_YUVA422P9LE = 94,
        @AV_PIX_FMT_YUVA444P9BE = 95,
        @AV_PIX_FMT_YUVA444P9LE = 96,
        @AV_PIX_FMT_YUVA420P10BE = 97,
        @AV_PIX_FMT_YUVA420P10LE = 98,
        @AV_PIX_FMT_YUVA422P10BE = 99,
        @AV_PIX_FMT_YUVA422P10LE = 100,
        @AV_PIX_FMT_YUVA444P10BE = 101,
        @AV_PIX_FMT_YUVA444P10LE = 102,
        @AV_PIX_FMT_YUVA420P16BE = 103,
        @AV_PIX_FMT_YUVA420P16LE = 104,
        @AV_PIX_FMT_YUVA422P16BE = 105,
        @AV_PIX_FMT_YUVA422P16LE = 106,
        @AV_PIX_FMT_YUVA444P16BE = 107,
        @AV_PIX_FMT_YUVA444P16LE = 108,
        @AV_PIX_FMT_VDPAU = 109,
        @AV_PIX_FMT_XYZ12LE = 110,
        @AV_PIX_FMT_XYZ12BE = 111,
        @AV_PIX_FMT_NV16 = 112,
        @AV_PIX_FMT_NV20LE = 113,
        @AV_PIX_FMT_NV20BE = 114,
        @AV_PIX_FMT_RGBA64BE = 115,
        @AV_PIX_FMT_RGBA64LE = 116,
        @AV_PIX_FMT_BGRA64BE = 117,
        @AV_PIX_FMT_BGRA64LE = 118,
        @AV_PIX_FMT_YVYU422 = 119,
        @AV_PIX_FMT_VDA = 120,
        @AV_PIX_FMT_YA16BE = 121,
        @AV_PIX_FMT_YA16LE = 122,
        @AV_PIX_FMT_GBRAP = 123,
        @AV_PIX_FMT_GBRAP16BE = 124,
        @AV_PIX_FMT_GBRAP16LE = 125,
        @AV_PIX_FMT_QSV = 126,
        @AV_PIX_FMT_MMAL = 127,
        @AV_PIX_FMT_D3D11VA_VLD = 128,
        @AV_PIX_FMT_CUDA = 129,
        @AV_PIX_FMT_0RGB = 295,
        @AV_PIX_FMT_RGB0 = 296,
        @AV_PIX_FMT_0BGR = 297,
        @AV_PIX_FMT_BGR0 = 298,
        @AV_PIX_FMT_YUV420P12BE = 299,
        @AV_PIX_FMT_YUV420P12LE = 300,
        @AV_PIX_FMT_YUV420P14BE = 301,
        @AV_PIX_FMT_YUV420P14LE = 302,
        @AV_PIX_FMT_YUV422P12BE = 303,
        @AV_PIX_FMT_YUV422P12LE = 304,
        @AV_PIX_FMT_YUV422P14BE = 305,
        @AV_PIX_FMT_YUV422P14LE = 306,
        @AV_PIX_FMT_YUV444P12BE = 307,
        @AV_PIX_FMT_YUV444P12LE = 308,
        @AV_PIX_FMT_YUV444P14BE = 309,
        @AV_PIX_FMT_YUV444P14LE = 310,
        @AV_PIX_FMT_GBRP12BE = 311,
        @AV_PIX_FMT_GBRP12LE = 312,
        @AV_PIX_FMT_GBRP14BE = 313,
        @AV_PIX_FMT_GBRP14LE = 314,
        @AV_PIX_FMT_YUVJ411P = 315,
        @AV_PIX_FMT_BAYER_BGGR8 = 316,
        @AV_PIX_FMT_BAYER_RGGB8 = 317,
        @AV_PIX_FMT_BAYER_GBRG8 = 318,
        @AV_PIX_FMT_BAYER_GRBG8 = 319,
        @AV_PIX_FMT_BAYER_BGGR16LE = 320,
        @AV_PIX_FMT_BAYER_BGGR16BE = 321,
        @AV_PIX_FMT_BAYER_RGGB16LE = 322,
        @AV_PIX_FMT_BAYER_RGGB16BE = 323,
        @AV_PIX_FMT_BAYER_GBRG16LE = 324,
        @AV_PIX_FMT_BAYER_GBRG16BE = 325,
        @AV_PIX_FMT_BAYER_GRBG16LE = 326,
        @AV_PIX_FMT_BAYER_GRBG16BE = 327,
        @AV_PIX_FMT_YUV440P10LE = 328,
        @AV_PIX_FMT_YUV440P10BE = 329,
        @AV_PIX_FMT_YUV440P12LE = 330,
        @AV_PIX_FMT_YUV440P12BE = 331,
        @AV_PIX_FMT_AYUV64LE = 332,
        @AV_PIX_FMT_AYUV64BE = 333,
        @AV_PIX_FMT_VIDEOTOOLBOX = 334,
        @AV_PIX_FMT_P010LE = 335,
        @AV_PIX_FMT_P010BE = 336,
        @AV_PIX_FMT_GBRAP12BE = 337,
        @AV_PIX_FMT_GBRAP12LE = 338,
        @AV_PIX_FMT_GBRAP10BE = 339,
        @AV_PIX_FMT_GBRAP10LE = 340,
        @AV_PIX_FMT_MEDIACODEC = 341,
        @AV_PIX_FMT_GRAY12BE = 342,
        @AV_PIX_FMT_GRAY12LE = 343,
        @AV_PIX_FMT_GRAY10BE = 344,
        @AV_PIX_FMT_GRAY10LE = 345,
        @AV_PIX_FMT_P016LE = 346,
        @AV_PIX_FMT_P016BE = 347,
        @AV_PIX_FMT_NB = 348,
    }

    internal enum AVRounding : int
    {
        @AV_ROUND_ZERO = 0,
        @AV_ROUND_INF = 1,
        @AV_ROUND_DOWN = 2,
        @AV_ROUND_UP = 3,
        @AV_ROUND_NEAR_INF = 5,
        @AV_ROUND_PASS_MINMAX = 8192,
    }

    internal enum AVSampleFormat : int
    {
        @AV_SAMPLE_FMT_NONE = -1,
        @AV_SAMPLE_FMT_U8 = 0,
        @AV_SAMPLE_FMT_S16 = 1,
        @AV_SAMPLE_FMT_S32 = 2,
        @AV_SAMPLE_FMT_FLT = 3,
        @AV_SAMPLE_FMT_DBL = 4,
        @AV_SAMPLE_FMT_U8P = 5,
        @AV_SAMPLE_FMT_S16P = 6,
        @AV_SAMPLE_FMT_S32P = 7,
        @AV_SAMPLE_FMT_FLTP = 8,
        @AV_SAMPLE_FMT_DBLP = 9,
        @AV_SAMPLE_FMT_S64 = 10,
        @AV_SAMPLE_FMT_S64P = 11,
        @AV_SAMPLE_FMT_NB = 12,
    }

    internal enum AVSideDataParamChangeFlags : int
    {
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 1,
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT = 2,
        @AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 4,
        @AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 8,
    }

    internal enum AVStreamParseType : int
    {
        @AVSTREAM_PARSE_NONE = 0,
        @AVSTREAM_PARSE_FULL = 1,
        @AVSTREAM_PARSE_HEADERS = 2,
        @AVSTREAM_PARSE_TIMESTAMPS = 3,
        @AVSTREAM_PARSE_FULL_ONCE = 4,
        @AVSTREAM_PARSE_FULL_RAW = 1463898624,
    }

    internal enum AVSubtitleType : int
    {
        @SUBTITLE_NONE = 0,
        @SUBTITLE_BITMAP = 1,
        @SUBTITLE_TEXT = 2,
        @SUBTITLE_ASS = 3,
    }

    internal enum AVTimebaseSource : int
    {
        @AVFMT_TBCF_AUTO = -1,
        @AVFMT_TBCF_DECODER = 0,
        @AVFMT_TBCF_DEMUXER = 1,
        @AVFMT_TBCF_R_FRAMERATE = 2,
    }

    internal enum AVTimecodeFlag : int
    {
        @AV_TIMECODE_FLAG_DROPFRAME = 1,
        @AV_TIMECODE_FLAG_24HOURSMAX = 2,
        @AV_TIMECODE_FLAG_ALLOWNEGATIVE = 4,
    }

    internal enum Motion_Est_ID : int
    {
        @ME_ZERO = 1,
        @ME_FULL = 2,
        @ME_LOG = 3,
        @ME_PHODS = 4,
        @ME_EPZS = 5,
        @ME_X1 = 6,
        @ME_HEX = 7,
        @ME_UMH = 8,
        @ME_TESA = 9,
        @ME_ITER = 50,
    }

    internal enum SwrDitherType : int
    {
        @SWR_DITHER_NONE = 0,
        @SWR_DITHER_RECTANGULAR = 1,
        @SWR_DITHER_TRIANGULAR = 2,
        @SWR_DITHER_TRIANGULAR_HIGHPASS = 3,
        @SWR_DITHER_NS = 64,
        @SWR_DITHER_NS_LIPSHITZ = 65,
        @SWR_DITHER_NS_F_WEIGHTED = 66,
        @SWR_DITHER_NS_MODIFIED_E_WEIGHTED = 67,
        @SWR_DITHER_NS_IMPROVED_E_WEIGHTED = 68,
        @SWR_DITHER_NS_SHIBATA = 69,
        @SWR_DITHER_NS_LOW_SHIBATA = 70,
        @SWR_DITHER_NS_HIGH_SHIBATA = 71,
        @SWR_DITHER_NB = 72,
    }

    internal enum SwrEngine : int
    {
        @SWR_ENGINE_SWR = 0,
        @SWR_ENGINE_SOXR = 1,
        @SWR_ENGINE_NB = 2,
    }

    internal enum SwrFilterType : int
    {
        @SWR_FILTER_TYPE_CUBIC = 0,
        @SWR_FILTER_TYPE_BLACKMAN_NUTTALL = 1,
        @SWR_FILTER_TYPE_KAISER = 2,
    }

}