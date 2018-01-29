using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Win32
{
	public abstract class WinMM
	{
		public const int AUXCAPS_AUXIN = 2;

		public const int AUXCAPS_CDAUDIO = 1;

		public const int AUXCAPS_LRVOLUME = 2;

		public const int AUXCAPS_VOLUME = 1;

		public const int AUX_MAPPER = -1;

		public const int C1_TRANSPARENT = 1;

		public const int CALLBACK_FUNCTION = 196608;

		public const int CALLBACK_NULL = 0;

		public const int CALLBACK_TASK = 131072;

		public const int CALLBACK_TYPEMASK = 458752;

		public const int CALLBACK_WINDOW = 65536;

		public const int CAPS1 = 94;

		public const int DRVCNF_CANCEL = 0;

		public const int DRVCNF_OK = 1;

		public const int DRVCNF_RESTART = 2;

		public const int DRV_CANCEL = 0;

		public const int DRV_CLOSE = 4;

		public const int DRV_CONFIGURE = 7;

		public const int DRV_DISABLE = 5;

		public const int DRV_ENABLE = 2;

		public const int DRV_EXITSESSION = 11;

		public const int DRV_FREE = 6;

		public const int DRV_INSTALL = 9;

		public const int DRV_LOAD = 1;

		public const int DRV_MCI_FIRST = 2048;

		public const int DRV_MCI_LAST = 6143;

		public const int DRV_OK = 1;

		public const int DRV_OPEN = 3;

		public const int DRV_POWER = 15;

		public const int DRV_QUERYCONFIGURE = 8;

		public const int DRV_REMOVE = 10;

		public const int DRV_RESERVED = 2048;

		public const int DRV_RESTART = 2;

		public const int DRV_USER = 16384;

		public const int JOYERR_BASE = 160;

		public const int JOYERR_NOCANDO = 166;

		public const int JOYERR_NOERROR = 0;

		public const int JOYERR_PARMS = 165;

		public const int JOYERR_UNPLUGGED = 167;

		public const int JOYSTICKID1 = 0;

		public const int JOYSTICKID2 = 1;

		public const int JOY_BUTTON1 = 1;

		public const int JOY_BUTTON10 = 512;

		public const int JOY_BUTTON11 = 1024;

		public const int JOY_BUTTON12 = 2048;

		public const int JOY_BUTTON13 = 4096;

		public const int JOY_BUTTON14 = 8192;

		public const int JOY_BUTTON15 = 16384;

		public const int JOY_BUTTON16 = 32768;

		public const int JOY_BUTTON17 = 65536;

		public const int JOY_BUTTON18 = 131072;

		public const int JOY_BUTTON19 = 262144;

		public const int JOY_BUTTON1CHG = 256;

		public const int JOY_BUTTON2 = 2;

		public const int JOY_BUTTON20 = 524288;

		public const int JOY_BUTTON21 = 1048576;

		public const int JOY_BUTTON22 = 2097152;

		public const int JOY_BUTTON23 = 4194304;

		public const int JOY_BUTTON24 = 8388608;

		public const int JOY_BUTTON25 = 16777216;

		public const int JOY_BUTTON26 = 33554432;

		public const int JOY_BUTTON27 = 67108864;

		public const int JOY_BUTTON28 = 134217728;

		public const int JOY_BUTTON29 = 268435456;

		public const int JOY_BUTTON2CHG = 512;

		public const int JOY_BUTTON3 = 4;

		public const int JOY_BUTTON30 = 536870912;

		public const int JOY_BUTTON31 = 1073741824;

		public const int JOY_BUTTON32 = -2147483648;

		public const int JOY_BUTTON3CHG = 1024;

		public const int JOY_BUTTON4 = 8;

		public const int JOY_BUTTON4CHG = 2048;

		public const int JOY_BUTTON5 = 16;

		public const int JOY_BUTTON6 = 32;

		public const int JOY_BUTTON7 = 64;

		public const int JOY_BUTTON8 = 128;

		public const int JOY_BUTTON9 = 256;

		public const int JOY_CAL_READ3 = 262144;

		public const int JOY_CAL_READ4 = 524288;

		public const int JOY_CAL_READ5 = 4194304;

		public const int JOY_CAL_READ6 = 8388608;

		public const int JOY_CAL_READALWAYS = 65536;

		public const int JOY_CAL_READRONLY = 33554432;

		public const int JOY_CAL_READUONLY = 67108864;

		public const int JOY_CAL_READVONLY = 134217728;

		public const int JOY_CAL_READXONLY = 1048576;

		public const int JOY_CAL_READXYONLY = 131072;

		public const int JOY_CAL_READYONLY = 2097152;

		public const int JOY_CAL_READZONLY = 16777216;

		public const int JOY_POVBACKWARD = 18000;

		public const int JOY_POVCENTERED = -1;

		public const int JOY_POVFORWARD = 0;

		public const int JOY_POVLEFT = 27000;

		public const int JOY_POVRIGHT = 9000;

		public const int JOY_RETURNALL = 255;

		public const int JOY_RETURNBUTTONS = 128;

		public const int JOY_RETURNCENTERED = 1024;

		public const int JOY_RETURNPOV = 64;

		public const int JOY_RETURNPOVCTS = 512;

		public const int JOY_RETURNR = 8;

		public const int JOY_RETURNRAWDATA = 256;

		public const int JOY_RETURNU = 16;

		public const int JOY_RETURNV = 32;

		public const int JOY_RETURNX = 1;

		public const int JOY_RETURNY = 2;

		public const int JOY_RETURNZ = 4;

		public const int JOY_USEDEADZONE = 2048;

		public const int LZERROR_BADINHANDLE = -1;

		public const int LZERROR_BADOUTHANDLE = -2;

		public const int LZERROR_BADVALUE = -7;

		public const int LZERROR_GLOBLOCK = -6;

		public const int LZERROR_PUBLICLOC = -5;

		public const int LZERROR_READ = -3;

		public const int LZERROR_UNKNOWNALG = -8;

		public const int LZERROR_WRITE = -4;

		public const int MAXERRORLENGTH = 128;

		public const int MAXPNAMELEN = 32;

		public const int MCIERR_BAD_CONSTANT = 290;

		public const int MCIERR_BAD_INTEGER = 270;

		public const int MCIERR_BAD_TIME_FORMAT = 293;

		public const int MCIERR_BASE = 256;

		public const int MCIERR_CANNOT_LOAD_DRIVER = 266;

		public const int MCIERR_CANNOT_USE_ALL = 279;

		public const int MCIERR_CREATEWINDOW = 347;

		public const int MCIERR_CUSTOM_DRIVER_BASE = 512;

		public const int MCIERR_DEVICE_LENGTH = 310;

		public const int MCIERR_DEVICE_LOCKED = 288;

		public const int MCIERR_DEVICE_NOT_INSTALLED = 306;

		public const int MCIERR_DEVICE_NOT_READY = 276;

		public const int MCIERR_DEVICE_OPEN = 265;

		public const int MCIERR_DEVICE_ORD_LENGTH = 311;

		public const int MCIERR_DEVICE_TYPE_REQUIRED = 287;

		public const int MCIERR_DRIVER = 278;

		public const int MCIERR_DRIVER_INTERNAL = 272;

		public const int MCIERR_DUPLICATE_ALIAS = 289;

		public const int MCIERR_DUPLICATE_FLAGS = 295;

		public const int MCIERR_EXTENSION_NOT_FOUND = 281;

		public const int MCIERR_EXTRA_CHARACTERS = 305;

		public const int MCIERR_FILENAME_REQUIRED = 304;

		public const int MCIERR_FILE_NOT_FOUND = 275;

		public const int MCIERR_FILE_NOT_SAVED = 286;

		public const int MCIERR_FILE_READ = 348;

		public const int MCIERR_FILE_WRITE = 349;

		public const int MCIERR_FLAGS_NOT_COMPATIBLE = 284;

		public const int MCIERR_GET_CD = 307;

		public const int MCIERR_HARDWARE = 262;

		public const int MCIERR_ILLEGAL_FOR_AUTO_OPEN = 303;

		public const int MCIERR_INTERNAL = 277;

		public const int MCIERR_INVALID_DEVICE_ID = 257;

		public const int MCIERR_INVALID_DEVICE_NAME = 263;

		public const int MCIERR_INVALID_FILE = 296;

		public const int MCIERR_MISSING_COMMAND_STRING = 267;

		public const int MCIERR_MISSING_DEVICE_NAME = 292;

		public const int MCIERR_MISSING_PARAMETER = 273;

		public const int MCIERR_MISSING_STRING_ARGUMENT = 269;

		public const int MCIERR_MULTIPLE = 280;

		public const int MCIERR_MUST_USE_SHAREABLE = 291;

		public const int MCIERR_NEW_REQUIRES_ALIAS = 299;

		public const int MCIERR_NONAPPLICABLE_FUNCTION = 302;

		public const int MCIERR_NOTIFY_ON_AUTO_OPEN = 300;

		public const int MCIERR_NO_CLOSING_QUOTE = 294;

		public const int MCIERR_NO_ELEMENT_ALLOWED = 301;

		public const int MCIERR_NO_INTEGER = 312;

		public const int MCIERR_NO_WINDOW = 346;

		public const int MCIERR_NULL_PARAMETER_BLOCK = 297;

		public const int MCIERR_OUTOFRANGE = 282;

		public const int MCIERR_OUT_OF_MEMORY = 264;

		public const int MCIERR_PARAM_OVERFLOW = 268;

		public const int MCIERR_PARSER_INTERNAL = 271;

		public const int MCIERR_SEQ_DIV_INCOMPATIBLE = 336;

		public const int MCIERR_SEQ_NOMIDIPRESENT = 343;

		public const int MCIERR_SEQ_PORTUNSPECIFIED = 342;

		public const int MCIERR_SEQ_PORT_INUSE = 337;

		public const int MCIERR_SEQ_PORT_MAPNODEVICE = 339;

		public const int MCIERR_SEQ_PORT_MISCERROR = 340;

		public const int MCIERR_SEQ_PORT_NONEXISTENT = 338;

		public const int MCIERR_SEQ_TIMER = 341;

		public const int MCIERR_SET_CD = 308;

		public const int MCIERR_SET_DRIVE = 309;

		public const int MCIERR_UNNAMED_RESOURCE = 298;

		public const int MCIERR_UNRECOGNIZED_COMMAND = 261;

		public const int MCIERR_UNRECOGNIZED_KEYWORD = 259;

		public const int MCIERR_UNSUPPORTED_FUNCTION = 274;

		public const int MCIERR_WAVE_INPUTSINUSE = 322;

		public const int MCIERR_WAVE_INPUTSUNSUITABLE = 328;

		public const int MCIERR_WAVE_INPUTUNSPECIFIED = 325;

		public const int MCIERR_WAVE_OUTPUTSINUSE = 320;

		public const int MCIERR_WAVE_OUTPUTSUNSUITABLE = 326;

		public const int MCIERR_WAVE_OUTPUTUNSPECIFIED = 324;

		public const int MCIERR_WAVE_SETINPUTINUSE = 323;

		public const int MCIERR_WAVE_SETINPUTUNSUITABLE = 329;

		public const int MCIERR_WAVE_SETOUTPUTINUSE = 321;

		public const int MCIERR_WAVE_SETOUTPUTUNSUITABLE = 327;

		public const int MCI_ALL_DEVICE_ID = -1;

		public const int MCI_ANIM_GETDEVCAPS_CAN_REVERSE = 16385;

		public const int MCI_ANIM_GETDEVCAPS_CAN_STRETCH = 16391;

		public const int MCI_ANIM_GETDEVCAPS_FAST_RATE = 16386;

		public const int MCI_ANIM_GETDEVCAPS_MAX_WINDOWS = 16392;

		public const int MCI_ANIM_GETDEVCAPS_NORMAL_RATE = 16388;

		public const int MCI_ANIM_GETDEVCAPS_PALETTES = 16390;

		public const int MCI_ANIM_GETDEVCAPS_SLOW_RATE = 16387;

		public const int MCI_ANIM_INFO_TEXT = 65536;

		public const int MCI_ANIM_OPEN_NOSTATIC = 262144;

		public const int MCI_ANIM_OPEN_PARENT = 131072;

		public const int MCI_ANIM_OPEN_WS = 65536;

		public const int MCI_ANIM_PLAY_FAST = 262144;

		public const int MCI_ANIM_PLAY_REVERSE = 131072;

		public const int MCI_ANIM_PLAY_SCAN = 1048576;

		public const int MCI_ANIM_PLAY_SLOW = 524288;

		public const int MCI_ANIM_PLAY_SPEED = 65536;

		public const int MCI_ANIM_PUT_DESTINATION = 262144;

		public const int MCI_ANIM_PUT_SOURCE = 131072;

		public const int MCI_ANIM_REALIZE_BKGD = 131072;

		public const int MCI_ANIM_REALIZE_NORM = 65536;

		public const int MCI_ANIM_RECT = 65536;

		public const int MCI_ANIM_STATUS_FORWARD = 16386;

		public const int MCI_ANIM_STATUS_HPAL = 16388;

		public const int MCI_ANIM_STATUS_HWND = 16387;

		public const int MCI_ANIM_STATUS_SPEED = 16385;

		public const int MCI_ANIM_STATUS_STRETCH = 16389;

		public const int MCI_ANIM_STEP_FRAMES = 131072;

		public const int MCI_ANIM_STEP_REVERSE = 65536;

		public const int MCI_ANIM_UPDATE_HDC = 131072;

		public const int MCI_ANIM_WHERE_DESTINATION = 262144;

		public const int MCI_ANIM_WHERE_SOURCE = 131072;

		public const int MCI_ANIM_WINDOW_DEFAULT = 0;

		public const int MCI_ANIM_WINDOW_DISABLE_STRETCH = 2097152;

		public const int MCI_ANIM_WINDOW_ENABLE_STRETCH = 1048576;

		public const int MCI_ANIM_WINDOW_HWND = 65536;

		public const int MCI_ANIM_WINDOW_STATE = 262144;

		public const int MCI_ANIM_WINDOW_TEXT = 524288;

		public const int MCI_BREAK = 2065;

		public const int MCI_BREAK_HWND = 512;

		public const int MCI_BREAK_KEY = 256;

		public const int MCI_BREAK_OFF = 1024;

		public const int MCI_CD_OFFSET = 1088;

		public const int MCI_CLOSE = 2052;

		public const int MCI_COPY = 2130;

		public const int MCI_CUE = 2096;

		public const int MCI_CUT = 2129;

		public const int MCI_DELETE = 2134;

		public const int MCI_DEVTYPE_ANIMATION = 519;

		public const int MCI_DEVTYPE_CD_AUDIO = 516;

		public const int MCI_DEVTYPE_DAT = 517;

		public const int MCI_DEVTYPE_DIGITAL_VIDEO = 520;

		public const int MCI_DEVTYPE_FIRST = 513;

		public const int MCI_DEVTYPE_FIRST_USER = 4096;

		public const int MCI_DEVTYPE_LAST = 523;

		public const int MCI_DEVTYPE_OTHER = 521;

		public const int MCI_DEVTYPE_OVERLAY = 515;

		public const int MCI_DEVTYPE_SCANNER = 518;

		public const int MCI_DEVTYPE_SEQUENCER = 523;

		public const int MCI_DEVTYPE_VCR = 513;

		public const int MCI_DEVTYPE_VIDEODISC = 514;

		public const int MCI_DEVTYPE_WAVEFORM_AUDIO = 522;

		public const int MCI_ESCAPE = 2053;

		public const int MCI_FIRST = 2048;

		public const int MCI_FORMAT_BYTES = 8;

		public const int MCI_FORMAT_FRAMES = 3;

		public const int MCI_FORMAT_HMS = 1;

		public const int MCI_FORMAT_MILLISECONDS = 0;

		public const int MCI_FORMAT_MSF = 2;

		public const int MCI_FORMAT_SAMPLES = 9;

		public const int MCI_FORMAT_SMPTE_24 = 4;

		public const int MCI_FORMAT_SMPTE_25 = 5;

		public const int MCI_FORMAT_SMPTE_30 = 6;

		public const int MCI_FORMAT_SMPTE_30DROP = 7;

		public const int MCI_FORMAT_TMSF = 10;

		public const int MCI_FREEZE = 2116;

		public const int MCI_FROM = 4;

		public const int MCI_GETDEVCAPS = 2059;

		public const int MCI_GETDEVCAPS_CAN_EJECT = 7;

		public const int MCI_GETDEVCAPS_CAN_PLAY = 8;

		public const int MCI_GETDEVCAPS_CAN_RECORD = 1;

		public const int MCI_GETDEVCAPS_CAN_SAVE = 9;

		public const int MCI_GETDEVCAPS_COMPOUND_DEVICE = 6;

		public const int MCI_GETDEVCAPS_DEVICE_TYPE = 4;

		public const int MCI_GETDEVCAPS_HAS_AUDIO = 2;

		public const int MCI_GETDEVCAPS_HAS_VIDEO = 3;

		public const int MCI_GETDEVCAPS_ITEM = 256;

		public const int MCI_GETDEVCAPS_USES_FILES = 5;

		public const int MCI_INFO = 2058;

		public const int MCI_INFO_FILE = 512;

		public const int MCI_INFO_PRODUCT = 256;

		public const int MCI_LAST = 4095;

		public const int MCI_LOAD = 2128;

		public const int MCI_LOAD_FILE = 256;

		public const int MCI_MODE_NOT_READY = 524;

		public const int MCI_MODE_OPEN = 530;

		public const int MCI_MODE_PAUSE = 529;

		public const int MCI_MODE_PLAY = 526;

		public const int MCI_MODE_RECORD = 527;

		public const int MCI_MODE_SEEK = 528;

		public const int MCI_MODE_STOP = 525;

		public const int MCI_NOTIFY = 1;

		public const int MCI_NOTIFY_ABORTED = 4;

		public const int MCI_NOTIFY_FAILURE = 8;

		public const int MCI_NOTIFY_SUCCESSFUL = 1;

		public const int MCI_NOTIFY_SUPERSEDED = 2;

		public const int MCI_OPEN = 2051;

		public const int MCI_OPEN_ALIAS = 1024;

		public const int MCI_OPEN_ELEMENT = 512;

		public const int MCI_OPEN_ELEMENT_ID = 2048;

		public const int MCI_OPEN_SHAREABLE = 256;

		public const int MCI_OPEN_TYPE = 8192;

		public const int MCI_OPEN_TYPE_ID = 4096;

		public const int MCI_OVLY_GETDEVCAPS_CAN_FREEZE = 16386;

		public const int MCI_OVLY_GETDEVCAPS_CAN_STRETCH = 16385;

		public const int MCI_OVLY_GETDEVCAPS_MAX_WINDOWS = 16387;

		public const int MCI_OVLY_INFO_TEXT = 65536;

		public const int MCI_OVLY_OPEN_PARENT = 131072;

		public const int MCI_OVLY_OPEN_WS = 65536;

		public const int MCI_OVLY_PUT_DESTINATION = 262144;

		public const int MCI_OVLY_PUT_FRAME = 524288;

		public const int MCI_OVLY_PUT_SOURCE = 131072;

		public const int MCI_OVLY_PUT_VIDEO = 1048576;

		public const int MCI_OVLY_RECT = 65536;

		public const int MCI_OVLY_STATUS_HWND = 16385;

		public const int MCI_OVLY_STATUS_STRETCH = 16386;

		public const int MCI_OVLY_WHERE_DESTINATION = 262144;

		public const int MCI_OVLY_WHERE_FRAME = 524288;

		public const int MCI_OVLY_WHERE_SOURCE = 131072;

		public const int MCI_OVLY_WHERE_VIDEO = 1048576;

		public const int MCI_OVLY_WINDOW_DEFAULT = 0;

		public const int MCI_OVLY_WINDOW_DISABLE_STRETCH = 2097152;

		public const int MCI_OVLY_WINDOW_ENABLE_STRETCH = 1048576;

		public const int MCI_OVLY_WINDOW_HWND = 65536;

		public const int MCI_OVLY_WINDOW_STATE = 262144;

		public const int MCI_OVLY_WINDOW_TEXT = 524288;

		public const int MCI_PASTE = 2131;

		public const int MCI_PAUSE = 2057;

		public const int MCI_PLAY = 2054;

		public const int MCI_PUT = 2114;

		public const int MCI_REALIZE = 2112;

		public const int MCI_RECORD = 2063;

		public const int MCI_RECORD_INSERT = 256;

		public const int MCI_RECORD_OVERWRITE = 512;

		public const int MCI_RESUME = 2133;

		public const int MCI_SAVE = 2067;

		public const int MCI_SAVE_FILE = 256;

		public const int MCI_SEEK = 2055;

		public const int MCI_SEEK_TO_END = 512;

		public const int MCI_SEEK_TO_START = 256;

		public const int MCI_SEQ_DIV_PPQN = 1216;

		public const int MCI_SEQ_DIV_SMPTE_24 = 1217;

		public const int MCI_SEQ_DIV_SMPTE_25 = 1218;

		public const int MCI_SEQ_DIV_SMPTE_30 = 1220;

		public const int MCI_SEQ_DIV_SMPTE_30DROP = 1219;

		public const int MCI_SEQ_FILE = 16386;

		public const int MCI_SEQ_FORMAT_SONGPTR = 16385;

		public const int MCI_SEQ_MAPPER = 65535;

		public const int MCI_SEQ_MIDI = 16387;

		public const int MCI_SEQ_NONE = 65533;

		public const int MCI_SEQ_OFFSET = 1216;

		public const int MCI_SEQ_SET_MASTER = 524288;

		public const int MCI_SEQ_SET_OFFSET = 16777216;

		public const int MCI_SEQ_SET_PORT = 131072;

		public const int MCI_SEQ_SET_SLAVE = 262144;

		public const int MCI_SEQ_SET_TEMPO = 65536;

		public const int MCI_SEQ_SMPTE = 16388;

		public const int MCI_SEQ_STATUS_DIVTYPE = 16394;

		public const int MCI_SEQ_STATUS_MASTER = 16392;

		public const int MCI_SEQ_STATUS_OFFSET = 16393;

		public const int MCI_SEQ_STATUS_PORT = 16387;

		public const int MCI_SEQ_STATUS_SLAVE = 16391;

		public const int MCI_SEQ_STATUS_TEMPO = 16386;

		public const int MCI_SET = 2061;

		public const int MCI_SET_AUDIO = 2048;

		public const int MCI_SET_AUDIO_ALL = 16385;

		public const int MCI_SET_AUDIO_LEFT = 16386;

		public const int MCI_SET_AUDIO_RIGHT = 16387;

		public const int MCI_SET_DOOR_CLOSED = 512;

		public const int MCI_SET_DOOR_OPEN = 256;

		public const int MCI_SET_OFF = 16384;

		public const int MCI_SET_ON = 8192;

		public const int MCI_SET_TIME_FORMAT = 1024;

		public const int MCI_SET_VIDEO = 4096;

		public const int MCI_SOUND = 2066;

		public const int MCI_SOUND_NAME = 256;

		public const int MCI_SPIN = 2060;

		public const int MCI_STATUS = 2068;

		public const int MCI_STATUS_CURRENT_TRACK = 8;

		public const int MCI_STATUS_ITEM = 256;

		public const int MCI_STATUS_LENGTH = 1;

		public const int MCI_STATUS_MEDIA_PRESENT = 5;

		public const int MCI_STATUS_MODE = 4;

		public const int MCI_STATUS_NUMBER_OF_TRACKS = 3;

		public const int MCI_STATUS_POSITION = 2;

		public const int MCI_STATUS_READY = 7;

		public const int MCI_STATUS_START = 512;

		public const int MCI_STATUS_TIME_FORMAT = 6;

		public const int MCI_STEP = 2062;

		public const int MCI_STOP = 2056;

		public const int MCI_STRING_OFFSET = 512;

		public const int MCI_SYSINFO = 2064;

		public const int MCI_SYSINFO_INSTALLNAME = 2048;

		public const int MCI_SYSINFO_NAME = 1024;

		public const int MCI_SYSINFO_OPEN = 512;

		public const int MCI_SYSINFO_QUANTITY = 256;

		public const int MCI_TO = 8;

		public const int MCI_TRACK = 16;

		public const int MCI_UNFREEZE = 2117;

		public const int MCI_UPDATE = 2132;

		public const int MCI_USER_MESSAGES = 3072;

		public const int MCI_VD_ESCAPE_STRING = 256;

		public const int MCI_VD_FORMAT_TRACK = 16385;

		public const int MCI_VD_GETDEVCAPS_CAN_REVERSE = 16386;

		public const int MCI_VD_GETDEVCAPS_CAV = 131072;

		public const int MCI_VD_GETDEVCAPS_CLV = 65536;

		public const int MCI_VD_GETDEVCAPS_FAST_RATE = 16387;

		public const int MCI_VD_GETDEVCAPS_NORMAL_RATE = 16389;

		public const int MCI_VD_GETDEVCAPS_SLOW_RATE = 16388;

		public const int MCI_VD_MEDIA_CAV = 1027;

		public const int MCI_VD_MEDIA_CLV = 1026;

		public const int MCI_VD_MEDIA_OTHER = 1028;

		public const int MCI_VD_MODE_PARK = 1025;

		public const int MCI_VD_OFFSET = 1024;

		public const int MCI_VD_PLAY_FAST = 131072;

		public const int MCI_VD_PLAY_REVERSE = 65536;

		public const int MCI_VD_PLAY_SCAN = 524288;

		public const int MCI_VD_PLAY_SLOW = 1048576;

		public const int MCI_VD_PLAY_SPEED = 262144;

		public const int MCI_VD_SEEK_REVERSE = 65536;

		public const int MCI_VD_SPIN_DOWN = 131072;

		public const int MCI_VD_SPIN_UP = 65536;

		public const int MCI_VD_STATUS_DISC_SIZE = 16390;

		public const int MCI_VD_STATUS_FORWARD = 16387;

		public const int MCI_VD_STATUS_MEDIA_TYPE = 16388;

		public const int MCI_VD_STATUS_SIDE = 16389;

		public const int MCI_VD_STATUS_SPEED = 16386;

		public const int MCI_VD_STEP_FRAMES = 65536;

		public const int MCI_VD_STEP_REVERSE = 131072;

		public const int MCI_WAIT = 2;

		public const int MCI_WAVE_GETDEVCAPS_INPUTS = 16385;

		public const int MCI_WAVE_GETDEVCAPS_OUTPUTS = 16386;

		public const int MCI_WAVE_INPUT = 4194304;

		public const int MCI_WAVE_MAPPER = 1153;

		public const int MCI_WAVE_OFFSET = 1152;

		public const int MCI_WAVE_OPEN_BUFFER = 65536;

		public const int MCI_WAVE_OUTPUT = 8388608;

		public const int MCI_WAVE_PCM = 1152;

		public const int MCI_WAVE_SET_ANYINPUT = 67108864;

		public const int MCI_WAVE_SET_ANYOUTPUT = 134217728;

		public const int MCI_WAVE_SET_AVGBYTESPERSEC = 524288;

		public const int MCI_WAVE_SET_BITSPERSAMPLE = 2097152;

		public const int MCI_WAVE_SET_BLOCKALIGN = 1048576;

		public const int MCI_WAVE_SET_CHANNELS = 131072;

		public const int MCI_WAVE_SET_FORMATTAG = 65536;

		public const int MCI_WAVE_SET_SAMPLESPERSEC = 262144;

		public const int MCI_WAVE_STATUS_AVGBYTESPERSEC = 16388;

		public const int MCI_WAVE_STATUS_BITSPERSAMPLE = 16390;

		public const int MCI_WAVE_STATUS_BLOCKALIGN = 16389;

		public const int MCI_WAVE_STATUS_CHANNELS = 16386;

		public const int MCI_WAVE_STATUS_FORMATTAG = 16385;

		public const int MCI_WAVE_STATUS_LEVEL = 16391;

		public const int MCI_WAVE_STATUS_SAMPLESPERSEC = 16387;

		public const int MCI_WHERE = 2115;

		public const int MCI_WINDOW = 2113;

		public const int MEVT_F_CALLBACK = 1073741824;

		public const int MEVT_F_LONG = -2147483648;

		public const int MEVT_F_SHORT = 0;

		public const int MHDR_DONE = 1;

		public const int MHDR_INQUEUE = 4;

		public const int MHDR_PREPARED = 2;

		public const int MHDR_VALID = 7;

		public const int MIDICAPS_CACHE = 4;

		public const int MIDICAPS_LRVOLUME = 2;

		public const int MIDICAPS_STREAM = 8;

		public const int MIDICAPS_VOLUME = 1;

		public const int MIDIERR_BASE = 64;

		public const int MIDIERR_INVALIDSETUP = 69;

		public const int MIDIERR_LASTERROR = 69;

		public const int MIDIERR_NODEVICE = 68;

		public const int MIDIERR_NOMAP = 66;

		public const int MIDIERR_NOTREADY = 67;

		public const int MIDIERR_STILLPLAYING = 65;

		public const int MIDIERR_UNPREPARED = 64;

		public const int MIDIMAPPER = -1;

		public const int MIDIPROP_GET = 1073741824;

		public const int MIDIPROP_SET = -2147483648;

		public const int MIDIPROP_TEMPO = 2;

		public const int MIDIPROP_TIMEDIV = 1;

		public const int MIDISTRM_ERROR = -2;

		public const int MIDI_CACHE_ALL = 1;

		public const int MIDI_CACHE_BESTFIT = 2;

		public const int MIDI_CACHE_QUERY = 3;

		public const int MIDI_CACHE_VALID = 7;

		public const int MIDI_IO_STATUS = 32;

		public const int MIDI_MAPPER = -1;

		public const int MIDI_UNCACHE = 4;

		public const int MIM_CLOSE = 962;

		public const int MIM_DATA = 963;

		public const int MIM_ERROR = 965;

		public const int MIM_LONGDATA = 964;

		public const int MIM_LONGERROR = 966;

		public const int MIM_MOREDATA = 972;

		public const int MIM_OPEN = 961;

		public const int MIXERCONTROL_CONTROLF_DISABLED = -2147483648;

		public const int MIXERCONTROL_CONTROLF_MULTIPLE = 2;

		public const int MIXERCONTROL_CONTROLF_UNIFORM = 1;

		public const int MIXERCONTROL_CONTROLTYPE_BASS = 1342373890;

		public const int MIXERCONTROL_CONTROLTYPE_BOOLEAN = 536936448;

		public const int MIXERCONTROL_CONTROLTYPE_BOOLEANMETER = 268500992;

		public const int MIXERCONTROL_CONTROLTYPE_BUTTON = 553713664;

		public const int MIXERCONTROL_CONTROLTYPE_CUSTOM = 0;

		public const int MIXERCONTROL_CONTROLTYPE_DECIBELS = 805568512;

		public const int MIXERCONTROL_CONTROLTYPE_EQUALIZER = 1342373892;

		public const int MIXERCONTROL_CONTROLTYPE_FADER = 1342373888;

		public const int MIXERCONTROL_CONTROLTYPE_LOUDNESS = 536936452;

		public const int MIXERCONTROL_CONTROLTYPE_MICROTIME = 1610809344;

		public const int MIXERCONTROL_CONTROLTYPE_MILLITIME = 1627586560;

		public const int MIXERCONTROL_CONTROLTYPE_MIXER = 1895890945;

		public const int MIXERCONTROL_CONTROLTYPE_MONO = 536936451;

		public const int MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT = 1895890944;

		public const int MIXERCONTROL_CONTROLTYPE_MUTE = 536936450;

		public const int MIXERCONTROL_CONTROLTYPE_MUX = 1879113729;

		public const int MIXERCONTROL_CONTROLTYPE_ONOFF = 536936449;

		public const int MIXERCONTROL_CONTROLTYPE_PAN = 1073872897;

		public const int MIXERCONTROL_CONTROLTYPE_PEAKMETER = 268566529;

		public const int MIXERCONTROL_CONTROLTYPE_PERCENT = 805634048;

		public const int MIXERCONTROL_CONTROLTYPE_QSOUNDPAN = 1073872898;

		public const int MIXERCONTROL_CONTROLTYPE_SIGNED = 805437440;

		public const int MIXERCONTROL_CONTROLTYPE_SIGNEDMETER = 268566528;

		public const int MIXERCONTROL_CONTROLTYPE_SINGLESELECT = 1879113728;

		public const int MIXERCONTROL_CONTROLTYPE_SLIDER = 1073872896;

		public const int MIXERCONTROL_CONTROLTYPE_STEREOENH = 536936453;

		public const int MIXERCONTROL_CONTROLTYPE_TREBLE = 1342373891;

		public const int MIXERCONTROL_CONTROLTYPE_UNSIGNED = 805502976;

		public const int MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER = 268632064;

		public const int MIXERCONTROL_CONTROLTYPE_VOLUME = 1342373889;

		public const int MIXERCONTROL_CT_CLASS_CUSTOM = 0;

		public const int MIXERCONTROL_CT_CLASS_FADER = 1342177280;

		public const int MIXERCONTROL_CT_CLASS_LIST = 1879048192;

		public const int MIXERCONTROL_CT_CLASS_MASK = -268435456;

		public const int MIXERCONTROL_CT_CLASS_METER = 268435456;

		public const int MIXERCONTROL_CT_CLASS_NUMBER = 805306368;

		public const int MIXERCONTROL_CT_CLASS_SLIDER = 1073741824;

		public const int MIXERCONTROL_CT_CLASS_SWITCH = 536870912;

		public const int MIXERCONTROL_CT_CLASS_TIME = 1610612736;

		public const int MIXERCONTROL_CT_SC_LIST_MULTIPLE = 16777216;

		public const int MIXERCONTROL_CT_SC_LIST_SINGLE = 0;

		public const int MIXERCONTROL_CT_SC_METER_POLLED = 0;

		public const int MIXERCONTROL_CT_SC_SWITCH_BOOLEAN = 0;

		public const int MIXERCONTROL_CT_SC_SWITCH_BUTTON = 16777216;

		public const int MIXERCONTROL_CT_SC_TIME_MICROSECS = 0;

		public const int MIXERCONTROL_CT_SC_TIME_MILLISECS = 16777216;

		public const int MIXERCONTROL_CT_SUBCLASS_MASK = 251658240;

		public const int MIXERCONTROL_CT_UNITS_BOOLEAN = 65536;

		public const int MIXERCONTROL_CT_UNITS_CUSTOM = 0;

		public const int MIXERCONTROL_CT_UNITS_DECIBELS = 262144;

		public const int MIXERCONTROL_CT_UNITS_MASK = 16711680;

		public const int MIXERCONTROL_CT_UNITS_PERCENT = 327680;

		public const int MIXERCONTROL_CT_UNITS_SIGNED = 131072;

		public const int MIXERCONTROL_CT_UNITS_UNSIGNED = 196608;

		public const int MIXERLINE_COMPONENTTYPE_DST_DIGITAL = 1;

		public const int MIXERLINE_COMPONENTTYPE_DST_FIRST = 0;

		public const int MIXERLINE_COMPONENTTYPE_DST_HEADPHONES = 5;

		public const int MIXERLINE_COMPONENTTYPE_DST_LAST = 8;

		public const int MIXERLINE_COMPONENTTYPE_DST_LINE = 2;

		public const int MIXERLINE_COMPONENTTYPE_DST_MONITOR = 3;

		public const int MIXERLINE_COMPONENTTYPE_DST_SPEAKERS = 4;

		public const int MIXERLINE_COMPONENTTYPE_DST_TELEPHONE = 6;

		public const int MIXERLINE_COMPONENTTYPE_DST_UNDEFINED = 0;

		public const int MIXERLINE_COMPONENTTYPE_DST_VOICEIN = 8;

		public const int MIXERLINE_COMPONENTTYPE_DST_WAVEIN = 7;

		public const int MIXERLINE_COMPONENTTYPE_SRC_ANALOG = 4106;

		public const int MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY = 4105;

		public const int MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC = 4101;

		public const int MIXERLINE_COMPONENTTYPE_SRC_DIGITAL = 4097;

		public const int MIXERLINE_COMPONENTTYPE_SRC_FIRST = 4096;

		public const int MIXERLINE_COMPONENTTYPE_SRC_LAST = 4106;

		public const int MIXERLINE_COMPONENTTYPE_SRC_LINE = 4098;

		public const int MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE = 4099;

		public const int MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER = 4103;

		public const int MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER = 4100;

		public const int MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE = 4102;

		public const int MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED = 4096;

		public const int MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT = 4104;

		public const int MIXERLINE_LINEF_ACTIVE = 1;

		public const int MIXERLINE_LINEF_DISCONNECTED = 32768;

		public const int MIXERLINE_LINEF_SOURCE = -2147483648;

		public const int MIXERLINE_TARGETTYPE_AUX = 5;

		public const int MIXERLINE_TARGETTYPE_MIDIIN = 4;

		public const int MIXERLINE_TARGETTYPE_MIDIOUT = 3;

		public const int MIXERLINE_TARGETTYPE_UNDEFINED = 0;

		public const int MIXERLINE_TARGETTYPE_WAVEIN = 2;

		public const int MIXERLINE_TARGETTYPE_WAVEOUT = 1;

		public const int MIXERR_BASE = 1024;

		public const int MIXERR_INVALCONTROL = 1025;

		public const int MIXERR_INVALLINE = 1024;

		public const int MIXERR_INVALVALUE = 1026;

		public const int MIXERR_LASTERROR = 1026;

		public const int MIXER_GETCONTROLDETAILSF_LISTTEXT = 1;

		public const int MIXER_GETCONTROLDETAILSF_QUERYMASK = 15;

		public const int MIXER_GETCONTROLDETAILSF_VALUE = 0;

		public const int MIXER_GETLINECONTROLSF_ALL = 0;

		public const int MIXER_GETLINECONTROLSF_ONEBYID = 1;

		public const int MIXER_GETLINECONTROLSF_ONEBYTYPE = 2;

		public const int MIXER_GETLINECONTROLSF_QUERYMASK = 15;

		public const int MIXER_GETLINEINFOF_COMPONENTTYPE = 3;

		public const int MIXER_GETLINEINFOF_DESTINATION = 0;

		public const int MIXER_GETLINEINFOF_LINEID = 2;

		public const int MIXER_GETLINEINFOF_QUERYMASK = 15;

		public const int MIXER_GETLINEINFOF_SOURCE = 1;

		public const int MIXER_GETLINEINFOF_TARGETTYPE = 4;

		public const int MIXER_LONG_NAME_CHARS = 64;

		public const int MIXER_OBJECTF_AUX = 1342177280;

		public const int MIXER_OBJECTF_HANDLE = -2147483648;

		public const int MIXER_OBJECTF_HMIDIIN = -1073741824;

		public const int MIXER_OBJECTF_HMIDIOUT = -1342177280;

		public const int MIXER_OBJECTF_HMIXER = -2147483648;

		public const int MIXER_OBJECTF_HWAVEIN = -1610612736;

		public const int MIXER_OBJECTF_HWAVEOUT = -1879048192;

		public const int MIXER_OBJECTF_MIDIIN = 1073741824;

		public const int MIXER_OBJECTF_MIDIOUT = 805306368;

		public const int MIXER_OBJECTF_MIXER = 0;

		public const int MIXER_OBJECTF_WAVEIN = 536870912;

		public const int MIXER_OBJECTF_WAVEOUT = 268435456;

		public const int MIXER_SETCONTROLDETAILSF_CUSTOM = 1;

		public const int MIXER_SETCONTROLDETAILSF_QUERYMASK = 15;

		public const int MIXER_SETCONTROLDETAILSF_VALUE = 0;

		public const int MIXER_SHORT_NAME_CHARS = 16;

		public const int MMIOERR_BASE = 256;

		public const int MMIOERR_CANNOTCLOSE = 260;

		public const int MMIOERR_CANNOTEXPAND = 264;

		public const int MMIOERR_CANNOTOPEN = 259;

		public const int MMIOERR_CANNOTREAD = 261;

		public const int MMIOERR_CANNOTSEEK = 263;

		public const int MMIOERR_CANNOTWRITE = 262;

		public const int MMIOERR_CHUNKNOTFOUND = 265;

		public const int MMIOERR_FILENOTFOUND = 257;

		public const int MMIOERR_OUTOFMEMORY = 258;

		public const int MMIOERR_UNBUFFERED = 266;

		public const int MMIOM_CLOSE = 4;

		public const int MMIOM_OPEN = 3;

		public const int MMIOM_READ = 0;

		public const int MMIOM_RENAME = 6;

		public const int MMIOM_SEEK = 2;

		public const int MMIOM_USER = 32768;

		public const int MMIOM_WRITE = 1;

		public const int MMIOM_WRITEFLUSH = 5;

		public const int MMIO_ALLOCBUF = 65536;

		public const int MMIO_COMPAT = 0;

		public const int MMIO_CREATE = 4096;

		public const int MMIO_CREATELIST = 64;

		public const int MMIO_CREATERIFF = 32;

		public const int MMIO_DEFAULTBUFFER = 8192;

		public const int MMIO_DELETE = 512;

		public const int MMIO_DENYNONE = 64;

		public const int MMIO_DENYREAD = 48;

		public const int MMIO_DENYWRITE = 32;

		public const int MMIO_DIRTY = 268435456;

		public const int MMIO_EMPTYBUF = 16;

		public const int MMIO_EXCLUSIVE = 16;

		public const int MMIO_EXIST = 16384;

		public const int MMIO_FHOPEN = 16;

		public const int MMIO_FINDCHUNK = 16;

		public const int MMIO_FINDLIST = 64;

		public const int MMIO_FINDPROC = 262144;

		public const int MMIO_FINDRIFF = 32;

		public const int MMIO_GETTEMP = 131072;

		public const int MMIO_INSTALLPROC = 65536;

		public const int MMIO_OPEN_VALID = 262143;

		public const int MMIO_PARSE = 256;

		public const int MMIO_PUBLICPROC = 268435456;

		public const int MMIO_READ = 0;

		public const int MMIO_READWRITE = 2;

		public const int MMIO_REMOVEPROC = 131072;

		public const int MMIO_RWMODE = 3;

		public const int MMIO_SHAREMODE = 112;

		public const int MMIO_TOUPPER = 16;

		public const int MMIO_UNICODEPROC = 16777216;

		public const int MMIO_VALIDPROC = 285671424;

		public const int MMIO_WRITE = 1;

		public const int MMSYSERR_ALLOCATED = 4;

		public const int MMSYSERR_BADDEVICEID = 2;

		public const int MMSYSERR_BADERRNUM = 9;

		public const int MMSYSERR_BASE = 0;

		public const int MMSYSERR_ERROR = 1;

		public const int MMSYSERR_HANDLEBUSY = 12;

		public const int MMSYSERR_INVALFLAG = 10;

		public const int MMSYSERR_INVALHANDLE = 5;

		public const int MMSYSERR_INVALIDALIAS = 13;

		public const int MMSYSERR_INVALPARAM = 11;

		public const int MMSYSERR_LASTERROR = 13;

		public const int MMSYSERR_NODRIVER = 6;

		public const int MMSYSERR_NOERROR = 0;

		public const int MMSYSERR_NOMEM = 7;

		public const int MMSYSERR_NOTENABLED = 3;

		public const int MMSYSERR_NOTSUPPORTED = 8;

		public const int MM_ADLIB = 9;

		public const int MM_JOY1BUTTONDOWN = 949;

		public const int MM_JOY1BUTTONUP = 951;

		public const int MM_JOY1MOVE = 928;

		public const int MM_JOY1ZMOVE = 930;

		public const int MM_JOY2BUTTONDOWN = 950;

		public const int MM_JOY2BUTTONUP = 952;

		public const int MM_JOY2MOVE = 929;

		public const int MM_JOY2ZMOVE = 931;

		public const int MM_MCINOTIFY = 953;

		public const int MM_MCISIGNAL = 971;

		public const int MM_MCISYSTEM_STRING = 970;

		public const int MM_MICROSOFT = 1;

		public const int MM_MIDI_MAPPER = 1;

		public const int MM_MIM_CLOSE = 962;

		public const int MM_MIM_DATA = 963;

		public const int MM_MIM_ERROR = 965;

		public const int MM_MIM_LONGDATA = 964;

		public const int MM_MIM_LONGERROR = 966;

		public const int MM_MIM_MOREDATA = 972;

		public const int MM_MIM_OPEN = 961;

		public const int MM_MOM_CLOSE = 968;

		public const int MM_MOM_DONE = 969;

		public const int MM_MOM_OPEN = 967;

		public const int MM_MOM_POSITIONCB = 970;

		public const int MM_MPU401_MIDIIN = 11;

		public const int MM_MPU401_MIDIOUT = 10;

		public const int MM_PC_JOYSTICK = 12;

		public const int MM_SNDBLST_MIDIIN = 4;

		public const int MM_SNDBLST_MIDIOUT = 3;

		public const int MM_SNDBLST_SYNTH = 5;

		public const int MM_SNDBLST_WAVEIN = 7;

		public const int MM_SNDBLST_WAVEOUT = 6;

		public const int MM_WAVE_MAPPER = 2;

		public const int MM_WIM_CLOSE = 959;

		public const int MM_WIM_DATA = 960;

		public const int MM_WIM_OPEN = 958;

		public const int MM_WOM_CLOSE = 956;

		public const int MM_WOM_DONE = 957;

		public const int MM_WOM_OPEN = 955;

		public const int MOD_FMSYNTH = 4;

		public const int MOD_MAPPER = 5;

		public const int MOD_MIDIPORT = 1;

		public const int MOD_SQSYNTH = 3;

		public const int MOD_SYNTH = 2;

		public const int MOM_CLOSE = 968;

		public const int MOM_DONE = 969;

		public const int MOM_OPEN = 967;

		public const int MOM_POSITIONCB = 970;

		public const int NEWTRANSPARENT = 3;

		public const int QUERYROPSUPPORT = 40;

		public const int SEEK_CUR = 1;

		public const int SEEK_END = 2;

		public const int SEEK_SET = 0;

		public const int SELECTDIB = 41;

		public const int SND_ALIAS = 65536;

		public const int SND_ALIAS_ID = 1114112;

		public const int SND_ALIAS_START = 0;

		public const int SND_APPLICATION = 128;

		public const int SND_ASYNC = 1;

		public const int SND_FILENAME = 131072;

		public const int SND_LOOP = 8;

		public const int SND_MEMORY = 4;

		public const int SND_NODEFAULT = 2;

		public const int SND_NOSTOP = 16;

		public const int SND_NOWAIT = 8192;

		public const int SND_PURGE = 64;

		public const int SND_RESERVED = -16777216;

		public const int SND_RESOURCE = 262148;

		public const int SND_SYNC = 0;

		public const int SND_TYPE_MASK = 1507335;

		public const int SND_VALID = 31;

		public const int SND_VALIDFLAGS = 1515551;

		public const int TIMERR_BASE = 96;

		public const int TIMERR_NOCANDO = 97;

		public const int TIMERR_NOERROR = 0;

		public const int TIMERR_STRUCT = 129;

		public const int TIME_BYTES = 4;

		public const int TIME_MIDI = 16;

		public const int TIME_MS = 1;

		public const int TIME_ONESHOT = 0;

		public const int TIME_PERIODIC = 1;

		public const int TIME_SAMPLES = 2;

		public const int TIME_SMPTE = 8;

		public const int WAVECAPS_LRVOLUME = 8;

		public const int WAVECAPS_PITCH = 1;

		public const int WAVECAPS_PLAYBACKRATE = 2;

		public const int WAVECAPS_SYNC = 16;

		public const int WAVECAPS_VOLUME = 4;

		public const int WAVERR_BADFORMAT = 32;

		public const int WAVERR_BASE = 32;

		public const int WAVERR_LASTERROR = 35;

		public const int WAVERR_STILLPLAYING = 33;

		public const int WAVERR_SYNC = 35;

		public const int WAVERR_UNPREPARED = 34;

		public const int WAVE_ALLOWSYNC = 2;

		public const int WAVE_FORMAT_1M08 = 1;

		public const int WAVE_FORMAT_1M16 = 4;

		public const int WAVE_FORMAT_1S08 = 2;

		public const int WAVE_FORMAT_1S16 = 8;

		public const int WAVE_FORMAT_2M08 = 16;

		public const int WAVE_FORMAT_2M16 = 64;

		public const int WAVE_FORMAT_2S08 = 32;

		public const int WAVE_FORMAT_2S16 = 128;

		public const int WAVE_FORMAT_4M08 = 256;

		public const int WAVE_FORMAT_4M16 = 1024;

		public const int WAVE_FORMAT_4S08 = 512;

		public const int WAVE_FORMAT_4S16 = 2048;

		public const int WAVE_FORMAT_DIRECT = 8;

		public const int WAVE_FORMAT_DIRECT_QUERY = 9;

		public const int WAVE_FORMAT_PCM = 1;

		public const int WAVE_FORMAT_QUERY = 1;

		public const int WAVE_INVALIDFORMAT = 0;

		public const int WAVE_MAPPED = 4;

		public const int WAVE_MAPPER = -1;

		public const int WAVE_VALID = 3;

		public const int WHDR_BEGINLOOP = 4;

		public const int WHDR_DONE = 1;

		public const int WHDR_ENDLOOP = 8;

		public const int WHDR_INQUEUE = 16;

		public const int WHDR_PREPARED = 2;

		public const int WHDR_VALID = 31;

		public const int WIM_CLOSE = 959;

		public const int WIM_DATA = 960;

		public const int WIM_OPEN = 958;

		public const int WOM_CLOSE = 956;

		public const int WOM_DONE = 957;

		public const int WOM_OPEN = 955;

		public const string CFSEPCHAR = "+";

		[DllImport("winmm")]
		public static extern int mciGetYieldProc(int mciId, ref int pdwYieldData);

		[DllImport("winmm")]
		public static extern int mciSetYieldProc(int mciId, int fpYieldProc, int dwYieldData);

		[DllImport("winmm")]
		public static extern int mmioInstallIOProcA(int fccIOProc, ref int pIOProc, int dwFlags);

		[DllImport("winmm")]
		public static extern short midiOutGetNumDevs();

		[DllImport("winmm")]
		public static extern int CloseDriver(IntPtr hDriver, int lParam1, int lParam2);

		[DllImport("winmm")]
		public static extern int DefDriverProc(int dwDriverIdentifier, IntPtr hdrvr, int uMsg, int lParam1, int lParam2);

		[DllImport("winmm")]
		public static extern int DrvGetModuleHandle(IntPtr hDriver);

		[DllImport("winmm")]
		public static extern int GetDriverModuleHandle(IntPtr hDriver);

		[DllImport("winmm")]
		public static extern int OpenDriver(string szDriverName, string szSectionName, int lParam2);

		[DllImport("winmm")]
		public static extern int PlaySound(string lpszName, IntPtr hModule, int dwFlags);

		[DllImport("winmm")]
		public static extern int SendDriverMessage(IntPtr hDriver, int message, int lParam1, int lParam2);

		[DllImport("winmm")]
		public static extern int auxGetDevCaps(int uDeviceID, ref AUXCAPS lpCaps, int uSize);

		[DllImport("winmm")]
		public static extern int auxGetNumDevs();

		[DllImport("winmm")]
		public static extern int auxGetVolume(int uDeviceID, ref int lpdwVolume);

		[DllImport("winmm")]
		public static extern int auxOutMessage(int uDeviceID, int msg, int dw1, int dw2);

		[DllImport("winmm")]
		public static extern int auxSetVolume(int uDeviceID, int dwVolume);

		[DllImport("winmm")]
		public static extern int joyGetDevCaps(int id, ref JOYCAPS lpCaps, int uSize);

		[DllImport("winmm")]
		public static extern int joyGetNumDevs();

		[DllImport("winmm")]
		public static extern int joyGetPos(int uJoyID, ref JOYINFO pji);

		[DllImport("winmm")]
		public static extern int joyGetPosEx(int uJoyID, ref JOYINFOEX pji);

		[DllImport("winmm")]
		public static extern int joyGetThreshold(int id, ref int lpuThreshold);

		[DllImport("winmm")]
		public static extern int joyReleaseCapture(int id);

		[DllImport("winmm")]
		public static extern int joySetCapture(IntPtr hwnd, int uID, int uPeriod, int bChanged);

		[DllImport("winmm")]
		public static extern int joySetThreshold(int id, int uThreshold);

		[DllImport("winmm")]
		public static extern int mciExecute(string lpstrCommand);

		[DllImport("winmm")]
		public static extern int mciGetCreatorTask(int wDeviceID);

		[DllImport("winmm")]
		public static extern int mciGetDeviceID(string lpstrName);

		[DllImport("winmm")]
		public static extern int mciGetDeviceIDFromElementID(int dwElementID, string lpstrType);

		[DllImport("winmm")]
		public static extern int mciGetErrorString(int dwError, string lpstrBuffer, int uLength);

		[DllImport("winmm")]
		public static extern int mciSendCommand(int wDeviceID, int uMessage, int dwParam1, IntPtr dwParam2);

		[DllImport("winmm")]
		public static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

		[DllImport("winmm")]
		public static extern int midiConnect(IntPtr hmi, IntPtr hmo, IntPtr pReserved);

		[DllImport("winmm")]
		public static extern int midiDisconnect(IntPtr hmi, IntPtr hmo, IntPtr pReserved);

		[DllImport("winmm")]
		public static extern int midiInAddBuffer(IntPtr hMidiIn, ref MIDIHDR lpMidiInHdr, int uSize);

		[DllImport("winmm")]
		public static extern int midiInClose(IntPtr hMidiIn);

		[DllImport("winmm")]
		public static extern int midiInGetDevCaps(int uDeviceID, ref MIDIINCAPS lpCaps, int uSize);

		[DllImport("winmm")]
		public static extern int midiInGetErrorText(int err, string lpText, int uSize);

		[DllImport("winmm")]
		public static extern int midiInGetID(IntPtr hMidiIn, ref int lpuDeviceID);

		[DllImport("winmm")]
		public static extern int midiInGetNumDevs();

		[DllImport("winmm")]
		public static extern int midiInMessage(IntPtr hMidiIn, int msg, int dw1, int dw2);

		[DllImport("winmm")]
		public static extern int midiInOpen(int lphMidiIn, int uDeviceID, int dwCallback, int dwInstance, int dwFlags);

		[DllImport("winmm")]
		public static extern int midiInPrepareHeader(IntPtr hMidiIn, ref MIDIHDR lpMidiInHdr, int uSize);

		[DllImport("winmm")]
		public static extern int midiInReset(IntPtr hMidiIn);

		[DllImport("winmm")]
		public static extern int midiInStart(IntPtr hMidiIn);

		[DllImport("winmm")]
		public static extern int midiInStop(IntPtr hMidiIn);

		[DllImport("winmm")]
		public static extern int midiInUnprepareHeader(IntPtr hMidiIn, ref MIDIHDR lpMidiInHdr, int uSize);

		[DllImport("winmm")]
		public static extern int midiOutCacheDrumPatches(IntPtr hMidiOut, int uPatch, ref int lpKeyArray, int uFlags);

		[DllImport("winmm")]
		public static extern int midiOutCachePatches(IntPtr hMidiOut, int uBank, ref int lpPatchArray, int uFlags);

		[DllImport("winmm")]
		public static extern int midiOutClose(IntPtr hMidiOut);

		[DllImport("winmm")]
		public static extern int midiOutGetDevCaps(int uDeviceID, ref MIDIOUTCAPS lpCaps, int uSize);

		[DllImport("winmm")]
		public static extern int midiOutGetErrorText(int err, StringBuilder lpText, int uSize);

		[DllImport("winmm")]
		public static extern int midiOutGetID(IntPtr hMidiOut, ref int lpuDeviceID);

		[DllImport("winmm")]
		public static extern int midiOutGetVolume(int uDeviceID, ref int lpdwVolume);

		[DllImport("winmm")]
		public static extern int midiOutLongMsg(IntPtr hMidiOut, ref MIDIHDR lpMidiOutHdr, int uSize);

		[DllImport("winmm")]
		public static extern int midiOutMessage(IntPtr hMidiOut, int msg, int dw1, int dw2);

		[DllImport("winmm")]
		public static extern int midiOutOpen(int lphMidiOut, int uDeviceID, int dwCallback, int dwInstance, int dwFlags);

		[DllImport("winmm")]
		public static extern int midiOutPrepareHeader(IntPtr hMidiOut, ref MIDIHDR lpMidiOutHdr, int uSize);

		[DllImport("winmm")]
		public static extern int midiOutReset(IntPtr hMidiOut);

		[DllImport("winmm")]
		public static extern int midiOutSetVolume(int uDeviceID, int dwVolume);

		[DllImport("winmm")]
		public static extern int midiOutShortMsg(IntPtr hMidiOut, int dwMsg);

		[DllImport("winmm")]
		public static extern int midiOutUnprepareHeader(IntPtr hMidiOut, ref MIDIHDR lpMidiOutHdr, int uSize);

		[DllImport("winmm")]
		public static extern int midiStreamClose(IntPtr hms);

		[DllImport("winmm")]
		public static extern int midiStreamOpen(int phms, int puDeviceID, int cMidi, int dwCallback, int dwInstance, int fdwOpen);

		[DllImport("winmm")]
		public static extern int midiStreamOut(IntPtr hms, ref MIDIHDR pmh, int cbmh);

		[DllImport("winmm")]
		public static extern int midiStreamPause(IntPtr hms);

		[DllImport("winmm")]
		public static extern int midiStreamPosition(IntPtr hms, ref MMTIME lpmmt, int cbmmt);

		[DllImport("winmm")]
		public static extern int midiStreamProperty(IntPtr hms, byte lppropdata, int dwProperty);

		[DllImport("winmm")]
		public static extern int midiStreamRestart(IntPtr hms);

		[DllImport("winmm")]
		public static extern int midiStreamStop(IntPtr hms);

		[DllImport("winmm")]
		public static extern int mixerClose(IntPtr hmx);

		[DllImport("winmm")]
		public static extern int mixerGetControlDetails(IntPtr hmxobj, ref MIXERCONTROLDETAILS pmxcd, int fdwDetails);

		[DllImport("winmm")]
		public static extern int mixerGetDevCaps(int uMxId, ref MIXERCAPS pmxcaps, int cbmxcaps);

		[DllImport("winmm")]
		public static extern int mixerGetID(IntPtr hmxobj, ref int pumxID, int fdwId);

		[DllImport("winmm")]
		public static extern int mixerGetLineControls(IntPtr hmxobj, ref MIXERLINECONTROLS pmxlc, int fdwControls);

		[DllImport("winmm")]
		public static extern int mixerGetLineInfo(IntPtr hmxobj, ref MIXERLINE pmxl, int fdwInfo);

		[DllImport("winmm")]
		public static extern int mixerGetNumDevs();

		[DllImport("winmm")]
		public static extern int mixerMessage(IntPtr hmx, int uMsg, int dwParam1, int dwParam2);

		[DllImport("winmm")]
		public static extern int mixerOpen(int phmx, int uMxId, int dwCallback, int dwInstance, int fdwOpen);

		[DllImport("winmm")]
		public static extern int mixerSetControlDetails(IntPtr hmxobj, ref MIXERCONTROLDETAILS pmxcd, int fdwDetails);

		[DllImport("winmm")]
		public static extern int mmioAdvance(IntPtr hmmio, ref MMIOINFO lpmmioinfo, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioAscend(IntPtr hmmio, ref MMCKINFO lpck, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioClose(IntPtr hmmio, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioCreateChunk(IntPtr hmmio, ref MMCKINFO lpck, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioDescend(IntPtr hmmio, ref MMCKINFO lpck, ref MMCKINFO lpckParent, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioFlush(IntPtr hmmio, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioGetInfo(IntPtr hmmio, ref MMIOINFO lpmmioinfo, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioOpen(string szFileName, ref MMIOINFO lpmmioinfo, int dwOpenFlags);

		[DllImport("winmm")]
		public static extern int mmioRead(IntPtr hmmio, string pch, int cch);

		[DllImport("winmm")]
		public static extern int mmioRename(string szFileName, string SzNewFileName, ref MMIOINFO lpmmioinfo, int dwRenameFlags);

		[DllImport("winmm")]
		public static extern int mmioSeek(IntPtr hmmio, int lOffset, int iOrigin);

		[DllImport("winmm")]
		public static extern int mmioSendMessage(IntPtr hmmio, int uMsg, int lParam1, int lParam2);

		[DllImport("winmm")]
		public static extern int mmioSetBuffer(IntPtr hmmio, string pchBuffer, int cchBuffer, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioSetInfo(IntPtr hmmio, ref MMIOINFO lpmmioinfo, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioStringToFOURCC(string sz, int uFlags);

		[DllImport("winmm")]
		public static extern int mmioWrite(IntPtr hmmio, string pch, int cch);

		[DllImport("winmm")]
		public static extern int mmsystemGetVersion();

		[DllImport("winmm")]
		public static extern int sndPlaySound(string lpszSoundName, int uFlags);

		[DllImport("winmm")]
		public static extern int timeBeginPeriod(int uPeriod);

		[DllImport("winmm")]
		public static extern int timeEndPeriod(int uPeriod);

		[DllImport("winmm")]
		public static extern int timeGetDevCaps(ref TIMECAPS lpTimeCaps, int uSize);

		[DllImport("winmm")]
		public static extern int timeGetSystemTime(ref MMTIME lpTime, int uSize);

		[DllImport("winmm")]
		public static extern int timeGetTime();

		[DllImport("winmm")]
		public static extern int timeKillEvent(int uID);

		[DllImport("winmm")]
		public static extern int timeSetEvent(int uDelay, int uResolution, ref int lpFunction, int dwUser, int uFlags);

		[DllImport("winmm")]
		public static extern int waveInAddBuffer(IntPtr hWaveIn, ref WAVEHDR lpWaveInHdr, int uSize);

		[DllImport("winmm")]
		public static extern int waveInClose(IntPtr hWaveIn);

		[DllImport("winmm")]
		public static extern int waveInGetDevCaps(int uDeviceID, ref WAVEINCAPS lpCaps, int uSize);

		[DllImport("winmm")]
		public static extern int waveInGetErrorText(int err, string lpText, int uSize);

		[DllImport("winmm")]
		public static extern int waveInGetID(IntPtr hWaveIn, ref int lpuDeviceID);

		[DllImport("winmm")]
		public static extern int waveInGetNumDevs();

		[DllImport("winmm")]
		public static extern int waveInGetPosition(IntPtr hWaveIn, ref MMTIME lpInfo, int uSize);

		[DllImport("winmm")]
		public static extern int waveInMessage(IntPtr hWaveIn, int msg, int dw1, int dw2);

		[DllImport("winmm")]
		public static extern int waveInOpen(int lphWaveIn, int uDeviceID, ref WAVEFORMAT lpFormat, int dwCallback, int dwInstance, int dwFlags);

		[DllImport("winmm")]
		public static extern int waveInPrepareHeader(IntPtr hWaveIn, ref WAVEHDR lpWaveInHdr, int uSize);

		[DllImport("winmm")]
		public static extern int waveInReset(IntPtr hWaveIn);

		[DllImport("winmm")]
		public static extern int waveInStart(IntPtr hWaveIn);

		[DllImport("winmm")]
		public static extern int waveInStop(IntPtr hWaveIn);

		[DllImport("winmm")]
		public static extern int waveInUnprepareHeader(IntPtr hWaveIn, ref WAVEHDR lpWaveInHdr, int uSize);

		[DllImport("winmm")]
		public static extern int waveOutBreakLoop(IntPtr hWaveOut);

		[DllImport("winmm")]
		public static extern int waveOutClose(IntPtr hWaveOut);

		[DllImport("winmm")]
		public static extern int waveOutGetDevCaps(int uDeviceID, ref WAVEOUTCAPS lpCaps, int uSize);

		[DllImport("winmm")]
		public static extern int waveOutGetErrorText(int err, string lpText, int uSize);

		[DllImport("winmm")]
		public static extern int waveOutGetID(IntPtr hWaveOut, ref int lpuDeviceID);

		[DllImport("winmm")]
		public static extern int waveOutGetNumDevs();

		[DllImport("winmm")]
		public static extern int waveOutGetPitch(IntPtr hWaveOut, ref int lpdwPitch);

		[DllImport("winmm")]
		public static extern int waveOutGetPlaybackRate(IntPtr hWaveOut, ref int lpdwRate);

		[DllImport("winmm")]
		public static extern int waveOutGetPosition(IntPtr hWaveOut, ref MMTIME lpInfo, int uSize);

		[DllImport("winmm")]
		public static extern int waveOutGetVolume(int uDeviceID, ref int lpdwVolume);

		[DllImport("winmm")]
		public static extern int waveOutMessage(IntPtr hWaveOut, int msg, int dw1, int dw2);

		[DllImport("winmm")]
		public static extern int waveOutOpen(int lphWaveOut, int uDeviceID, ref WAVEFORMAT lpFormat, int dwCallback, int dwInstance, int dwFlags);

		[DllImport("winmm")]
		public static extern int waveOutPause(IntPtr hWaveOut);

		[DllImport("winmm")]
		public static extern int waveOutPrepareHeader(IntPtr hWaveOut, ref WAVEHDR lpWaveOutHdr, int uSize);

		[DllImport("winmm")]
		public static extern int waveOutReset(IntPtr hWaveOut);

		[DllImport("winmm")]
		public static extern int waveOutRestart(IntPtr hWaveOut);

		[DllImport("winmm")]
		public static extern int waveOutSetPitch(IntPtr hWaveOut, int dwPitch);

		[DllImport("winmm")]
		public static extern int waveOutSetPlaybackRate(IntPtr hWaveOut, int dwRate);

		[DllImport("winmm")]
		public static extern int waveOutSetVolume(int uDeviceID, int dwVolume);

		[DllImport("winmm")]
		public static extern int waveOutUnprepareHeader(IntPtr hWaveOut, ref WAVEHDR lpWaveOutHdr, int uSize);

		[DllImport("winmm")]
		public static extern int waveOutWrite(IntPtr hWaveOut, ref WAVEHDR lpWaveOutHdr, int uSize);
	}
}
