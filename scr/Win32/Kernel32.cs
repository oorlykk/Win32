using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Win32
{
	public abstract class Kernel32
	{
		public const int ACCESS_ALLOWED_ACE_TYPE = 0;

		public const int ACCESS_DENIED_ACE_TYPE = 1;

		public const int ACCESS_SYSTEM_SECURITY = 16777216;

		public const int ACL_REVISION = 2;

		public const int ACL_REVISION1 = 1;

		public const int ACL_REVISION2 = 2;

		public const int AC_LINE_BACKUP_POWER = 2;

		public const int AC_LINE_OFFLINE = 0;

		public const int AC_LINE_ONLINE = 1;

		public const int AC_LINE_UNKNOWN = 255;

		public const int APPLICATION_ERROR_MASK = 536870912;

		public const int AclRevisionInformation = 1;

		public const int AclSizeInformation = 2;

		public const int BACKGROUND_BLUE = 16;

		public const int BACKGROUND_GREEN = 32;

		public const int BACKGROUND_INTENSITY = 128;

		public const int BACKGROUND_RED = 64;

		public const int BACKUP_ALTERNATE_DATA = 4;

		public const int BACKUP_DATA = 1;

		public const int BACKUP_EA_DATA = 2;

		public const int BACKUP_LINK = 5;

		public const int BACKUP_SECURITY_DATA = 3;

		public const int BATTERY_FLAG_CHARGING = 8;

		public const int BATTERY_FLAG_CRITICAL = 4;

		public const int BATTERY_FLAG_HIGH = 1;

		public const int BATTERY_FLAG_LOW = 2;

		public const int BATTERY_FLAG_NO_BATTERY = 128;

		public const int BATTERY_FLAG_UNKNOWN = 255;

		public const int BATTERY_LIFE_UNKNOWN = 65535;

		public const int BATTERY_PERCENTAGE_UNKNOWN = 255;

		public const int BAUD_075 = 1;

		public const int BAUD_110 = 2;

		public const int BAUD_115200 = 131072;

		public const int BAUD_1200 = 64;

		public const int BAUD_128K = 65536;

		public const int BAUD_134_5 = 4;

		public const int BAUD_14400 = 4096;

		public const int BAUD_150 = 8;

		public const int BAUD_1800 = 128;

		public const int BAUD_19200 = 8192;

		public const int BAUD_2400 = 256;

		public const int BAUD_300 = 16;

		public const int BAUD_38400 = 16384;

		public const int BAUD_4800 = 512;

		public const int BAUD_56K = 32768;

		public const int BAUD_57600 = 262144;

		public const int BAUD_600 = 32;

		public const int BAUD_7200 = 1024;

		public const int BAUD_9600 = 2048;

		public const int BAUD_USER = 268435456;

		public const int C1_ALPHA = 256;

		public const int C1_BLANK = 64;

		public const int C1_CNTRL = 32;

		public const int C1_DIGIT = 4;

		public const int C1_LOWER = 2;

		public const int C1_PUNCT = 16;

		public const int C1_SPACE = 8;

		public const int C1_UPPER = 1;

		public const int C1_XDIGIT = 128;

		public const int C2_ARABICNUMBER = 6;

		public const int C2_BLOCKSEPARATOR = 8;

		public const int C2_COMMONSEPARATOR = 7;

		public const int C2_EUROPENUMBER = 3;

		public const int C2_EUROPESEPARATOR = 4;

		public const int C2_EUROPETERMINATOR = 5;

		public const int C2_LEFTTORIGHT = 1;

		public const int C2_NOTAPPLICABLE = 0;

		public const int C2_OTHERNEUTRAL = 11;

		public const int C2_RIGHTTOLEFT = 2;

		public const int C2_SEGMENTSEPARATOR = 9;

		public const int C2_WHITESPACE = 10;

		public const int C3_DIACRITIC = 2;

		public const int C3_NONSPACING = 1;

		public const int C3_NOTAPPLICABLE = 0;

		public const int C3_SYMBOL = 8;

		public const int C3_VOWELMARK = 4;

		public const int CAL_GREGORIAN = 1;

		public const int CAL_GREGORIAN_US = 2;

		public const int CAL_ICALINTVALUE = 1;

		public const int CAL_IYEAROFFSETRANGE = 3;

		public const int CAL_JAPAN = 3;

		public const int CAL_KOREA = 5;

		public const int CAL_SABBREVDAYNAME1 = 14;

		public const int CAL_SABBREVDAYNAME2 = 15;

		public const int CAL_SABBREVDAYNAME3 = 16;

		public const int CAL_SABBREVDAYNAME4 = 17;

		public const int CAL_SABBREVDAYNAME5 = 18;

		public const int CAL_SABBREVDAYNAME6 = 19;

		public const int CAL_SABBREVDAYNAME7 = 20;

		public const int CAL_SABBREVMONTHNAME1 = 34;

		public const int CAL_SABBREVMONTHNAME10 = 43;

		public const int CAL_SABBREVMONTHNAME11 = 44;

		public const int CAL_SABBREVMONTHNAME12 = 45;

		public const int CAL_SABBREVMONTHNAME13 = 46;

		public const int CAL_SABBREVMONTHNAME2 = 35;

		public const int CAL_SABBREVMONTHNAME3 = 36;

		public const int CAL_SABBREVMONTHNAME4 = 37;

		public const int CAL_SABBREVMONTHNAME5 = 38;

		public const int CAL_SABBREVMONTHNAME6 = 39;

		public const int CAL_SABBREVMONTHNAME7 = 40;

		public const int CAL_SABBREVMONTHNAME8 = 41;

		public const int CAL_SABBREVMONTHNAME9 = 42;

		public const int CAL_SCALNAME = 2;

		public const int CAL_SDAYNAME1 = 7;

		public const int CAL_SDAYNAME2 = 8;

		public const int CAL_SDAYNAME3 = 9;

		public const int CAL_SDAYNAME4 = 10;

		public const int CAL_SDAYNAME5 = 11;

		public const int CAL_SDAYNAME6 = 12;

		public const int CAL_SDAYNAME7 = 13;

		public const int CAL_SERASTRING = 4;

		public const int CAL_SLONGDATE = 6;

		public const int CAL_SMONTHNAME1 = 21;

		public const int CAL_SMONTHNAME10 = 30;

		public const int CAL_SMONTHNAME11 = 31;

		public const int CAL_SMONTHNAME12 = 32;

		public const int CAL_SMONTHNAME13 = 33;

		public const int CAL_SMONTHNAME2 = 22;

		public const int CAL_SMONTHNAME3 = 23;

		public const int CAL_SMONTHNAME4 = 24;

		public const int CAL_SMONTHNAME5 = 25;

		public const int CAL_SMONTHNAME6 = 26;

		public const int CAL_SMONTHNAME7 = 27;

		public const int CAL_SMONTHNAME8 = 28;

		public const int CAL_SMONTHNAME9 = 29;

		public const int CAL_SSHORTDATE = 5;

		public const int CAL_TAIWAN = 4;

		public const int CAPSLOCK_ON = 128;

		public const int CBR_110 = 110;

		public const int CBR_115200 = 115200;

		public const int CBR_1200 = 1200;

		public const int CBR_128000 = 128000;

		public const int CBR_14400 = 14400;

		public const int CBR_19200 = 19200;

		public const int CBR_2400 = 2400;

		public const int CBR_256000 = 256000;

		public const int CBR_300 = 300;

		public const int CBR_38400 = 38400;

		public const int CBR_4800 = 4800;

		public const int CBR_56000 = 56000;

		public const int CBR_57600 = 57600;

		public const int CBR_600 = 600;

		public const int CBR_9600 = 9600;

		public const int CE_BREAK = 16;

		public const int CE_DNS = 2048;

		public const int CE_FRAME = 8;

		public const int CE_IOE = 1024;

		public const int CE_MODE = 32768;

		public const int CE_OOP = 4096;

		public const int CE_OVERRUN = 2;

		public const int CE_PTO = 512;

		public const int CE_RXOVER = 1;

		public const int CE_RXPARITY = 4;

		public const int CE_TXFULL = 256;

		public const int CLRBREAK = 9;

		public const int CLRDTR = 6;

		public const int CLRRTS = 4;

		public const int CONSOLE_TEXTMODE_BUFFER = 1;

		public const int CONTAINER_INHERIT_ACE = 2;

		public const int CP_ACP = 0;

		public const int CP_OEMCP = 1;

		public const int CREATE_ALWAYS = 2;

		public const int CREATE_NEW = 1;

		public const int CREATE_NEW_CONSOLE = 16;

		public const int CREATE_NEW_PROCESS_GROUP = 512;

		public const int CREATE_NO_WINDOW = 134217728;

		public const int CREATE_PROCESS_DEBUG_EVENT = 3;

		public const int CREATE_SUSPENDED = 4;

		public const int CREATE_THREAD_DEBUG_EVENT = 2;

		public const int CTRL_BREAK_EVENT = 1;

		public const int CTRL_CLOSE_EVENT = 2;

		public const int CTRL_C_EVENT = 0;

		public const int CTRL_LOGOFF_EVENT = 5;

		public const int CTRL_SHUTDOWN_EVENT = 6;

		public const int CTRY_AUSTRALIA = 61;

		public const int CTRY_AUSTRIA = 43;

		public const int CTRY_BELGIUM = 32;

		public const int CTRY_BRAZIL = 55;

		public const int CTRY_CANADA = 2;

		public const int CTRY_DEFAULT = 0;

		public const int CTRY_DENMARK = 45;

		public const int CTRY_FINLAND = 358;

		public const int CTRY_FRANCE = 33;

		public const int CTRY_GERMANY = 49;

		public const int CTRY_ICELAND = 354;

		public const int CTRY_IRELAND = 353;

		public const int CTRY_ITALY = 39;

		public const int CTRY_JAPAN = 81;

		public const int CTRY_MEXICO = 52;

		public const int CTRY_NETHERLANDS = 31;

		public const int CTRY_NEW_ZEALAND = 64;

		public const int CTRY_NORWAY = 47;

		public const int CTRY_PORTUGAL = 351;

		public const int CTRY_PRCHINA = 86;

		public const int CTRY_SOUTH_KOREA = 82;

		public const int CTRY_SPAIN = 34;

		public const int CTRY_SWEDEN = 46;

		public const int CTRY_SWITZERLAND = 41;

		public const int CTRY_TAIWAN = 886;

		public const int CTRY_UNITED_KINGDOM = 44;

		public const int CTRY_UNITED_STATES = 1;

		public const int CT_CTYPE1 = 1;

		public const int CT_CTYPE2 = 2;

		public const int CT_CTYPE3 = 4;

		public const int DATABITS_16 = 16;

		public const int DATABITS_16X = 32;

		public const int DATABITS_5 = 1;

		public const int DATABITS_6 = 2;

		public const int DATABITS_7 = 4;

		public const int DATABITS_8 = 8;

		public const int DATE_LONGDATE = 2;

		public const int DATE_SHORTDATE = 1;

		public const int DDD_EXACT_MATCH_ON_REMOVE = 4;

		public const int DDD_RAW_TARGET_PATH = 1;

		public const int DDD_REMOVE_DEFINITION = 2;

		public const int DEBUG_ONLY_THIS_PROCESS = 2;

		public const int DEBUG_PROCESS = 1;

		public const int DELETE = 65536;

		public const int DETACHED_PROCESS = 8;

		public const int DFCS_ADJUSTRECT = 8192;

		public const int DFCS_BUTTON3STATE = 8;

		public const int DFCS_BUTTONCHECK = 0;

		public const int DFCS_BUTTONPUSH = 16;

		public const int DFCS_BUTTONRADIO = 4;

		public const int DFCS_BUTTONRADIOIMAGE = 1;

		public const int DFCS_BUTTONRADIOMASK = 2;

		public const int DFCS_CAPTIONCLOSE = 0;

		public const int DFCS_CAPTIONHELP = 4;

		public const int DFCS_CAPTIONMAX = 2;

		public const int DFCS_CAPTIONMIN = 1;

		public const int DFCS_CAPTIONRESTORE = 3;

		public const int DFCS_CHECKED = 1024;

		public const int DFCS_FLAT = 16384;

		public const int DFCS_INACTIVE = 256;

		public const int DFCS_MENUARROW = 0;

		public const int DFCS_MENUARROWRIGHT = 4;

		public const int DFCS_MENUBULLET = 2;

		public const int DFCS_MENUCHECK = 1;

		public const int DFCS_MONO = 32768;

		public const int DFCS_PUSHED = 512;

		public const int DFCS_SCROLLCOMBOBOX = 5;

		public const int DFCS_SCROLLDOWN = 1;

		public const int DFCS_SCROLLLEFT = 2;

		public const int DFCS_SCROLLRIGHT = 3;

		public const int DFCS_SCROLLSIZEGRIP = 8;

		public const int DFCS_SCROLLSIZEGRIPRIGHT = 16;

		public const int DFCS_SCROLLUP = 0;

		public const int DFC_BUTTON = 4;

		public const int DFC_CAPTION = 1;

		public const int DFC_MENU = 2;

		public const int DFC_SCROLL = 3;

		public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = 548;

		public const int DOMAIN_ALIAS_RID_ADMINS = 544;

		public const int DOMAIN_ALIAS_RID_BACKUP_OPS = 551;

		public const int DOMAIN_ALIAS_RID_GUESTS = 546;

		public const int DOMAIN_ALIAS_RID_POWER_USERS = 547;

		public const int DOMAIN_ALIAS_RID_PRINT_OPS = 550;

		public const int DOMAIN_ALIAS_RID_REPLICATOR = 552;

		public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = 549;

		public const int DOMAIN_ALIAS_RID_USERS = 545;

		public const int DOMAIN_GROUP_RID_ADMINS = 512;

		public const int DOMAIN_GROUP_RID_GUESTS = 514;

		public const int DOMAIN_GROUP_RID_USERS = 513;

		public const int DOMAIN_USER_RID_ADMIN = 500;

		public const int DOMAIN_USER_RID_GUEST = 501;

		public const int DONT_RESOLVE_DLL_REFERENCES = 1;

		public const int DOUBLE_CLICK = 2;

		public const int DRIVE_CDROM = 5;

		public const int DRIVE_FIXED = 3;

		public const int DRIVE_RAMDISK = 6;

		public const int DRIVE_REMOTE = 4;

		public const int DRIVE_REMOVABLE = 2;

		public const int DTR_CONTROL_DISABLE = 0;

		public const int DTR_CONTROL_ENABLE = 1;

		public const int DTR_CONTROL_HANDSHAKE = 2;

		public const int DUPLICATE_CLOSE_SOURCE = 1;

		public const int DUPLICATE_SAME_ACCESS = 2;

		public const int ENABLE_ECHO_INPUT = 4;

		public const int ENABLE_LINE_INPUT = 2;

		public const int ENABLE_MOUSE_INPUT = 16;

		public const int ENABLE_PROCESSED_INPUT = 1;

		public const int ENABLE_PROCESSED_OUTPUT = 1;

		public const int ENABLE_WINDOW_INPUT = 8;

		public const int ENABLE_WRAP_AT_EOL_OUTPUT = 2;

		public const int ENHANCED_KEY = 256;

		public const int ENUM_ALL_CALENDARS = 65535;

		public const int ERROR_SEVERITY_ERROR = -1073741824;

		public const int ERROR_SEVERITY_INFORMATIONAL = 1073741824;

		public const int ERROR_SEVERITY_SUCCESS = 0;

		public const int ERROR_SEVERITY_WARNING = -2147483648;

		public const int EVENPARITY = 2;

		public const int EV_BREAK = 64;

		public const int EV_CTS = 8;

		public const int EV_DSR = 16;

		public const int EV_ERR = 128;

		public const int EV_EVENT1 = 2048;

		public const int EV_EVENT2 = 4096;

		public const int EV_PERR = 512;

		public const int EV_RING = 256;

		public const int EV_RLSD = 32;

		public const int EV_RX80FULL = 1024;

		public const int EV_RXCHAR = 1;

		public const int EV_RXFLAG = 2;

		public const int EV_TXEMPTY = 4;

		public const int EXCEPTION_CONTINUE_EXECUTION = -1;

		public const int EXCEPTION_CONTINUE_SEARCH = 0;

		public const int EXCEPTION_DEBUG_EVENT = 1;

		public const int EXCEPTION_EXECUTE_HANDLER = 1;

		public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;

		public const int EXIT_PROCESS_DEBUG_EVENT = 5;

		public const int EXIT_THREAD_DEBUG_EVENT = 4;

		public const int FAILED_ACCESS_ACE_FLAG = 128;

		public const int FILE_ADD_FILE = 2;

		public const int FILE_ADD_SUBDIRECTORY = 4;

		public const int FILE_ALL_ACCESS = 2032127;

		public const int FILE_APPEND_DATA = 4;

		public const int FILE_ATTRIBUTE_ARCHIVE = 32;

		public const int FILE_ATTRIBUTE_COMPRESSED = 2048;

		public const int FILE_ATTRIBUTE_DIRECTORY = 16;

		public const int FILE_ATTRIBUTE_HIDDEN = 2;

		public const int FILE_ATTRIBUTE_NORMAL = 128;

		public const int FILE_ATTRIBUTE_READONLY = 1;

		public const int FILE_ATTRIBUTE_SYSTEM = 4;

		public const int FILE_ATTRIBUTE_TEMPORARY = 256;

		public const int FILE_BEGIN = 0;

		public const int FILE_CASE_PRESERVED_NAMES = 2;

		public const int FILE_CASE_SENSITIVE_SEARCH = 1;

		public const int FILE_CREATE_PIPE_INSTANCE = 4;

		public const int FILE_CURRENT = 1;

		public const int FILE_DELETE_CHILD = 64;

		public const int FILE_END = 2;

		public const int FILE_EXECUTE = 32;

		public const int FILE_FILE_COMPRESSION = 16;

		public const int FILE_FLAG_BACKUP_SEMANTICS = 33554432;

		public const int FILE_FLAG_DELETE_ON_CLOSE = 67108864;

		public const int FILE_FLAG_NO_BUFFERING = 536870912;

		public const int FILE_FLAG_OVERLAPPED = 1073741824;

		public const int FILE_FLAG_POSIX_SEMANTICS = 16777216;

		public const int FILE_FLAG_RANDOM_ACCESS = 268435456;

		public const int FILE_FLAG_SEQUENTIAL_SCAN = 134217728;

		public const int FILE_FLAG_WRITE_THROUGH = -2147483648;

		public const int FILE_GENERIC_EXECUTE = 1179808;

		public const int FILE_GENERIC_READ = 1179785;

		public const int FILE_GENERIC_WRITE = 1179926;

		public const int FILE_LIST_DIRECTORY = 1;

		public const int FILE_MAP_ALL_ACCESS = 983071;

		public const int FILE_MAP_COPY = 1;

		public const int FILE_MAP_READ = 4;

		public const int FILE_MAP_WRITE = 2;

		public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 4;

		public const int FILE_NOTIFY_CHANGE_DIR_NAME = 2;

		public const int FILE_NOTIFY_CHANGE_FILE_NAME = 1;

		public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 16;

		public const int FILE_NOTIFY_CHANGE_SECURITY = 256;

		public const int FILE_NOTIFY_CHANGE_SIZE = 8;

		public const int FILE_PERSISTENT_ACLS = 8;

		public const int FILE_READ_ATTRIBUTES = 128;

		public const int FILE_READ_DATA = 1;

		public const int FILE_READ_EA = 8;

		public const int FILE_READ_PROPERTIES = 8;

		public const int FILE_SHARE_READ = 1;

		public const int FILE_SHARE_WRITE = 2;

		public const int FILE_TRAVERSE = 32;

		public const int FILE_TYPE_CHAR = 2;

		public const int FILE_TYPE_DISK = 1;

		public const int FILE_TYPE_PIPE = 3;

		public const int FILE_TYPE_REMOTE = 32768;

		public const int FILE_TYPE_UNKNOWN = 0;

		public const int FILE_UNICODE_ON_DISK = 4;

		public const int FILE_VOLUME_IS_COMPRESSED = 32768;

		public const int FILE_WRITE_ATTRIBUTES = 256;

		public const int FILE_WRITE_DATA = 2;

		public const int FILE_WRITE_EA = 16;

		public const int FILE_WRITE_PROPERTIES = 16;

		public const int FOCUS_EVENT = 16;

		public const int FOREGROUND_BLUE = 1;

		public const int FOREGROUND_GREEN = 2;

		public const int FOREGROUND_INTENSITY = 8;

		public const int FOREGROUND_RED = 4;

		public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;

		public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

		public const int FORMAT_MESSAGE_FROM_HMODULE = 2048;

		public const int FORMAT_MESSAGE_FROM_STRING = 1024;

		public const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

		public const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

		public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 255;

		public const int FROM_LEFT_1ST_BUTTON_PRESSED = 1;

		public const int FROM_LEFT_2ND_BUTTON_PRESSED = 4;

		public const int FROM_LEFT_3RD_BUTTON_PRESSED = 8;

		public const int FROM_LEFT_4TH_BUTTON_PRESSED = 16;

		public const int FS_CASE_IS_PRESERVED = 2;

		public const int FS_CASE_SENSITIVE = 1;

		public const int FS_PERSISTENT_ACLS = 8;

		public const int FS_UNICODE_STORED_ON_DISK = 4;

		public const int GENERIC_ALL = 268435456;

		public const int GENERIC_EXECUTE = 536870912;

		public const int GENERIC_READ = -2147483648;

		public const int GENERIC_WRITE = 1073741824;

		public const int GET_TAPE_DRIVE_INFORMATION = 1;

		public const int GET_TAPE_MEDIA_INFORMATION = 0;

		public const int GHND = 66;

		public const int GMEM_DDESHARE = 8192;

		public const int GMEM_DISCARDABLE = 256;

		public const int GMEM_DISCARDED = 16384;

		public const int GMEM_FIXED = 0;

		public const int GMEM_INVALID_HANDLE = 32768;

		public const int GMEM_LOCKCOUNT = 255;

		public const int GMEM_LOWER = 4096;

		public const int GMEM_MODIFY = 128;

		public const int GMEM_MOVEABLE = 2;

		public const int GMEM_NOCOMPACT = 16;

		public const int GMEM_NODISCARD = 32;

		public const int GMEM_NOTIFY = 16384;

		public const int GMEM_NOT_BANKED = 4096;

		public const int GMEM_SHARE = 8192;

		public const int GMEM_VALID_FLAGS = 32626;

		public const int GMEM_ZEROINIT = 64;

		public const int GPTR = 64;

		public const int HIGH_PRIORITY_CLASS = 128;

		public const int HKEY_CLASSES_ROOT = -2147483648;

		public const int HKEY_CURRENT_CONFIG = -2147483643;

		public const int HKEY_CURRENT_USER = -2147483647;

		public const int HKEY_DYN_DATA = -2147483642;

		public const int HKEY_LOCAL_MACHINE = -2147483646;

		public const int HKEY_PERFORMANCE_DATA = -2147483644;

		public const int HKEY_USERS = -2147483645;

		public const int IDLE_PRIORITY_CLASS = 64;

		public const int IE_BADID = -1;

		public const int IE_BAUDRATE = -12;

		public const int IE_BYTESIZE = -11;

		public const int IE_DEFAULT = -5;

		public const int IE_HARDWARE = -10;

		public const int IE_MEMORY = -4;

		public const int IE_NOPEN = -3;

		public const int IE_OPEN = -2;

		public const int IGNORE = 0;

		public const int INFINITE = 65535;

		public const int INHERIT_ONLY_ACE = 8;

		public const int IO_COMPLETION_ALL_ACCESS = 2031619;

		public const int IO_COMPLETION_MODIFY_STATE = 2;

		public const int KEY_ALL_ACCESS = 983103;

		public const int KEY_CREATE_LINK = 32;

		public const int KEY_CREATE_SUB_KEY = 4;

		public const int KEY_ENUMERATE_SUB_KEYS = 8;

		public const int KEY_EVENT = 1;

		public const int KEY_EXECUTE = 131097;

		public const int KEY_NOTIFY = 16;

		public const int KEY_QUERY_VALUE = 1;

		public const int KEY_READ = 131097;

		public const int KEY_SET_VALUE = 2;

		public const int KEY_WRITE = 131078;

		public const int LANG_BULGARIAN = 2;

		public const int LANG_CHINESE = 4;

		public const int LANG_CROATIAN = 26;

		public const int LANG_CZECH = 5;

		public const int LANG_DANISH = 6;

		public const int LANG_DUTCH = 19;

		public const int LANG_ENGLISH = 9;

		public const int LANG_FINNISH = 11;

		public const int LANG_FRENCH = 12;

		public const int LANG_GERMAN = 7;

		public const int LANG_GREEK = 8;

		public const int LANG_HUNGARIAN = 14;

		public const int LANG_ICELANDIC = 15;

		public const int LANG_ITALIAN = 16;

		public const int LANG_JAPANESE = 17;

		public const int LANG_KOREAN = 18;

		public const int LANG_NEUTRAL = 0;

		public const int LANG_NORWEGIAN = 20;

		public const int LANG_POLISH = 21;

		public const int LANG_PORTUGUESE = 22;

		public const int LANG_ROMANIAN = 24;

		public const int LANG_RUSSIAN = 25;

		public const int LANG_SLOVAK = 27;

		public const int LANG_SLOVENIAN = 36;

		public const int LANG_SPANISH = 10;

		public const int LANG_SWEDISH = 29;

		public const int LANG_TURKISH = 31;

		public const int LCMAP_BYTEREV = 2048;

		public const int LCMAP_LOWERCASE = 256;

		public const int LCMAP_SORTKEY = 1024;

		public const int LCMAP_UPPERCASE = 512;

		public const int LEFT_ALT_PRESSED = 2;

		public const int LEFT_CTRL_PRESSED = 8;

		public const int LHND = 66;

		public const int LMEM_DISCARDABLE = 3840;

		public const int LMEM_DISCARDED = 16384;

		public const int LMEM_FIXED = 0;

		public const int LMEM_INVALID_HANDLE = 32768;

		public const int LMEM_LOCKCOUNT = 255;

		public const int LMEM_MODIFY = 128;

		public const int LMEM_MOVEABLE = 2;

		public const int LMEM_NOCOMPACT = 16;

		public const int LMEM_NODISCARD = 32;

		public const int LMEM_VALID_FLAGS = 3954;

		public const int LMEM_ZEROINIT = 64;

		public const int LNOTIFY_DISCARD = 2;

		public const int LNOTIFY_MOVE = 1;

		public const int LNOTIFY_OUTOFMEM = 0;

		public const int LOAD_DLL_DEBUG_EVENT = 6;

		public const int LOCALE_ICENTURY = 36;

		public const int LOCALE_ICOUNTRY = 5;

		public const int LOCALE_ICURRDIGITS = 25;

		public const int LOCALE_ICURRENCY = 27;

		public const int LOCALE_IDATE = 33;

		public const int LOCALE_IDAYLZERO = 38;

		public const int LOCALE_IDEFAULTCODEPAGE = 11;

		public const int LOCALE_IDEFAULTCOUNTRY = 10;

		public const int LOCALE_IDEFAULTLANGUAGE = 9;

		public const int LOCALE_IDIGITS = 17;

		public const int LOCALE_IINTLCURRDIGITS = 26;

		public const int LOCALE_ILANGUAGE = 1;

		public const int LOCALE_ILDATE = 34;

		public const int LOCALE_ILZERO = 18;

		public const int LOCALE_IMEASURE = 13;

		public const int LOCALE_IMONLZERO = 39;

		public const int LOCALE_INEGCURR = 28;

		public const int LOCALE_INEGSEPBYSPACE = 87;

		public const int LOCALE_INEGSIGNPOSN = 83;

		public const int LOCALE_INEGSYMPRECEDES = 86;

		public const int LOCALE_IPOSSEPBYSPACE = 85;

		public const int LOCALE_IPOSSIGNPOSN = 82;

		public const int LOCALE_IPOSSYMPRECEDES = 84;

		public const int LOCALE_ITIME = 35;

		public const int LOCALE_ITLZERO = 37;

		public const int LOCALE_NOUSEROVERRIDE = -2147483648;

		public const int LOCALE_S1159 = 40;

		public const int LOCALE_S2359 = 41;

		public const int LOCALE_SABBREVCTRYNAME = 7;

		public const int LOCALE_SABBREVDAYNAME1 = 49;

		public const int LOCALE_SABBREVDAYNAME2 = 50;

		public const int LOCALE_SABBREVDAYNAME3 = 51;

		public const int LOCALE_SABBREVDAYNAME4 = 52;

		public const int LOCALE_SABBREVDAYNAME5 = 53;

		public const int LOCALE_SABBREVDAYNAME6 = 54;

		public const int LOCALE_SABBREVDAYNAME7 = 55;

		public const int LOCALE_SABBREVLANGNAME = 3;

		public const int LOCALE_SABBREVMONTHNAME1 = 68;

		public const int LOCALE_SABBREVMONTHNAME10 = 77;

		public const int LOCALE_SABBREVMONTHNAME11 = 78;

		public const int LOCALE_SABBREVMONTHNAME12 = 79;

		public const int LOCALE_SABBREVMONTHNAME13 = 4111;

		public const int LOCALE_SABBREVMONTHNAME2 = 69;

		public const int LOCALE_SABBREVMONTHNAME3 = 70;

		public const int LOCALE_SABBREVMONTHNAME4 = 71;

		public const int LOCALE_SABBREVMONTHNAME5 = 72;

		public const int LOCALE_SABBREVMONTHNAME6 = 73;

		public const int LOCALE_SABBREVMONTHNAME7 = 74;

		public const int LOCALE_SABBREVMONTHNAME8 = 75;

		public const int LOCALE_SABBREVMONTHNAME9 = 76;

		public const int LOCALE_SCOUNTRY = 6;

		public const int LOCALE_SCURRENCY = 20;

		public const int LOCALE_SDATE = 29;

		public const int LOCALE_SDAYNAME1 = 42;

		public const int LOCALE_SDAYNAME2 = 43;

		public const int LOCALE_SDAYNAME3 = 44;

		public const int LOCALE_SDAYNAME4 = 45;

		public const int LOCALE_SDAYNAME5 = 46;

		public const int LOCALE_SDAYNAME6 = 47;

		public const int LOCALE_SDAYNAME7 = 48;

		public const int LOCALE_SDECIMAL = 14;

		public const int LOCALE_SENGCOUNTRY = 4098;

		public const int LOCALE_SENGLANGUAGE = 4097;

		public const int LOCALE_SGROUPING = 16;

		public const int LOCALE_SINTLSYMBOL = 21;

		public const int LOCALE_SLANGUAGE = 2;

		public const int LOCALE_SLIST = 12;

		public const int LOCALE_SLONGDATE = 32;

		public const int LOCALE_SMONDECIMALSEP = 22;

		public const int LOCALE_SMONGROUPING = 24;

		public const int LOCALE_SMONTHNAME1 = 56;

		public const int LOCALE_SMONTHNAME10 = 65;

		public const int LOCALE_SMONTHNAME11 = 66;

		public const int LOCALE_SMONTHNAME12 = 67;

		public const int LOCALE_SMONTHNAME2 = 57;

		public const int LOCALE_SMONTHNAME3 = 58;

		public const int LOCALE_SMONTHNAME4 = 59;

		public const int LOCALE_SMONTHNAME5 = 60;

		public const int LOCALE_SMONTHNAME6 = 61;

		public const int LOCALE_SMONTHNAME7 = 62;

		public const int LOCALE_SMONTHNAME8 = 63;

		public const int LOCALE_SMONTHNAME9 = 64;

		public const int LOCALE_SMONTHOUSANDSEP = 23;

		public const int LOCALE_SNATIVECTRYNAME = 8;

		public const int LOCALE_SNATIVEDIGITS = 19;

		public const int LOCALE_SNATIVELANGNAME = 4;

		public const int LOCALE_SNEGATIVESIGN = 81;

		public const int LOCALE_SPOSITIVESIGN = 80;

		public const int LOCALE_SSHORTDATE = 31;

		public const int LOCALE_STHOUSAND = 15;

		public const int LOCALE_STIME = 30;

		public const int LOCALE_STIMEFORMAT = 4099;

		public const int LOCKFILE_EXCLUSIVE_LOCK = 2;

		public const int LOCKFILE_FAIL_IMMEDIATELY = 1;

		public const int LOGON32_LOGON_BATCH = 4;

		public const int LOGON32_LOGON_INTERACTIVE = 2;

		public const int LOGON32_LOGON_SERVICE = 5;

		public const int LOGON32_PROVIDER_DEFAULT = 0;

		public const int LOGON32_PROVIDER_WINNT35 = 1;

		public const int LPTR = 64;

		public const int LPTx = 128;

		public const int MAILSLOT_NO_MESSAGE = -1;

		public const int MAILSLOT_WAIT_FOREVER = -1;

		public const int MAP_COMPOSITE = 64;

		public const int MAP_FOLDCZONE = 16;

		public const int MAP_FOLDDIGITS = 128;

		public const int MAP_PRECOMPOSED = 32;

		public const int MARKPARITY = 3;

		public const int MAXByte = 255;

		public const int MAXCHAR = 127;

		public const int MAXDWORD = -1;

		public const int MAXIMUM_ALLOWED = 33554432;

		public const int MAXLONG = 2147483647;

		public const int MAXSHORT = 32767;

		public const int MAXWORD = 65535;

		public const int MAX_DEFAULTCHAR = 2;

		public const int MAX_LEADBYTES = 12;

		public const int MAX_PATH = 260;

		public const int MB_COMPOSITE = 2;

		public const int MB_PRECOMPOSED = 1;

		public const int MB_USEGLYPHCHARS = 4;

		public const int MENU_EVENT = 8;

		public const int MINCHAR = 128;

		public const int MINLONG = -2147483648;

		public const int MINSHORT = 32768;

		public const int MOUSE_MOVED = 1;

		public const int MOVEFILE_COPY_ALLOWED = 2;

		public const int MOVEFILE_DELAY_UNTIL_REBOOT = 4;

		public const int MOVEFILE_REPLACE_EXISTING = 1;

		public const int MS_CTS_ON = 16;

		public const int MS_DSR_ON = 32;

		public const int MS_RING_ON = 64;

		public const int MS_RLSD_ON = 128;

		public const int NMPWAIT_NOWAIT = 1;

		public const int NMPWAIT_USE_DEFAULT_WAIT = 0;

		public const int NMPWAIT_WAIT_FOREVER = 65535;

		public const int NONZEROLHND = 2;

		public const int NONZEROLPTR = 0;

		public const int NOPARITY = 0;

		public const int NORMAL_PRIORITY_CLASS = 32;

		public const int NORM_IGNORECASE = 1;

		public const int NORM_IGNORENONSPACE = 2;

		public const int NORM_IGNORESYMBOLS = 4;

		public const int NO_PROPAGATE_INHERIT_ACE = 4;

		public const int NUMLOCK_ON = 32;

		public const int OBJECT_INHERIT_ACE = 1;

		public const int ODDPARITY = 1;

		public const int OFS_MAXPATHNAME = 128;

		public const int OF_CANCEL = 2048;

		public const int OF_CREATE = 4096;

		public const int OF_DELETE = 512;

		public const int OF_EXIST = 16384;

		public const int OF_PARSE = 256;

		public const int OF_PROMPT = 8192;

		public const int OF_READ = 0;

		public const int OF_READWRITE = 2;

		public const int OF_REOPEN = 32768;

		public const int OF_SHARE_COMPAT = 0;

		public const int OF_SHARE_DENY_NONE = 64;

		public const int OF_SHARE_DENY_READ = 48;

		public const int OF_SHARE_DENY_WRITE = 32;

		public const int OF_SHARE_EXCLUSIVE = 16;

		public const int OF_VERIFY = 1024;

		public const int OF_WRITE = 1;

		public const int ONE5STOPBITS = 1;

		public const int ONESTOPBIT = 0;

		public const int OPEN_ALWAYS = 4;

		public const int OPEN_EXISTING = 3;

		public const int OUTPUT_DEBUG_STRING_EVENT = 8;

		public const int PARITY_EVEN = 1024;

		public const int PARITY_MARK = 2048;

		public const int PARITY_NONE = 256;

		public const int PARITY_ODD = 512;

		public const int PARITY_SPACE = 4096;

		public const int PCF_16BITMODE = 512;

		public const int PCF_DTRDSR = 1;

		public const int PCF_INTTIMEOUTS = 128;

		public const int PCF_PARITY_CHECK = 8;

		public const int PCF_RLSD = 4;

		public const int PCF_RTSCTS = 2;

		public const int PCF_SETXCHAR = 32;

		public const int PCF_SPECIALCHARS = 256;

		public const int PCF_TOTALTIMEOUTS = 64;

		public const int PCF_XONXOFF = 16;

		public const int PERF_100NSEC_MULTI_TIMER = 575735040;

		public const int PERF_100NSEC_MULTI_TIMER_INV = 592512256;

		public const int PERF_100NSEC_TIMER = 542180608;

		public const int PERF_100NSEC_TIMER_INV = 558957824;

		public const int PERF_AVERAGE_BASE = 1073939458;

		public const int PERF_AVERAGE_BULK = 1073874176;

		public const int PERF_AVERAGE_TIMER = 805438464;

		public const int PERF_COUNTER_BASE = 196608;

		public const int PERF_COUNTER_BULK_COUNT = 272696576;

		public const int PERF_COUNTER_COUNTER = 272696320;

		public const int PERF_COUNTER_ELAPSED = 262144;

		public const int PERF_COUNTER_FRACTION = 131072;

		public const int PERF_COUNTER_HISTOGRAM = 393216;

		public const int PERF_COUNTER_HISTOGRAM_TYPE = -2147483648;

		public const int PERF_COUNTER_MULTI_BASE = 1107494144;

		public const int PERF_COUNTER_MULTI_TIMER = 574686464;

		public const int PERF_COUNTER_MULTI_TIMER_INV = 591463680;

		public const int PERF_COUNTER_NODATA = 1073742336;

		public const int PERF_COUNTER_QUEUELEN = 327680;

		public const int PERF_COUNTER_QUEUELEN_TYPE = 4523008;

		public const int PERF_COUNTER_RATE = 65536;

		public const int PERF_COUNTER_RAWCOUNT = 65536;

		public const int PERF_COUNTER_TEXT = 2816;

		public const int PERF_COUNTER_TIMER = 541132032;

		public const int PERF_COUNTER_TIMER_INV = 557909248;

		public const int PERF_COUNTER_VALUE = 0;

		public const int PERF_DATA_REVISION = 1;

		public const int PERF_DATA_VERSION = 1;

		public const int PERF_DELTA_BASE = 8388608;

		public const int PERF_DELTA_COUNTER = 4194304;

		public const int PERF_DETAIL_ADVANCED = 200;

		public const int PERF_DETAIL_EXPERT = 300;

		public const int PERF_DETAIL_NOVICE = 100;

		public const int PERF_DETAIL_WIZARD = 400;

		public const int PERF_DISPLAY_NOSHOW = 1073741824;

		public const int PERF_DISPLAY_NO_SUFFIX = 0;

		public const int PERF_DISPLAY_PERCENT = 536870912;

		public const int PERF_DISPLAY_PER_SEC = 268435456;

		public const int PERF_DISPLAY_SECONDS = 805306368;

		public const int PERF_ELAPSED_TIME = 807666944;

		public const int PERF_INVERSE_COUNTER = 16777216;

		public const int PERF_MULTI_COUNTER = 33554432;

		public const int PERF_NO_INSTANCES = -1;

		public const int PERF_NO_UNIQUE_ID = -1;

		public const int PERF_NUMBER_DECIMAL = 65536;

		public const int PERF_NUMBER_DEC_1000 = 131072;

		public const int PERF_NUMBER_HEX = 0;

		public const int PERF_OBJECT_TIMER = 2097152;

		public const int PERF_RAW_BASE = 1073939459;

		public const int PERF_RAW_FRACTION = 537003008;

		public const int PERF_SAMPLE_BASE = 1073939457;

		public const int PERF_SAMPLE_COUNTER = 4260864;

		public const int PERF_SAMPLE_FRACTION = 549585920;

		public const int PERF_SIZE_DWORD = 0;

		public const int PERF_SIZE_LARGE = 256;

		public const int PERF_SIZE_VARIABLE_LEN = 768;

		public const int PERF_SIZE_ZERO = 512;

		public const int PERF_TEXT_ASCII = 65536;

		public const int PERF_TEXT_UNICODE = 0;

		public const int PERF_TIMER_100NS = 1048576;

		public const int PERF_TIMER_TICK = 0;

		public const int PERF_TYPE_COUNTER = 1024;

		public const int PERF_TYPE_NUMBER = 0;

		public const int PERF_TYPE_TEXT = 2048;

		public const int PERF_TYPE_ZERO = 3072;

		public const int PIPE_ACCESS_DUPLEX = 3;

		public const int PIPE_ACCESS_INBOUND = 1;

		public const int PIPE_ACCESS_OUTBOUND = 2;

		public const int PIPE_CLIENT_END = 0;

		public const int PIPE_NOWAIT = 1;

		public const int PIPE_READMODE_BYTE = 0;

		public const int PIPE_READMODE_MESSAGE = 2;

		public const int PIPE_SERVER_END = 1;

		public const int PIPE_TYPE_BYTE = 0;

		public const int PIPE_TYPE_MESSAGE = 4;

		public const int PIPE_UNLIMITED_INSTANCES = 255;

		public const int PIPE_WAIT = 0;

		public const int PRIVILEGE_SET_ALL_NECESSARY = 1;

		public const int PROCESSOR_ALPHA_21064 = 21064;

		public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;

		public const int PROCESSOR_ARCHITECTURE_INTEL = 0;

		public const int PROCESSOR_ARCHITECTURE_MIPS = 1;

		public const int PROCESSOR_ARCHITECTURE_PPC = 3;

		public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 65535;

		public const int PROCESSOR_INTEL_386 = 386;

		public const int PROCESSOR_INTEL_486 = 486;

		public const int PROCESSOR_INTEL_PENTIUM = 586;

		public const int PROCESSOR_MIPS_R4000 = 4000;

		public const int PROCESS_HEAP_ENTRY_BUSY = 4;

		public const int PROCESS_HEAP_ENTRY_DDESHARE = 32;

		public const int PROCESS_HEAP_ENTRY_MOVEABLE = 16;

		public const int PROCESS_HEAP_REGION = 1;

		public const int PROCESS_HEAP_UNCOMMITTED_RANGE = 2;

		public const int PROFILE_KERNEL = 536870912;

		public const int PROFILE_SERVER = 1073741824;

		public const int PROFILE_USER = 268435456;

		public const int PST_FAX = 33;

		public const int PST_LAT = 257;

		public const int PST_NETWORK_BRIDGE = 256;

		public const int PST_PARALLELPORT = 2;

		public const int PST_RS232 = 1;

		public const int PST_RS422 = 3;

		public const int PST_RS423 = 4;

		public const int PST_RS449 = 5;

		public const int PST_SCANNER = 34;

		public const int PST_TCPIP_TELNET = 258;

		public const int PST_UNSPECIFIED = 0;

		public const int PST_X25 = 259;

		public const int PURGE_RXABORT = 2;

		public const int PURGE_RXCLEAR = 8;

		public const int PURGE_TXABORT = 1;

		public const int PURGE_TXCLEAR = 4;

		public const int READ_CONTROL = 131072;

		public const int REALTIME_PRIORITY_CLASS = 256;

		public const int REG_BINARY = 3;

		public const int REG_CREATED_NEW_KEY = 1;

		public const int REG_DWORD = 4;

		public const int REG_DWORD_BIG_ENDIAN = 5;

		public const int REG_DWORD_LITTLE_ENDIAN = 4;

		public const int REG_EXPAND_SZ = 2;

		public const int REG_FULL_RESOURCE_DESCRIPTOR = 9;

		public const int REG_LEGAL_CHANGE_FILTER = 15;

		public const int REG_LEGAL_OPTION = 7;

		public const int REG_LINK = 6;

		public const int REG_MULTI_SZ = 7;

		public const int REG_NONE = 0;

		public const int REG_NOTIFY_CHANGE_ATTRIBUTES = 2;

		public const int REG_NOTIFY_CHANGE_LAST_SET = 4;

		public const int REG_NOTIFY_CHANGE_NAME = 1;

		public const int REG_NOTIFY_CHANGE_SECURITY = 8;

		public const int REG_OPENED_EXISTING_KEY = 2;

		public const int REG_OPTION_BACKUP_RESTORE = 4;

		public const int REG_OPTION_CREATE_LINK = 2;

		public const int REG_OPTION_NON_VOLATILE = 0;

		public const int REG_OPTION_RESERVED = 0;

		public const int REG_OPTION_VOLATILE = 1;

		public const int REG_REFRESH_HIVE = 2;

		public const int REG_RESOURCE_LIST = 8;

		public const int REG_RESOURCE_REQUIREMENTS_LIST = 10;

		public const int REG_SZ = 1;

		public const int REG_WHOLE_HIVE_VOLATILE = 1;

		public const int RESETDEV = 7;

		public const int RIGHTMOST_BUTTON_PRESSED = 2;

		public const int RIGHT_ALT_PRESSED = 1;

		public const int RIGHT_CTRL_PRESSED = 4;

		public const int RIP_EVENT = 9;

		public const int RTS_CONTROL_DISABLE = 0;

		public const int RTS_CONTROL_ENABLE = 1;

		public const int RTS_CONTROL_HANDSHAKE = 2;

		public const int RTS_CONTROL_TOGGLE = 3;

		public const int RT_ACCELERATOR = 9;

		public const int RT_BITMAP = 2;

		public const int RT_CURSOR = 1;

		public const int RT_DIALOG = 5;

		public const int RT_FONT = 8;

		public const int RT_FONTDIR = 7;

		public const int RT_ICON = 3;

		public const int RT_MENU = 4;

		public const int RT_RCDATA = 10;

		public const int RT_STRING = 6;

		public const int SCROLLLOCK_ON = 64;

		public const int SCS_32BIT_BINARY = 0;

		public const int SCS_DOS_BINARY = 1;

		public const int SCS_OS216_BINARY = 5;

		public const int SCS_PIF_BINARY = 3;

		public const int SCS_POSIX_BINARY = 4;

		public const int SCS_WOW_BINARY = 2;

		public const int SC_MANAGER_ALL_ACCESS = 983103;

		public const int SC_MANAGER_CONNECT = 1;

		public const int SC_MANAGER_CREATE_SERVICE = 2;

		public const int SC_MANAGER_ENUMERATE_SERVICE = 4;

		public const int SC_MANAGER_LOCK = 8;

		public const int SC_MANAGER_MODIFY_BOOT_CONFIG = 32;

		public const int SC_MANAGER_QUERY_LOCK_STATUS = 16;

		public const int SECTION_ALL_ACCESS = 983071;

		public const int SECTION_EXTEND_SIZE = 16;

		public const int SECTION_MAP_EXECUTE = 8;

		public const int SECTION_MAP_READ = 4;

		public const int SECTION_MAP_WRITE = 2;

		public const int SECTION_QUERY = 1;

		public const int SECURITY_ANONYMOUS_LOGON_RID = 7;

		public const int SECURITY_BATCH_RID = 3;

		public const int SECURITY_BUILTIN_DOMAIN_RID = 32;

		public const int SECURITY_CONTEXT_TRACKING = 262144;

		public const int SECURITY_CREATOR_GROUP_RID = 1;

		public const int SECURITY_CREATOR_OWNER_RID = 0;

		public const int SECURITY_DESCRIPTOR_MIN_LENGTH = 20;

		public const int SECURITY_DESCRIPTOR_REVISION = 1;

		public const int SECURITY_DESCRIPTOR_REVISION1 = 1;

		public const int SECURITY_DIALUP_RID = 1;

		public const int SECURITY_EFFECTIVE_ONLY = 524288;

		public const int SECURITY_INTERACTIVE_RID = 4;

		public const int SECURITY_LOCAL_RID = 0;

		public const int SECURITY_LOCAL_SYSTEM_RID = 18;

		public const int SECURITY_LOGON_IDS_RID = 5;

		public const int SECURITY_NETWORK_RID = 2;

		public const int SECURITY_NT_NON_UNIQUE = 21;

		public const int SECURITY_NULL_RID = 0;

		public const int SECURITY_SERVICE_RID = 6;

		public const int SECURITY_SQOS_PRESENT = 1048576;

		public const int SECURITY_VALID_SQOS_FLAGS = 2031616;

		public const int SECURITY_WORLD_RID = 0;

		public const int SEM_FAILCRITICALERRORS = 1;

		public const int SEM_NOGPFAULTERRORBOX = 2;

		public const int SEM_NOOPENFILEERRORBOX = 32768;

		public const int SERVICE_ACCEPT_PAUSE_CONTINUE = 2;

		public const int SERVICE_ACCEPT_SHUTDOWN = 4;

		public const int SERVICE_ACCEPT_STOP = 1;

		public const int SERVICE_ACTIVE = 1;

		public const int SERVICE_ALL_ACCESS = 983551;

		public const int SERVICE_CHANGE_CONFIG = 2;

		public const int SERVICE_CONTINUE_PENDING = 5;

		public const int SERVICE_CONTROL_CONTINUE = 3;

		public const int SERVICE_CONTROL_INTERROGATE = 4;

		public const int SERVICE_CONTROL_PAUSE = 2;

		public const int SERVICE_CONTROL_SHUTDOWN = 5;

		public const int SERVICE_CONTROL_STOP = 1;

		public const int SERVICE_ENUMERATE_DEPENDENTS = 8;

		public const int SERVICE_INACTIVE = 2;

		public const int SERVICE_INTERROGATE = 128;

		public const int SERVICE_NO_CHANGE = 65535;

		public const int SERVICE_PAUSED = 7;

		public const int SERVICE_PAUSE_CONTINUE = 64;

		public const int SERVICE_PAUSE_PENDING = 6;

		public const int SERVICE_QUERY_CONFIG = 1;

		public const int SERVICE_QUERY_STATUS = 4;

		public const int SERVICE_RUNNING = 4;

		public const int SERVICE_START = 16;

		public const int SERVICE_START_PENDING = 2;

		public const int SERVICE_STATE_ALL = 3;

		public const int SERVICE_STOP = 32;

		public const int SERVICE_STOPPED = 1;

		public const int SERVICE_STOP_PENDING = 3;

		public const int SERVICE_USER_DEFINED_CONTROL = 256;

		public const int SETBREAK = 8;

		public const int SETDTR = 5;

		public const int SETRTS = 3;

		public const int SETXOFF = 1;

		public const int SETXON = 2;

		public const int SET_TAPE_DRIVE_INFORMATION = 1;

		public const int SET_TAPE_MEDIA_INFORMATION = 0;

		public const int SE_DACL_DEFAULTED = 8;

		public const int SE_DACL_PRESENT = 4;

		public const int SE_GROUP_DEFAULTED = 2;

		public const int SE_GROUP_ENABLED = 4;

		public const int SE_GROUP_ENABLED_BY_DEFAULT = 2;

		public const int SE_GROUP_LOGON_ID = -1073741824;

		public const int SE_GROUP_MANDATORY = 1;

		public const int SE_GROUP_OWNER = 8;

		public const int SE_OWNER_DEFAULTED = 1;

		public const int SE_PRIVILEGE_ENABLED = 2;

		public const int SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1;

		public const int SE_PRIVILEGE_USED_FOR_ACCESS = -2147483648;

		public const int SE_SACL_DEFAULTED = 32;

		public const int SE_SACL_PRESENT = 16;

		public const int SE_SELF_RELATIVE = 32768;

		public const int SHIFT_PRESSED = 16;

		public const int SHUTDOWN_NORETRY = 1;

		public const int SID_MAX_SUB_AUTHORITIES = 15;

		public const int SID_RECOMMENDED_SUB_AUTHORITIES = 1;

		public const int SID_REVISION = 1;

		public const int SLE_ERROR = 1;

		public const int SLE_MINORERROR = 2;

		public const int SLE_WARNING = 3;

		public const int SORT_CHINESE_BIG5 = 0;

		public const int SORT_CHINESE_UNICODE = 1;

		public const int SORT_DEFAULT = 0;

		public const int SORT_JAPANESE_UNICODE = 1;

		public const int SORT_JAPANESE_XJIS = 0;

		public const int SORT_KOREAN_KSC = 0;

		public const int SORT_KOREAN_UNICODE = 1;

		public const int SORT_STRINGSORT = 4096;

		public const int SPACEPARITY = 4;

		public const int SPECIFIC_RIGHTS_ALL = 65535;

		public const int SP_BAUD = 2;

		public const int SP_DATABITS = 4;

		public const int SP_HANDSHAKING = 16;

		public const int SP_PARITY = 1;

		public const int SP_PARITY_CHECK = 32;

		public const int SP_RLSD = 64;

		public const int SP_SERIALCOMM = 1;

		public const int SP_STOPBITS = 8;

		public const int STANDARD_RIGHTS_ALL = 2031616;

		public const int STANDARD_RIGHTS_EXECUTE = 131072;

		public const int STANDARD_RIGHTS_READ = 131072;

		public const int STANDARD_RIGHTS_REQUIRED = 983040;

		public const int STANDARD_RIGHTS_WRITE = 131072;

		public const int STARTF_FORCEOFFFEEDBACK = 128;

		public const int STARTF_FORCEONFEEDBACK = 64;

		public const int STARTF_RUNFULLSCREEN = 32;

		public const int STARTF_USECOUNTCHARS = 8;

		public const int STARTF_USEFILLATTRIBUTE = 16;

		public const int STARTF_USEPOSITION = 4;

		public const int STARTF_USESHOWWINDOW = 1;

		public const int STARTF_USESIZE = 2;

		public const int STARTF_USESTDHANDLES = 256;

		public const int STD_ERROR_HANDLE = -12;

		public const int STD_INPUT_HANDLE = -10;

		public const int STD_OUTPUT_HANDLE = -11;

		public const int STOPBITS_10 = 1;

		public const int STOPBITS_15 = 2;

		public const int STOPBITS_20 = 4;

		public const int STREAM_CONTAINS_SECURITY = 2;

		public const int STREAM_MODIFIED_WHEN_READ = 1;

		public const int SUBLANG_CHINESE_HONGKONG = 3;

		public const int SUBLANG_CHINESE_SIMPLIFIED = 2;

		public const int SUBLANG_CHINESE_SINGAPORE = 4;

		public const int SUBLANG_CHINESE_TRADITIONAL = 1;

		public const int SUBLANG_DEFAULT = 1;

		public const int SUBLANG_DUTCH = 1;

		public const int SUBLANG_DUTCH_BELGIAN = 2;

		public const int SUBLANG_ENGLISH_AUS = 3;

		public const int SUBLANG_ENGLISH_CAN = 4;

		public const int SUBLANG_ENGLISH_EIRE = 6;

		public const int SUBLANG_ENGLISH_NZ = 5;

		public const int SUBLANG_ENGLISH_UK = 2;

		public const int SUBLANG_ENGLISH_US = 1;

		public const int SUBLANG_FRENCH = 1;

		public const int SUBLANG_FRENCH_BELGIAN = 2;

		public const int SUBLANG_FRENCH_CANADIAN = 3;

		public const int SUBLANG_FRENCH_SWISS = 4;

		public const int SUBLANG_GERMAN = 1;

		public const int SUBLANG_GERMAN_AUSTRIAN = 3;

		public const int SUBLANG_GERMAN_SWISS = 2;

		public const int SUBLANG_ITALIAN = 1;

		public const int SUBLANG_ITALIAN_SWISS = 2;

		public const int SUBLANG_NEUTRAL = 0;

		public const int SUBLANG_NORWEGIAN_BOKMAL = 1;

		public const int SUBLANG_NORWEGIAN_NYNORSK = 2;

		public const int SUBLANG_PORTUGUESE = 2;

		public const int SUBLANG_PORTUGUESE_BRAZILIAN = 1;

		public const int SUBLANG_SPANISH = 1;

		public const int SUBLANG_SPANISH_MEXICAN = 2;

		public const int SUBLANG_SPANISH_MODERN = 3;

		public const int SUBLANG_SYS_DEFAULT = 2;

		public const int SUCCESSFUL_ACCESS_ACE_FLAG = 64;

		public const int SYNCHRONIZE = 1048576;

		public const int SYSTEM_ALARM_ACE_TYPE = 3;

		public const int SYSTEM_AUDIT_ACE_TYPE = 2;

		public const int S_ALLTHRESHOLD = 2;

		public const int S_LEGATO = 1;

		public const int S_NORMAL = 0;

		public const int S_PERIOD1024 = 1;

		public const int S_PERIOD2048 = 2;

		public const int S_PERIOD512 = 0;

		public const int S_PERIODVOICE = 3;

		public const int S_QUEUEEMPTY = 0;

		public const int S_SERBDNT = -5;

		public const int S_SERDCC = -7;

		public const int S_SERDDR = -14;

		public const int S_SERDFQ = -13;

		public const int S_SERDLN = -6;

		public const int S_SERDMD = -10;

		public const int S_SERDPT = -12;

		public const int S_SERDSH = -11;

		public const int S_SERDSR = -15;

		public const int S_SERDST = -16;

		public const int S_SERDTP = -8;

		public const int S_SERDVL = -9;

		public const int S_SERDVNA = -1;

		public const int S_SERMACT = -3;

		public const int S_SEROFM = -2;

		public const int S_SERQFUL = -4;

		public const int S_STACCATO = 2;

		public const int S_THRESHOLD = 1;

		public const int S_WHITE1024 = 5;

		public const int S_WHITE2048 = 6;

		public const int S_WHITE512 = 4;

		public const int S_WHITEVOICE = 7;

		public const int SecurityAnonymous = 1;

		public const int SecurityIdentification = 2;

		public const int SidTypeAlias = 4;

		public const int SidTypeDeletedAccount = 6;

		public const int SidTypeDomain = 3;

		public const int SidTypeGroup = 2;

		public const int SidTypeInvalid = 7;

		public const int SidTypeUnknown = 8;

		public const int SidTypeUser = 1;

		public const int SidTypeWellKnownGroup = 5;

		public const int TC_GP_TRAP = 2;

		public const int TC_HARDERR = 1;

		public const int TC_NORMAL = 0;

		public const int TC_SIGNAL = 3;

		public const int TF_FORCEDRIVE = 128;

		public const int THREAD_BASE_PRIORITY_IDLE = -15;

		public const int THREAD_BASE_PRIORITY_LOWRT = 15;

		public const int THREAD_BASE_PRIORITY_MAX = 2;

		public const int THREAD_BASE_PRIORITY_MIN = -2;

		public const int THREAD_PRIORITY_ABOVE_NORMAL = 1;

		public const int THREAD_PRIORITY_BELOW_NORMAL = -1;

		public const int THREAD_PRIORITY_ERROR_RETURN = 2147483647;

		public const int THREAD_PRIORITY_HIGHEST = 2;

		public const int THREAD_PRIORITY_IDLE = -15;

		public const int THREAD_PRIORITY_LOWEST = -2;

		public const int THREAD_PRIORITY_NORMAL = 0;

		public const int THREAD_PRIORITY_TIME_CRITICAL = 15;

		public const int TIME_FORCE24HOURFORMAT = 8;

		public const int TIME_NOMINUTESORSECONDS = 1;

		public const int TIME_NOSECONDS = 2;

		public const int TIME_NOTIMEMARKER = 4;

		public const int TLS_OUT_OF_INDEXES = 65535;

		public const int TRUNCATE_EXISTING = 5;

		public const int TWOSTOPBITS = 2;

		public const int TokenDefaultDacl = 6;

		public const int TokenGroups = 2;

		public const int TokenImpersonationLevel = 9;

		public const int TokenOwner = 4;

		public const int TokenPrimaryGroup = 5;

		public const int TokenPrivileges = 3;

		public const int TokenSource = 7;

		public const int TokenStatistics = 10;

		public const int TokenType = 8;

		public const int TokenUser = 1;

		public const int UNLOAD_DLL_DEBUG_EVENT = 7;

		public const int VALID_INHERIT_FLAGS = 15;

		public const int VER_PLATFORM_WIN32_NT = 2;

		public const int VER_PLATFORM_WIN32_WINDOWS = 1;

		public const int VER_PLATFORM_WIN32s = 0;

		public const int WC_COMPOSITECHECK = 512;

		public const int WC_DEFAULTCHAR = 64;

		public const int WC_DEFAULTCHECK = 256;

		public const int WC_DISCARDNS = 16;

		public const int WC_SEPCHARS = 32;

		public const int WINDOW_BUFFER_SIZE_EVENT = 4;

		public const int WRITE_DAC = 262144;

		public const int WRITE_OWNER = 524288;

		public const int mouse_eventC = 2;

		public const string SC_GROUP_IDENTIFIER = "+";

		public const string SERVICES_ACTIVE_DATABASE = "ServicesActive";

		public const string SERVICES_FAILED_DATABASE = "ServicesFailed";

		public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

		public const string SE_AUDIT_NAME = "SeAuditPrivilege";

		public const string SE_BACKUP_NAME = "SeBackupPrivilege";

		public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

		public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

		public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

		public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

		public const string SE_DEBUG_NAME = "SeDebugPrivilege";

		public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

		public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

		public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

		public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

		public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

		public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

		public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

		public const string SE_RESTORE_NAME = "SeRestorePrivilege";

		public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

		public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

		public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

		public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

		public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

		public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

		public const string SE_TCB_NAME = "SeTcbPrivilege";

		public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

		[DllImport("kernel32")]
		public static extern void OutputDebugString(string lpszOutputString);

		[DllImport("KERNEL32")]
		public static extern int ConvertDefaultLocale(int Locale);

		[DllImport("KERNEL32")]
		public static extern int EnumDateFormats(int lpDateFmtEnumProc, int Locale, int dwFlags);

		[DllImport("KERNEL32")]
		public static extern int EnumSystemCodePages(int lpCodePageEnumProc, int dwFlags);

		[DllImport("KERNEL32")]
		public static extern int EnumSystemLocales(int lpLocaleEnumProc, int dwFlags);

		[DllImport("KERNEL32")]
		public static extern int EnumTimeFormats(int lpTimeFmtEnumProc, int Locale, int dwFlags);

		[DllImport("KERNEL32")]
		public static extern int GetThreadLocale();

		[DllImport("KERNEL32")]
		public static extern int IsValidLocale(int Locale, int dwFlags);

		[DllImport("KERNEL32")]
		public static extern void ZeroMemory(IntPtr dest, int numBytes);

		[DllImport("kernel32")]
		public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);

		[DllImport("kernel32")]
		public static extern int AllocConsole();

		[DllImport("kernel32")]
		public static extern int BackupRead(IntPtr hFile, byte lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, int bAbort, int bProcessSecurity, IntPtr lpContext);

		[DllImport("kernel32")]
		public static extern int BackupSeek(IntPtr hFile, int dwLowBytesToSeek, int dwHighBytesToSeek, ref int lpdwLowByteSeeked, ref int lpdwHighByteSeeked, ref int lpContext);

		[DllImport("kernel32")]
		public static extern int BackupWrite(IntPtr hFile, byte lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, int bAbort, int bProcessSecurity, ref int lpContext);

		[DllImport("kernel32")]
		public static extern int Beep(int dwFreq, int dwDuration);

		[DllImport("kernel32")]
		public static extern int BeginUpdateResource(string pFileName, int bDeleteExistingResources);

		[DllImport("kernel32")]
		public static extern int BuildCommDCB(string lpDef, ref DCB lpDCB);

		[DllImport("kernel32")]
		public static extern int BuildCommDCBAndTimeouts(string lpDef, ref DCB lpDCB, ref COMMTIMEOUTS lpCommTimeouts);

		[DllImport("kernel32")]
		public static extern int CallNamedPipe(string lpNamedPipeName, IntPtr lpInBuffer, int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize, ref int lpBytesRead, int nTimeOut);

		[DllImport("kernel32")]
		public static extern int ClearCommBreak(int nCid);

		[DllImport("kernel32")]
		public static extern int ClearCommError(IntPtr hFile, ref int lpErrors, ref COMSTAT lpStat);

		[DllImport("kernel32")]
		public static extern int CloseHandle(IntPtr hObject);

		[DllImport("kernel32")]
		public static extern int CommConfigDialog(string lpszName, IntPtr hwnd, ref COMMCONFIG lpCC);

		[DllImport("kernel32")]
		public static extern int CompareFileTime(ref FILETIME lpFileTime1, ref FILETIME lpFileTime2);

		[DllImport("kernel32")]
		public static extern int CompareString(int Locale, int dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);

		[DllImport("kernel32")]
		public static extern int ConnectNamedPipe(IntPtr hNamedPipe, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int ContinueDebugEvent(int dwProcessId, int dwThreadId, int dwContinueStatus);

		[DllImport("kernel32")]
		public static extern int CopyFile(string lpExistingFileName, string lpNewFileName, int bFailIfExists);

		[DllImport("kernel32")]
		public static extern int CreateConsoleScreenBuffer(int dwDesiredAccess, int dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, int dwFlags, IntPtr lpScreenBufferData);

		[DllImport("kernel32")]
		public static extern int CreateDirectory(string lpPathName, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

		[DllImport("kernel32")]
		public static extern int CreateDirectoryEx(string lpTemplateDirectory, string lpNewDirectory, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

		[DllImport("kernel32")]
		public static extern int CreateEvent(ref SECURITY_ATTRIBUTES lpEventAttributes, int bManualReset, int bInitialState, string lpName);

		[DllImport("kernel32")]
		public static extern int CreateFile(string lpFileName, int dwDesiredAccess, int dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

		[DllImport("kernel32")]
		public static extern int CreateFileMapping(IntPtr hFile, ref SECURITY_ATTRIBUTES lpFileMappigAttributes, int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, string lpName);

		[DllImport("kernel32")]
		public static extern int CreateIoCompletionPort(int FileHandle, int ExistingCompletionPort, int CompletionKey, int NumberOfConcurrentThreads);

		[DllImport("kernel32")]
		public static extern int CreateMailslot(string lpName, int nMaxMessageSize, int lReadTimeout, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

		[DllImport("kernel32")]
		public static extern int CreateMutex(ref SECURITY_ATTRIBUTES lpMutexAttributes, int bInitialOwner, string lpName);

		[DllImport("kernel32")]
		public static extern int CreateNamedPipe(string lpName, int dwOpenMode, int dwPipeMode, int nMaxInstances, int nOutBufferSize, int nInBufferSize, int nDefaultTimeOut, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

		[DllImport("kernel32")]
		public static extern int CreatePipe(int phReadPipe, int phWritePipe, ref SECURITY_ATTRIBUTES lpPipeAttributes, int nSize);

		[DllImport("kernel32")]
		public static extern int CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDriectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

		[DllImport("kernel32")]
		public static extern int CreateRemoteThread(IntPtr hProcess, ref SECURITY_ATTRIBUTES lpThreadAttributes, int dwStackSize, ref int lpStartAddress, IntPtr lpParameter, int dwCreationFlags, ref int lpThreadId);

		[DllImport("kernel32")]
		public static extern int CreateSemaphore(ref SECURITY_ATTRIBUTES lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, string lpName);

		[DllImport("kernel32")]
		public static extern int CreateTapePartition(IntPtr hDevice, int dwPartitionMethod, int dwCount, int dwSize);

		[DllImport("kernel32")]
		public static extern int CreateThread(ref SECURITY_ATTRIBUTES lpThreadAttributes, int dwStackSize, ref int lpStartAddress, IntPtr lpParameter, int dwCreationFlags, ref int lpThreadId);

		[DllImport("kernel32")]
		public static extern int DebugActiveProcess(int dwProcessId);

		[DllImport("kernel32")]
		public static extern int DefineDosDevice(int dwFlags, string lpDeviceName, string lpTargetPath);

		[DllImport("kernel32")]
		public static extern int DeleteFile(string lpFileName);

		[DllImport("kernel32")]
		public static extern int DeviceIoControl(IntPtr hDevice, int dwIoControlCode, IntPtr lpInBuffer, int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize, ref int lpBytesReturned, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int DisableThreadLibraryCalls(IntPtr hLibModule);

		[DllImport("kernel32")]
		public static extern int DisconnectNamedPipe(IntPtr hNamedPipe);

		[DllImport("kernel32")]
		public static extern int DosDateTimeToFileTime(int wFatDate, int wFatTime, ref FILETIME lpFileTime);

		[DllImport("kernel32")]
		public static extern int DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle, IntPtr hTargetProcessHandle, ref int lpTargetHandle, int dwDesiredAccess, int bInheritHandle, int dwOptions);

		[DllImport("kernel32")]
		public static extern int EndUpdateResource(IntPtr hUpdate, int fDiscard);

		[DllImport("kernel32")]
		public static extern int EnumCalendarInfo(int lpCalInfoEnumProc, int Locale, int Calendar, int CalType);

		[DllImport("kernel32")]
		public static extern int EnumResourceLanguages(IntPtr hModule, string lpType, string lpName, ref int lpEnumFunc, int lParam);

		[DllImport("kernel32")]
		public static extern int EnumResourceNames(IntPtr hModule, string lpType, ref int lpEnumFunc, int lParam);

		[DllImport("kernel32")]
		public static extern int EnumResourceTypes(IntPtr hModule, ref int lpEnumFunc, int lParam);

		[DllImport("kernel32")]
		public static extern int EraseTape(IntPtr hDevice, int dwEraseType, int bimmediate);

		[DllImport("kernel32")]
		public static extern int EscapeCommFunction(int nCid, int nFunc);

		[DllImport("kernel32")]
		public static extern int ExpandEnvironmentStrings(string lpSrc, string lpDst, int nSize);

		[DllImport("kernel32")]
		public static extern int FileTimeToDosDateTime(ref FILETIME lpFileTime, ref int lpFatDate, ref int lpFatTime);

		[DllImport("kernel32")]
		public static extern int FileTimeToLocalFileTime(ref FILETIME lpFileTime, ref FILETIME lpLocalFileTime);

		[DllImport("kernel32")]
		public static extern int FileTimeToSystemTime(ref FILETIME lpFileTime, ref SYSTEMTIME lpSystemTime);

		[DllImport("kernel32")]
		public static extern int FillConsoleOutputAttribute(IntPtr hConsoleOutput, int wAttribute, int nLength, COORD dwWriteCoord, ref int lpNumberOfAttrsWritten);

		[DllImport("kernel32")]
		public static extern int FillConsoleOutputCharacter(IntPtr hConsoleOutput, byte cCharacter, int nLength, COORD dwWriteCoord, ref int lpNumberOfCharsWritten);

		[DllImport("kernel32")]
		public static extern int FindClose(IntPtr hFindFile);

		[DllImport("kernel32")]
		public static extern int FindCloseChangeNotification(IntPtr hChangeHandle);

		[DllImport("kernel32")]
		public static extern int FindFirstChangeNotification(string lpPathName, int bWatchSubtree, int dwNotifyFilter);

		[DllImport("kernel32")]
		public static extern int FindFirstFile(string lpFileName, WIN32_FIND_DATA lpFindFileData);

		[DllImport("kernel32")]
		public static extern int FindNextChangeNotification(IntPtr hChangeHandle);

		[DllImport("kernel32")]
		public static extern int FindNextFile(IntPtr hFindFile, WIN32_FIND_DATA lpFindFileData);

		[DllImport("kernel32")]
		public static extern int FindResource(IntPtr hInstance, string lpName, string lpType);

		[DllImport("kernel32")]
		public static extern int FindResourceEx(IntPtr hModule, string lpType, string lpName, int wLanguage);

		[DllImport("kernel32")]
		public static extern int FlushConsoleInputBuffer(IntPtr hConsoleInput);

		[DllImport("kernel32")]
		public static extern int FlushFileBuffers(IntPtr hFile);

		[DllImport("kernel32")]
		public static extern int FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, int dwSize);

		[DllImport("kernel32")]
		public static extern int FlushViewOfFile(IntPtr lpBaseAddress, int dwNumberOfBytesToFlush);

		[DllImport("kernel32")]
		public static extern int FoldString(int dwMapFlags, string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);

		[DllImport("kernel32")]
		public static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, string lpBuffer, int nSize, int Arguments);

		[DllImport("kernel32")]
		public static extern int FreeConsole();

		[DllImport("kernel32")]
		public static extern int FreeEnvironmentStrings(string lpsz);

		[DllImport("kernel32")]
		public static extern int FreeLibrary(IntPtr hLibModule);

		[DllImport("kernel32")]
		public static extern int FreeResource(IntPtr hResData);

		[DllImport("kernel32")]
		public static extern int GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);

		[DllImport("kernel32")]
		public static extern int GetACP();

		[DllImport("kernel32")]
		public static extern int GetBinaryType(string lpApplicationName, ref int lpBinaryType);

		[DllImport("kernel32")]
		public static extern int GetCPInfo(int CodePage, ref CPINFO lpCPInfo);

		[DllImport("kernel32")]
		public static extern int GetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, ref int lpdwSize);

		[DllImport("kernel32")]
		public static extern int GetCommMask(IntPtr hFile, ref int lpEvtMask);

		[DllImport("kernel32")]
		public static extern int GetCommModemStatus(IntPtr hFile, ref int lpModemStat);

		[DllImport("kernel32")]
		public static extern int GetCommProperties(IntPtr hFile, ref COMMPROP lpCommProp);

		[DllImport("kernel32")]
		public static extern int GetCommState(int nCid, ref DCB lpDCB);

		[DllImport("kernel32")]
		public static extern int GetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);

		[DllImport("kernel32")]
		public static extern int GetCommandLine();

		[DllImport("kernel32")]
		public static extern int GetCompressedFileSize(string lpFileName, ref int lpFileSizeHigh);

		[DllImport("kernel32")]
		public static extern int GetComputerName(string lpBuffer, int nSize);

		[DllImport("kernel32")]
		public static extern int GetConsoleCP();

		[DllImport("kernel32")]
		public static extern int GetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

		[DllImport("kernel32")]
		public static extern int GetConsoleMode(IntPtr hConsoleHandle, ref int lpMode);

		[DllImport("kernel32")]
		public static extern int GetConsoleOutputCP();

		[DllImport("kernel32")]
		public static extern int GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);

		[DllImport("kernel32")]
		public static extern int GetConsoleTitle(string lpConsoleTitle, int nSize);

		[DllImport("kernel32")]
		public static extern int GetCurrencyFormat(int Locale, int dwFlags, string lpValue, ref CURRENCYFMT lpFormat, string lpCurrencyStr, int cchCurrency);

		[DllImport("kernel32")]
		public static extern int GetCurrentDirectory(int nBufferLength, string lpBuffer);

		[DllImport("kernel32")]
		public static extern int GetCurrentProcess();

		[DllImport("kernel32")]
		public static extern int GetCurrentProcessId();

		[DllImport("kernel32")]
		public static extern int GetCurrentThread();

		[DllImport("kernel32")]
		public static extern int GetCurrentThreadId();

		[DllImport("kernel32")]
		public static extern int GetCurrentTime();

		[DllImport("kernel32")]
		public static extern int GetDateFormat(int Locale, int dwFlags, ref SYSTEMTIME lpDate, string lpFormat, string lpDateStr, int cchDate);

		[DllImport("kernel32")]
		public static extern int GetDefaultCommConfig(string lpszName, ref COMMCONFIG lpCC, ref int lpdwSize);

		[DllImport("kernel32")]
		public static extern int GetDiskFreeSpace(string lpRootPathName, ref int lpSectorsPerCluster, ref int lpBytesPerSector, ref int lpNumberOfFreeClusters, ref int lpTotalNumberOfClusters);

		[DllImport("kernel32")]
		public static extern int GetDriveType(string nDrive);

		[DllImport("kernel32")]
		public static extern int GetEnvironmentVariable(string lpName, string lpBuffer, int nSize);

		[DllImport("kernel32")]
		public static extern int GetExitCodeProcess(IntPtr hProcess, ref int lpExitCode);

		[DllImport("kernel32")]
		public static extern int GetExitCodeThread(IntPtr hThread, ref int lpExitCode);

		[DllImport("kernel32")]
		public static extern int GetFileAttributes(string lpFileName);

		[DllImport("kernel32")]
		public static extern int GetFileInformationByHandle(IntPtr hFile, ref BY_HANDLE_FILE_INFORMATION lpFileInformation);

		[DllImport("kernel32")]
		public static extern int GetFileSize(IntPtr hFile, ref int lpFileSizeHigh);

		[DllImport("kernel32")]
		public static extern int GetFileTime(IntPtr hFile, ref FILETIME lpCreationTime, ref FILETIME lpLastAccessTime, ref FILETIME lpLastWriteTime);

		[DllImport("kernel32")]
		public static extern int GetFileType(IntPtr hFile);

		[DllImport("kernel32")]
		public static extern int GetFullPathName(string lpFileName, int nBufferLength, StringBuilder lpBuffer, string lpFilePart);

		[DllImport("kernel32")]
		public static extern int GetHandleInformation(IntPtr hObject, ref int lpdwFlags);

		[DllImport("kernel32")]
		public static extern int GetLastError();

		[DllImport("kernel32")]
		public static extern int GetLocaleInfo(int Locale, int LCType, string lpLCData, int cchData);

		[DllImport("kernel32")]
		public static extern int GetLogicalDriveStrings(int nBufferLength, StringBuilder lpBuffer);

		[DllImport("kernel32")]
		public static extern int GetLogicalDrives();

		[DllImport("kernel32")]
		public static extern int GetMailslotInfo(IntPtr hMailslot, ref int lpMaxMessageSize, ref int lpNextSize, ref int lpMessageCount, ref int lpReadTimeout);

		[DllImport("kernel32")]
		public static extern int GetModuleFileName(IntPtr hModule, StringBuilder lpFileName, int nSize);

		[DllImport("kernel32")]
		public static extern int GetModuleHandle(string lpModuleName);

		[DllImport("kernel32")]
		public static extern int GetNamedPipeHandleState(IntPtr hNamedPipe, ref int lpState, ref int lpCurInstances, ref int lpMaxCollectionCount, ref int lpCollectDataTimeout, string lpUserName, int nMaxUserNameSize);

		[DllImport("kernel32")]
		public static extern int GetNamedPipeInfo(IntPtr hNamedPipe, ref int lpFlags, ref int lpOutBufferSize, ref int lpInBufferSize, ref int lpMaxInstances);

		[DllImport("kernel32")]
		public static extern int GetNumberFormat(int Locale, int dwFlags, string lpValue, ref NUMBERFMT lpFormat, string lpNumberStr, int cchNumber);

		[DllImport("kernel32")]
		public static extern int GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref int lpNumberOfEvents);

		[DllImport("kernel32")]
		public static extern int GetNumberOfConsoleMouseButtons(int lpNumberOfMouseButtons);

		[DllImport("kernel32")]
		public static extern int GetOEMCP();

		[DllImport("kernel32")]
		public static extern int GetOverlappedResult(IntPtr hFile, ref OVERLAPPED lpOverlapped, ref int lpNumberOfBytesTransferred, int bWait);

		[DllImport("kernel32")]
		public static extern int GetPriorityClass(IntPtr hProcess);

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileSection(string lpAppName, StringBuilder lpReturnedString, int nSize, string lpFileName);

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string lpApplicationName, IntPtr lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

		[DllImport("kernel32")]
		public static extern int GetProcessAffinityMask(IntPtr hProcess, ref int lpProcessAffinityMask, int SystemAffinityMask);

		[DllImport("kernel32")]
		public static extern int GetProcessHeap();

		[DllImport("kernel32")]
		public static extern int GetProcessHeaps(int NumberOfHeaps, int ProcessHeaps);

		[DllImport("kernel32")]
		public static extern int GetProcessShutdownParameters(int lpdwLevel, ref int lpdwFlags);

		[DllImport("kernel32")]
		public static extern int GetProcessTimes(IntPtr hProcess, ref FILETIME lpCreationTime, ref FILETIME lpExitTime, ref FILETIME lpKernelTime, ref FILETIME lpUserTime);

		[DllImport("kernel32")]
		public static extern int GetProcessWorkingSetSize(IntPtr hProcess, ref int lpMinimumWorkingSetSize, ref int lpMaximumWorkingSetSize);

		[DllImport("kernel32")]
		public static extern int GetProfileInt(string lpAppName, string lpKeyName, int nDefault);

		[DllImport("kernel32")]
		public static extern int GetProfileSection(string lpAppName, string lpReturnedString, int nSize);

		[DllImport("kernel32")]
		public static extern int GetProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize);

		[DllImport("kernel32")]
		public static extern int GetQueuedCompletionStatus(int CompletionPort, ref int lpNumberOfBytesTransferred, ref int lpCompletionKey, ref int lpOverlapped, int dwMilliseconds);

		[DllImport("kernel32")]
		public static extern int GetShortPathName(string lpszLongPath, string lpszShortPath, int cchBuffer);

		[DllImport("kernel32")]
		public static extern int GetStdHandle(int nStdHandle);

		[DllImport("kernel32")]
		public static extern int GetStringTypeA(int lcid, int dwInfoType, string lpSrcStr, int cchSrc, ref int lpCharType);

		[DllImport("kernel32")]
		public static extern int GetStringTypeEx(int Locale, int dwInfoType, string lpSrcStr, int cchSrc, short lpCharType);

		[DllImport("kernel32")]
		public static extern int GetStringTypeW(int dwInfoType, string lpSrcStr, int cchSrc, short lpCharType);

		[DllImport("kernel32")]
		public static extern int GetSystemDefaultLCID();

		[DllImport("kernel32")]
		public static extern int GetSystemDirectory(StringBuilder lpBuffer, int nSize);

		[DllImport("kernel32")]
		public static extern int GetSystemPowerStatus(ref SYSTEM_POWER_STATUS lpSystemPowerStatus);

		[DllImport("kernel32")]
		public static extern int GetSystemTimeAdjustment(int lpTimeAdjustment, ref int lpTimeIncrement, ref int lpTimeAdjustmentDisabled);

		[DllImport("kernel32")]
		public static extern int GetTapeParameters(IntPtr hDevice, int dwOperation, ref int lpdwSize, IntPtr lpTapeInformation);

		[DllImport("kernel32")]
		public static extern int GetTapePosition(IntPtr hDevice, int dwPositionType, ref int lpdwPartition, ref int lpdwOffsetLow, ref int lpdwOffsetHigh);

		[DllImport("kernel32")]
		public static extern int GetTapeStatus(IntPtr hDevice);

		[DllImport("kernel32")]
		public static extern int GetTempFileName(string lpszPath, string lpPrefixString, int wUnique, StringBuilder lpTempFileName);

		[DllImport("kernel32")]
		public static extern int GetTempPath(int nBufferLength, StringBuilder lpBuffer);

		[DllImport("kernel32")]
		public static extern int GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

		[DllImport("kernel32")]
		public static extern int GetThreadPriority(IntPtr hThread);

		[DllImport("kernel32")]
		public static extern int GetThreadSelectorEntry(IntPtr hThread, int dwSelector, ref LDT_ENTRY lpSelectorEntry);

		[DllImport("kernel32")]
		public static extern int GetThreadTimes(IntPtr hThread, ref FILETIME lpCreationTime, ref FILETIME lpExitTime, ref FILETIME lpKernelTime, ref FILETIME lpUserTime);

		[DllImport("kernel32")]
		public static extern int GetTickCount();

		[DllImport("kernel32")]
		public static extern int GetTimeFormat(int Locale, int dwFlags, ref SYSTEMTIME lpTime, string lpFormat, string lpTimeStr, int cchTime);

		[DllImport("kernel32")]
		public static extern int GetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

		[DllImport("kernel32")]
		public static extern int GetUserDefaultLCID();

		[DllImport("kernel32")]
		public static extern int GetVersion();

		[DllImport("kernel32")]
		public static extern int GetVersionEx(ref OSVERSIONINFO lpVersionInformation);

		[DllImport("kernel32")]
		public static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);

		[DllImport("kernel32")]
		public static extern int GetWindowsDirectory(StringBuilder lpBuffer, int nSize);

		[DllImport("kernel32")]
		public static extern int GlobalAlloc(int wFlags, int dwBytes);

		[DllImport("kernel32")]
		public static extern int GlobalCompact(int dwMinFree);

		[DllImport("kernel32")]
		public static extern int GlobalFlags(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int GlobalFree(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int GlobalGetAtomName(short nAtom, string lpBuffer, int nSize);

		[DllImport("kernel32")]
		public static extern int GlobalHandle(IntPtr wMem);

		[DllImport("kernel32")]
		public static extern int GlobalLock(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int GlobalReAlloc(IntPtr hMem, int dwBytes, int wFlags);

		[DllImport("kernel32")]
		public static extern int GlobalSize(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int GlobalUnWire(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int GlobalUnlock(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int GlobalWire(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int HeapAlloc(IntPtr hHeap, int dwFlags, int dwBytes);

		[DllImport("kernel32")]
		public static extern int HeapCompact(IntPtr hHeap, int dwFlags);

		[DllImport("kernel32")]
		public static extern int HeapCreate(int flOptions, int dwInitialSize, int dwMaximumSize);

		[DllImport("kernel32")]
		public static extern int HeapDestroy(IntPtr hHeap);

		[DllImport("kernel32")]
		public static extern int HeapFree(IntPtr hHeap, int dwFlags, IntPtr lpMem);

		[DllImport("kernel32")]
		public static extern int HeapLock(IntPtr hHeap);

		[DllImport("kernel32")]
		public static extern int HeapReAlloc(IntPtr hHeap, int dwFlags, IntPtr lpMem, int dwBytes);

		[DllImport("kernel32")]
		public static extern int HeapSize(IntPtr hHeap, int dwFlags, IntPtr lpMem);

		[DllImport("kernel32")]
		public static extern int HeapUnlock(IntPtr hHeap);

		[DllImport("kernel32")]
		public static extern int HeapValidate(IntPtr hHeap, int dwFlags, IntPtr lpMem);

		[DllImport("kernel32")]
		public static extern int InitAtomTable(int nSize);

		[DllImport("kernel32")]
		public static extern int InterlockedDecrement(int lpAddend);

		[DllImport("kernel32")]
		public static extern int InterlockedExchange(int Target, int Value);

		[DllImport("kernel32")]
		public static extern int InterlockedIncrement(int lpAddend);

		[DllImport("kernel32")]
		public static extern int IsBadCodePtr(int lpfn);

		[DllImport("kernel32")]
		public static extern int IsBadHugeReadPtr(IntPtr lp, int ucb);

		[DllImport("kernel32")]
		public static extern int IsBadHugeWritePtr(IntPtr lp, int ucb);

		[DllImport("kernel32")]
		public static extern int IsBadReadPtr(IntPtr lp, int ucb);

		[DllImport("kernel32")]
		public static extern int IsBadStringPtr(string lpsz, int ucchMax);

		[DllImport("kernel32")]
		public static extern int IsBadWritePtr(IntPtr lp, int ucb);

		[DllImport("kernel32")]
		public static extern int IsDBCSLeadByte(byte bTestChar);

		[DllImport("kernel32")]
		public static extern int IsValidCodePage(int CodePage);

		[DllImport("kernel32")]
		public static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, string lpDestStr, int cchDest);

		[DllImport("kernel32")]
		public static extern int LoadLibrary(string lpLibFileName);

		[DllImport("kernel32")]
		public static extern int LoadLibraryEx(string lpLibFileName, IntPtr hFile, int dwFlags);

		[DllImport("kernel32")]
		public static extern int LoadModule(string lpModuleName, IntPtr lpParameterBlock);

		[DllImport("kernel32")]
		public static extern int LoadResource(IntPtr hInstance, IntPtr hResInfo);

		[DllImport("kernel32")]
		public static extern int LocalAlloc(int wFlags, int wBytes);

		[DllImport("kernel32")]
		public static extern int LocalCompact(int uMinFree);

		[DllImport("kernel32")]
		public static extern int LocalFileTimeToFileTime(ref FILETIME lpLocalFileTime, ref FILETIME lpFileTime);

		[DllImport("kernel32")]
		public static extern int LocalFlags(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int LocalFree(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int LocalHandle(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int LocalLock(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int LocalReAlloc(IntPtr hMem, int wBytes, int wFlags);

		[DllImport("kernel32")]
		public static extern int LocalShrink(IntPtr hMem, int cbNewSize);

		[DllImport("kernel32")]
		public static extern int LocalSize(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int LocalUnlock(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern int LockFile(IntPtr hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh);

		[DllImport("kernel32")]
		public static extern int LockFileEx(IntPtr hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int LockResource(IntPtr hResData);

		[DllImport("kernel32")]
		public static extern int MapViewOfFile(IntPtr hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, int dwNumberOfBytesToMap);

		[DllImport("kernel32")]
		public static extern int MapViewOfFileEx(IntPtr hFileMappingObject, int dwDesiredAccess, int dwFileOffsetHigh, int dwFileOffsetLow, int dwNumberOfBytesToMap, IntPtr lpBaseAddress);

		[DllImport("kernel32")]
		public static extern int MoveFile(string lpExistingFileName, string lpNewFileName);

		[DllImport("kernel32")]
		public static extern int MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);

		[DllImport("kernel32")]
		public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

		[DllImport("kernel32")]
		public static extern int MultiByteToWideChar(int CodePage, int dwFlags, string lpMultiByteStr, int cchMultiByte, string lpWideCharStr, int cchWideChar);

		[DllImport("kernel32")]
		public static extern int OpenEvent(int dwDesiredAccess, int bInheritHandle, string lpName);

		[DllImport("kernel32")]
		public static extern int OpenFile(string lpFileName, ref OFSTRUCT lpReOpenBuff, int wStyle);

		[DllImport("kernel32")]
		public static extern int OpenFileMapping(int dwDesiredAccess, int bInheritHandle, string lpName);

		[DllImport("kernel32")]
		public static extern int OpenMutex(int dwDesiredAccess, int bInheritHandle, string lpName);

		[DllImport("kernel32")]
		public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

		[DllImport("kernel32")]
		public static extern int OpenSemaphore(int dwDesiredAccess, int bInheritHandle, string lpName);

		[DllImport("kernel32")]
		public static extern int PeekNamedPipe(IntPtr hNamedPipe, IntPtr lpBuffer, int nBufferSize, ref int lpBytesRead, ref int lpTotalBytesAvail, ref int lpBytesLeftThisMessage);

		[DllImport("kernel32")]
		public static extern int PrepareTape(IntPtr hDevice, int dwOperation, int bimmediate);

		[DllImport("kernel32")]
		public static extern int PulseEvent(IntPtr hEvent);

		[DllImport("kernel32")]
		public static extern int PurgeComm(IntPtr hFile, int dwFlags);

		[DllImport("kernel32")]
		public static extern int QueryDosDevice(string lpDeviceName, string lpTargetPath, int ucchMax);

		[DllImport("kernel32")]
		public static extern int QueryPerformanceCounter(ref LARGE_INTEGER lpPerformanceCount);

		[DllImport("kernel32")]
		public static extern int QueryPerformanceFrequency(ref LARGE_INTEGER lpFrequency);

		[DllImport("kernel32")]
		public static extern int ReadConsole(IntPtr hConsoleInput, IntPtr lpBuffer, int nNumberOfCharsToRead, ref int lpNumberOfCharsRead, IntPtr lpReserved);

		[DllImport("kernel32")]
		public static extern int ReadConsoleOutput(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

		[DllImport("kernel32")]
		public static extern int ReadConsoleOutputAttribute(IntPtr hConsoleOutput, ref int lpAttribute, int nLength, COORD dwReadCoord, ref int lpNumberOfAttrsRead);

		[DllImport("kernel32")]
		public static extern int ReadConsoleOutputCharacter(IntPtr hConsoleOutput, string lpCharacter, int nLength, COORD dwReadCoord, ref int lpNumberOfCharsRead);

		[DllImport("kernel32")]
		public static extern int ReadFile(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int ReadFileEx(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToRead, ref OVERLAPPED lpOverlapped, ref int lpCompletionRoutine);

		[DllImport("kernel32")]
		public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		[DllImport("kernel32")]
		public static extern int ReleaseMutex(IntPtr hMutex);

		[DllImport("kernel32")]
		public static extern int ReleaseSemaphore(IntPtr hSemaphore, int lReleaseCount, ref int lpPreviousCount);

		[DllImport("kernel32")]
		public static extern int RemoveDirectory(string lpPathName);

		[DllImport("kernel32")]
		public static extern int ResetEvent(IntPtr hEvent);

		[DllImport("kernel32")]
		public static extern int ResumeThread(IntPtr hThread);

		[DllImport("kernel32")]
		public static extern int ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);

		[DllImport("kernel32")]
		public static extern int SearchPath(string lpPath, string lpFileName, string lpExtension, int nBufferLength, string lpBuffer, string lpFilePart);

		[DllImport("kernel32")]
		public static extern int SetCommBreak(int nCid);

		[DllImport("kernel32")]
		public static extern int SetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, int dwSize);

		[DllImport("kernel32")]
		public static extern int SetCommMask(IntPtr hFile, int dwEvtMask);

		[DllImport("kernel32")]
		public static extern int SetCommState(IntPtr hCommDev, ref DCB lpDCB);

		[DllImport("kernel32")]
		public static extern int SetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);

		[DllImport("kernel32")]
		public static extern int SetComputerName(string lpComputerName);

		[DllImport("kernel32")]
		public static extern int SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);

		[DllImport("kernel32")]
		public static extern int SetConsoleCP(int wCodePageID);

		[DllImport("kernel32")]
		public static extern int SetConsoleCtrlHandler(int HandlerRoutine, int Add);

		[DllImport("kernel32")]
		public static extern int SetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

		[DllImport("kernel32")]
		public static extern int SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);

		[DllImport("kernel32")]
		public static extern int SetConsoleMode(IntPtr hConsoleHandle, int dwMode);

		[DllImport("kernel32")]
		public static extern int SetConsoleOutputCP(int wCodePageID);

		[DllImport("kernel32")]
		public static extern int SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);

		[DllImport("kernel32")]
		public static extern int SetConsoleTextAttribute(IntPtr hConsoleOutput, int wAttributes);

		[DllImport("kernel32")]
		public static extern int SetConsoleTitle(string lpConsoleTitle);

		[DllImport("kernel32")]
		public static extern int SetConsoleWindowInfo(IntPtr hConsoleOutput, int bAbsolute, ref SMALL_RECT lpConsoleWindow);

		[DllImport("kernel32")]
		public static extern int SetCurrentDirectory(string lpPathName);

		[DllImport("kernel32")]
		public static extern int SetDefaultCommConfig(string lpszName, ref COMMCONFIG lpCC, int dwSize);

		[DllImport("kernel32")]
		public static extern int SetEndOfFile(IntPtr hFile);

		[DllImport("kernel32")]
		public static extern int SetEnvironmentVariable(string lpName, string lpValue);

		[DllImport("kernel32")]
		public static extern int SetErrorMode(int wMode);

		[DllImport("kernel32")]
		public static extern int SetEvent(IntPtr hEvent);

		[DllImport("kernel32")]
		public static extern int SetFileAttributes(string lpFileName, int dwFileAttributes);

		[DllImport("kernel32")]
		public static extern int SetFilePointer(IntPtr hFile, int lDistanceToMove, ref int lpDistanceToMoveHigh, int dwMoveMethod);

		[DllImport("kernel32")]
		public static extern int SetFileTime(IntPtr hFile, ref FILETIME lpCreationTime, ref FILETIME lpLastAccessTime, ref FILETIME lpLastWriteTime);

		[DllImport("kernel32")]
		public static extern int SetHandleCount(int wNumber);

		[DllImport("kernel32")]
		public static extern int SetHandleInformation(IntPtr hObject, int dwMask, int dwFlags);

		[DllImport("kernel32")]
		public static extern int SetLocalTime(ref SYSTEMTIME lpSystemTime);

		[DllImport("kernel32")]
		public static extern int SetLocaleInfo(int Locale, int LCType, string lpLCData);

		[DllImport("kernel32")]
		public static extern int SetMailslotInfo(IntPtr hMailslot, int lReadTimeout);

		[DllImport("kernel32")]
		public static extern int SetNamedPipeHandleState(IntPtr hNamedPipe, ref int lpMode, ref int lpMaxCollectionCount, ref int lpCollectDataTimeout);

		[DllImport("kernel32")]
		public static extern int SetPriorityClass(IntPtr hProcess, int dwPriorityClass);

		[DllImport("kernel32")]
		public static extern int SetProcessShutdownParameters(int dwLevel, int dwFlags);

		[DllImport("kernel32")]
		public static extern int SetProcessWorkingSetSize(IntPtr hProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

		[DllImport("kernel32")]
		public static extern int SetStdHandle(int nStdHandle, int nHandle);

		[DllImport("kernel32")]
		public static extern int SetSystemPowerState(int fSuspend, int fForce);

		[DllImport("kernel32")]
		public static extern int SetSystemTime(ref SYSTEMTIME lpSystemTime);

		[DllImport("kernel32")]
		public static extern int SetTapeParameters(IntPtr hDevice, int dwOperation, IntPtr lpTapeInformation);

		[DllImport("kernel32")]
		public static extern int SetTapePosition(IntPtr hDevice, int dwPositionMethod, int dwPartition, int dwOffsetLow, int dwOffsetHigh, int bimmediate);

		[DllImport("kernel32")]
		public static extern int SetThreadAffinityMask(IntPtr hThread, int dwThreadAffinityMask);

		[DllImport("kernel32")]
		public static extern int SetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

		[DllImport("kernel32")]
		public static extern int SetThreadLocale(int Locale);

		[DllImport("kernel32")]
		public static extern int SetThreadPriority(IntPtr hThread, int nPriority);

		[DllImport("kernel32")]
		public static extern int SetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

		[DllImport("kernel32")]
		public static extern int SetUnhandledExceptionFilter(int lpTopLevelExceptionFilter);

		[DllImport("kernel32")]
		public static extern int SetVolumeLabel(string lpRootPathName, string lpVolumeName);

		[DllImport("kernel32")]
		public static extern int SetupComm(IntPtr hFile, int dwInQueue, int dwOutQueue);

		[DllImport("kernel32")]
		public static extern int SizeofResource(IntPtr hInstance, IntPtr hResInfo);

		[DllImport("kernel32")]
		public static extern int SleepEx(int dwMilliseconds, int bAlertable);

		[DllImport("kernel32")]
		public static extern int SuspendThread(IntPtr hThread);

		[DllImport("kernel32")]
		public static extern int SystemTimeToFileTime(ref SYSTEMTIME lpSystemTime, ref FILETIME lpFileTime);

		[DllImport("kernel32")]
		public static extern int SystemTimeToTzSpecificLocalTime(ref TIME_ZONE_INFORMATION lpTimeZoneInformation, ref SYSTEMTIME lpUniversalTime, ref SYSTEMTIME lpLocalTime);

		[DllImport("kernel32")]
		public static extern int TerminateProcess(IntPtr hProcess, int uExitCode);

		[DllImport("kernel32")]
		public static extern int TerminateThread(IntPtr hThread, int dwExitCode);

		[DllImport("kernel32")]
		public static extern int TlsAlloc();

		[DllImport("kernel32")]
		public static extern int TlsFree(int dwTlsIndex);

		[DllImport("kernel32")]
		public static extern int TlsGetValue(int dwTlsIndex);

		[DllImport("kernel32")]
		public static extern int TlsSetValue(int dwTlsIndex, IntPtr lpTlsValue);

		[DllImport("kernel32")]
		public static extern int TransactNamedPipe(IntPtr hNamedPipe, IntPtr lpInBuffer, int nInBufferSize, IntPtr lpOutBuffer, int nOutBufferSize, ref int lpBytesRead, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int TransmitCommChar(int nCid, byte cChar);

		[DllImport("kernel32")]
		public static extern int UnhandledExceptionFilter(ref EXCEPTION_POINTERS ExceptionInfo);

		[DllImport("kernel32")]
		public static extern int UnlockFile(IntPtr hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh);

		[DllImport("kernel32")]
		public static extern int UnlockFileEx(IntPtr hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int UnmapViewOfFile(IntPtr lpBaseAddress);

		[DllImport("kernel32")]
		public static extern int UpdateResource(IntPtr hUpdate, string lpType, string lpName, int wLanguage, IntPtr lpData, int cbData);

		[DllImport("kernel32")]
		public static extern int VerLanguageName(int wLang, string szLang, int nSize);

		[DllImport("kernel32")]
		public static extern int VirtualAlloc(IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);

		[DllImport("kernel32")]
		public static extern int VirtualFree(IntPtr lpAddress, int dwSize, int dwFreeType);

		[DllImport("kernel32")]
		public static extern int VirtualLock(IntPtr lpAddress, int dwSize);

		[DllImport("kernel32")]
		public static extern int VirtualProtect(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		[DllImport("kernel32")]
		public static extern int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		[DllImport("kernel32")]
		public static extern int VirtualQuery(IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

		[DllImport("kernel32")]
		public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);

		[DllImport("kernel32")]
		public static extern int VirtualUnlock(IntPtr lpAddress, int dwSize);

		[DllImport("kernel32")]
		public static extern int WaitCommEvent(IntPtr hFile, ref int lpEvtMask, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int WaitForMultipleObjects(int nCount, ref int lpHandles, int bWaitAll, int dwMilliseconds);

		[DllImport("kernel32")]
		public static extern int WaitForMultipleObjectsEx(int nCount, ref int lpHandles, int bWaitAll, int dwMilliseconds, int bAlertable);

		[DllImport("kernel32")]
		public static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);

		[DllImport("kernel32")]
		public static extern int WaitForSingleObjectEx(IntPtr hHandle, int dwMilliseconds, int bAlertable);

		[DllImport("kernel32")]
		public static extern int WaitNamedPipe(string lpNamedPipeName, int nTimeOut);

		[DllImport("kernel32")]
		public static extern int WideCharToMultiByte(int CodePage, int dwFlags, string lpWideCharStr, int cchWideChar, string lpMultiByteStr, int cchMultiByte, string lpDefaultChar, ref int lpUsedDefaultChar);

		[DllImport("kernel32")]
		public static extern int WinExec(string lpCmdLine, int nCmdShow);

		[DllImport("kernel32")]
		public static extern int WriteConsole(IntPtr hConsoleOutput, IntPtr lpBuffer, int nNumberOfCharsToWrite, ref int lpNumberOfCharsWritten, IntPtr lpReserved);

		[DllImport("kernel32")]
		public static extern int WriteConsoleOutput(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

		[DllImport("kernel32")]
		public static extern int WriteConsoleOutputAttribute(IntPtr hConsoleOutput, short lpAttribute, int nLength, COORD dwWriteCoord, ref int lpNumberOfAttrsWritten);

		[DllImport("kernel32")]
		public static extern int WriteConsoleOutputCharacter(IntPtr hConsoleOutput, string lpCharacter, int nLength, COORD dwWriteCoord, ref int lpNumberOfCharsWritten);

		[DllImport("kernel32")]
		public static extern int WriteFile(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);

		[DllImport("kernel32")]
		public static extern int WriteFileEx(IntPtr hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite, ref OVERLAPPED lpOverlapped, ref int lpCompletionRoutine);

		[DllImport("kernel32")]
		public static extern int WritePrivateProfileSection(string lpAppName, string lpString, string lpFileName);

		[DllImport("kernel32")]
		public static extern int WritePrivateProfileString(string lpApplicationName, IntPtr lpKeyName, IntPtr lpString, string lpFileName);

		[DllImport("kernel32")]
		public static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, IntPtr lpString, string lpFileName);

		[DllImport("kernel32")]
		public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		[DllImport("kernel32")]
		public static extern int WriteProfileSection(string lpAppName, string lpString);

		[DllImport("kernel32")]
		public static extern int WriteProfileString(string lpszSection, string lpszKeyName, string lpszString);

		[DllImport("kernel32")]
		public static extern int WriteTapemark(IntPtr hDevice, int dwTapemarkType, int dwTapemarkCount, int bimmediate);

		[DllImport("kernel32")]
		public static extern int hread(IntPtr hFile, IntPtr lpBuffer, int lBytes);

		[DllImport("kernel32")]
		public static extern int hwrite(IntPtr hFile, string lpBuffer, int lBytes);

		[DllImport("kernel32")]
		public static extern int lclose(IntPtr hFile);

		[DllImport("kernel32")]
		public static extern int lcreat(string lpPathName, int iAttribute);

		[DllImport("kernel32")]
		public static extern int llseek(IntPtr hFile, int lOffset, int iOrigin);

		[DllImport("kernel32")]
		public static extern int lopen(string lpPathName, int iReadWrite);

		[DllImport("kernel32")]
		public static extern int lread(IntPtr hFile, IntPtr lpBuffer, int wBytes);

		[DllImport("kernel32")]
		public static extern int lstrcat(string lpString1, string lpString2);

		[DllImport("kernel32")]
		public static extern int lstrcmp(string lpString1, string lpString2);

		[DllImport("kernel32")]
		public static extern int lstrcmpi(string lpString1, string lpString2);

		[DllImport("kernel32")]
		public static extern int lstrcpy(string lpString1, string lpString2);

		[DllImport("kernel32")]
		public static extern int lstrcpyn(string lpString1, string lpString2, int iMaxLength);

		[DllImport("kernel32")]
		public static extern int lstrlen(string lpString);

		[DllImport("kernel32")]
		public static extern int lwrite(IntPtr hFile, string lpBuffer, int wBytes);

		[DllImport("kernel32")]
		public static extern short GetSystemDefaultLangID();

		[DllImport("kernel32")]
		public static extern short GetUserDefaultLangID();

		[DllImport("kernel32")]
		public static extern short GlobalAddAtom(string lpString);

		[DllImport("kernel32")]
		public static extern short GlobalDeleteAtom(short nAtom);

		[DllImport("kernel32")]
		public static extern short GlobalFindAtom(string lpString);

		[DllImport("kernel32")]
		public static extern string GetEnvironmentStrings();

		[DllImport("kernel32")]
		public static extern void CopyMemory(IntPtr Destination, IntPtr Source, int Length);

		[DllImport("kernel32")]
		public static extern void DebugBreak();

		[DllImport("kernel32")]
		public static extern void DeleteCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

		[DllImport("kernel32")]
		public static extern void EnterCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

		[DllImport("kernel32")]
		public static extern void ExitProcess(int uExitCode);

		[DllImport("kernel32")]
		public static extern void ExitThread(int dwExitCode);

		[DllImport("kernel32")]
		public static extern void FatalAppExit(int uAction, string lpMessageText);

		[DllImport("kernel32")]
		public static extern void FatalExit(int code);

		[DllImport("kernel32")]
		public static extern void FreeLibraryAndExitThread(IntPtr hLibModule, int dwExitCode);

		[DllImport("kernel32")]
		public static extern void GetLocalTime(ref SYSTEMTIME lpSystemTime);

		[DllImport("kernel32")]
		public static extern void GetStartupInfo(ref STARTUPINFO lpStartupInfo);

		[DllImport("kernel32")]
		public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

		[DllImport("kernel32")]
		public static extern void GetSystemTime(ref SYSTEMTIME lpSystemTime);

		[DllImport("kernel32")]
		public static extern void GlobalFix(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern void GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);

		[DllImport("kernel32")]
		public static extern void GlobalUnfix(IntPtr hMem);

		[DllImport("kernel32")]
		public static extern void InitializeCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

		[DllImport("kernel32")]
		public static extern void LeaveCriticalSection(ref CRITICAL_SECTION lpCriticalSection);

		[DllImport("kernel32")]
		public static extern void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, ref int lpArguments);

		[DllImport("kernel32")]
		public static extern void SetFileApisToANSI();

		[DllImport("kernel32")]
		public static extern void SetFileApisToOEM();

		[DllImport("kernel32")]
		public static extern void SetLastError(int dwErrCode);

		[DllImport("kernel32")]
		public static extern void Sleep(int dwMilliseconds);

		[DllImport("kernel32")]
		public static extern int GetComputerNameW(IntPtr lpBuffer, int nSize);

		[DllImport("kernel32")]
		public static extern int GetProcAddress(IntPtr hModule, string lpProcName);
	}
}
