using System;

namespace Win32
{
	public abstract class ERROR
	{
		public const int CACHE_E_FIRST = -2147221136;

		public const int CACHE_E_LAST = -2147221121;

		public const int CACHE_E_NOCACHE_UPDATED = -2147221136;

		public const int CACHE_S_FIRST = 262512;

		public const int CACHE_S_FORMATETC_NOTSUPPORTED = 262512;

		public const int CACHE_S_LAST = 262527;

		public const int CACHE_S_SAMECACHE = 262513;

		public const int CACHE_S_SOMECACHES_NOTUPDATED = 262514;

		public const int CLASSFACTORY_E_FIRST = -2147221232;

		public const int CLASSFACTORY_E_LAST = -2147221217;

		public const int CLASSFACTORY_S_FIRST = 262416;

		public const int CLASSFACTORY_S_LAST = 262431;

		public const int CLASS_E_CLASSNOTAVAILABLE = -2147221231;

		public const int CLASS_E_NOAGGREGATION = -2147221232;

		public const int CLIENTSITE_E_FIRST = -2147221104;

		public const int CLIENTSITE_E_LAST = -2147221089;

		public const int CLIENTSITE_S_FIRST = 262544;

		public const int CLIENTSITE_S_LAST = 262559;

		public const int CLIPBRD_E_BAD_DATA = -2147221037;

		public const int CLIPBRD_E_CANT_CLOSE = -2147221036;

		public const int CLIPBRD_E_CANT_EMPTY = -2147221039;

		public const int CLIPBRD_E_CANT_OPEN = -2147221040;

		public const int CLIPBRD_E_CANT_SET = -2147221038;

		public const int CLIPBRD_E_FIRST = -2147221040;

		public const int CLIPBRD_E_LAST = -2147221025;

		public const int CLIPBRD_S_FIRST = 262608;

		public const int CLIPBRD_S_LAST = 262623;

		public const int CONVERT10_E_FIRST = -2147221056;

		public const int CONVERT10_E_LAST = -2147221041;

		public const int CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = -2147221053;

		public const int CONVERT10_E_OLESTREAM_FMT = -2147221054;

		public const int CONVERT10_E_OLESTREAM_GET = -2147221056;

		public const int CONVERT10_E_OLESTREAM_PUT = -2147221055;

		public const int CONVERT10_E_STG_DIB_TO_BITMAP = -2147221050;

		public const int CONVERT10_E_STG_FMT = -2147221052;

		public const int CONVERT10_E_STG_NO_STD_STREAM = -2147221051;

		public const int CONVERT10_S_FIRST = 262592;

		public const int CONVERT10_S_LAST = 262607;

		public const int CONVERT10_S_NO_PRESENTATION = 262592;

		public const int CO_E_ALREADYINITIALIZED = -2147221007;

		public const int CO_E_APPDIDNTREG = -2147220994;

		public const int CO_E_APPNOTFOUND = -2147221003;

		public const int CO_E_APPSINGLEUSE = -2147221002;

		public const int CO_E_BAD_PATH = -2146959356;

		public const int CO_E_CANTDETERMINECLASS = -2147221006;

		public const int CO_E_CLASSSTRING = -2147221005;

		public const int CO_E_CLASS_CREATE_FAILED = -2146959359;

		public const int CO_E_DLLNOTFOUND = -2147221000;

		public const int CO_E_ERRORINAPP = -2147221001;

		public const int CO_E_ERRORINDLL = -2147220999;

		public const int CO_E_FIRST = -2147221008;

		public const int CO_E_IIDSTRING = -2147221004;

		public const int CO_E_INIT_CLASS_CACHE = -2147467255;

		public const int CO_E_INIT_MEMORY_ALLOCATOR = -2147467256;

		public const int CO_E_INIT_ONLY_SINGLE_THREADED = -2147467246;

		public const int CO_E_INIT_RPC_CHANNEL = -2147467254;

		public const int CO_E_INIT_SCM_EXEC_FAILURE = -2147467247;

		public const int CO_E_INIT_SCM_FILE_MAPPING_EXISTS = -2147467249;

		public const int CO_E_INIT_SCM_MAP_VIEW_OF_FILE = -2147467248;

		public const int CO_E_INIT_SCM_MUTEX_EXISTS = -2147467250;

		public const int CO_E_INIT_SHARED_ALLOCATOR = -2147467257;

		public const int CO_E_INIT_TLS = -2147467258;

		public const int CO_E_INIT_TLS_CHANNEL_CONTROL = -2147467252;

		public const int CO_E_INIT_TLS_SET_CHANNEL_CONTROL = -2147467253;

		public const int CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = -2147467251;

		public const int CO_E_LAST = -2147220993;

		public const int CO_E_NOTINITIALIZED = -2147221008;

		public const int CO_E_OBJISREG = -2147220996;

		public const int CO_E_OBJNOTCONNECTED = -2147220995;

		public const int CO_E_OBJNOTREG = -2147220997;

		public const int CO_E_OBJSRV_RPC_FAILURE = -2146959354;

		public const int CO_E_RELEASED = -2147220993;

		public const int CO_E_SCM_ERROR = -2146959358;

		public const int CO_E_SCM_RPC_FAILURE = -2146959357;

		public const int CO_E_SERVER_EXEC_FAILURE = -2146959355;

		public const int CO_E_SERVER_STOPPING = -2146959352;

		public const int CO_E_WRONGOSFORAPP = -2147220998;

		public const int CO_S_FIRST = 262640;

		public const int CO_S_LAST = 262655;

		public const int DATA_E_FIRST = -2147221200;

		public const int DATA_E_LAST = -2147221185;

		public const int DATA_S_FIRST = 262448;

		public const int DATA_S_LAST = 262463;

		public const int DATA_S_SAMEFORMATETC = 262448;

		public const int DISP_E_ARRAYISLOCKED = -2147352563;

		public const int DISP_E_BADCALLEE = -2147352560;

		public const int DISP_E_BADINDEX = -2147352565;

		public const int DISP_E_BADPARAMCOUNT = -2147352562;

		public const int DISP_E_BADVARTYPE = -2147352568;

		public const int DISP_E_EXCEPTION = -2147352567;

		public const int DISP_E_MEMBERNOTFOUND = -2147352573;

		public const int DISP_E_NONAMEDARGS = -2147352569;

		public const int DISP_E_NOTACOLLECTION = -2147352559;

		public const int DISP_E_OVERFLOW = -2147352566;

		public const int DISP_E_PARAMNOTFOUND = -2147352572;

		public const int DISP_E_PARAMNOTOPTIONAL = -2147352561;

		public const int DISP_E_TYPEMISMATCH = -2147352571;

		public const int DISP_E_UNKNOWNINTERFACE = -2147352575;

		public const int DISP_E_UNKNOWNLCID = -2147352564;

		public const int DISP_E_UNKNOWNNAME = -2147352570;

		public const int DRAGDROP_E_ALREADYREGISTERED = -2147221247;

		public const int DRAGDROP_E_FIRST = -2147221248;

		public const int DRAGDROP_E_INVALIDHWND = -2147221246;

		public const int DRAGDROP_E_LAST = -2147221233;

		public const int DRAGDROP_E_NOTREGISTERED = -2147221248;

		public const int DRAGDROP_S_CANCEL = 262401;

		public const int DRAGDROP_S_DROP = 262400;

		public const int DRAGDROP_S_FIRST = 262400;

		public const int DRAGDROP_S_LAST = 262415;

		public const int DRAGDROP_S_USEDEFAULTCURSORS = 262402;

		public const int DV_E_CLIPFORMAT = -2147221398;

		public const int DV_E_DVASPECT = -2147221397;

		public const int DV_E_DVTARGETDEVICE = -2147221403;

		public const int DV_E_DVTARGETDEVICE_SIZE = -2147221396;

		public const int DV_E_FORMATETC = -2147221404;

		public const int DV_E_LINDEX = -2147221400;

		public const int DV_E_NOIVIEWOBJECT = -2147221395;

		public const int DV_E_STATDATA = -2147221401;

		public const int DV_E_STGMEDIUM = -2147221402;

		public const int DV_E_TYMED = -2147221399;

		public const int ENUM_E_FIRST = -2147221072;

		public const int ENUM_E_LAST = -2147221057;

		public const int ENUM_S_FIRST = 262576;

		public const int ENUM_S_LAST = 262591;

		public const int EPT_S_CANT_CREATE = 1899;

		public const int EPT_S_CANT_PERFORM_OP = 1752;

		public const int EPT_S_INVALID_ENTRY = 1751;

		public const int EPT_S_NOT_REGISTERED = 1753;

		public const int ERROR_ACCESS_DENIED = 5;

		public const int ERROR_ACCOUNT_DISABLED = 1331;

		public const int ERROR_ACCOUNT_EXPIRED = 1793;

		public const int ERROR_ACCOUNT_RESTRICTION = 1327;

		public const int ERROR_ADAP_HDW_ERR = 57;

		public const int ERROR_ALIAS_EXISTS = 1379;

		public const int ERROR_ALLOTTED_SPACE_EXCEEDED = 1344;

		public const int ERROR_ALREADY_ASSIGNED = 85;

		public const int ERROR_ALREADY_EXISTS = 183;

		public const int ERROR_ALREADY_RUNNING_LKG = 1074;

		public const int ERROR_ALREADY_WAITING = 1904;

		public const int ERROR_ARENA_TRASHED = 7;

		public const int ERROR_ARITHMETIC_OVERFLOW = 534;

		public const int ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;

		public const int ERROR_AUTODATASEG_EXCEEDS_64k = 199;

		public const int ERROR_BADDB = 1009;

		public const int ERROR_BADKEY = 1010;

		public const int ERROR_BAD_ARGUMENTS = 160;

		public const int ERROR_BAD_COMMAND = 22;

		public const int ERROR_BAD_DESCRIPTOR_FORMAT = 1361;

		public const int ERROR_BAD_DEVICE = 1200;

		public const int ERROR_BAD_DEV_TYPE = 66;

		public const int ERROR_BAD_DRIVER = 2001;

		public const int ERROR_BAD_DRIVER_LEVEL = 119;

		public const int ERROR_BAD_ENVIRONMENT = 10;

		public const int ERROR_BAD_EXE_FORMAT = 193;

		public const int ERROR_BAD_FORMAT = 11;

		public const int ERROR_BAD_IMPERSONATION_LEVEL = 1346;

		public const int ERROR_BAD_INHERITANCE_ACL = 1340;

		public const int ERROR_BAD_LENGTH = 24;

		public const int ERROR_BAD_LOGON_SESSION_STATE = 1365;

		public const int ERROR_BAD_NETPATH = 53;

		public const int ERROR_BAD_NET_NAME = 67;

		public const int ERROR_BAD_NET_RESP = 58;

		public const int ERROR_BAD_PATHNAME = 161;

		public const int ERROR_BAD_PIPE = 230;

		public const int ERROR_BAD_PROFILE = 1206;

		public const int ERROR_BAD_PROVIDER = 1204;

		public const int ERROR_BAD_REM_ADAP = 60;

		public const int ERROR_BAD_THREADID_ADDR = 159;

		public const int ERROR_BAD_TOKEN_TYPE = 1349;

		public const int ERROR_BAD_UNIT = 20;

		public const int ERROR_BAD_USERNAME = 2202;

		public const int ERROR_BAD_VALIDATION_CLASS = 1348;

		public const int ERROR_BEGINNING_OF_MEDIA = 1102;

		public const int ERROR_BOOT_ALREADY_ACCEPTED = 1076;

		public const int ERROR_BROKEN_PIPE = 109;

		public const int ERROR_BUFFER_OVERFLOW = 111;

		public const int ERROR_BUSY = 170;

		public const int ERROR_BUSY_DRIVE = 142;

		public const int ERROR_BUS_RESET = 1111;

		public const int ERROR_CALL_NOT_IMPLEMENTED = 120;

		public const int ERROR_CANCEL_VIOLATION = 173;

		public const int ERROR_CANNOT_COPY = 266;

		public const int ERROR_CANNOT_FIND_WND_CLASS = 1407;

		public const int ERROR_CANNOT_IMPERSONATE = 1368;

		public const int ERROR_CANNOT_MAKE = 82;

		public const int ERROR_CANNOT_OPEN_PROFILE = 1205;

		public const int ERROR_CANTOPEN = 1011;

		public const int ERROR_CANTREAD = 1012;

		public const int ERROR_CANTWRITE = 1013;

		public const int ERROR_CANT_ACCESS_DOMAIN_INFO = 1351;

		public const int ERROR_CANT_DISABLE_MANDATORY = 1310;

		public const int ERROR_CANT_OPEN_ANONYMOUS = 1347;

		public const int ERROR_CAN_NOT_COMPLETE = 1003;

		public const int ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001;

		public const int ERROR_CHILD_MUST_BE_VOLATILE = 1021;

		public const int ERROR_CHILD_NOT_COMPLETE = 129;

		public const int ERROR_CHILD_WINDOW_MENU = 1436;

		public const int ERROR_CIRCULAR_DEPENDENCY = 1059;

		public const int ERROR_CLASS_ALREADY_EXISTS = 1410;

		public const int ERROR_CLASS_DOES_NOT_EXIST = 1411;

		public const int ERROR_CLASS_HAS_WINDOWS = 1412;

		public const int ERROR_CLIPBOARD_NOT_OPEN = 1418;

		public const int ERROR_CLIPPING_NOT_SUPPORTED = 2005;

		public const int ERROR_CONNECTION_UNAVAIL = 1201;

		public const int ERROR_CONTROL_ID_NOT_FOUND = 1421;

		public const int ERROR_COUNTER_TIMEOUT = 1121;

		public const int ERROR_CRC = 23;

		public const int ERROR_CURRENT_DIRECTORY = 16;

		public const int ERROR_DATABASE_DOES_NOT_EXIST = 1065;

		public const int ERROR_DC_NOT_FOUND = 1425;

		public const int ERROR_DEPENDENT_SERVICES_RUNNING = 1051;

		public const int ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435;

		public const int ERROR_DEVICE_ALREADY_REMEMBERED = 1202;

		public const int ERROR_DEVICE_IN_USE = 2404;

		public const int ERROR_DEVICE_NOT_PARTITIONED = 1107;

		public const int ERROR_DEV_NOT_EXIST = 55;

		public const int ERROR_DIRECTORY = 267;

		public const int ERROR_DIRECT_ACCESS_HANDLE = 130;

		public const int ERROR_DIR_NOT_EMPTY = 145;

		public const int ERROR_DIR_NOT_ROOT = 144;

		public const int ERROR_DISCARDED = 157;

		public const int ERROR_DISK_CHANGE = 107;

		public const int ERROR_DISK_CORRUPT = 1393;

		public const int ERROR_DISK_FULL = 112;

		public const int ERROR_DISK_OPERATION_FAILED = 1127;

		public const int ERROR_DISK_RECALIBRATE_FAILED = 1126;

		public const int ERROR_DISK_RESET_FAILED = 1128;

		public const int ERROR_DLL_INIT_FAILED = 1114;

		public const int ERROR_DOMAIN_EXISTS = 1356;

		public const int ERROR_DOMAIN_LIMIT_EXCEEDED = 1357;

		public const int ERROR_DOMAIN_TRUST_INCONSISTENT = 1810;

		public const int ERROR_DRIVE_LOCKED = 108;

		public const int ERROR_DUPLICATE_SERVICE_NAME = 1078;

		public const int ERROR_DUP_DOMAINNAME = 1221;

		public const int ERROR_DUP_NAME = 52;

		public const int ERROR_DYNLINK_FROM_INVALID_RING = 196;

		public const int ERROR_EAS_DIDNT_FIT = 275;

		public const int ERROR_EAS_NOT_SUPPORTED = 282;

		public const int ERROR_EA_ACCESS_DENIED = 994;

		public const int ERROR_EA_FILE_CORRUPT = 276;

		public const int ERROR_EA_LIST_INCONSISTENT = 255;

		public const int ERROR_EA_TABLE_FULL = 277;

		public const int ERROR_END_OF_MEDIA = 1100;

		public const int ERROR_ENVVAR_NOT_FOUND = 203;

		public const int ERROR_EOM_OVERFLOW = 1129;

		public const int ERROR_EVENTLOG_CANT_START = 1501;

		public const int ERROR_EVENTLOG_FILE_CHANGED = 1503;

		public const int ERROR_EVENTLOG_FILE_CORRUPT = 1500;

		public const int ERROR_EXCEPTION_IN_SERVICE = 1064;

		public const int ERROR_EXCL_SEM_ALREADY_OWNED = 101;

		public const int ERROR_EXE_MARKED_INVALID = 192;

		public const int ERROR_EXTENDED_ERROR = 1208;

		public const int ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063;

		public const int ERROR_FAIL_I24 = 83;

		public const int ERROR_FILEMARK_DETECTED = 1101;

		public const int ERROR_FILENAME_EXCED_RANGE = 206;

		public const int ERROR_FILE_CORRUPT = 1392;

		public const int ERROR_FILE_EXISTS = 80;

		public const int ERROR_FILE_INVALID = 1006;

		public const int ERROR_FILE_NOT_FOUND = 2;

		public const int ERROR_FLOPPY_BAD_REGISTERS = 1125;

		public const int ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122;

		public const int ERROR_FLOPPY_UNKNOWN_ERROR = 1124;

		public const int ERROR_FLOPPY_WRONG_CYLINDER = 1123;

		public const int ERROR_FULLSCREEN_MODE = 1007;

		public const int ERROR_FULL_BACKUP = 4004;

		public const int ERROR_GENERIC_NOT_MAPPED = 1360;

		public const int ERROR_GEN_FAILURE = 31;

		public const int ERROR_GROUP_EXISTS = 1318;

		public const int ERROR_HANDLE_DISK_FULL = 39;

		public const int ERROR_HANDLE_EOF = 38;

		public const int ERROR_HOOK_NEEDS_HMOD = 1428;

		public const int ERROR_HOOK_NOT_INSTALLED = 1431;

		public const int ERROR_HOTKEY_ALREADY_REGISTERED = 1409;

		public const int ERROR_HOTKEY_NOT_REGISTERED = 1419;

		public const int ERROR_HWNDS_HAVE_DIFF_PARENT = 1441;

		public const int ERROR_ILL_FORMED_PASSWORD = 1324;

		public const int ERROR_INC_BACKUP = 4003;

		public const int ERROR_INFLOOP_IN_RELOC_CHAIN = 202;

		public const int ERROR_INSUFFICIENT_BUFFER = 122;

		public const int ERROR_INTERNAL_DB_CORRUPTION = 1358;

		public const int ERROR_INTERNAL_DB_ERROR = 1383;

		public const int ERROR_INTERNAL_ERROR = 1359;

		public const int ERROR_INVALID_ACCEL_HANDLE = 1403;

		public const int ERROR_INVALID_ACCESS = 12;

		public const int ERROR_INVALID_ACCOUNT_NAME = 1315;

		public const int ERROR_INVALID_ACL = 1336;

		public const int ERROR_INVALID_ADDRESS = 487;

		public const int ERROR_INVALID_AT_INTERRUPT_TIME = 104;

		public const int ERROR_INVALID_BLOCK = 9;

		public const int ERROR_INVALID_BLOCK_LENGTH = 1106;

		public const int ERROR_INVALID_CATEGORY = 117;

		public const int ERROR_INVALID_COMBOBOX_MESSAGE = 1422;

		public const int ERROR_INVALID_COMPUTERNAME = 1210;

		public const int ERROR_INVALID_CURSOR_HANDLE = 1402;

		public const int ERROR_INVALID_DATA = 13;

		public const int ERROR_INVALID_DATATYPE = 1804;

		public const int ERROR_INVALID_DOMAINNAME = 1212;

		public const int ERROR_INVALID_DOMAIN_ROLE = 1354;

		public const int ERROR_INVALID_DOMAIN_STATE = 1353;

		public const int ERROR_INVALID_DRIVE = 15;

		public const int ERROR_INVALID_DWP_HANDLE = 1405;

		public const int ERROR_INVALID_EA_HANDLE = 278;

		public const int ERROR_INVALID_EA_NAME = 254;

		public const int ERROR_INVALID_EDIT_HEIGHT = 1424;

		public const int ERROR_INVALID_ENVIRONMENT = 1805;

		public const int ERROR_INVALID_EVENTNAME = 1211;

		public const int ERROR_INVALID_EVENT_COUNT = 151;

		public const int ERROR_INVALID_EXE_SIGNATURE = 191;

		public const int ERROR_INVALID_FILTER_PROC = 1427;

		public const int ERROR_INVALID_FLAGS = 1004;

		public const int ERROR_INVALID_FLAG_NUMBER = 186;

		public const int ERROR_INVALID_FORM_NAME = 1902;

		public const int ERROR_INVALID_FORM_SIZE = 1903;

		public const int ERROR_INVALID_FUNCTION = 1;

		public const int ERROR_INVALID_GROUPNAME = 1209;

		public const int ERROR_INVALID_GROUP_ATTRIBUTES = 1345;

		public const int ERROR_INVALID_GW_COMMAND = 1443;

		public const int ERROR_INVALID_HANDLE = 6;

		public const int ERROR_INVALID_HOOK_FILTER = 1426;

		public const int ERROR_INVALID_HOOK_HANDLE = 1404;

		public const int ERROR_INVALID_ICON_HANDLE = 1414;

		public const int ERROR_INVALID_ID_AUTHORITY = 1343;

		public const int ERROR_INVALID_INDEX = 1413;

		public const int ERROR_INVALID_LB_MESSAGE = 1432;

		public const int ERROR_INVALID_LEVEL = 124;

		public const int ERROR_INVALID_LIST_FORMAT = 153;

		public const int ERROR_INVALID_LOGON_HOURS = 1328;

		public const int ERROR_INVALID_LOGON_TYPE = 1367;

		public const int ERROR_INVALID_MEMBER = 1388;

		public const int ERROR_INVALID_MENU_HANDLE = 1401;

		public const int ERROR_INVALID_MESSAGE = 1002;

		public const int ERROR_INVALID_MESSAGEDEST = 1218;

		public const int ERROR_INVALID_MESSAGENAME = 1217;

		public const int ERROR_INVALID_MINALLOCSIZE = 195;

		public const int ERROR_INVALID_MODULETYPE = 190;

		public const int ERROR_INVALID_MSGBOX_STYLE = 1438;

		public const int ERROR_INVALID_NAME = 123;

		public const int ERROR_INVALID_NETNAME = 1214;

		public const int ERROR_INVALID_ORDINAL = 182;

		public const int ERROR_INVALID_OWNER = 1307;

		public const int ERROR_INVALID_PARAMETER = 87;

		public const int ERROR_INVALID_PASSWORD = 86;

		public const int ERROR_INVALID_PASSWORDNAME = 1216;

		public const int ERROR_INVALID_PIXEL_FORMAT = 2000;

		public const int ERROR_INVALID_PRIMARY_GROUP = 1308;

		public const int ERROR_INVALID_PRINTER_COMMAND = 1803;

		public const int ERROR_INVALID_PRINTER_NAME = 1801;

		public const int ERROR_INVALID_PRINTER_STATE = 1906;

		public const int ERROR_INVALID_PRIORITY = 1800;

		public const int ERROR_INVALID_SCROLLBAR_RANGE = 1448;

		public const int ERROR_INVALID_SECURITY_DESCR = 1338;

		public const int ERROR_INVALID_SEGDPL = 198;

		public const int ERROR_INVALID_SEGMENT_NUMBER = 180;

		public const int ERROR_INVALID_SEPARATOR_FILE = 1799;

		public const int ERROR_INVALID_SERVER_STATE = 1352;

		public const int ERROR_INVALID_SERVICENAME = 1213;

		public const int ERROR_INVALID_SERVICE_ACCOUNT = 1057;

		public const int ERROR_INVALID_SERVICE_CONTROL = 1052;

		public const int ERROR_INVALID_SERVICE_LOCK = 1071;

		public const int ERROR_INVALID_SHARENAME = 1215;

		public const int ERROR_INVALID_SHOWWIN_COMMAND = 1449;

		public const int ERROR_INVALID_SID = 1337;

		public const int ERROR_INVALID_SIGNAL_NUMBER = 209;

		public const int ERROR_INVALID_SPI_VALUE = 1439;

		public const int ERROR_INVALID_STACKSEG = 189;

		public const int ERROR_INVALID_STARTING_CODESEG = 188;

		public const int ERROR_INVALID_SUB_AUTHORITY = 1335;

		public const int ERROR_INVALID_TARGET_HANDLE = 114;

		public const int ERROR_INVALID_THREAD_ID = 1444;

		public const int ERROR_INVALID_TIME = 1901;

		public const int ERROR_INVALID_USER_BUFFER = 1784;

		public const int ERROR_INVALID_VERIFY_SWITCH = 118;

		public const int ERROR_INVALID_WINDOW_HANDLE = 1400;

		public const int ERROR_INVALID_WINDOW_STYLE = 2002;

		public const int ERROR_INVALID_WORKSTATION = 1329;

		public const int ERROR_IOPL_NOT_ENABLED = 197;

		public const int ERROR_IO_DEVICE = 1117;

		public const int ERROR_IO_INCOMPLETE = 996;

		public const int ERROR_IO_PENDING = 997;

		public const int ERROR_IRQ_BUSY = 1119;

		public const int ERROR_IS_JOINED = 134;

		public const int ERROR_IS_JOIN_PATH = 147;

		public const int ERROR_IS_JOIN_TARGET = 133;

		public const int ERROR_IS_SUBSTED = 135;

		public const int ERROR_IS_SUBST_PATH = 146;

		public const int ERROR_IS_SUBST_TARGET = 149;

		public const int ERROR_ITERATED_DATA_EXCEEDS_64k = 194;

		public const int ERROR_JOIN_TO_JOIN = 138;

		public const int ERROR_JOIN_TO_SUBST = 140;

		public const int ERROR_JOURNAL_HOOK_SET = 1430;

		public const int ERROR_KEY_DELETED = 1018;

		public const int ERROR_KEY_HAS_CHILDREN = 1020;

		public const int ERROR_LABEL_TOO_LONG = 154;

		public const int ERROR_LAST_ADMIN = 1322;

		public const int ERROR_LB_WITHOUT_TABSTOPS = 1434;

		public const int ERROR_LISTBOX_ID_NOT_FOUND = 1416;

		public const int ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390;

		public const int ERROR_LOCAL_USER_SESSION_KEY = 1303;

		public const int ERROR_LOCKED = 212;

		public const int ERROR_LOCK_FAILED = 167;

		public const int ERROR_LOCK_VIOLATION = 33;

		public const int ERROR_LOGON_FAILURE = 1326;

		public const int ERROR_LOGON_NOT_GRANTED = 1380;

		public const int ERROR_LOGON_SESSION_COLLISION = 1366;

		public const int ERROR_LOGON_SESSION_EXISTS = 1363;

		public const int ERROR_LOGON_TYPE_NOT_GRANTED = 1385;

		public const int ERROR_LOG_FILE_FULL = 1502;

		public const int ERROR_LUIDS_EXHAUSTED = 1334;

		public const int ERROR_MAPPED_ALIGNMENT = 1132;

		public const int ERROR_MAX_THRDS_REACHED = 164;

		public const int ERROR_MEDIA_CHANGED = 1110;

		public const int ERROR_MEMBERS_PRIMARY_GROUP = 1374;

		public const int ERROR_MEMBER_IN_ALIAS = 1378;

		public const int ERROR_MEMBER_IN_GROUP = 1320;

		public const int ERROR_MEMBER_NOT_IN_ALIAS = 1377;

		public const int ERROR_MEMBER_NOT_IN_GROUP = 1321;

		public const int ERROR_METAFILE_NOT_SUPPORTED = 2003;

		public const int ERROR_META_EXPANSION_TOO_LONG = 208;

		public const int ERROR_MOD_NOT_FOUND = 126;

		public const int ERROR_MORE_DATA = 234;

		public const int ERROR_MORE_WRITES = 1120;

		public const int ERROR_MR_MID_NOT_FOUND = 317;

		public const int ERROR_NEGATIVE_SEEK = 131;

		public const int ERROR_NESTING_NOT_ALLOWED = 215;

		public const int ERROR_NETLOGON_NOT_STARTED = 1792;

		public const int ERROR_NETNAME_DELETED = 64;

		public const int ERROR_NETWORK_ACCESS_DENIED = 65;

		public const int ERROR_NETWORK_BUSY = 54;

		public const int ERROR_NET_WRITE_FAULT = 88;

		public const int ERROR_NOACCESS = 998;

		public const int ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807;

		public const int ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809;

		public const int ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808;

		public const int ERROR_NONE_MAPPED = 1332;

		public const int ERROR_NON_MDICHILD_WINDOW = 1445;

		public const int ERROR_NOTIFY_ENUM_DIR = 1022;

		public const int ERROR_NOT_ALL_ASSIGNED = 1300;

		public const int ERROR_NOT_CHILD_WINDOW = 1442;

		public const int ERROR_NOT_CONNECTED = 2250;

		public const int ERROR_NOT_CONTAINER = 1207;

		public const int ERROR_NOT_DOS_DISK = 26;

		public const int ERROR_NOT_ENOUGH_MEMORY = 8;

		public const int ERROR_NOT_ENOUGH_QUOTA = 1816;

		public const int ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130;

		public const int ERROR_NOT_JOINED = 136;

		public const int ERROR_NOT_LOCKED = 158;

		public const int ERROR_NOT_LOGON_PROCESS = 1362;

		public const int ERROR_NOT_OWNER = 288;

		public const int ERROR_NOT_READY = 21;

		public const int ERROR_NOT_REGISTRY_FILE = 1017;

		public const int ERROR_NOT_SAME_DEVICE = 17;

		public const int ERROR_NOT_SUBSTED = 137;

		public const int ERROR_NOT_SUPPORTED = 50;

		public const int ERROR_NO_BROWSER_SERVERS_FOUND = 6118;

		public const int ERROR_NO_DATA = 232;

		public const int ERROR_NO_DATA_DETECTED = 1104;

		public const int ERROR_NO_IMPERSONATION_TOKEN = 1309;

		public const int ERROR_NO_INHERITANCE = 1391;

		public const int ERROR_NO_LOGON_SERVERS = 1311;

		public const int ERROR_NO_LOG_SPACE = 1019;

		public const int ERROR_NO_MEDIA_IN_DRIVE = 1112;

		public const int ERROR_NO_MORE_FILES = 18;

		public const int ERROR_NO_MORE_ITEMS = 259;

		public const int ERROR_NO_MORE_SEARCH_HANDLES = 113;

		public const int ERROR_NO_NETWORK = 1222;

		public const int ERROR_NO_NET_OR_BAD_PATH = 1203;

		public const int ERROR_NO_PROC_SLOTS = 89;

		public const int ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302;

		public const int ERROR_NO_SCROLLBARS = 1447;

		public const int ERROR_NO_SECURITY_ON_OBJECT = 1350;

		public const int ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116;

		public const int ERROR_NO_SIGNAL_SENT = 205;

		public const int ERROR_NO_SPOOL_SPACE = 62;

		public const int ERROR_NO_SUCH_ALIAS = 1376;

		public const int ERROR_NO_SUCH_DOMAIN = 1355;

		public const int ERROR_NO_SUCH_GROUP = 1319;

		public const int ERROR_NO_SUCH_LOGON_SESSION = 1312;

		public const int ERROR_NO_SUCH_MEMBER = 1387;

		public const int ERROR_NO_SUCH_PACKAGE = 1364;

		public const int ERROR_NO_SUCH_PRIVILEGE = 1313;

		public const int ERROR_NO_SUCH_USER = 1317;

		public const int ERROR_NO_SYSTEM_MENU = 1437;

		public const int ERROR_NO_TOKEN = 1008;

		public const int ERROR_NO_TRUST_LSA_SECRET = 1786;

		public const int ERROR_NO_TRUST_SAM_ACCOUNT = 1787;

		public const int ERROR_NO_UNICODE_TRANSLATION = 1113;

		public const int ERROR_NO_USER_SESSION_KEY = 1394;

		public const int ERROR_NO_VOLUME_LABEL = 125;

		public const int ERROR_NO_WILDCARD_CHARACTERS = 1417;

		public const int ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386;

		public const int ERROR_NULL_LM_PASSWORD = 1304;

		public const int ERROR_OPEN_FAILED = 110;

		public const int ERROR_OPEN_FILES = 2401;

		public const int ERROR_OPERATION_ABORTED = 995;

		public const int ERROR_OUTOFMEMORY = 14;

		public const int ERROR_OUT_OF_PAPER = 28;

		public const int ERROR_OUT_OF_STRUCTURES = 84;

		public const int ERROR_PARTITION_FAILURE = 1105;

		public const int ERROR_PASSWORD_EXPIRED = 1330;

		public const int ERROR_PASSWORD_RESTRICTION = 1325;

		public const int ERROR_PATH_BUSY = 148;

		public const int ERROR_PATH_NOT_FOUND = 3;

		public const int ERROR_PIPE_BUSY = 231;

		public const int ERROR_PIPE_CONNECTED = 535;

		public const int ERROR_PIPE_LISTENING = 536;

		public const int ERROR_PIPE_NOT_CONNECTED = 233;

		public const int ERROR_POPUP_ALREADY_ACTIVE = 1446;

		public const int ERROR_POSSIBLE_DEADLOCK = 1131;

		public const int ERROR_PRINTER_ALREADY_EXISTS = 1802;

		public const int ERROR_PRINTER_DELETED = 1905;

		public const int ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795;

		public const int ERROR_PRINTER_DRIVER_IN_USE = 3001;

		public const int ERROR_PRINTQ_FULL = 61;

		public const int ERROR_PRINT_CANCELLED = 63;

		public const int ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006;

		public const int ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005;

		public const int ERROR_PRIVATE_DIALOG_INDEX = 1415;

		public const int ERROR_PRIVILEGE_NOT_HELD = 1314;

		public const int ERROR_PROCESS_ABORTED = 1067;

		public const int ERROR_PROC_NOT_FOUND = 127;

		public const int ERROR_PUBLIC_ONLY_HOOK = 1429;

		public const int ERROR_READ_FAULT = 30;

		public const int ERROR_REC_NON_EXISTENT = 4005;

		public const int ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794;

		public const int ERROR_REDIR_PAUSED = 72;

		public const int ERROR_REGISTRY_CORRUPT = 1015;

		public const int ERROR_REGISTRY_IO_FAILED = 1016;

		public const int ERROR_REGISTRY_RECOVERED = 1014;

		public const int ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;

		public const int ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220;

		public const int ERROR_REM_NOT_LIST = 51;

		public const int ERROR_REQ_NOT_ACCEP = 71;

		public const int ERROR_RESOURCE_DATA_NOT_FOUND = 1812;

		public const int ERROR_RESOURCE_LANG_NOT_FOUND = 1815;

		public const int ERROR_RESOURCE_NAME_NOT_FOUND = 1814;

		public const int ERROR_RESOURCE_TYPE_NOT_FOUND = 1813;

		public const int ERROR_REVISION_MISMATCH = 1306;

		public const int ERROR_RING2SEG_MUST_BE_MOVABLE = 200;

		public const int ERROR_RING2_STACK_IN_USE = 207;

		public const int ERROR_RPL_NOT_ALLOWED = 4006;

		public const int ERROR_RXACT_COMMIT_FAILURE = 1370;

		public const int ERROR_RXACT_INVALID_STATE = 1369;

		public const int ERROR_SAME_DRIVE = 143;

		public const int ERROR_SCREEN_ALREADY_LOCKED = 1440;

		public const int ERROR_SECRET_TOO_LONG = 1382;

		public const int ERROR_SECTOR_NOT_FOUND = 27;

		public const int ERROR_SEEK = 25;

		public const int ERROR_SEEK_ON_DEVICE = 132;

		public const int ERROR_SEM_IS_SET = 102;

		public const int ERROR_SEM_NOT_FOUND = 187;

		public const int ERROR_SEM_OWNER_DIED = 105;

		public const int ERROR_SEM_TIMEOUT = 121;

		public const int ERROR_SEM_USER_LIMIT = 106;

		public const int ERROR_SERIAL_NO_DEVICE = 1118;

		public const int ERROR_SERVER_DISABLED = 1341;

		public const int ERROR_SERVER_HAS_OPEN_HANDLES = 1811;

		public const int ERROR_SERVER_NOT_DISABLED = 1342;

		public const int ERROR_SERVICE_ALREADY_RUNNING = 1056;

		public const int ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061;

		public const int ERROR_SERVICE_DATABASE_LOCKED = 1055;

		public const int ERROR_SERVICE_DEPENDENCY_DELETED = 1075;

		public const int ERROR_SERVICE_DEPENDENCY_FAIL = 1068;

		public const int ERROR_SERVICE_DISABLED = 1058;

		public const int ERROR_SERVICE_DOES_NOT_EXIST = 1060;

		public const int ERROR_SERVICE_EXISTS = 1073;

		public const int ERROR_SERVICE_LOGON_FAILED = 1069;

		public const int ERROR_SERVICE_MARKED_FOR_DELETE = 1072;

		public const int ERROR_SERVICE_NEVER_STARTED = 1077;

		public const int ERROR_SERVICE_NOT_ACTIVE = 1062;

		public const int ERROR_SERVICE_NO_THREAD = 1054;

		public const int ERROR_SERVICE_REQUEST_TIMEOUT = 1053;

		public const int ERROR_SERVICE_SPECIFIC_ERROR = 1066;

		public const int ERROR_SERVICE_START_HANG = 1070;

		public const int ERROR_SESSION_CREDENTIAL_CONFLICT = 1219;

		public const int ERROR_SETCOUNT_ON_BAD_LB = 1433;

		public const int ERROR_SETMARK_DETECTED = 1103;

		public const int ERROR_SHARING_BUFFER_EXCEEDED = 36;

		public const int ERROR_SHARING_PAUSED = 70;

		public const int ERROR_SHARING_VIOLATION = 32;

		public const int ERROR_SHUTDOWN_IN_PROGRESS = 1115;

		public const int ERROR_SIGNAL_PENDING = 162;

		public const int ERROR_SIGNAL_REFUSED = 156;

		public const int ERROR_SOME_NOT_MAPPED = 1301;

		public const int ERROR_SPECIAL_ACCOUNT = 1371;

		public const int ERROR_SPECIAL_GROUP = 1372;

		public const int ERROR_SPECIAL_USER = 1373;

		public const int ERROR_SPL_NO_ADDJOB = 3004;

		public const int ERROR_SPL_NO_STARTDOC = 3003;

		public const int ERROR_SPOOL_FILE_NOT_FOUND = 3002;

		public const int ERROR_STACK_OVERFLOW = 1001;

		public const int ERROR_STATIC_INIT = 4002;

		public const int ERROR_SUBST_TO_JOIN = 141;

		public const int ERROR_SUBST_TO_SUBST = 139;

		public const int ERROR_SUCCESS = 0;

		public const int ERROR_SWAPERROR = 999;

		public const int ERROR_SYSTEM_TRACE = 150;

		public const int ERROR_THREAD_1_INACTIVE = 210;

		public const int ERROR_TLW_WITH_WSCHILD = 1406;

		public const int ERROR_TOKEN_ALREADY_IN_USE = 1375;

		public const int ERROR_TOO_MANY_CMDS = 56;

		public const int ERROR_TOO_MANY_CONTEXT_IDS = 1384;

		public const int ERROR_TOO_MANY_LUIDS_REQUESTED = 1333;

		public const int ERROR_TOO_MANY_MODULES = 214;

		public const int ERROR_TOO_MANY_MUXWAITERS = 152;

		public const int ERROR_TOO_MANY_NAMES = 68;

		public const int ERROR_TOO_MANY_OPEN_FILES = 4;

		public const int ERROR_TOO_MANY_POSTS = 298;

		public const int ERROR_TOO_MANY_SECRETS = 1381;

		public const int ERROR_TOO_MANY_SEMAPHORES = 100;

		public const int ERROR_TOO_MANY_SEM_REQUESTS = 103;

		public const int ERROR_TOO_MANY_SESS = 69;

		public const int ERROR_TOO_MANY_SIDS = 1389;

		public const int ERROR_TOO_MANY_TCBS = 155;

		public const int ERROR_TRANSFORM_NOT_SUPPORTED = 2004;

		public const int ERROR_TRUSTED_DOMAIN_FAILURE = 1788;

		public const int ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789;

		public const int ERROR_TRUST_FAILURE = 1790;

		public const int ERROR_UNABLE_TO_LOCK_MEDIA = 1108;

		public const int ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109;

		public const int ERROR_UNEXP_NET_ERR = 59;

		public const int ERROR_UNKNOWN_PORT = 1796;

		public const int ERROR_UNKNOWN_PRINTER_DRIVER = 1797;

		public const int ERROR_UNKNOWN_PRINTPROCESSOR = 1798;

		public const int ERROR_UNKNOWN_PRINT_MONITOR = 3000;

		public const int ERROR_UNKNOWN_REVISION = 1305;

		public const int ERROR_UNRECOGNIZED_MEDIA = 1785;

		public const int ERROR_UNRECOGNIZED_VOLUME = 1005;

		public const int ERROR_USER_EXISTS = 1316;

		public const int ERROR_VC_DISCONNECTED = 240;

		public const int ERROR_WAIT_NO_CHILDREN = 128;

		public const int ERROR_WINDOW_NOT_COMBOBOX = 1423;

		public const int ERROR_WINDOW_NOT_DIALOG = 1420;

		public const int ERROR_WINDOW_OF_OTHER_THREAD = 1408;

		public const int ERROR_WINS_INTERNAL = 4000;

		public const int ERROR_WRITE_FAULT = 29;

		public const int ERROR_WRITE_PROTECT = 19;

		public const int ERROR_WRONG_DISK = 34;

		public const int ERROR_WRONG_PASSWORD = 1323;

		public const int E_ABORT = -2147467260;

		public const int E_ACCESSDENIED = -2147024891;

		public const int E_FAIL = -2147467259;

		public const int E_HANDLE = -2147024890;

		public const int E_INVALIDARG = -2147024809;

		public const int E_NOINTERFACE = -2147467262;

		public const int E_NOTIMPL = -2147467263;

		public const int E_OUTOFMEMORY = -2147024882;

		public const int E_POINTER = -2147467261;

		public const int E_UNEXPECTED = -2147418113;

		public const int FACILITY_NT_BIT = 268435456;

		public const int INPLACE_E_FIRST = -2147221088;

		public const int INPLACE_E_LAST = -2147221073;

		public const int INPLACE_E_NOTOOLSPACE = -2147221087;

		public const int INPLACE_E_NOTUNDOABLE = -2147221088;

		public const int INPLACE_S_FIRST = 262560;

		public const int INPLACE_S_LAST = 262575;

		public const int INPLACE_S_TRUNCATED = 262560;

		public const int MARSHAL_E_FIRST = -2147221216;

		public const int MARSHAL_E_LAST = -2147221201;

		public const int MARSHAL_S_FIRST = 262432;

		public const int MARSHAL_S_LAST = 262447;

		public const int MEM_E_INVALID_LINK = -2146959344;

		public const int MEM_E_INVALID_ROOT = -2146959351;

		public const int MEM_E_INVALID_SIZE = -2146959343;

		public const int MK_E_CANTOPENFILE = -2147221014;

		public const int MK_E_CONNECTMANUALLY = -2147221024;

		public const int MK_E_ENUMERATION_FAILED = -2147221009;

		public const int MK_E_EXCEEDEDDEADLINE = -2147221023;

		public const int MK_E_FIRST = -2147221024;

		public const int MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = -2147221017;

		public const int MK_E_INVALIDEXTENSION = -2147221018;

		public const int MK_E_LAST = -2147221009;

		public const int MK_E_MUSTBOTHERUSER = -2147221013;

		public const int MK_E_NEEDGENERIC = -2147221022;

		public const int MK_E_NOINVERSE = -2147221012;

		public const int MK_E_NOOBJECT = -2147221019;

		public const int MK_E_NOPREFIX = -2147221010;

		public const int MK_E_NOSTORAGE = -2147221011;

		public const int MK_E_NOTBINDABLE = -2147221016;

		public const int MK_E_NOTBOUND = -2147221015;

		public const int MK_E_NO_NORMALIZED = -2146959353;

		public const int MK_E_SYNTAX = -2147221020;

		public const int MK_E_UNAVAILABLE = -2147221021;

		public const int MK_S_FIRST = 262624;

		public const int MK_S_HIM = 262629;

		public const int MK_S_LAST = 262639;

		public const int MK_S_ME = 262628;

		public const int MK_S_MONIKERALREADYREGISTERED = 262631;

		public const int MK_S_REDUCED_TO_SELF = 262626;

		public const int MK_S_US = 262630;

		public const int NOERROR = 0;

		public const int NO_ERROR = 0;

		public const int OLEOBJ_E_FIRST = -2147221120;

		public const int OLEOBJ_E_INVALIDVERB = -2147221119;

		public const int OLEOBJ_E_LAST = -2147221105;

		public const int OLEOBJ_E_NOVERBS = -2147221120;

		public const int OLEOBJ_S_CANNOT_DOVERB_NOW = 262529;

		public const int OLEOBJ_S_FIRST = 262528;

		public const int OLEOBJ_S_INVALIDHWND = 262530;

		public const int OLEOBJ_S_INVALIDVERB = 262528;

		public const int OLEOBJ_S_LAST = 262543;

		public const int OLE_E_ADVF = -2147221503;

		public const int OLE_E_ADVISENOTSUPPORTED = -2147221501;

		public const int OLE_E_BLANK = -2147221497;

		public const int OLE_E_CANTCONVERT = -2147221487;

		public const int OLE_E_CANT_BINDTOSOURCE = -2147221494;

		public const int OLE_E_CANT_GETMONIKER = -2147221495;

		public const int OLE_E_CLASSDIFF = -2147221496;

		public const int OLE_E_ENUM_NOMORE = -2147221502;

		public const int OLE_E_FIRST = -2147221504;

		public const int OLE_E_INVALIDHWND = -2147221489;

		public const int OLE_E_INVALIDRECT = -2147221491;

		public const int OLE_E_LAST = -2147221249;

		public const int OLE_E_NOCACHE = -2147221498;

		public const int OLE_E_NOCONNECTION = -2147221500;

		public const int OLE_E_NOSTORAGE = -2147221486;

		public const int OLE_E_NOTRUNNING = -2147221499;

		public const int OLE_E_NOT_INPLACEACTIVE = -2147221488;

		public const int OLE_E_OLEVERB = -2147221504;

		public const int OLE_E_PROMPTSAVECANCELLED = -2147221492;

		public const int OLE_E_STATIC = -2147221493;

		public const int OLE_E_WRONGCOMPOBJ = -2147221490;

		public const int OLE_S_FIRST = 262144;

		public const int OLE_S_LAST = 262399;

		public const int OLE_S_MAC_CLIPFORMAT = 262146;

		public const int OLE_S_STATIC = 262145;

		public const int OLE_S_USEREG = 262144;

		public const int REGDB_E_CLASSNOTREG = -2147221164;

		public const int REGDB_E_FIRST = -2147221168;

		public const int REGDB_E_IIDNOTREG = -2147221163;

		public const int REGDB_E_INVALIDVALUE = -2147221165;

		public const int REGDB_E_KEYMISSING = -2147221166;

		public const int REGDB_E_LAST = -2147221153;

		public const int REGDB_E_READREGDB = -2147221168;

		public const int REGDB_E_WRITEREGDB = -2147221167;

		public const int REGDB_S_FIRST = 262480;

		public const int REGDB_S_LAST = 262495;

		public const int RPC_E_ATTEMPTED_MULTITHREAD = -2147417854;

		public const int RPC_E_CALL_CANCELED = -2147418110;

		public const int RPC_E_CALL_REJECTED = -2147418111;

		public const int RPC_E_CANTCALLOUT_AGAIN = -2147418095;

		public const int RPC_E_CANTCALLOUT_INASYNCCALL = -2147418108;

		public const int RPC_E_CANTCALLOUT_INEXTERNALCALL = -2147418107;

		public const int RPC_E_CANTCALLOUT_ININPUTSYNCCALL = -2147417843;

		public const int RPC_E_CANTPOST_INSENDCALL = -2147418109;

		public const int RPC_E_CANTTRANSMIT_CALL = -2147418102;

		public const int RPC_E_CHANGED_MODE = -2147417850;

		public const int RPC_E_CLIENT_CANTMARSHAL_DATA = -2147418101;

		public const int RPC_E_CLIENT_CANTUNMARSHAL_DATA = -2147418100;

		public const int RPC_E_CLIENT_DIED = -2147418104;

		public const int RPC_E_CONNECTION_TERMINATED = -2147418106;

		public const int RPC_E_DISCONNECTED = -2147417848;

		public const int RPC_E_FAULT = -2147417852;

		public const int RPC_E_INVALIDMETHOD = -2147417849;

		public const int RPC_E_INVALID_CALLDATA = -2147417844;

		public const int RPC_E_INVALID_DATA = -2147418097;

		public const int RPC_E_INVALID_DATAPACKET = -2147418103;

		public const int RPC_E_INVALID_PARAMETER = -2147418096;

		public const int RPC_E_NOT_REGISTERED = -2147417853;

		public const int RPC_E_OUT_OF_RESOURCES = -2147417855;

		public const int RPC_E_RETRY = -2147417847;

		public const int RPC_E_SERVERCALL_REJECTED = -2147417845;

		public const int RPC_E_SERVERCALL_RETRYLATER = -2147417846;

		public const int RPC_E_SERVERFAULT = -2147417851;

		public const int RPC_E_SERVER_CANTMARSHAL_DATA = -2147418099;

		public const int RPC_E_SERVER_CANTUNMARSHAL_DATA = -2147418098;

		public const int RPC_E_SERVER_DIED = -2147418105;

		public const int RPC_E_SERVER_DIED_DNE = -2147418094;

		public const int RPC_E_SYS_CALL_FAILED = -2147417856;

		public const int RPC_E_THREAD_NOT_INIT = -2147417841;

		public const int RPC_E_UNEXPECTED = -2147352577;

		public const int RPC_E_WRONG_THREAD = -2147417842;

		public const int RPC_S_ADDRESS_ERROR = 1768;

		public const int RPC_S_ALREADY_LISTENING = 1713;

		public const int RPC_S_ALREADY_REGISTERED = 1711;

		public const int RPC_S_BINDING_HAS_NO_AUTH = 1746;

		public const int RPC_S_CALL_FAILED = 1726;

		public const int RPC_S_CALL_FAILED_DNE = 1727;

		public const int RPC_S_CALL_IN_PROGRESS = 1791;

		public const int RPC_S_CANNOT_SUPPORT = 1764;

		public const int RPC_S_CANT_CREATE_ENDPOINT = 1720;

		public const int RPC_S_DUPLICATE_ENDPOINT = 1740;

		public const int RPC_S_ENTRY_ALREADY_EXISTS = 1760;

		public const int RPC_S_ENTRY_NOT_FOUND = 1761;

		public const int RPC_S_FP_DIV_ZERO = 1769;

		public const int RPC_S_FP_OVERFLOW = 1771;

		public const int RPC_S_FP_UNDERFLOW = 1770;

		public const int RPC_S_GROUP_MEMBER_NOT_FOUND = 1898;

		public const int RPC_S_INCOMPLETE_NAME = 1755;

		public const int RPC_S_INTERFACE_NOT_FOUND = 1759;

		public const int RPC_S_INTERNAL_ERROR = 1766;

		public const int RPC_S_INVALID_AUTH_IDENTITY = 1749;

		public const int RPC_S_INVALID_BINDING = 1702;

		public const int RPC_S_INVALID_BOUND = 1734;

		public const int RPC_S_INVALID_ENDPOINT_FORMAT = 1706;

		public const int RPC_S_INVALID_NAF_ID = 1763;

		public const int RPC_S_INVALID_NAME_SYNTAX = 1736;

		public const int RPC_S_INVALID_NETWORK_OPTIONS = 1724;

		public const int RPC_S_INVALID_NET_ADDR = 1707;

		public const int RPC_S_INVALID_OBJECT = 1900;

		public const int RPC_S_INVALID_RPC_PROTSEQ = 1704;

		public const int RPC_S_INVALID_STRING_BINDING = 1700;

		public const int RPC_S_INVALID_STRING_UUID = 1705;

		public const int RPC_S_INVALID_TAG = 1733;

		public const int RPC_S_INVALID_TIMEOUT = 1709;

		public const int RPC_S_INVALID_VERS_OPTION = 1756;

		public const int RPC_S_MAX_CALLS_TOO_SMALL = 1742;

		public const int RPC_S_NAME_SERVICE_UNAVAILABLE = 1762;

		public const int RPC_S_NOTHING_TO_EXPORT = 1754;

		public const int RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758;

		public const int RPC_S_NOT_LISTENING = 1715;

		public const int RPC_S_NO_BINDINGS = 1718;

		public const int RPC_S_NO_CALL_ACTIVE = 1725;

		public const int RPC_S_NO_CONTEXT_AVAILABLE = 1765;

		public const int RPC_S_NO_ENDPOINT_FOUND = 1708;

		public const int RPC_S_NO_ENTRY_NAME = 1735;

		public const int RPC_S_NO_MORE_BINDINGS = 1806;

		public const int RPC_S_NO_MORE_MEMBERS = 1757;

		public const int RPC_S_NO_PROTSEQS = 1719;

		public const int RPC_S_NO_PROTSEQS_REGISTERED = 1714;

		public const int RPC_S_OBJECT_NOT_FOUND = 1710;

		public const int RPC_S_OUT_OF_RESOURCES = 1721;

		public const int RPC_S_PROCNUM_OUT_OF_RANGE = 1745;

		public const int RPC_S_PROTOCOL_ERROR = 1728;

		public const int RPC_S_PROTSEQ_NOT_FOUND = 1744;

		public const int RPC_S_PROTSEQ_NOT_SUPPORTED = 1703;

		public const int RPC_S_SERVER_TOO_BUSY = 1723;

		public const int RPC_S_SERVER_UNAVAILABLE = 1722;

		public const int RPC_S_STRING_TOO_LONG = 1743;

		public const int RPC_S_TYPE_ALREADY_REGISTERED = 1712;

		public const int RPC_S_UNKNOWN_AUTHN_LEVEL = 1748;

		public const int RPC_S_UNKNOWN_AUTHN_SERVICE = 1747;

		public const int RPC_S_UNKNOWN_AUTHN_TYPE = 1741;

		public const int RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750;

		public const int RPC_S_UNKNOWN_IF = 1717;

		public const int RPC_S_UNKNOWN_MGR_TYPE = 1716;

		public const int RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737;

		public const int RPC_S_UNSUPPORTED_TRANS_SYN = 1730;

		public const int RPC_S_UNSUPPORTED_TYPE = 1732;

		public const int RPC_S_UUID_NO_ADDRESS = 1739;

		public const int RPC_S_WRONG_KIND_OF_BINDING = 1701;

		public const int RPC_S_ZERO_DIVIDE = 1767;

		public const int RPC_X_BAD_STUB_DATA = 1783;

		public const int RPC_X_BYTE_COUNT_TOO_SMALL = 1782;

		public const int RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781;

		public const int RPC_X_NO_MORE_ENTRIES = 1772;

		public const int RPC_X_NULL_REF_POINTER = 1780;

		public const int RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779;

		public const int RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773;

		public const int RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774;

		public const int RPC_X_SS_CONTEXT_DAMAGED = 1777;

		public const int RPC_X_SS_HANDLES_MISMATCH = 1778;

		public const int RPC_X_SS_IN_NULL_CONTEXT = 1775;

		public const int SEVERITY_ERROR = 1;

		public const int SEVERITY_SUCCESS = 0;

		public const int STG_E_ABNORMALAPIEXIT = -2147286790;

		public const int STG_E_ACCESSDENIED = -2147287035;

		public const int STG_E_CANTSAVE = -2147286781;

		public const int STG_E_DISKISWRITEPROTECTED = -2147287021;

		public const int STG_E_EXTANTMARSHALLINGS = -2147286776;

		public const int STG_E_FILEALREADYEXISTS = -2147286960;

		public const int STG_E_FILENOTFOUND = -2147287038;

		public const int STG_E_INSUFFICIENTMEMORY = -2147287032;

		public const int STG_E_INUSE = -2147286784;

		public const int STG_E_INVALIDFLAG = -2147286785;

		public const int STG_E_INVALIDFUNCTION = -2147287039;

		public const int STG_E_INVALIDHANDLE = -2147287034;

		public const int STG_E_INVALIDHEADER = -2147286789;

		public const int STG_E_INVALIDNAME = -2147286788;

		public const int STG_E_INVALIDPARAMETER = -2147286953;

		public const int STG_E_INVALIDPOINTER = -2147287031;

		public const int STG_E_LOCKVIOLATION = -2147287007;

		public const int STG_E_MEDIUMFULL = -2147286928;

		public const int STG_E_NOMOREFILES = -2147287022;

		public const int STG_E_NOTCURRENT = -2147286783;

		public const int STG_E_NOTFILEBASEDSTORAGE = -2147286777;

		public const int STG_E_OLDDLL = -2147286779;

		public const int STG_E_OLDFORMAT = -2147286780;

		public const int STG_E_PATHNOTFOUND = -2147287037;

		public const int STG_E_READFAULT = -2147287010;

		public const int STG_E_REVERTED = -2147286782;

		public const int STG_E_SEEKERROR = -2147287015;

		public const int STG_E_SHAREREQUIRED = -2147286778;

		public const int STG_E_SHAREVIOLATION = -2147287008;

		public const int STG_E_TOOMANYOPENFILES = -2147287036;

		public const int STG_E_UNIMPLEMENTEDFUNCTION = -2147286786;

		public const int STG_E_UNKNOWN = -2147286787;

		public const int STG_E_WRITEFAULT = -2147287011;

		public const int STG_S_CONVERTED = 197120;

		public const int S_FALSE = 1;

		public const int S_OK = 0;

		public const int TYPE_E_AMBIGUOUSNAME = -2147319764;

		public const int TYPE_E_BADMODULEKIND = -2147317571;

		public const int TYPE_E_BUFFERTOOSMALL = -2147319786;

		public const int TYPE_E_CANTCREATETMPFILE = -2147316573;

		public const int TYPE_E_CANTLOADLIBRARY = -2147312566;

		public const int TYPE_E_CIRCULARTYPE = -2147312508;

		public const int TYPE_E_DLLFUNCTIONNOTFOUND = -2147319761;

		public const int TYPE_E_DUPLICATEID = -2147317562;

		public const int TYPE_E_ELEMENTNOTFOUND = -2147319765;

		public const int TYPE_E_INCONSISTENTPROPFUNCS = -2147312509;

		public const int TYPE_E_INVALIDID = -2147317553;

		public const int TYPE_E_INVALIDSTATE = -2147319767;

		public const int TYPE_E_INVDATAREAD = -2147319784;

		public const int TYPE_E_IOERROR = -2147316574;

		public const int TYPE_E_LIBNOTREGISTERED = -2147319779;

		public const int TYPE_E_NAMECONFLICT = -2147319763;

		public const int TYPE_E_OUTOFBOUNDS = -2147316575;

		public const int TYPE_E_QUALIFIEDNAMEDISALLOWED = -2147319768;

		public const int TYPE_E_REGISTRYACCESS = -2147319780;

		public const int TYPE_E_SIZETOOBIG = -2147317563;

		public const int TYPE_E_TYPEMISMATCH = -2147316576;

		public const int TYPE_E_UNDEFINEDTYPE = -2147319769;

		public const int TYPE_E_UNKNOWNLCID = -2147319762;

		public const int TYPE_E_UNSUPFORMAT = -2147319783;

		public const int TYPE_E_WRONGTYPEKIND = -2147319766;

		public const int VIEW_E_DRAW = -2147221184;

		public const int VIEW_E_FIRST = -2147221184;

		public const int VIEW_E_LAST = -2147221169;

		public const int VIEW_S_ALREADY_FROZEN = 262464;

		public const int VIEW_S_FIRST = 262464;

		public const int VIEW_S_LAST = 262479;
	}
}
