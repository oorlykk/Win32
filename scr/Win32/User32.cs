using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Win32
{
	public class User32
	{
		public const int APPCLASS_MASK = 15;

		public const int APPCLASS_MONITOR = 1;

		public const int APPCLASS_STANDARD = 0;

		public const int APPCMD_CLIENTONLY = 16;

		public const int APPCMD_FILTERINITS = 32;

		public const int APPCMD_MASK = 4080;

		public const int BDR_INNER = 12;

		public const int BDR_OUTER = 3;

		public const int BDR_RAISED = 5;

		public const int BDR_RAISEDINNER = 4;

		public const int BDR_RAISEDOUTER = 1;

		public const int BDR_SUNKEN = 10;

		public const int BDR_SUNKENINNER = 8;

		public const int BDR_SUNKENOUTER = 2;

		public const int BF_ADJUST = 8192;

		public const int BF_BOTTOM = 8;

		public const int BF_BOTTOMLEFT = 9;

		public const int BF_BOTTOMRIGHT = 12;

		public const int BF_DIAGONAL = 16;

		public const int BF_DIAGONAL_ENDBOTTOMLEFT = 25;

		public const int BF_DIAGONAL_ENDBOTTOMRIGHT = 28;

		public const int BF_DIAGONAL_ENDTOPLEFT = 19;

		public const int BF_DIAGONAL_ENDTOPRIGHT = 22;

		public const int BF_FLAT = 16384;

		public const int BF_LEFT = 1;

		public const int BF_MIDDLE = 2048;

		public const int BF_MONO = 32768;

		public const int BF_RECT = 15;

		public const int BF_RIGHT = 4;

		public const int BF_SOFT = 4096;

		public const int BF_TOP = 2;

		public const int BF_TOPLEFT = 3;

		public const int BF_TOPRIGHT = 6;

		public const int BIF_BROWSEFORCOMPUTER = 4096;

		public const int BIF_BROWSEFORPRINTER = 8192;

		public const int BIF_BROWSEINCLUDEFILES = 16384;

		public const int BIF_BROWSEINCLUDEURLS = 128;

		public const int BIF_DONTGOBELOWDOMAIN = 2;

		public const int BIF_EDITBOX = 16;

		public const int BIF_RETURNFSANCESTORS = 8;

		public const int BIF_RETURNONLYFSDIRS = 1;

		public const int BIF_SHAREABLE = 32768;

		public const int BIF_STATUSTEXT = 4;

		public const int BIF_USENEWUI = 64;

		public const int BIF_VALIDATE = 32;

		public const int BM_GETCHECK = 240;

		public const int BM_GETSTATE = 242;

		public const int BM_SETCHECK = 241;

		public const int BM_SETSTATE = 243;

		public const int BM_SETSTYLE = 244;

		public const int BST_CHECKED = 1;

		public const int BM_CLICK = 245;

		public const int BM_GETIMAGE = 246;

		public const int BM_SETIMAGE = 247;

		public const int BN_CLICKED = 0;

		public const int BN_DISABLE = 4;

		public const int BN_DOUBLECLICKED = 5;

		public const int BN_HILITE = 2;

		public const int BN_PAINT = 1;

		public const int BN_UNHILITE = 3;

		public const int BS_3STATE = 5;

		public const int BS_AUTO3STATE = 6;

		public const int BS_AUTOCHECKBOX = 3;

		public const int BS_AUTORADIOBUTTON = 9;

		public const int BS_CHECKBOX = 2;

		public const int BS_DEFPUSHBUTTON = 1;

		public const int BS_GROUPBOX = 7;

		public const int BS_LEFTTEXT = 32;

		public const int BS_OWNERDRAW = 11;

		public const int BS_PUSHBUTTON = 0;

		public const int BS_RADIOBUTTON = 4;

		public const int BS_USERBUTTON = 8;

		public const int CADV_LATEACK = 65535;

		public const int CBF_FAIL_ADVISES = 16384;

		public const int CBF_FAIL_ALLSVRXACTIONS = 258048;

		public const int CBF_FAIL_CONNECTIONS = 8192;

		public const int CBF_FAIL_EXECUTES = 32768;

		public const int CBF_FAIL_POKES = 65536;

		public const int CBF_FAIL_REQUESTS = 131072;

		public const int CBF_FAIL_SELFCONNECTIONS = 4096;

		public const int CBF_SKIP_ALLNOTIFICATIONS = 3932160;

		public const int CBF_SKIP_CONNECT_CONFIRMS = 262144;

		public const int CBF_SKIP_DISCONNECTS = 2097152;

		public const int CBF_SKIP_REGISTRATIONS = 524288;

		public const int CBF_SKIP_UNREGISTRATIONS = 1048576;

		public const int CBN_CLOSEUP = 8;

		public const int CBN_DBLCLK = 2;

		public const int CBN_DROPDOWN = 7;

		public const int CBN_EDITCHANGE = 5;

		public const int CBN_EDITUPDATE = 6;

		public const int CBN_ERRSPACE = -1;

		public const int CBN_KILLFOCUS = 4;

		public const int CBN_SELCHANGE = 1;

		public const int CBN_SELENDCANCEL = 10;

		public const int CBN_SELENDOK = 9;

		public const int CBN_SETFOCUS = 3;

		public const int CBR_BLOCK = 65535;

		public const int CBS_AUTOHSCROLL = 64;

		public const int CBS_DISABLENOSCROLL = 2048;

		public const int CBS_DROPDOWN = 2;

		public const int CBS_DROPDOWNLIST = 3;

		public const int CBS_HASSTRINGS = 512;

		public const int CBS_NOINTEGRALHEIGHT = 1024;

		public const int CBS_OEMCONVERT = 128;

		public const int CBS_OWNERDRAWFIXED = 16;

		public const int CBS_OWNERDRAWVARIABLE = 32;

		public const int CBS_SIMPLE = 1;

		public const int CBS_SORT = 256;

		public const int CB_ADDSTRING = 323;

		public const int CB_DELETESTRING = 324;

		public const int CB_DIR = 325;

		public const int CB_ERR = -1;

		public const int CB_ERRSPACE = -2;

		public const int CB_FINDSTRING = 332;

		public const int CB_FINDSTRINGEXACT = 344;

		public const int CB_GETCOUNT = 326;

		public const int CB_GETCURSEL = 327;

		public const int CB_GETDROPPEDCONTROLRECT = 338;

		public const int CB_GETDROPPEDSTATE = 343;

		public const int CB_GETEDITSEL = 320;

		public const int CB_GETEXTENDEDUI = 342;

		public const int CB_GETITEMDATA = 336;

		public const int CB_GETITEMHEIGHT = 340;

		public const int CB_GETLBTEXT = 328;

		public const int CB_GETLBTEXTLEN = 329;

		public const int CB_GETLOCALE = 346;

		public const int CB_INSERTSTRING = 330;

		public const int CB_LIMITTEXT = 321;

		public const int CB_MSGMAX = 347;

		public const int CB_OKAY = 0;

		public const int CB_RESETCONTENT = 331;

		public const int CB_SELECTSTRING = 333;

		public const int CB_SETCURSEL = 334;

		public const int CB_SETEDITSEL = 322;

		public const int CB_SETEXTENDEDUI = 341;

		public const int CB_SETITEMDATA = 337;

		public const int CB_SETITEMHEIGHT = 339;

		public const int CB_SETLOCALE = 345;

		public const int CB_SHOWDROPDOWN = 335;

		public const int CF_BITMAP = 2;

		public const int CF_DIB = 8;

		public const int CF_DIF = 5;

		public const int CF_DSPBITMAP = 130;

		public const int CF_DSPENHMETAFILE = 142;

		public const int CF_DSPMETAFILEPICT = 131;

		public const int CF_DSPTEXT = 129;

		public const int CF_ENHMETAFILE = 14;

		public const int CF_GDIOBJFIRST = 768;

		public const int CF_GDIOBJLAST = 1023;

		public const int CF_METAFILEPICT = 3;

		public const int CF_OEMTEXT = 7;

		public const int CF_OWNERDISPLAY = 128;

		public const int CF_PALETTE = 9;

		public const int CF_PENDATA = 10;

		public const int CF_PRIVATEFIRST = 512;

		public const int CF_PRIVATELAST = 767;

		public const int CF_RIFF = 11;

		public const int CF_SYLK = 4;

		public const int CF_TEXT = 1;

		public const int CF_TIFF = 6;

		public const int CF_UNICODETEXT = 13;

		public const int CF_WAVE = 12;

		public const int CN_EVENT = 4;

		public const int CN_RECEIVE = 1;

		public const int CN_TRANSMIT = 2;

		public const int COLOR_ACTIVEBORDER = 10;

		public const int COLOR_ACTIVECAPTION = 2;

		public const int COLOR_APPWORKSPACE = 12;

		public const int COLOR_BACKGROUND = 1;

		public const int COLOR_BTNFACE = 15;

		public const int COLOR_BTNHIGHLIGHT = 20;

		public const int COLOR_BTNSHADOW = 16;

		public const int COLOR_BTNTEXT = 18;

		public const int COLOR_CAPTIONTEXT = 9;

		public const int COLOR_GRAYTEXT = 17;

		public const int COLOR_HIGHLIGHT = 13;

		public const int COLOR_HIGHLIGHTTEXT = 14;

		public const int COLOR_INACTIVEBORDER = 11;

		public const int COLOR_INACTIVECAPTION = 3;

		public const int COLOR_INACTIVECAPTIONTEXT = 19;

		public const int COLOR_MENU = 4;

		public const int COLOR_MENUTEXT = 7;

		public const int COLOR_SCROLLBAR = 0;

		public const int COLOR_WINDOW = 5;

		public const int COLOR_WINDOWFRAME = 6;

		public const int COLOR_WINDOWTEXT = 8;

		public const int CP_WINANSI = 1004;

		public const int CP_WINUNICODE = 1200;

		public const int CS_BYTEALIGNCLIENT = 4096;

		public const int CS_BYTEALIGNWINDOW = 8192;

		public const int CS_CLASSDC = 64;

		public const int CS_DBLCLKS = 8;

		public const int CS_HREDRAW = 2;

		public const int CS_KEYCVTWINDOW = 4;

		public const int CS_NOCLOSE = 512;

		public const int CS_NOKEYCVT = 256;

		public const int CS_OWNDC = 32;

		public const int CS_PARENTDC = 128;

		public const int CS_PUBLICCLASS = 16384;

		public const int CS_SAVEBITS = 2048;

		public const int CS_VREDRAW = 1;

		public const int CTLCOLOR_BTN = 3;

		public const int CTLCOLOR_DLG = 4;

		public const int CTLCOLOR_EDIT = 1;

		public const int CTLCOLOR_LISTBOX = 2;

		public const int CTLCOLOR_MAX = 8;

		public const int CTLCOLOR_MSGBOX = 0;

		public const int CTLCOLOR_SCROLLBAR = 5;

		public const int CTLCOLOR_STATIC = 6;

		public const int CW_USEDEFAULT = -2147483648;

		public const int DCX_CACHE = 2;

		public const int DCX_CLIPCHILDREN = 8;

		public const int DCX_CLIPSIBLINGS = 16;

		public const int DCX_EXCLUDERGN = 64;

		public const int DCX_EXCLUDEUPDATE = 256;

		public const int DCX_INTERSECTRGN = 128;

		public const int DCX_INTERSECTUPDATE = 512;

		public const int DCX_LOCKWINDOWUPDATE = 1024;

		public const int DCX_NORECOMPUTE = 1048576;

		public const int DCX_NORESETATTRS = 4;

		public const int DCX_PARENTCLIP = 32;

		public const int DCX_VALIDATE = 2097152;

		public const int DCX_WINDOW = 1;

		public const int DC_HASDEFID = 1332;

		public const int DDE_FACK = 32768;

		public const int DDE_FACKREQ = 32768;

		public const int DDE_FACKRESERVED = -49408;

		public const int DDE_FADVRESERVED = -49153;

		public const int DDE_FAPPSTATUS = 255;

		public const int DDE_FBUSY = 16384;

		public const int DDE_FDATRESERVED = -45057;

		public const int DDE_FDEFERUPD = 16384;

		public const int DDE_FNOTPROCESSED = 0;

		public const int DDE_FPOKRESERVED = -8193;

		public const int DDE_FRELEASE = 8192;

		public const int DDE_FREQUESTED = 4096;

		public const int DDL_ARCHIVE = 32;

		public const int DDL_DIRECTORY = 16;

		public const int DDL_DRIVES = 16384;

		public const int DDL_EXCLUSIVE = 32768;

		public const int DDL_HIDDEN = 2;

		public const int DDL_POSTMSGS = 8192;

		public const int DDL_READONLY = 1;

		public const int DDL_READWRITE = 0;

		public const int DDL_SYSTEM = 4;

		public const int DESKTOP_CREATEMENU = 4;

		public const int DESKTOP_CREATEWINDOW = 2;

		public const int DESKTOP_ENUMERATE = 64;

		public const int DESKTOP_HOOKCONTROL = 8;

		public const int DESKTOP_JOURNALPLAYBACK = 32;

		public const int DESKTOP_JOURNALRECORD = 16;

		public const int DESKTOP_READOBJECTS = 1;

		public const int DESKTOP_WRITEOBJECTS = 128;

		public const int DLGC_BUTTON = 8192;

		public const int DLGC_DEFPUSHBUTTON = 16;

		public const int DLGC_HASSETSEL = 8;

		public const int DLGC_RADIOBUTTON = 64;

		public const int DLGC_STATIC = 256;

		public const int DLGC_UNDEFPUSHBUTTON = 32;

		public const int DLGC_WANTALLKEYS = 4;

		public const int DLGC_WANTARROWS = 1;

		public const int DLGC_WANTCHARS = 128;

		public const int DLGC_WANTMESSAGE = 4;

		public const int DLGC_WANTTAB = 2;

		public const int DLGWINDOWEXTRA = 30;

		public const int DMLERR_ADVACKTIMEOUT = 16384;

		public const int DMLERR_BUSY = 16385;

		public const int DMLERR_DATAACKTIMEOUT = 16386;

		public const int DMLERR_DLL_NOT_INITIALIZED = 16387;

		public const int DMLERR_DLL_USAGE = 16388;

		public const int DMLERR_EXECACKTIMEOUT = 16389;

		public const int DMLERR_FIRST = 16384;

		public const int DMLERR_INVALIDPARAMETER = 16390;

		public const int DMLERR_LAST = 16401;

		public const int DMLERR_LOW_MEMORY = 16391;

		public const int DMLERR_MEMORY_ERROR = 16392;

		public const int DMLERR_NOTPROCESSED = 16393;

		public const int DMLERR_NO_CONV_ESTABLISHED = 16394;

		public const int DMLERR_NO_ERROR = 0;

		public const int DMLERR_POKEACKTIMEOUT = 16395;

		public const int DMLERR_POSTMSG_FAILED = 16396;

		public const int DMLERR_REENTRANCY = 16397;

		public const int DMLERR_SERVER_DIED = 16398;

		public const int DMLERR_SYS_ERROR = 16399;

		public const int DMLERR_UNADVACKTIMEOUT = 16400;

		public const int DMLERR_UNFOUND_QUEUE_ID = 16401;

		public const int DM_GETDEFID = 1024;

		public const int DM_SETDEFID = 1025;

		public const int DNS_FILTEROFF = 8;

		public const int DNS_FILTERON = 4;

		public const int DNS_REGISTER = 1;

		public const int DNS_UNREGISTER = 2;

		public const int DS_ABSALIGN = 1;

		public const int DS_LOCALEDIT = 32;

		public const int DS_MODALFRAME = 128;

		public const int DS_NOIDLEMSG = 256;

		public const int DS_SETFONT = 64;

		public const int DS_SETFOREGROUND = 512;

		public const int DS_SYSMODAL = 2;

		public const int DT_BOTTOM = 8;

		public const int DT_CALCRECT = 1024;

		public const int DT_CENTER = 1;

		public const int DT_EDITCONTROL = 8192;

		public const int DT_END_ELLIPSIS = 32768;

		public const int DT_EXPANDTABS = 64;

		public const int DT_EXTERNALLEADING = 512;

		public const int DT_INTERNAL = 4096;

		public const int DT_LEFT = 0;

		public const int DT_MODIFYSTRING = 65536;

		public const int DT_NOCLIP = 256;

		public const int DT_NOPREFIX = 2048;

		public const int DT_PATH_ELLIPSIS = 16384;

		public const int DT_RIGHT = 2;

		public const int DT_RTLREADING = 131072;

		public const int DT_SINGLELINE = 32;

		public const int DT_TABSTOP = 128;

		public const int DT_TOP = 0;

		public const int DT_VCENTER = 4;

		public const int DT_WORDBREAK = 16;

		public const int DT_WORD_ELLIPSIS = 262144;

		public const int DWL_DLGPROC = 4;

		public const int DWL_MSGRESULT = 0;

		public const int DWL_USER = 8;

		public const int EC_DISABLE = 8;

		public const int EC_ENABLEALL = 0;

		public const int EC_ENABLEONE = 128;

		public const int EC_QUERYWAITING = 2;

		public const int EDGE_BUMP = 9;

		public const int EDGE_ETCHED = 6;

		public const int EDGE_RAISED = 5;

		public const int EDGE_SUNKEN = 10;

		public const int EM_CANPASTE = 1074;

		public const int EM_CANREDO = 1109;

		public const int EM_CANUNDO = 198;

		public const int EM_CHARFROMPOS = 1063;

		public const int EM_DISPLAYBAND = 1075;

		public const int EM_EMPTYUNDOBUFFER = 205;

		public const int EM_EXGETSEL = 1076;

		public const int EM_EXLIMITTEXT = 1077;

		public const int EM_EXLINEFROMCHAR = 1078;

		public const int EM_EXSETSEL = 1079;

		public const int EM_FINDTEXT = 1080;

		public const int EM_FINDTEXTEX = 1103;

		public const int EM_FINDWORDBREAK = 1100;

		public const int EM_FMTLINES = 200;

		public const int EM_FORMATRANGE = 1081;

		public const int EM_GETCHARFORMAT = 1082;

		public const int EM_GETEVENTMASK = 1083;

		public const int EM_GETFIRSTVISIBLELINE = 206;

		public const int EM_GETLIMITTEXT = 1061;

		public const int EM_GETLINE = 196;

		public const int EM_GETLINECOUNT = 186;

		public const int EM_GETMODIFY = 184;

		public const int EM_GETOLEINTERFACE = 1084;

		public const int EM_GETOPTIONS = 1102;

		public const int EM_GETPARAFORMAT = 1085;

		public const int EM_GETPASSWORDCHAR = 210;

		public const int EM_GETRECT = 178;

		public const int EM_GETREDONAME = 1111;

		public const int EM_GETSEL = 176;

		public const int EM_GETSELTEXT = 1086;

		public const int EM_GETTEXTMODE = 1114;

		public const int EM_GETTEXTRANGE = 1099;

		public const int EM_GETTHUMB = 190;

		public const int EM_GETUNDONAME = 1110;

		public const int EM_GETWORDBREAKPROC = 209;

		public const int EM_HIDESELECTION = 1087;

		public const int EM_LIMITTEXT = 197;

		public const int EM_LINEFROMCHAR = 201;

		public const int EM_LINEINDEX = 187;

		public const int EM_LINELENGTH = 193;

		public const int EM_LINESCROLL = 182;

		public const int EM_PASTESPECIAL = 1088;

		public const int EM_POSFROMCHAR = 1062;

		public const int EM_REDO = 1108;

		public const int EM_REPLACESEL = 194;

		public const int EM_REQUESTRESIZE = 1089;

		public const int EM_SCROLL = 181;

		public const int EM_SCROLLCARET = 183;

		public const int EM_SELECTIONTYPE = 1090;

		public const int EM_SETBKGNDCOLOR = 1091;

		public const int EM_SETCHARFORMAT = 1092;

		public const int EM_SETEVENTMASK = 1093;

		public const int EM_SETMODIFY = 185;

		public const int EM_SETOLECALLBACK = 1094;

		public const int EM_SETOPTIONS = 1101;

		public const int EM_SETPARAFORMAT = 1095;

		public const int EM_SETPASSWORDCHAR = 204;

		public const int EM_SETREADONLY = 207;

		public const int EM_SETRECT = 179;

		public const int EM_SETRECTNP = 180;

		public const int EM_SETSEL = 177;

		public const int EM_SETTABSTOPS = 203;

		public const int EM_SETTARGETDEVICE = 1096;

		public const int EM_SETTEXTMODE = 1113;

		public const int EM_SETUNDOLIMIT = 1106;

		public const int EM_SETWORDBREAKPROC = 208;

		public const int EM_STOPGROUPTYPING = 1112;

		public const int EM_STREAMIN = 1097;

		public const int EM_STREAMOUT = 1098;

		public const int EM_UNDO = 199;

		public const int EN_CHANGE = 768;

		public const int EN_ERRSPACE = 1280;

		public const int EN_HSCROLL = 1537;

		public const int EN_KILLFOCUS = 512;

		public const int EN_MAXTEXT = 1281;

		public const int EN_SETFOCUS = 256;

		public const int EN_UPDATE = 1024;

		public const int EN_VSCROLL = 1538;

		public const int ESB_DISABLE_BOTH = 3;

		public const int ESB_DISABLE_DOWN = 2;

		public const int ESB_DISABLE_LEFT = 1;

		public const int ESB_DISABLE_LTUP = 1;

		public const int ESB_DISABLE_RIGHT = 2;

		public const int ESB_DISABLE_RTDN = 2;

		public const int ESB_DISABLE_UP = 1;

		public const int ESB_ENABLE_BOTH = 0;

		public const int ES_AUTOHSCROLL = 128;

		public const int ES_AUTOVSCROLL = 64;

		public const int ES_CENTER = 1;

		public const int ES_LEFT = 0;

		public const int ES_LOWERCASE = 16;

		public const int ES_MULTILINE = 4;

		public const int ES_NOHIDESEL = 256;

		public const int ES_OEMCONVERT = 1024;

		public const int ES_PASSWORD = 32;

		public const int ES_READONLY = 2048;

		public const int ES_RIGHT = 2;

		public const int ES_UPPERCASE = 8;

		public const int ES_WANTRETURN = 4096;

		public const int EWX_FORCE = 4;

		public const int EWX_LOGOFF = 0;

		public const int EWX_REBOOT = 2;

		public const int EWX_SHUTDOWN = 1;

		public const int FALT = 16;

		public const int FCONTROL = 8;

		public const int FNOINVERT = 2;

		public const int FSHIFT = 4;

		public const int FVIRTKEY = 1;

		public const int GCL_CBCLSEXTRA = -20;

		public const int GCL_CBWNDEXTRA = -18;

		public const int GCL_HBRBACKGROUND = -10;

		public const int GCL_HCURSOR = -12;

		public const int GCL_HICON = -14;

		public const int GCL_HMODULE = -16;

		public const int GCL_MENUNAME = -8;

		public const int GCL_STYLE = -26;

		public const int GCL_WNDPROC = -24;

		public const int GCW_ATOM = -32;

		public const int GWL_EXSTYLE = -20;

		public const int GWL_HINSTANCE = -6;

		public const int GWL_HWNDPARENT = -8;

		public const int GWL_ID = -12;

		public const int GWL_STYLE = -16;

		public const int GWL_USERDATA = -21;

		public const int GWL_WNDPROC = -4;

		public const int GW_CHILD = 5;

		public const int GW_HWNDFIRST = 0;

		public const int GW_HWNDLAST = 1;

		public const int GW_HWNDNEXT = 2;

		public const int GW_HWNDPREV = 3;

		public const int GW_MAX = 5;

		public const int GW_OWNER = 4;

		public const int HCBT_ACTIVATE = 5;

		public const int HCBT_CLICKSKIPPED = 6;

		public const int HCBT_CREATEWND = 3;

		public const int HCBT_DESTROYWND = 4;

		public const int HCBT_KEYSKIPPED = 7;

		public const int HCBT_MINMAX = 1;

		public const int HCBT_MOVESIZE = 0;

		public const int HCBT_QS = 2;

		public const int HCBT_SETFOCUS = 9;

		public const int HCBT_SYSCOMMAND = 8;

		public const int HC_ACTION = 0;

		public const int HC_GETNEXT = 1;

		public const int HC_NOREM = 3;

		public const int HC_NOREMOVE = 3;

		public const int HC_SKIP = 2;

		public const int HC_SYSMODALOFF = 5;

		public const int HC_SYSMODALON = 4;

		public const int HDATA_APPOWNED = 1;

		public const int HELP_COMMAND = 258;

		public const int HELP_CONTENTS = 3;

		public const int HELP_CONTEXT = 1;

		public const int HELP_CONTEXTPOPUP = 8;

		public const int HELP_FORCEFILE = 9;

		public const int HELP_HELPONHELP = 4;

		public const int HELP_INDEX = 3;

		public const int HELP_KEY = 257;

		public const int HELP_MULTIKEY = 513;

		public const int HELP_PARTIALKEY = 261;

		public const int HELP_QUIT = 2;

		public const int HELP_SETCONTENTS = 5;

		public const int HELP_SETINDEX = 5;

		public const int HELP_SETWINPOS = 515;

		public const int HIDE_WINDOW = 0;

		public const int HKL_NEXT = 1;

		public const int HKL_PREV = 0;

		public const int HSHELL_ACTIVATESHELLWINDOW = 3;

		public const int HSHELL_WINDOWCREATED = 1;

		public const int HSHELL_WINDOWDESTROYED = 2;

		public const int HTBORDER = 18;

		public const int HTBOTTOM = 15;

		public const int HTBOTTOMLEFT = 16;

		public const int HTBOTTOMRIGHT = 17;

		public const int HTCAPTION = 2;

		public const int HTCLIENT = 1;

		public const int HTERROR = -2;

		public const int HTGROWBOX = 4;

		public const int HTHSCROLL = 6;

		public const int HTLEFT = 10;

		public const int HTMAXBUTTON = 9;

		public const int HTMENU = 5;

		public const int HTMINBUTTON = 8;

		public const int HTNOWHERE = 0;

		public const int HTREDUCE = 8;

		public const int HTRIGHT = 11;

		public const int HTSIZE = 4;

		public const int HTSIZEFIRST = 10;

		public const int HTSIZELAST = 17;

		public const int HTSYSMENU = 3;

		public const int HTTOP = 12;

		public const int HTTOPLEFT = 13;

		public const int HTTOPRIGHT = 14;

		public const int HTTRANSPARENT = -1;

		public const int HTVSCROLL = 7;

		public const int HTZOOM = 9;

		public const int IDABORT = 3;

		public const int IDCANCEL = 2;

		public const int IDC_APPSTARTING = 32650;

		public const int IDC_ARROW = 32512;

		public const int IDC_CROSS = 32515;

		public const int IDC_IBEAM = 32513;

		public const int IDC_ICON = 32641;

		public const int IDC_NO = 32648;

		public const int IDC_SIZE = 32640;

		public const int IDC_SIZEALL = 32646;

		public const int IDC_SIZENESW = 32643;

		public const int IDC_SIZENS = 32645;

		public const int IDC_SIZENWSE = 32642;

		public const int IDC_SIZEWE = 32644;

		public const int IDC_UPARROW = 32516;

		public const int IDC_WAIT = 32514;

		public const int IDHOT_SNAPDESKTOP = -2;

		public const int IDHOT_SNAPWINDOW = -1;

		public const int IDIGNORE = 5;

		public const int IDI_APPLICATION = 32512;

		public const int IDI_ASTERISK = 32516;

		public const int IDI_EXCLAMATION = 32515;

		public const int IDI_HAND = 32513;

		public const int IDI_QUESTION = 32514;

		public const int IDNO = 7;

		public const int IDOK = 1;

		public const int IDRETRY = 4;

		public const int IDYES = 6;

		public const int INVALID_HANDLE_VALUE = -1;

		public const int KEYEVENTF_EXTENDEDKEY = 1;

		public const int KEYEVENTF_KEYUP = 2;

		public const int KF_ALTDOWN = 8192;

		public const int KF_DLGMODE = 2048;

		public const int KF_EXTENDED = 256;

		public const int KF_MENUMODE = 4096;

		public const int KF_REPEAT = 16384;

		public const int KF_UP = 32768;

		public const int KLF_ACTIVATE = 1;

		public const int KLF_REORDER = 8;

		public const int KLF_SUBSTITUTE_OK = 2;

		public const int KLF_UNLOADPREVIOUS = 4;

		public const int KL_NAMELENGTH = 9;

		public const int LBN_DBLCLK = 2;

		public const int LBN_ERRSPACE = -2;

		public const int LBN_KILLFOCUS = 5;

		public const int LBN_SELCANCEL = 3;

		public const int LBN_SELCHANGE = 1;

		public const int LBN_SETFOCUS = 4;

		public const int LBS_DISABLENOSCROLL = 4096;

		public const int LBS_EXTENDEDSEL = 2048;

		public const int LBS_HASSTRINGS = 64;

		public const int LBS_MULTICOLUMN = 512;

		public const int LBS_MULTIPLESEL = 8;

		public const int LBS_NODATA = 8192;

		public const int LBS_NOINTEGRALHEIGHT = 256;

		public const int LBS_NOREDRAW = 4;

		public const int LBS_NOTIFY = 1;

		public const int LBS_OWNERDRAWFIXED = 16;

		public const int LBS_OWNERDRAWVARIABLE = 32;

		public const int LBS_SORT = 2;

		public const int LBS_STANDARD = 10485763;

		public const int LBS_USETABSTOPS = 128;

		public const int LBS_WANTKEYBOARDINPUT = 1024;

		public const int LB_ADDFILE = 406;

		public const int LB_ADDSTRING = 384;

		public const int LB_CTLCODE = 0;

		public const int LB_DELETESTRING = 386;

		public const int LB_DIR = 397;

		public const int LB_ERR = -1;

		public const int LB_ERRSPACE = -2;

		public const int LB_FINDSTRING = 399;

		public const int LB_FINDSTRINGEXACT = 418;

		public const int LB_GETANCHORINDEX = 413;

		public const int LB_GETCARETINDEX = 415;

		public const int LB_GETCOUNT = 395;

		public const int LB_GETCURSEL = 392;

		public const int LB_GETHORIZONTALEXTENT = 403;

		public const int LB_GETITEMDATA = 409;

		public const int LB_GETITEMHEIGHT = 417;

		public const int LB_GETITEMRECT = 408;

		public const int LB_GETLOCALE = 422;

		public const int LB_GETSEL = 391;

		public const int LB_GETSELCOUNT = 400;

		public const int LB_GETSELITEMS = 401;

		public const int LB_GETTEXT = 393;

		public const int LB_GETTEXTLEN = 394;

		public const int LB_GETTOPINDEX = 398;

		public const int LB_INSERTSTRING = 385;

		public const int LB_MSGMAX = 424;

		public const int LB_OKAY = 0;

		public const int LB_RESETCONTENT = 388;

		public const int LB_SELECTSTRING = 396;

		public const int LB_SELITEMRANGE = 411;

		public const int LB_SELITEMRANGEEX = 387;

		public const int LB_SETANCHORINDEX = 412;

		public const int LB_SETCARETINDEX = 414;

		public const int LB_SETCOLUMNWIDTH = 405;

		public const int LB_SETCOUNT = 423;

		public const int LB_SETCURSEL = 390;

		public const int LB_SETHORIZONTALEXTENT = 404;

		public const int LB_SETITEMDATA = 410;

		public const int LB_SETITEMHEIGHT = 416;

		public const int LB_SETLOCALE = 421;

		public const int LB_SETSEL = 389;

		public const int LB_SETTABSTOPS = 402;

		public const int LB_SETTOPINDEX = 407;

		public const int MAX_MONITORS = 4;

		public const int MA_ACTIVATE = 1;

		public const int MA_ACTIVATEANDEAT = 2;

		public const int MA_NOACTIVATE = 3;

		public const int MA_NOACTIVATEANDEAT = 4;

		public const int MB_ABORTRETRYIGNORE = 2;

		public const int MB_APPLMODAL = 0;

		public const int MB_DEFAULT_DESKTOP_ONLY = 131072;

		public const int MB_DEFBUTTON1 = 0;

		public const int MB_DEFBUTTON2 = 256;

		public const int MB_DEFBUTTON3 = 512;

		public const int MB_DEFMASK = 3840;

		public const int MB_ICONASTERISK = 64;

		public const int MB_ICONEXCLAMATION = 48;

		public const int MB_ICONHAND = 16;

		public const int MB_ICONINFORMATION = 64;

		public const int MB_ICONMASK = 240;

		public const int MB_ICONQUESTION = 32;

		public const int MB_ICONSTOP = 16;

		public const int MB_MISCMASK = 49152;

		public const int MB_MODEMASK = 12288;

		public const int MB_NOFOCUS = 32768;

		public const int MB_OK = 0;

		public const int MB_OKCANCEL = 1;

		public const int MB_RETRYCANCEL = 5;

		public const int MB_SETFOREGROUND = 65536;

		public const int MB_SYSTEMMODAL = 4096;

		public const int MB_TASKMODAL = 8192;

		public const int MB_TYPEMASK = 15;

		public const int MB_YESNO = 4;

		public const int MB_YESNOCANCEL = 3;

		public const int MDIS_ALLCHILDSTYLES = 1;

		public const int MDITILE_HORIZONTAL = 1;

		public const int MDITILE_SKIPDISABLED = 2;

		public const int MDITILE_VERTICAL = 0;

		public const int MF_APPEND = 256;

		public const int MF_BITMAP = 4;

		public const int MF_BYCOMMAND = 0;

		public const int MF_BYPOSITION = 1024;

		public const int MF_CALLBACKS = 134217728;

		public const int MF_CHANGE = 128;

		public const int MF_CHECKED = 8;

		public const int MF_CONV = 1073741824;

		public const int MF_DELETE = 512;

		public const int MF_DISABLED = 2;

		public const int MF_ENABLED = 0;

		public const int MF_END = 128;

		public const int MF_ERRORS = 268435456;

		public const int MF_GRAYED = 1;

		public const int MF_HELP = 16384;

		public const int MF_HILITE = 128;

		public const int MF_HSZ_INFO = 16777216;

		public const int MF_INSERT = 0;

		public const int MF_LINKS = 536870912;

		public const int MF_MASK = -16777216;

		public const int MF_MENUBARBREAK = 32;

		public const int MF_MENUBREAK = 64;

		public const int MF_MOUSESELECT = 32768;

		public const int MF_OWNERDRAW = 256;

		public const int MF_POPUP = 16;

		public const int MF_POSTMSGS = 67108864;

		public const int MF_REMOVE = 4096;

		public const int MF_SENDMSGS = 33554432;

		public const int MF_SEPARATOR = 2048;

		public const int MF_STRING = 0;

		public const int MF_SYSMENU = 8192;

		public const int MF_UNCHECKED = 0;

		public const int MF_UNHILITE = 0;

		public const int MF_USECHECKBITMAPS = 512;

		public const int MH_CLEANUP = 4;

		public const int MH_CREATE = 1;

		public const int MH_DELETE = 3;

		public const int MH_KEEP = 2;

		public const int MK_CONTROL = 8;

		public const int MK_LBUTTON = 1;

		public const int MK_MBUTTON = 16;

		public const int MK_RBUTTON = 2;

		public const int MK_SHIFT = 4;

		public const int MOD_ALT = 1;

		public const int MOD_CONTROL = 2;

		public const int MOD_SHIFT = 4;

		public const int MOUSEEVENTF_ABSOLUTE = 32768;

		public const int MOUSEEVENTF_LEFTDOWN = 2;

		public const int MOUSEEVENTF_LEFTUP = 4;

		public const int MOUSEEVENTF_MIDDLEDOWN = 32;

		public const int MOUSEEVENTF_MIDDLEUP = 64;

		public const int MOUSEEVENTF_MOVE = 1;

		public const int MOUSEEVENTF_RIGHTDOWN = 8;

		public const int MOUSEEVENTF_RIGHTUP = 16;

		public const int MSGF_DDEMGR = 32769;

		public const int MSGF_DIALOGBOX = 0;

		public const int MSGF_MAINLOOP = 8;

		public const int MSGF_MAX = 8;

		public const int MSGF_MENU = 2;

		public const int MSGF_MESSAGEBOX = 1;

		public const int MSGF_MOVE = 3;

		public const int MSGF_NEXTWINDOW = 6;

		public const int MSGF_SCROLLBAR = 5;

		public const int MSGF_SIZE = 4;

		public const int MSGF_USER = 4096;

		public const int OBM_BTNCORNERS = 32758;

		public const int OBM_BTSIZE = 32761;

		public const int OBM_CHECK = 32760;

		public const int OBM_CHECKBOXES = 32759;

		public const int OBM_CLOSE = 32754;

		public const int OBM_COMBO = 32738;

		public const int OBM_DNARROW = 32752;

		public const int OBM_DNARROWD = 32742;

		public const int OBM_DNARROWI = 32736;

		public const int OBM_LFARROW = 32750;

		public const int OBM_LFARROWD = 32740;

		public const int OBM_LFARROWI = 32734;

		public const int OBM_MNARROW = 32739;

		public const int OBM_OLD_CLOSE = 32767;

		public const int OBM_OLD_DNARROW = 32764;

		public const int OBM_OLD_LFARROW = 32762;

		public const int OBM_OLD_REDUCE = 32757;

		public const int OBM_OLD_RESTORE = 32755;

		public const int OBM_OLD_RGARROW = 32763;

		public const int OBM_OLD_UPARROW = 32765;

		public const int OBM_OLD_ZOOM = 32756;

		public const int OBM_REDUCE = 32749;

		public const int OBM_REDUCED = 32746;

		public const int OBM_RESTORE = 32747;

		public const int OBM_RESTORED = 32744;

		public const int OBM_RGARROW = 32751;

		public const int OBM_RGARROWD = 32741;

		public const int OBM_RGARROWI = 32735;

		public const int OBM_SIZE = 32766;

		public const int OBM_UPARROW = 32753;

		public const int OBM_UPARROWD = 32743;

		public const int OBM_UPARROWI = 32737;

		public const int OBM_ZOOM = 32748;

		public const int OBM_ZOOMD = 32745;

		public const int OCR_CROSS = 32515;

		public const int OCR_IBEAM = 32513;

		public const int OCR_ICOCUR = 32647;

		public const int OCR_ICON = 32641;

		public const int OCR_NO = 32648;

		public const int OCR_NORMAL = 32512;

		public const int OCR_SIZE = 32640;

		public const int OCR_SIZEALL = 32646;

		public const int OCR_SIZENESW = 32643;

		public const int OCR_SIZENS = 32645;

		public const int OCR_SIZENWSE = 32642;

		public const int OCR_SIZEWE = 32644;

		public const int OCR_UP = 32516;

		public const int OCR_WAIT = 32514;

		public const int ODA_DRAWENTIRE = 1;

		public const int ODA_FOCUS = 4;

		public const int ODA_SELECT = 2;

		public const int ODS_CHECKED = 8;

		public const int ODS_DISABLED = 4;

		public const int ODS_FOCUS = 16;

		public const int ODS_GRAYED = 2;

		public const int ODS_SELECTED = 1;

		public const int ODT_BUTTON = 4;

		public const int ODT_COMBOBOX = 3;

		public const int ODT_LISTBOX = 2;

		public const int ODT_MENU = 1;

		public const int OIC_BANG = 32515;

		public const int OIC_HAND = 32513;

		public const int OIC_NOTE = 32516;

		public const int OIC_QUES = 32514;

		public const int OIC_SAMPLE = 32512;

		public const int ORD_LANGDRIVER = 1;

		public const int PAGE_EXECUTE = 16;

		public const int PAGE_EXECUTE_READ = 32;

		public const int PAGE_EXECUTE_READWRITE = 64;

		public const int PAGE_EXECUTE_WRITECOPY = 128;

		public const int PAGE_GUARD = 256;

		public const int PAGE_NOACCESS = 1;

		public const int PAGE_NOCACHE = 512;

		public const int PAGE_READONLY = 2;

		public const int PAGE_READWRITE = 4;

		public const int PAGE_WRITECOPY = 8;

		public const int PM_NOREMOVE = 0;

		public const int PM_NOYIELD = 2;

		public const int PM_REMOVE = 1;

		public const int PWR_CRITICALRESUME = 3;

		public const int PWR_FAIL = -1;

		public const int PWR_OK = 1;

		public const int PWR_SUSPENDREQUEST = 1;

		public const int PWR_SUSPENDRESUME = 2;

		public const int QID_SYNC = 65535;

		public const int QS_ALLEVENTS = 191;

		public const int QS_ALLINPUT = 255;

		public const int QS_HOTKEY = 128;

		public const int QS_INPUT = 7;

		public const int QS_KEY = 1;

		public const int QS_MOUSE = 6;

		public const int QS_MOUSEBUTTON = 4;

		public const int QS_MOUSEMOVE = 2;

		public const int QS_PAINT = 32;

		public const int QS_POSTMESSAGE = 8;

		public const int QS_SENDMESSAGE = 64;

		public const int QS_TIMER = 16;

		public const int RDW_ALLCHILDREN = 128;

		public const int RDW_ERASE = 4;

		public const int RDW_ERASENOW = 512;

		public const int RDW_FRAME = 1024;

		public const int RDW_INTERNALPAINT = 2;

		public const int RDW_INVALIDATE = 1;

		public const int RDW_NOCHILDREN = 64;

		public const int RDW_NOERASE = 32;

		public const int RDW_NOFRAME = 2048;

		public const int RDW_NOINTERNALPAINT = 16;

		public const int RDW_UPDATENOW = 256;

		public const int RDW_VALIDATE = 8;

		public const int READ = 0;

		public const int READ_WRITE = 2;

		public const int SBM_ENABLE_ARROWS = 228;

		public const int SBM_GETPOS = 225;

		public const int SBM_GETRANGE = 227;

		public const int SBM_SETPOS = 224;

		public const int SBM_SETRANGE = 226;

		public const int SBM_SETRANGEREDRAW = 230;

		public const int SBS_BOTTOMALIGN = 4;

		public const int SBS_HORZ = 0;

		public const int SBS_LEFTALIGN = 2;

		public const int SBS_RIGHTALIGN = 4;

		public const int SBS_SIZEBOX = 8;

		public const int SBS_SIZEBOXBOTTOMRIGHTALIGN = 4;

		public const int SBS_SIZEBOXTOPLEFTALIGN = 2;

		public const int SBS_TOPALIGN = 2;

		public const int SBS_VERT = 1;

		public const int SB_BOTH = 3;

		public const int SB_BOTTOM = 7;

		public const int SB_CTL = 2;

		public const int SB_ENDSCROLL = 8;

		public const int SB_HORZ = 0;

		public const int SB_LEFT = 6;

		public const int SB_LINEDOWN = 1;

		public const int SB_LINELEFT = 0;

		public const int SB_LINERIGHT = 1;

		public const int SB_LINEUP = 0;

		public const int SB_PAGEDOWN = 3;

		public const int SB_PAGELEFT = 2;

		public const int SB_PAGERIGHT = 3;

		public const int SB_PAGEUP = 2;

		public const int SB_RIGHT = 7;

		public const int SB_THUMBPOSITION = 4;

		public const int SB_THUMBTRACK = 5;

		public const int SB_TOP = 6;

		public const int SB_VERT = 1;

		public const int SC_ARRANGE = 61712;

		public const int SC_CLOSE = 61536;

		public const int SC_HOTKEY = 61776;

		public const int SC_HSCROLL = 61568;

		public const int SC_ICON = 61472;

		public const int SC_KEYMENU = 61696;

		public const int SC_MAXIMIZE = 61488;

		public const int SC_MINIMIZE = 61472;

		public const int SC_MOUSEMENU = 61584;

		public const int SC_MOVE = 61456;

		public const int SC_NEXTWINDOW = 61504;

		public const int SC_PREVWINDOW = 61520;

		public const int SC_RESTORE = 61728;

		public const int SC_SCREENSAVE = 61760;

		public const int SC_SIZE = 61440;

		public const int SC_TASKLIST = 61744;

		public const int SC_VSCROLL = 61552;

		public const int SC_ZOOM = 61488;

		public const int SHOW_FULLSCREEN = 3;

		public const int SHOW_ICONWINDOW = 2;

		public const int SHOW_OPENNOACTIVATE = 4;

		public const int SHOW_OPENWINDOW = 1;

		public const int SIZEFULLSCREEN = 2;

		public const int SIZEICONIC = 1;

		public const int SIZENORMAL = 0;

		public const int SIZEZOOMHIDE = 4;

		public const int SIZEZOOMSHOW = 3;

		public const int SIZE_MAXHIDE = 4;

		public const int SIZE_MAXIMIZED = 2;

		public const int SIZE_MAXSHOW = 3;

		public const int SIZE_MINIMIZED = 1;

		public const int SIZE_RESTORED = 0;

		public const int SMTO_ABORTIFHUNG = 2;

		public const int SMTO_BLOCK = 1;

		public const int SMTO_NORMAL = 0;

		public const int SM_CMETRICS = 44;

		public const int SM_CMOUSEBUTTONS = 43;

		public const int SM_CXBORDER = 5;

		public const int SM_CXCURSOR = 13;

		public const int SM_CXDLGFRAME = 7;

		public const int SM_CXDOUBLECLK = 36;

		public const int SM_CXFIXEDFRAME = 7;

		public const int SM_CXFRAME = 32;

		public const int SM_CXFULLSCREEN = 16;

		public const int SM_CXHSCROLL = 21;

		public const int SM_CXHTHUMB = 10;

		public const int SM_CXICON = 11;

		public const int SM_CXICONSPACING = 38;

		public const int SM_CXMIN = 28;

		public const int SM_CXMINTRACK = 34;

		public const int SM_CXSCREEN = 0;

		public const int SM_CXSIZE = 30;

		public const int SM_CXSIZEFRAME = 32;

		public const int SM_CXVSCROLL = 2;

		public const int SM_CYBORDER = 6;

		public const int SM_CYCAPTION = 4;

		public const int SM_CYCURSOR = 14;

		public const int SM_CYDLGFRAME = 8;

		public const int SM_CYDOUBLECLK = 37;

		public const int SM_CYFIXEDFRAME = 8;

		public const int SM_CYFRAME = 33;

		public const int SM_CYFULLSCREEN = 17;

		public const int SM_CYHSCROLL = 3;

		public const int SM_CYICON = 12;

		public const int SM_CYICONSPACING = 39;

		public const int SM_CYKANJIWINDOW = 18;

		public const int SM_CYMENU = 15;

		public const int SM_CYMIN = 29;

		public const int SM_CYMINTRACK = 35;

		public const int SM_CYSCREEN = 1;

		public const int SM_CYSIZE = 31;

		public const int SM_CYSIZEFRAME = 33;

		public const int SM_CYVSCROLL = 20;

		public const int SM_CYVTHUMB = 9;

		public const int SM_DBCSENABLED = 42;

		public const int SM_DEBUG = 22;

		public const int SM_MENUDROPALIGNMENT = 40;

		public const int SM_MOUSEPRESENT = 19;

		public const int SM_PENWINDOWS = 41;

		public const int SM_RESERVED1 = 24;

		public const int SM_RESERVED2 = 25;

		public const int SM_RESERVED3 = 26;

		public const int SM_RESERVED4 = 27;

		public const int SM_SWAPBUTTON = 23;

		public const int SPIF_SENDWININICHANGE = 2;

		public const int SPIF_UPDATEINIFILE = 1;

		public const int SPI_GETACCESSTIMEOUT = 60;

		public const int SPI_GETANIMATION = 72;

		public const int SPI_GETBEEP = 1;

		public const int SPI_GETBORDER = 5;

		public const int SPI_GETDEFAULTINPUTLANG = 89;

		public const int SPI_GETDRAGFULLWINDOWS = 38;

		public const int SPI_GETFASTTASKSWITCH = 35;

		public const int SPI_GETFILTERKEYS = 50;

		public const int SPI_GETFONTSMOOTHING = 74;

		public const int SPI_GETGRIDGRANULARITY = 18;

		public const int SPI_GETHIGHCONTRAST = 66;

		public const int SPI_GETICONMETRICS = 45;

		public const int SPI_GETICONTITLELOGFONT = 31;

		public const int SPI_GETICONTITLEWRAP = 25;

		public const int SPI_GETKEYBOARDDELAY = 22;

		public const int SPI_GETKEYBOARDPREF = 68;

		public const int SPI_GETKEYBOARDSPEED = 10;

		public const int SPI_GETLOWPOWERACTIVE = 83;

		public const int SPI_GETLOWPOWERTIMEOUT = 79;

		public const int SPI_GETMENUDROPALIGNMENT = 27;

		public const int SPI_GETMINIMIZEDMETRICS = 43;

		public const int SPI_GETMOUSE = 3;

		public const int SPI_GETMOUSEKEYS = 54;

		public const int SPI_GETMOUSETRAILS = 94;

		public const int SPI_GETNONCLIENTMETRICS = 41;

		public const int SPI_GETPOWEROFFACTIVE = 84;

		public const int SPI_GETPOWEROFFTIMEOUT = 80;

		public const int SPI_GETSCREENREADER = 70;

		public const int SPI_GETSCREENSAVEACTIVE = 16;

		public const int SPI_GETSCREENSAVETIMEOUT = 14;

		public const int SPI_GETSERIALKEYS = 62;

		public const int SPI_GETSHOWSOUNDS = 56;

		public const int SPI_GETSOUNDSENTRY = 64;

		public const int SPI_GETSTICKYKEYS = 58;

		public const int SPI_GETTOGGLEKEYS = 52;

		public const int SPI_GETWINDOWSEXTENSION = 92;

		public const int SPI_GETWORKAREA = 48;

		public const int SPI_ICONHORIZONTALSPACING = 13;

		public const int SPI_ICONVERTICALSPACING = 24;

		public const int SPI_LANGDRIVER = 12;

		public const int SPI_SCREENSAVERRUNNING = 97;

		public const int SPI_SETACCESSTIMEOUT = 61;

		public const int SPI_SETANIMATION = 73;

		public const int SPI_SETBEEP = 2;

		public const int SPI_SETBORDER = 6;

		public const int SPI_SETCURSORS = 87;

		public const int SPI_SETDEFAULTINPUTLANG = 90;

		public const int SPI_SETDESKPATTERN = 21;

		public const int SPI_SETDESKWALLPAPER = 20;

		public const int SPI_SETDOUBLECLICKTIME = 32;

		public const int SPI_SETDOUBLECLKHEIGHT = 30;

		public const int SPI_SETDOUBLECLKWIDTH = 29;

		public const int SPI_SETDRAGFULLWINDOWS = 37;

		public const int SPI_SETDRAGHEIGHT = 77;

		public const int SPI_SETDRAGWIDTH = 76;

		public const int SPI_SETFASTTASKSWITCH = 36;

		public const int SPI_SETFILTERKEYS = 51;

		public const int SPI_SETFONTSMOOTHING = 75;

		public const int SPI_SETGRIDGRANULARITY = 19;

		public const int SPI_SETHANDHELD = 78;

		public const int SPI_SETHIGHCONTRAST = 67;

		public const int SPI_SETICONMETRICS = 46;

		public const int SPI_SETICONS = 88;

		public const int SPI_SETICONTITLELOGFONT = 34;

		public const int SPI_SETICONTITLEWRAP = 26;

		public const int SPI_SETKEYBOARDDELAY = 23;

		public const int SPI_SETKEYBOARDPREF = 69;

		public const int SPI_SETKEYBOARDSPEED = 11;

		public const int SPI_SETLANGTOGGLE = 91;

		public const int SPI_SETLOWPOWERACTIVE = 85;

		public const int SPI_SETLOWPOWERTIMEOUT = 81;

		public const int SPI_SETMENUDROPALIGNMENT = 28;

		public const int SPI_SETMINIMIZEDMETRICS = 44;

		public const int SPI_SETMOUSE = 4;

		public const int SPI_SETMOUSEBUTTONSWAP = 33;

		public const int SPI_SETMOUSEKEYS = 55;

		public const int SPI_SETMOUSETRAILS = 93;

		public const int SPI_SETNONCLIENTMETRICS = 42;

		public const int SPI_SETPENWINDOWS = 49;

		public const int SPI_SETPOWEROFFACTIVE = 86;

		public const int SPI_SETPOWEROFFTIMEOUT = 82;

		public const int SPI_SETSCREENREADER = 71;

		public const int SPI_SETSCREENSAVEACTIVE = 17;

		public const int SPI_SETSCREENSAVETIMEOUT = 15;

		public const int SPI_SETSERIALKEYS = 63;

		public const int SPI_SETSHOWSOUNDS = 57;

		public const int SPI_SETSOUNDSENTRY = 65;

		public const int SPI_SETSTICKYKEYS = 59;

		public const int SPI_SETTOGGLEKEYS = 53;

		public const int SPI_SETWORKAREA = 47;

		public const int SS_BLACKFRAME = 7;

		public const int SS_BLACKRECT = 4;

		public const int SS_CENTER = 1;

		public const int SS_GRAYFRAME = 8;

		public const int SS_GRAYRECT = 5;

		public const int SS_ICON = 3;

		public const int SS_LEFT = 0;

		public const int SS_LEFTNOWORDWRAP = 12;

		public const int SS_NOPREFIX = 128;

		public const int SS_RIGHT = 2;

		public const int SS_SIMPLE = 11;

		public const int SS_USERITEM = 10;

		public const int SS_WHITEFRAME = 9;

		public const int SS_WHITERECT = 6;

		public const int STM_GETICON = 369;

		public const int STM_MSGMAX = 370;

		public const int STM_SETICON = 368;

		public const int ST_ADVISE = 2;

		public const int ST_BEGINSWP = 0;

		public const int ST_BLOCKED = 8;

		public const int ST_BLOCKNEXT = 128;

		public const int ST_CLIENT = 16;

		public const int ST_CONNECTED = 1;

		public const int ST_ENDSWP = 1;

		public const int ST_INLIST = 64;

		public const int ST_ISLOCAL = 4;

		public const int ST_ISSELF = 256;

		public const int ST_TERMINATED = 32;

		public const int SWP_DRAWFRAME = 32;

		public const int SWP_FRAMECHANGED = 32;

		public const int SWP_HIDEWINDOW = 128;

		public const int SWP_NOACTIVATE = 16;

		public const int SWP_NOCOPYBITS = 256;

		public const int SWP_NOMOVE = 2;

		public const int SWP_NOOWNERZORDER = 512;

		public const int SWP_NOREDRAW = 8;

		public const int SWP_NOREPOSITION = 512;

		public const int SWP_NOSIZE = 1;

		public const int SWP_NOZORDER = 4;

		public const int SWP_SHOWWINDOW = 64;

		public const int SW_ERASE = 4;

		public const int SW_HIDE = 0;

		public const int SW_INVALIDATE = 2;

		public const int SW_MAX = 10;

		public const int SW_MAXIMIZE = 3;

		public const int SW_MINIMIZE = 6;

		public const int SW_NORMAL = 1;

		public const int SW_OTHERUNZOOM = 4;

		public const int SW_OTHERZOOM = 2;

		public const int SW_PARENTCLOSING = 1;

		public const int SW_PARENTOPENING = 3;

		public const int SW_RESTORE = 9;

		public const int SW_SCROLLCHILDREN = 1;

		public const int SW_SHOW = 5;

		public const int SW_SHOWDEFAULT = 10;

		public const int SW_SHOWMAXIMIZED = 3;

		public const int SW_SHOWMINIMIZED = 2;

		public const int SW_SHOWMINNOACTIVE = 7;

		public const int SW_SHOWNA = 8;

		public const int SW_SHOWNOACTIVATE = 4;

		public const int SW_SHOWNORMAL = 1;

		public const int TIMEOUT_ASYNC = 65535;

		public const int TPM_CENTERALIGN = 4;

		public const int TPM_LEFTALIGN = 0;

		public const int TPM_LEFTBUTTON = 0;

		public const int TPM_RIGHTALIGN = 8;

		public const int TPM_RIGHTBUTTON = 2;

		public const int VK_ADD = 107;

		public const int VK_ATTN = 246;

		public const int VK_BACK = 8;

		public const int VK_CANCEL = 3;

		public const int VK_CAPITAL = 20;

		public const int VK_CLEAR = 12;

		public const int VK_CONTROL = 17;

		public const int VK_CRSEL = 247;

		public const int VK_DECIMAL = 110;

		public const int VK_DELETE = 46;

		public const int VK_DIVIDE = 111;

		public const int VK_DOWN = 40;

		public const int VK_END = 35;

		public const int VK_EREOF = 249;

		public const int VK_ESCAPE = 27;

		public const int VK_EXECUTE = 43;

		public const int VK_EXSEL = 248;

		public const int VK_F1 = 112;

		public const int VK_F10 = 121;

		public const int VK_F11 = 122;

		public const int VK_F12 = 123;

		public const int VK_F13 = 124;

		public const int VK_F14 = 125;

		public const int VK_F15 = 126;

		public const int VK_F16 = 127;

		public const int VK_F17 = 128;

		public const int VK_F18 = 129;

		public const int VK_F19 = 130;

		public const int VK_F2 = 113;

		public const int VK_F20 = 131;

		public const int VK_F21 = 132;

		public const int VK_F22 = 133;

		public const int VK_F23 = 134;

		public const int VK_F24 = 135;

		public const int VK_F3 = 114;

		public const int VK_F4 = 115;

		public const int VK_F5 = 116;

		public const int VK_F6 = 117;

		public const int VK_F7 = 118;

		public const int VK_F8 = 119;

		public const int VK_F9 = 120;

		public const int VK_HELP = 47;

		public const int VK_HOME = 36;

		public const int VK_INSERT = 45;

		public const int VK_LBUTTON = 1;

		public const int VK_LCONTROL = 162;

		public const int VK_LEFT = 37;

		public const int VK_LMENU = 164;

		public const int VK_LSHIFT = 160;

		public const int VK_MBUTTON = 4;

		public const int VK_MENU = 18;

		public const int VK_MULTIPLY = 106;

		public const int VK_NEXT = 34;

		public const int VK_NONAME = 252;

		public const int VK_NUMLOCK = 144;

		public const int VK_NUMPAD0 = 96;

		public const int VK_NUMPAD1 = 97;

		public const int VK_NUMPAD2 = 98;

		public const int VK_NUMPAD3 = 99;

		public const int VK_NUMPAD4 = 100;

		public const int VK_NUMPAD5 = 101;

		public const int VK_NUMPAD6 = 102;

		public const int VK_NUMPAD7 = 103;

		public const int VK_NUMPAD8 = 104;

		public const int VK_NUMPAD9 = 105;

		public const int VK_OEM_CLEAR = 254;

		public const int VK_PA1 = 253;

		public const int VK_PAUSE = 19;

		public const int VK_PLAY = 250;

		public const int VK_PRINT = 42;

		public const int VK_PRIOR = 33;

		public const int VK_RBUTTON = 2;

		public const int VK_RCONTROL = 163;

		public const int VK_RETURN = 13;

		public const int VK_RIGHT = 39;

		public const int VK_RMENU = 165;

		public const int VK_RSHIFT = 161;

		public const int VK_SCROLL = 145;

		public const int VK_SELECT = 41;

		public const int VK_SEPARATOR = 108;

		public const int VK_SHIFT = 16;

		public const int VK_SNAPSHOT = 44;

		public const int VK_SPACE = 32;

		public const int VK_SUBTRACT = 109;

		public const int VK_TAB = 9;

		public const int VK_UP = 38;

		public const int VK_ZOOM = 251;

		public const int WA_ACTIVE = 1;

		public const int WA_CLICKACTIVE = 2;

		public const int WA_INACTIVE = 0;

		public const int WB_ISDELIMITER = 2;

		public const int WB_LEFT = 0;

		public const int WB_RIGHT = 1;

		public const int WC_DIALOG = 8002;

		public const int WH_CALLWNDPROC = 4;

		public const int WH_CBT = 5;

		public const int WH_DEBUG = 9;

		public const int WH_FOREGROUNDIDLE = 11;

		public const int WH_GETMESSAGE = 3;

		public const int WH_HARDWARE = 8;

		public const int WH_JOURNALPLAYBACK = 1;

		public const int WH_JOURNALRECORD = 0;

		public const int WH_KEYBOARD = 2;

		public const int WH_MAX = 11;

		public const int WH_MIN = -1;

		public const int WH_MOUSE = 7;

		public const int WH_MSGFILTER = -1;

		public const int WH_SHELL = 10;

		public const int WH_SYSMSGFILTER = 6;

		public const int WINSTA_ACCESSCLIPBOARD = 4;

		public const int WINSTA_ACCESSPUBLICATOMS = 32;

		public const int WINSTA_CREATEDESKTOP = 8;

		public const int WINSTA_ENUMDESKTOPS = 1;

		public const int WINSTA_ENUMERATE = 256;

		public const int WINSTA_EXITWINDOWS = 64;

		public const int WINSTA_READATTRIBUTES = 2;

		public const int WINSTA_READSCREEN = 512;

		public const int WINSTA_WRITEATTRIBUTES = 16;

		public const int WM_ACTIVATE = 6;

		public const int WM_ACTIVATEAPP = 28;

		public const int WM_ASKCBFORMATNAME = 780;

		public const int WM_CANCELJOURNAL = 75;

		public const int WM_CANCELMODE = 31;

		public const int WM_CHANGECBCHAIN = 781;

		public const int WM_CHAR = 258;

		public const int WM_CHARTOITEM = 47;

		public const int WM_CHILDACTIVATE = 34;

		public const int WM_CLEAR = 771;

		public const int WM_CLOSE = 16;

		public const int WM_COMMAND = 273;

		public const int WM_COMMNOTIFY = 68;

		public const int WM_COMPACTING = 65;

		public const int WM_COMPAREITEM = 57;

		public const int WM_COPY = 769;

		public const int WM_COPYDATA = 74;

		public const int WM_CREATE = 1;

		public const int WM_CTLCOLORBTN = 309;

		public const int WM_CTLCOLORDLG = 310;

		public const int WM_CTLCOLOREDIT = 307;

		public const int WM_CTLCOLORLISTBOX = 308;

		public const int WM_CTLCOLORMSGBOX = 306;

		public const int WM_CTLCOLORSCROLLBAR = 311;

		public const int WM_CTLCOLORSTATIC = 312;

		public const int WM_CUT = 768;

		public const int WM_DDE_ACK = 996;

		public const int WM_DDE_ADVISE = 994;

		public const int WM_DDE_DATA = 997;

		public const int WM_DDE_EXECUTE = 1000;

		public const int WM_DDE_FIRST = 992;

		public const int WM_DDE_INITIATE = 992;

		public const int WM_DDE_LAST = 1000;

		public const int WM_DDE_POKE = 999;

		public const int WM_DDE_REQUEST = 998;

		public const int WM_DDE_TERMINATE = 993;

		public const int WM_DDE_UNADVISE = 995;

		public const int WM_DEADCHAR = 259;

		public const int WM_DELETEITEM = 45;

		public const int WM_DESTROY = 2;

		public const int WM_DESTROYCLIPBOARD = 775;

		public const int WM_DEVMODECHANGE = 27;

		public const int WM_DRAWCLIPBOARD = 776;

		public const int WM_DRAWITEM = 43;

		public const int WM_DROPFILES = 563;

		public const int WM_ENABLE = 10;

		public const int WM_ENDSESSION = 22;

		public const int WM_ENTERIDLE = 289;

		public const int WM_ENTERMENULOOP = 529;

		public const int WM_ERASEBKGND = 20;

		public const int WM_EXITMENULOOP = 530;

		public const int WM_FONTCHANGE = 29;

		public const int WM_GETDLGCODE = 135;

		public const int WM_GETFONT = 49;

		public const int WM_GETHOTKEY = 51;

		public const int WM_GETMINMAXINFO = 36;

		public const int WM_GETTEXT = 13;

		public const int WM_GETTEXTLENGTH = 14;

		public const int WM_HOTKEY = 786;

		public const int WM_HSCROLL = 276;

		public const int WM_HSCROLLCLIPBOARD = 782;

		public const int WM_ICONERASEBKGND = 39;

		public const int WM_INITDIALOG = 272;

		public const int WM_INITMENU = 278;

		public const int WM_INITMENUPOPUP = 279;

		public const int WM_KEYDOWN = 256;

		public const int WM_KEYFIRST = 256;

		public const int WM_KEYLAST = 264;

		public const int WM_KEYUP = 257;

		public const int WM_KILLFOCUS = 8;

		public const int WM_LBUTTONDBLCLK = 515;

		public const int WM_LBUTTONDOWN = 513;

		public const int WM_LBUTTONUP = 514;

		public const int WM_MBUTTONDBLCLK = 521;

		public const int WM_MBUTTONDOWN = 519;

		public const int WM_MBUTTONUP = 520;

		public const int WM_MDIACTIVATE = 546;

		public const int WM_MDICASCADE = 551;

		public const int WM_MDICREATE = 544;

		public const int WM_MDIDESTROY = 545;

		public const int WM_MDIGETACTIVE = 553;

		public const int WM_MDIICONARRANGE = 552;

		public const int WM_MDIMAXIMIZE = 549;

		public const int WM_MDINEXT = 548;

		public const int WM_MDIREFRESHMENU = 564;

		public const int WM_MDIRESTORE = 547;

		public const int WM_MDISETMENU = 560;

		public const int WM_MDITILE = 550;

		public const int WM_MEASUREITEM = 44;

		public const int WM_MENUCHAR = 288;

		public const int WM_MENUSELECT = 287;

		public const int WM_MOUSEACTIVATE = 33;

		public const int WM_MOUSEFIRST = 512;

		public const int WM_MOUSELAST = 521;

		public const int WM_MOUSEMOVE = 512;

		public const int WM_MOVE = 3;

		public const int WM_NCACTIVATE = 134;

		public const int WM_NCCALCSIZE = 131;

		public const int WM_NCCREATE = 129;

		public const int WM_NCDESTROY = 130;

		public const int WM_NCHITTEST = 132;

		public const int WM_NCLBUTTONDBLCLK = 163;

		public const int WM_NCLBUTTONDOWN = 161;

		public const int WM_NCLBUTTONUP = 162;

		public const int WM_NCMBUTTONDBLCLK = 169;

		public const int WM_NCMBUTTONDOWN = 167;

		public const int WM_NCMBUTTONUP = 168;

		public const int WM_NCMOUSEMOVE = 160;

		public const int WM_NCPAINT = 133;

		public const int WM_NCRBUTTONDBLCLK = 166;

		public const int WM_NCRBUTTONDOWN = 164;

		public const int WM_NCRBUTTONUP = 165;

		public const int WM_NEXTDLGCTL = 40;

		public const int WM_NULL = 0;

		public const int WM_OTHERWINDOWCREATED = 66;

		public const int WM_OTHERWINDOWDESTROYED = 67;

		public const int WM_PAINT = 15;

		public const int WM_PAINTCLIPBOARD = 777;

		public const int WM_PAINTICON = 38;

		public const int WM_PALETTECHANGED = 785;

		public const int WM_PALETTEISCHANGING = 784;

		public const int WM_PARENTNOTIFY = 528;

		public const int WM_PASTE = 770;

		public const int WM_PENWINFIRST = 896;

		public const int WM_PENWINLAST = 911;

		public const int WM_POWER = 72;

		public const int WM_QUERYDRAGICON = 55;

		public const int WM_QUERYENDSESSION = 17;

		public const int WM_QUERYNEWPALETTE = 783;

		public const int WM_QUERYOPEN = 19;

		public const int WM_QUEUESYNC = 35;

		public const int WM_QUIT = 18;

		public const int WM_RBUTTONDBLCLK = 518;

		public const int WM_RBUTTONDOWN = 516;

		public const int WM_RBUTTONUP = 517;

		public const int WM_RENDERALLFORMATS = 774;

		public const int WM_RENDERFORMAT = 773;

		public const int WM_SETCURSOR = 32;

		public const int WM_SETFOCUS = 7;

		public const int WM_SETFONT = 48;

		public const int WM_SETHOTKEY = 50;

		public const int WM_SETREDRAW = 11;

		public const int WM_SETTEXT = 12;

		public const int WM_SHOWWINDOW = 24;

		public const int WM_SIZE = 5;

		public const int WM_SIZECLIPBOARD = 779;

		public const int WM_SPOOLERSTATUS = 42;

		public const int WM_SYSCHAR = 262;

		public const int WM_SYSCOLORCHANGE = 21;

		public const int WM_SYSCOMMAND = 274;

		public const int WM_SYSDEADCHAR = 263;

		public const int WM_SYSKEYDOWN = 260;

		public const int WM_SYSKEYUP = 261;

		public const int WM_TIMECHANGE = 30;

		public const int WM_TIMER = 275;

		public const int WM_UNDO = 772;

		public const int WM_USER = 1024;

		public const int WM_VKEYTOITEM = 46;

		public const int WM_VSCROLL = 277;

		public const int WM_VSCROLLCLIPBOARD = 778;

		public const int WM_WINDOWPOSCHANGED = 71;

		public const int WM_WINDOWPOSCHANGING = 70;

		public const int WM_WININICHANGE = 26;

		public const int WPF_RESTORETOMAXIMIZED = 2;

		public const int WPF_SETMINPOSITION = 1;

		public const int WRITE = 1;

		public const int WS_BORDER = 8388608;

		public const int WS_CAPTION = 12582912;

		public const int WS_CHILD = 1073741824;

		public const int WS_CHILDWINDOW = 1073741824;

		public const int WS_CLIPCHILDREN = 33554432;

		public const int WS_CLIPSIBLINGS = 67108864;

		public const int WS_DISABLED = 134217728;

		public const int WS_DLGFRAME = 4194304;

		public const int WS_EX_ACCEPTFILES = 16;

		public const int WS_EX_DLGMODALFRAME = 1;

		public const int WS_EX_NOPARENTNOTIFY = 4;

		public const int WS_EX_TOPMOST = 8;

		public const int WS_EX_TRANSPARENT = 32;

		public const int WS_GROUP = 131072;

		public const int WS_HSCROLL = 1048576;

		public const int WS_ICONIC = 536870912;

		public const int WS_MAXIMIZE = 16777216;

		public const int WS_MAXIMIZEBOX = 65536;

		public const int WS_MINIMIZE = 536870912;

		public const int WS_MINIMIZEBOX = 131072;

		public const int WS_OVERLAPPED = 0;

		public const int WS_OVERLAPPEDWINDOW = 13565952;

		public const int WS_POPUP = -2147483648;

		public const int WS_POPUPWINDOW = -2138570752;

		public const int WS_SIZEBOX = 262144;

		public const int WS_SYSMENU = 524288;

		public const int WS_TABSTOP = 65536;

		public const int WS_THICKFRAME = 262144;

		public const int WS_TILED = 0;

		public const int WS_TILEDWINDOW = 13565952;

		public const int WS_VISIBLE = 268435456;

		public const int WS_VSCROLL = 2097152;

		public const int WVR_ALIGNBOTTOM = 64;

		public const int WVR_ALIGNLEFT = 32;

		public const int WVR_ALIGNRIGHT = 128;

		public const int WVR_ALIGNTOP = 16;

		public const int WVR_HREDRAW = 256;

		public const int WVR_REDRAW = 768;

		public const int WVR_VALIDRECTS = 1024;

		public const int WVR_VREDRAW = 512;

		public const int XCLASS_BOOL = 4096;

		public const int XCLASS_DATA = 8192;

		public const int XCLASS_FLAGS = 16384;

		public const int XCLASS_MASK = 64512;

		public const int XCLASS_NOTIFICATION = 32768;

		public const int XST_ADVACKRCVD = 13;

		public const int XST_ADVDATAACKRCVD = 16;

		public const int XST_ADVDATASENT = 15;

		public const int XST_ADVSENT = 11;

		public const int XST_CONNECTED = 2;

		public const int XST_DATARCVD = 6;

		public const int XST_EXECACKRCVD = 10;

		public const int XST_EXECSENT = 9;

		public const int XST_INCOMPLETE = 1;

		public const int XST_INIT1 = 3;

		public const int XST_INIT2 = 4;

		public const int XST_NULL = 0;

		public const int XST_POKEACKRCVD = 8;

		public const int XST_POKESENT = 7;

		public const int XST_REQSENT = 5;

		public const int XST_UNADVACKRCVD = 14;

		public const int XST_UNADVSENT = 12;

		public const int XTYPF_ACKREQ = 8;

		public const int XTYPF_NOBLOCK = 2;

		public const int XTYPF_NODATA = 4;

		public const int XTYP_ADVDATA = 16400;

		public const int XTYP_ADVREQ = 8226;

		public const int XTYP_ADVSTART = 4144;

		public const int XTYP_ADVSTOP = 32832;

		public const int XTYP_CONNECT = 4194;

		public const int XTYP_CONNECT_CONFIRM = 32882;

		public const int XTYP_DISCONNECT = 32962;

		public const int XTYP_ERROR = 32770;

		public const int XTYP_EXECUTE = 16464;

		public const int XTYP_MASK = 240;

		public const int XTYP_MONITOR = 33010;

		public const int XTYP_POKE = 16528;

		public const int XTYP_REGISTER = 32930;

		public const int XTYP_REQUEST = 8368;

		public const int XTYP_SHIFT = 4;

		public const int XTYP_UNREGISTER = 32978;

		public const int XTYP_WILDCONNECT = 8418;

		public const int XTYP_XACT_COMPLETE = 32896;

		public const string SZDDESYS_ITEM_FORMATS = "Formats";

		public const string SZDDESYS_ITEM_HELP = "Help";

		public const string SZDDESYS_ITEM_RTNMSG = "ReturnMessage";

		public const string SZDDESYS_ITEM_STATUS = "Status";

		public const string SZDDESYS_ITEM_SYSITEMS = "SysItems";

		public const string SZDDESYS_ITEM_TOPICS = "Topics";

		public const string SZDDESYS_TOPIC = "System";

		public const string SZDDE_ITEM_ITEMLIST = "TopicItemList";

		public IntPtr HWND_BOTTOM
		{
			get
			{
				return (IntPtr)1;
			}
		}

		public IntPtr HWND_BROADCAST
		{
			get
			{
				return (IntPtr)65535;
			}
		}

		public IntPtr HWND_DESKTOP
		{
			get
			{
				return (IntPtr)0;
			}
		}

		public IntPtr HWND_TOP
		{
			get
			{
				return (IntPtr)0;
			}
		}

		public IntPtr HWND_NOTOPMOST
		{
			get
			{
				return (IntPtr)(-2);
			}
		}

		public IntPtr HWND_TOPMOST
		{
			get
			{
				return (IntPtr)(-2);
			}
		}

		[DllImport("advapi32")]
		public static extern int SetServiceBits(IntPtr hServiceStatus, int dwServiceBits, int bSetBitsOn, int bUpdateImmediately);

		[DllImport("kernel32")]
		public static extern int SetSystemTimeAdjustment(int dwTimeAdjustment, int bTimeAdjustmentDisabled);

		[DllImport("mpr")]
		public static extern int WNetGetUniversalName(string lpLocalPath, int dwInfoLevel, StringBuilder lpBuffer, ref int lpBufferSize);

		[DllImport("user32")]
		public static extern int ActivateKeyboardLayout(IntPtr hKL, int flags);

		[DllImport("user32")]
		public static extern int AdjustWindowRect(ref RECT lpRect, int dwStyle, int bMenu);

		[DllImport("user32")]
		public static extern int AdjustWindowRectEx(ref RECT lpRect, int dsStyle, int bMenu, int dwEsStyle);

		[DllImport("user32")]
		public static extern int AnyPopup();

		[DllImport("user32")]
		public static extern int AppendMenu(IntPtr hMenu, int wFlags, int wIDNewItem, IntPtr lpNewItem);

		[DllImport("user32")]
		public static extern int ArrangeIconicWindows(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int AttachThreadInput(int idAttach, int idAttachTo, int fAttach);

		[DllImport("user32")]
		public static extern int BeginDeferWindowPos(int nNumWindows);

		[DllImport("user32")]
		public static extern int BeginPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

		[DllImport("user32")]
		public static extern int BringWindowToTop(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int BroadcastSystemMessage(int dw, ref int pdw, int un, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int CallMsgFilter(ref MSG lpMsg, int ncode);

		[DllImport("user32")]
		public static extern int CallNextHookEx(IntPtr hHook, int ncode, int wParam, IntPtr lParam);

		[DllImport("user32")]
		public static extern int CallWindowProc(int lpPrevWndFunc, IntPtr hwnd, int Msg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int ChangeClipboardChain(IntPtr hwnd, IntPtr hwndNext);

		[DllImport("user32")]
		public static extern int ChangeMenu(IntPtr hMenu, int cmd, string lpszNewItem, int cmdInsert, int flags);

		[DllImport("user32")]
		public static extern int CharLowerBuff(string lpsz, int cchLength);

		[DllImport("user32")]
		public static extern int CharToOem(string lpszSrc, string lpszDst);

		[DllImport("user32")]
		public static extern int CharToOemBuff(string lpszSrc, string lpszDst, int cchDstLength);

		[DllImport("user32")]
		public static extern int CharUpperBuff(string lpsz, int cchLength);

		[DllImport("user32")]
		public static extern int CheckDlgButton(IntPtr hDlg, int nIDButton, int wCheck);

		[DllImport("user32")]
		public static extern int CheckMenuItem(IntPtr hMenu, int wIDCheckItem, int wCheck);

		[DllImport("user32")]
		public static extern int CheckMenuRadioItem(IntPtr hMenu, int un1, int un2, int un3, int un4);

		[DllImport("user32")]
		public static extern int CheckRadioButton(IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

		[DllImport("user32")]
		public static extern int ChildWindowFromPoint(IntPtr hwnd, int xPoint, int yPoint);

		[DllImport("user32")]
		public static extern int ChildWindowFromPointEx(IntPtr hwnd, int xPoint, int yPoint, int un);

		[DllImport("user32")]
		public static extern int ClientToScreen(IntPtr hwnd, ref POINT lpPoint);

		[DllImport("user32")]
		public static extern int ClipCursor(ref RECT lpRect);

		[DllImport("user32")]
		public static extern int CloseClipboard();

		[DllImport("user32")]
		public static extern int CloseDesktop(IntPtr hDesktop);

		[DllImport("user32")]
		public static extern int CloseWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int CloseWindowStation(IntPtr hWinSta);

		[DllImport("user32")]
		public static extern int CopyAcceleratorTable(IntPtr hAccelSrc, ACCEL[] lpAccelDst, int cAccelEntries);

		[DllImport("user32")]
		public static extern int CopyCursor(IntPtr hcur);

		[DllImport("user32")]
		public static extern int CopyIcon(IntPtr hIcon);

		[DllImport("user32")]
		public static extern int CopyImage(IntPtr handle, int un1, int n1, int n2, int un2);

		[DllImport("user32")]
		public static extern int CopyRect(ref RECT lpDestRect, ref RECT lpSourceRect);

		[DllImport("user32")]
		public static extern int CountClipboardFormats();

		[DllImport("user32")]
		public static extern int CreateAcceleratorTable(ref ACCEL lpaccl, int cEntries);

		[DllImport("user32")]
		public static extern int CreateCaret(IntPtr hwnd, IntPtr hBitmap, int nWidth, int nHeight);

		[DllImport("user32")]
		public static extern int CreateCursor(IntPtr hInstance, int nXhotspot, int nYhotspot, int nWidth, int nHeight, IntPtr lpANDbitPlane, IntPtr lpXORbitPlane);

		[DllImport("user32")]
		public static extern int CreateDesktop(string lpszDesktop, string lpszDevice, ref DEVMODE pDevmode, int dwFlags, int dwDesiredAccess, ref SECURITY_ATTRIBUTES lpsa);

		[DllImport("user32")]
		public static extern int CreateDialogIndirectParam(IntPtr hInstance, ref DLGTEMPLATE lpTemplate, IntPtr hwndParent, ref int lpDialogFunc, int dwInitParam);

		[DllImport("user32")]
		public static extern int CreateDialogParam(IntPtr hInstance, string lpName, IntPtr hwndParent, ref int lpDialogFunc, int lParamInit);

		[DllImport("user32")]
		public static extern int CreateIcon(IntPtr hInstance, int nWidth, int nHeight, byte nPlanes, byte nBitsPixel, byte lpANDbits, byte lpXORbits);

		[DllImport("user32")]
		public static extern int CreateIconFromResource(byte presbits, int dwResSize, int fIcon, int dwVer);

		[DllImport("user32")]
		public static extern int CreateIconIndirect(ref ICONINFO piconinfo);

		[DllImport("user32")]
		public static extern int CreateMDIWindow(string lpClassName, string lpWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hwndParent, IntPtr hInstance, int lParam);

		[DllImport("user32")]
		public static extern int CreateMenu();

		[DllImport("user32")]
		public static extern int CreatePopupMenu();

		[DllImport("user32")]
		public static extern int CreateWindowEx(int dwExStyle, string lpClassName, string lpWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hwndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

		[DllImport("user32")]
		public static extern int DdeAbandonTransaction(int idInst, IntPtr hConv, int idTransaction);

		[DllImport("user32")]
		public static extern int DdeAccessData(IntPtr hData, ref int pcbDataSize);

		[DllImport("user32")]
		public static extern int DdeAddData(IntPtr hData, byte pSrc, int cb, int cbOff);

		[DllImport("user32")]
		public static extern int DdeClientTransaction(byte pData, int cbData, IntPtr hConv, IntPtr hszItem, int wFmt, int wType, int dwTimeout, ref int pdwResult);

		[DllImport("user32")]
		public static extern int DdeCmpStringHandles(IntPtr hsz1, IntPtr hsz2);

		[DllImport("user32")]
		public static extern int DdeConnect(int idInst, IntPtr hszService, IntPtr hszTopic, ref CONVCONTEXT pCC);

		[DllImport("user32")]
		public static extern int DdeConnectList(int idInst, IntPtr hszService, IntPtr hszTopic, IntPtr hConvList, ref CONVCONTEXT pCC);

		[DllImport("user32")]
		public static extern int DdeCreateDataHandle(int idInst, byte pSrc, int cb, int cbOff, IntPtr hszItem, int wFmt, int afCmd);

		[DllImport("user32")]
		public static extern int DdeCreateStringHandle(int idInst, string psz, int iCodePage);

		[DllImport("user32")]
		public static extern int DdeDisconnect(IntPtr hConv);

		[DllImport("user32")]
		public static extern int DdeDisconnectList(IntPtr hConvList);

		[DllImport("user32")]
		public static extern int DdeEnableCallback(int idInst, IntPtr hConv, int wCmd);

		[DllImport("user32")]
		public static extern int DdeFreeDataHandle(IntPtr hData);

		[DllImport("user32")]
		public static extern int DdeFreeStringHandle(int idInst, IntPtr hsz);

		[DllImport("user32")]
		public static extern int DdeGetData(IntPtr hData, byte pDst, int cbMax, int cbOff);

		[DllImport("user32")]
		public static extern int DdeGetLastError(int idInst);

		[DllImport("user32")]
		public static extern int DdeImpersonateClient(IntPtr hConv);

		[DllImport("user32")]
		public static extern int DdeKeepStringHandle(int idInst, IntPtr hsz);

		[DllImport("user32")]
		public static extern int DdeNameService(int idInst, IntPtr hsz1, IntPtr hsz2, int afCmd);

		[DllImport("user32")]
		public static extern int DdePostAdvise(int idInst, IntPtr hszTopic, IntPtr hszItem);

		[DllImport("user32")]
		public static extern int DdeQueryConvInfo(IntPtr hConv, int idTransaction, ref CONVINFO pConvInfo);

		[DllImport("user32")]
		public static extern int DdeQueryNextServer(IntPtr hConvList, IntPtr hConvPrev);

		[DllImport("user32")]
		public static extern int DdeQueryString(int idInst, IntPtr hsz, string psz, int cchMax, int iCodePage);

		[DllImport("user32")]
		public static extern int DdeReconnect(IntPtr hConv);

		[DllImport("user32")]
		public static extern int DdeSetQualityOfService(IntPtr hwndClient, ref SECURITY_QUALITY_OF_SERVICE pqosNew, ref SECURITY_QUALITY_OF_SERVICE pqosPrev);

		[DllImport("user32")]
		public static extern int DdeSetUserHandle(IntPtr hConv, int id, IntPtr hUser);

		[DllImport("user32")]
		public static extern int DdeUnaccessData(IntPtr hData);

		[DllImport("user32")]
		public static extern int DdeUninitialize(int idInst);

		[DllImport("user32")]
		public static extern int DefDlgProc(IntPtr hDlg, int wMsg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int DefFrameProc(IntPtr hwnd, IntPtr hwndMDIClient, int wMsg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int DefMDIChildProc(IntPtr hwnd, int wMsg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int DefWindowProc(IntPtr hwnd, int wMsg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int DeferWindowPos(IntPtr hWinPosInfo, IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy, int wFlags);

		[DllImport("user32")]
		public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

		[DllImport("user32")]
		public static extern int DestroyAcceleratorTable(IntPtr haccel);

		[DllImport("user32")]
		public static extern int DestroyCaret();

		[DllImport("user32")]
		public static extern int DestroyCursor(IntPtr hCursor);

		[DllImport("user32")]
		public static extern int DestroyIcon(IntPtr hIcon);

		[DllImport("user32")]
		public static extern int DestroyMenu(IntPtr hMenu);

		[DllImport("user32")]
		public static extern int DestroyWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int DialogBoxIndirectParam(IntPtr hInstance, DLGTEMPLATE hDialogTemplate, IntPtr hwndParent, ref int lpDialogFunc, int dwInitParam);

		[DllImport("user32")]
		public static extern int DispatchMessage(ref MSG lpMsg);

		[DllImport("user32")]
		public static extern int DlgDirList(IntPtr hDlg, string lpPathSpec, int nIDListBox, int nIDStaticPath, int wFileType);

		[DllImport("user32")]
		public static extern int DlgDirListComboBox(IntPtr hDlg, string lpPathSpec, int nIDComboBox, int nIDStaticPath, int wFileType);

		[DllImport("user32")]
		public static extern int DlgDirSelectComboBoxEx(IntPtr hwndDlg, string lpszPath, int cbPath, int idComboBox);

		[DllImport("user32")]
		public static extern int DlgDirSelectEx(IntPtr hwndDlg, string lpszPath, int cbPath, int idListBox);

		[DllImport("user32")]
		public static extern int DragDetect(IntPtr hwnd, POINT pt);

		[DllImport("user32")]
		public static extern int DragObject(IntPtr hwnd1, IntPtr hwnd2, int un, int dw, IntPtr hCursor);

		[DllImport("user32")]
		public static extern int DrawAnimatedRects(IntPtr hwnd, int idAni, ref RECT lprcFrom, ref RECT lprcTo);

		[DllImport("user32")]
		public static extern int DrawCaption(IntPtr hwnd, IntPtr hdc, ref RECT pcRect, int un);

		[DllImport("user32")]
		public static extern int DrawEdge(IntPtr hdc, ref RECT qrc, int edge, int grfFlags);

		[DllImport("user32")]
		public static extern int DrawFocusRect(IntPtr hdc, ref RECT lpRect);

		[DllImport("user32")]
		public static extern int DrawFrameControl(IntPtr hdc, ref RECT lpRect, int un1, int un2);

		[DllImport("user32")]
		public static extern int DrawIcon(IntPtr hdc, int x, int y, IntPtr hIcon);

		[DllImport("user32")]
		public static extern int DrawIconEx(IntPtr hdc, int xLeft, int yTop, IntPtr hIcon, int cxWidth, int cyWidth, int istepIfAniCur, IntPtr hbrFlickerFreeDraw, int diFlags);

		[DllImport("user32")]
		public static extern int DrawMenuBar(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int DrawState(IntPtr hdc, IntPtr hBrush, ref int lpDrawStateProc, int lParam, int wParam, int n1, int n2, int n3, int n4, int un);

		[DllImport("user32")]
		public static extern int DrawText(IntPtr hdc, string lpStr, int nCount, ref RECT lpRect, int wFormat);

		[DllImport("user32")]
		public static extern int DrawTextEx(IntPtr hdc, string lpsz, int n, ref RECT lpRect, int un, ref DRAWTEXTPARAMS lpDrawTextParams);

		[DllImport("user32")]
		public static extern int EmptyClipboard();

		[DllImport("user32")]
		public static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);

		[DllImport("user32")]
		public static extern int EnableScrollBar(IntPtr hwnd, int wSBflags, int wArrows);

		[DllImport("user32")]
		public static extern int EnableWindow(IntPtr hwnd, int fEnable);

		[DllImport("user32")]
		public static extern int EndDeferWindowPos(IntPtr hWinPosInfo);

		[DllImport("user32")]
		public static extern int EndDialog(IntPtr hDlg, int nResult);

		[DllImport("user32")]
		public static extern int EndPaint(IntPtr hwnd, ref PAINTSTRUCT lpPaint);

		[DllImport("user32")]
		public static extern int EnumChildWindows(IntPtr hwndParent, ref int lpEnumFunc, int lParam);

		[DllImport("user32")]
		public static extern int EnumClipboardFormats(int wFormat);

		[DllImport("user32")]
		public static extern int EnumDesktopWindows(IntPtr hDesktop, ref int lpfn, int lParam);

		[DllImport("user32")]
		public static extern int EnumDesktops(IntPtr hwinsta, ref int lpEnumFunc, int lParam);

		[DllImport("user32")]
		public static extern int EnumProps(IntPtr hwnd, ref int lpEnumFunc);

		[DllImport("user32")]
		public static extern int EnumPropsEx(IntPtr hwnd, ref int lpEnumFunc, int lParam);

		[DllImport("user32")]
		public static extern int EnumThreadWindows(int dwThreadId, ref int lpfn, int lParam);

		[DllImport("user32")]
		public static extern int EnumWindowStations(int lpEnumFunc, int lParam);

		[DllImport("user32")]
		public static extern int EnumWindows(int lpEnumFunc, int lParam);

		[DllImport("user32")]
		public static extern int EqualRect(ref RECT lpRect1, ref RECT lpRect2);

		[DllImport("user32")]
		public static extern int ExcludeUpdateRgn(IntPtr hdc, IntPtr hwnd);

		[DllImport("user32")]
		public static extern int ExitWindows(int dwReserved, int uReturnCode);

		[DllImport("user32")]
		public static extern int ExitWindowsEx(int uFlags, int dwReserved);

		[DllImport("user32")]
		public static extern int FillRect(IntPtr hdc, ref RECT lpRect, IntPtr hBrush);

		[DllImport("user32")]
		public static extern int FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32")]
		public static extern int FindWindowEx(IntPtr hwnd1, IntPtr hwnd2, string lpsz1, string lpsz2);

		[DllImport("user32")]
		public static extern int FlashWindow(IntPtr hwnd, int bInvert);

		[DllImport("user32")]
		public static extern int FrameRect(IntPtr hdc, ref RECT lpRect, IntPtr hBrush);

		[DllImport("user32")]
		public static extern int FreeDDElParam(int msg, int lParam);

		[DllImport("user32")]
		public static extern int GetActiveWindow();

		[DllImport("user32")]
		public static extern int GetCapture();

		[DllImport("user32")]
		public static extern int GetCaretBlinkTime();

		[DllImport("user32")]
		public static extern int GetCaretPos(ref POINT lpPoint);

		[DllImport("user32")]
		public static extern int GetClassInfo(IntPtr hInstance, string lpClassName, out WNDCLASS lpWndClass);

		[DllImport("user32")]
		public static extern int GetClassLong(IntPtr hwnd, int nIndex);

		[DllImport("user32")]
		public static extern int GetClassName(IntPtr hwnd, string lpClassName, int nMaxCount);

		[DllImport("user32")]
		public static extern int GetClassWord(IntPtr hwnd, int nIndex);

		[DllImport("user32")]
		public static extern int GetClientRect(IntPtr hwnd, ref RECT lpRect);

		[DllImport("user32")]
		public static extern int GetClipCursor(out RECT lprc);

		[DllImport("user32")]
		public static extern int GetClipboardData(int wFormat);

		[DllImport("user32")]
		public static extern int GetClipboardFormatName(int wFormat, string lpString, int nMaxCount);

		[DllImport("user32")]
		public static extern int GetClipboardOwner();

		[DllImport("user32")]
		public static extern int GetClipboardViewer();

		[DllImport("user32")]
		public static extern int GetCursor();

		[DllImport("user32")]
		public static extern int GetCursorPos(out POINT lpPoint);

		[DllImport("user32")]
		public static extern int GetDC(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetDCEx(IntPtr hwnd, IntPtr hrgnclip, int fdwOptions);

		[DllImport("user32")]
		public static extern int GetDesktopWindow();

		[DllImport("user32")]
		public static extern int GetDialogBaseUnits();

		[DllImport("user32")]
		public static extern int GetDlgCtrlID(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetDlgItem(IntPtr hDlg, int nIDDlgItem);

		[DllImport("user32")]
		public static extern int GetDlgItemInt(IntPtr hDlg, int nIDDlgItem, ref int lpTranslated, int bSigned);

		[DllImport("user32")]
		public static extern int GetDlgItemText(IntPtr hDlg, int nIDDlgItem, StringBuilder lpString, int nMaxCount);

		[DllImport("user32")]
		public static extern int GetDoubleClickTime();

		[DllImport("user32")]
		public static extern int GetFocus();

		[DllImport("user32")]
		public static extern int GetForegroundWindow();

		[DllImport("user32")]
		public static extern int GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

		[DllImport("user32")]
		public static extern int GetInputState();

		[DllImport("user32")]
		public static extern int GetKBCodePage();

		[DllImport("user32")]
		public static extern int GetKeyNameText(int lParam, StringBuilder lpBuffer, int nSize);

		[DllImport("user32")]
		public static extern int GetKeyboardLayout(int dwLayout);

		[DllImport("user32")]
		public static extern int GetKeyboardLayoutList(int nBuff, ref int lpList);

		[DllImport("user32")]
		public static extern int GetKeyboardLayoutName(string pwszKLID);

		[DllImport("user32")]
		public static extern int GetKeyboardState(byte pbKeyState);

		[DllImport("user32")]
		public static extern int GetKeyboardType(int nTypeFlag);

		[DllImport("user32")]
		public static extern int GetLastActivePopup(IntPtr hwndOwnder);

		[DllImport("user32")]
		public static extern int GetMenu(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetMenuCheckMarkDimensions();

		[DllImport("user32")]
		public static extern int GetMenuContextHelpId(IntPtr hMenu);

		[DllImport("user32")]
		public static extern int GetMenuDefaultItem(IntPtr hMenu, int fByPos, int gmdiFlags);

		[DllImport("user32")]
		public static extern int GetMenuItemCount(IntPtr hMenu);

		[DllImport("user32")]
		public static extern int GetMenuItemID(IntPtr hMenu, int nPos);

		[DllImport("user32")]
		public static extern int GetMenuItemInfo(IntPtr hMenu, int un, int b, ref MENUITEMINFO lpMenuItemInfo);

		[DllImport("user32")]
		public static extern int GetMenuItemRect(IntPtr hwnd, IntPtr hMenu, int uItem, ref RECT lprcItem);

		[DllImport("user32")]
		public static extern int GetMenuState(IntPtr hMenu, int wID, int wFlags);

		[DllImport("user32")]
		public static extern int GetMenuString(IntPtr hMenu, int wIDItem, StringBuilder lpString, int nMaxCount, int wFlag);

		[DllImport("user32")]
		public static extern int GetMessage(ref MSG lpMsg, IntPtr hwnd, int wMsgFilterMin, int wMsgFilterMax);

		[DllImport("user32")]
		public static extern int GetMessageExtraInfo();

		[DllImport("user32")]
		public static extern int GetMessagePos();

		[DllImport("user32")]
		public static extern int GetMessageTime();

		[DllImport("user32")]
		public static extern int GetNextDlgGroupItem(IntPtr hDlg, IntPtr hCtl, int bPrevious);

		[DllImport("user32")]
		public static extern int GetNextDlgTabItem(IntPtr hDlg, IntPtr hCtl, int bPrevious);

		[DllImport("user32")]
		public static extern int GetNextWindow(IntPtr hwnd, int wFlag);

		[DllImport("user32")]
		public static extern int GetOpenClipboardWindow();

		[DllImport("user32")]
		public static extern int GetParent(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetPriorityClipboardFormat(int lpPriorityList, int nCount);

		[DllImport("user32")]
		public static extern int GetProcessWindowStation();

		[DllImport("user32")]
		public static extern int GetProp(IntPtr hwnd, string lpString);

		[DllImport("user32")]
		public static extern int GetQueueStatus(int fuFlags);

		[DllImport("user32")]
		public static extern int GetScrollInfo(IntPtr hwnd, int n, ref SCROLLINFO lpScrollInfo);

		[DllImport("user32")]
		public static extern int GetScrollPos(IntPtr hwnd, int nBar);

		[DllImport("user32")]
		public static extern int GetScrollRange(IntPtr hwnd, int nBar, ref int lpMinPos, ref int lpMaxPos);

		[DllImport("user32")]
		public static extern int GetSubMenu(IntPtr hMenu, int nPos);

		[DllImport("user32")]
		public static extern int GetSysColor(int nIndex);

		[DllImport("user32")]
		public static extern int GetSysColorBrush(int nIndex);

		[DllImport("user32")]
		public static extern int GetSystemMenu(IntPtr hwnd, int bRevert);

		[DllImport("user32")]
		public static extern int GetSystemMetrics(int nIndex);

		[DllImport("user32")]
		public static extern int GetTabbedTextExtent(IntPtr hdc, string lpString, int nCount, int nTabPositions, ref int lpnTabStopPositions);

		[DllImport("user32")]
		public static extern int GetThreadDesktop(int dwThread);

		[DllImport("user32")]
		public static extern int GetTopWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetUpdateRect(IntPtr hwnd, ref RECT lpRect, int bErase);

		[DllImport("user32")]
		public static extern int GetUpdateRgn(IntPtr hwnd, IntPtr hRgn, int fErase);

		[DllImport("user32")]
		public static extern int GetUserObjectInformation(IntPtr hObj, int nIndex, IntPtr pvInfo, int nLength, ref int lpnLengthNeeded);

		[DllImport("user32")]
		public static extern int GetUserObjectSecurity(IntPtr hObj, ref int pSIRequested, ref SECURITY_DESCRIPTOR pSd, int nLength, ref int lpnLengthNeeded);

		[DllImport("user32")]
		public static extern int GetWindow(IntPtr hwnd, int wCmd);

		[DllImport("user32")]
		public static extern int GetWindowContextHelpId(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetWindowDC(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetWindowLong(IntPtr hwnd, int nIndex);

		[DllImport("user32")]
		public static extern int GetWindowPlacement(IntPtr hwnd, ref WINDOWPLACEMENT lpwndpl);

		[DllImport("user32")]
		public static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);

		[DllImport("user32")]
		public static extern int GetWindowRgn(IntPtr hwnd, IntPtr hRgn);

		[DllImport("user32")]
		public static extern int GetWindowText(IntPtr hwnd, StringBuilder lpString, int cch);

		[DllImport("user32")]
		public static extern int GetWindowTextLength(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessId);

		[DllImport("user32")]
		public static extern int GrayString(IntPtr hdc, IntPtr hBrush, ref int lpOutputFunc, ref int lpData, int nCount, int X, int Y, int nWidth, int nHeight);

		[DllImport("user32")]
		public static extern int HideCaret(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int HiliteMenuItem(IntPtr hwnd, IntPtr hMenu, int wIDHiliteItem, int wHilite);

		[DllImport("user32")]
		public static extern int ImpersonateDdeClientWindow(IntPtr hwndClient, IntPtr hwndServer);

		[DllImport("user32")]
		public static extern int InSendMessage();

		[DllImport("user32")]
		public static extern int InflateRect(ref RECT lpRect, int x, int y);

		[DllImport("user32")]
		public static extern int InsertMenu(IntPtr hMenu, int nPosition, int wFlags, int wIDNewItem, IntPtr lpNewItem);

		[DllImport("user32")]
		public static extern int InsertMenuItem(IntPtr hMenu, int un, bool b, ref MENUITEMINFO lpcMenuItemInfo);

		[DllImport("user32")]
		public static extern int IntersectRect(ref RECT lpDestRect, ref RECT lpSrc1Rect, ref RECT lpSrc2Rect);

		[DllImport("user32")]
		public static extern int InvalidateRect(IntPtr hwnd, ref RECT lpRect, int bErase);

		[DllImport("user32")]
		public static extern int InvalidateRgn(IntPtr hwnd, IntPtr hRgn, int bErase);

		[DllImport("user32")]
		public static extern int InvertRect(IntPtr hdc, ref RECT lpRect);

		[DllImport("user32")]
		public static extern int IsCharAlpha(byte cChar);

		[DllImport("user32")]
		public static extern int IsCharAlphaNumeric(byte cChar);

		[DllImport("user32")]
		public static extern int IsCharLower(byte cChar);

		[DllImport("user32")]
		public static extern int IsCharUpper(byte cChar);

		[DllImport("user32")]
		public static extern int IsChild(IntPtr hwndParent, IntPtr hwnd);

		[DllImport("user32")]
		public static extern int IsClipboardFormatAvailable(int wFormat);

		[DllImport("user32")]
		public static extern int IsDialogMessage(IntPtr hDlg, ref MSG lpMsg);

		[DllImport("user32")]
		public static extern int IsDlgButtonChecked(IntPtr hDlg, int nIDButton);

		[DllImport("user32")]
		public static extern int IsIconic(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int IsMenu(IntPtr hMenu);

		[DllImport("user32")]
		public static extern int IsRectEmpty(ref RECT lpRect);

		[DllImport("user32")]
		public static extern int IsWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int IsWindowEnabled(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int IsWindowUnicode(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int IsWindowVisible(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int IsZoomed(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int KillTimer(IntPtr hwnd, int nIDEvent);

		[DllImport("user32")]
		public static extern int LoadAccelerators(IntPtr hInstance, string lpTableName);

		[DllImport("user32")]
		public static extern int LoadBitmap(IntPtr hInstance, string lpBitmapName);

		[DllImport("user32")]
		public static extern int LoadCursor(IntPtr hInstance, string lpCursorName);

		[DllImport("user32")]
		public static extern int LoadCursorFromFile(string lpFileName);

		[DllImport("user32")]
		public static extern int LoadIcon(IntPtr hInstance, string lpIconName);

		[DllImport("user32")]
		public static extern int LoadImage(IntPtr hInst, string lpsz, int un1, int n1, int n2, int un2);

		[DllImport("user32")]
		public static extern int LoadKeyboardLayout(string pwszKLID, int flags);

		[DllImport("user32")]
		public static extern int LoadMenu(IntPtr hInstance, string lpString);

		[DllImport("user32")]
		public static extern int LoadMenuIndirect(int lpMenuTemplate);

		[DllImport("user32")]
		public static extern int LoadString(IntPtr hInstance, int wID, string lpBuffer, int nBufferMax);

		[DllImport("user32")]
		public static extern int LockWindowUpdate(IntPtr hwndLock);

		[DllImport("user32")]
		public static extern int LookupIconIdFromDirectory(byte presbits, int fIcon);

		[DllImport("user32")]
		public static extern int LookupIconIdFromDirectoryEx(byte presbits, int fIcon, int cxDesired, int cyDesired, int Flags);

		[DllImport("user32")]
		public static extern int MapDialogRect(IntPtr hDlg, ref RECT lpRect);

		[DllImport("user32")]
		public static extern int MapVirtualKey(int wCode, int wMapType);

		[DllImport("user32")]
		public static extern int MapVirtualKeyEx(int uCode, int uMapType, int dwhkl);

		[DllImport("user32")]
		public static extern int MapWindowPoints(IntPtr hwndFrom, IntPtr hwndTo, POINT[] lppt, int cPoints);

		[DllImport("user32")]
		public static extern int MenuItemFromPoint(IntPtr hwnd, IntPtr hMenu, POINT ptScreen);

		[DllImport("user32")]
		public static extern int MessageBeep(int wType);

		[DllImport("user32")]
		public static extern int MessageBox(IntPtr hwnd, string lpText, string lpCaption, int wType);

		[DllImport("user32")]
		public static extern int MessageBoxEx(IntPtr hwnd, string lpText, string lpCaption, int uType, int wLanguageId);

		[DllImport("user32")]
		public static extern int MessageBoxIndirect(ref MSGBOXPARAMS lpMsgBoxParams);

		[DllImport("user32")]
		public static extern int ModifyMenu(IntPtr hMenu, int nPosition, int wFlags, int wIDNewItem, IntPtr lpString);

		[DllImport("user32")]
		public static extern int MoveWindow(IntPtr hwnd, int x, int y, int nWidth, int nHeight, int bRepaint);

		[DllImport("user32")]
		public static extern int MsgWaitForMultipleObjects(int nCount, ref int pHandles, int fWaitAll, int dwMilliseconds, int dwWakeMask);

		[DllImport("user32")]
		public static extern int OemKeyScan(int wOemChar);

		[DllImport("user32")]
		public static extern int OemToChar(string lpszSrc, string lpszDst);

		[DllImport("user32")]
		public static extern int OemToCharBuff(string lpszSrc, string lpszDst, int cchDstLength);

		[DllImport("user32")]
		public static extern int OffsetRect(ref RECT lpRect, int x, int y);

		[DllImport("user32")]
		public static extern int OpenClipboard(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int OpenDesktop(string lpszDesktop, int dwFlags, int fInherit, int dwDesiredAccess);

		[DllImport("user32")]
		public static extern int OpenIcon(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int OpenInputDesktop(int dwFlags, int fInherit, int dwDesiredAccess);

		[DllImport("user32")]
		public static extern int OpenWindowStation(string lpszWinSta, int fInherit, int dwDesiredAccess);

		[DllImport("user32")]
		public static extern int PackDDElParam(int msg, int uiLo, int uiHi);

		[DllImport("user32")]
		public static extern int PaintDesktop(IntPtr hdc);

		[DllImport("user32")]
		public static extern int PeekMessage(ref MSG lpMsg, IntPtr hwnd, int wMsgFilterMin, int wMsgFilterMax, int wRemoveMsg);

		[DllImport("user32")]
		public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int PostThreadMessage(int idThread, int msg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int PtInRect(ref RECT lpRect, int ptX, int ptY);

		[DllImport("user32")]
		public static extern int RedrawWindow(IntPtr hwnd, ref RECT lprcUpdate, IntPtr hrgnUpdate, int fuRedraw);

		[DllImport("user32")]
		public static extern int RegisterClass(ref WNDCLASS Class);

		[DllImport("user32")]
		public static extern int RegisterClipboardFormat(string lpString);

		[DllImport("user32")]
		public static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

		[DllImport("user32")]
		public static extern int RegisterWindowMessage(string lpString);

		[DllImport("user32")]
		public static extern int ReleaseCapture();

		[DllImport("user32")]
		public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

		[DllImport("user32")]
		public static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

		[DllImport("user32")]
		public static extern int RemoveProp(IntPtr hwnd, string lpString);

		[DllImport("user32")]
		public static extern int ReplyMessage(int lReply);

		[DllImport("user32")]
		public static extern int ReuseDDElParam(int lParam, int msgIn, int msgOut, int uiLo, int uiHi);

		[DllImport("user32")]
		public static extern int ScreenToClient(IntPtr hwnd, ref POINT lpPoint);

		[DllImport("user32")]
		public static extern int ScrollDC(IntPtr hdc, int dx, int dy, ref RECT lprcScroll, ref RECT lprcClip, IntPtr hrgnUpdate, ref RECT lprcUpdate);

		[DllImport("user32")]
		public static extern int ScrollWindow(IntPtr hwnd, int XAmount, int YAmount, ref RECT lpRect, ref RECT lpClipRect);

		[DllImport("user32")]
		public static extern int ScrollWindowEx(IntPtr hwnd, int dx, int dy, ref RECT lprcScroll, ref RECT lprcClip, IntPtr hrgnUpdate, ref RECT lprcUpdate, int fuScroll);

		[DllImport("user32")]
		public static extern int SendDlgItemMessage(IntPtr hDlg, int nIDDlgItem, int wMsg, int wParam, int lParam);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SendMessage(HandleRef hWnd, int wMsg, int wParam, int lParam);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int SendMessage(HandleRef hWnd, int wMsg, int wParam, ref CHARFORMAT2 lParam);

		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int wMsg, IntPtr wParam, ref CHARFORMAT2 lParam);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, ref CHARFORMAT2 lParam);

		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, ref CHARFORMAT2 lParam);

		[DllImport("user32")]
		public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, ref RECT lParam);

		[DllImport("user32")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, ref RECT lParam);

		[DllImport("user32")]
		public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, ref POINT lParam);

		[DllImport("user32")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, ref POINT lParam);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, StringBuilder lParam);

		[DllImport("user32")]
		public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

		[DllImport("user32")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

		[DllImport("user32")]
		public static extern int SendMessageW(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

		[DllImport("user32")]
		public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, string strMessage, string strCaption, uint uiType);

		[DllImport("user32")]
		public static extern int SendMessageCallback(IntPtr hwnd, int wMsg, int wParam, int lParam, ref int lpResultCallBack, int dwData);

		[DllImport("user32")]
		public static extern int SendMessageTimeout(IntPtr hwnd, int wMsg, int wParam, int lParam, int fuFlags, int uTimeout, ref int lpdwResult);

		[DllImport("user32")]
		public static extern int SendNotifyMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern int SetActiveWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int SetCapture(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int SetCaretBlinkTime(int wMSeconds);

		[DllImport("user32")]
		public static extern int SetCaretPos(int x, int y);

		[DllImport("user32")]
		public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);

		[DllImport("user32")]
		public static extern int SetClassWord(IntPtr hwnd, int nIndex, int wNewWord);

		[DllImport("user32")]
		public static extern int SetClipboardData(int wFormat, IntPtr hMem);

		[DllImport("user32")]
		public static extern int SetClipboardViewer(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int SetCursor(IntPtr hCursor);

		[DllImport("user32")]
		public static extern int SetCursorPos(int x, int y);

		[DllImport("user32")]
		public static extern int SetDlgItemInt(IntPtr hDlg, int nIDDlgItem, int wValue, int bSigned);

		[DllImport("user32")]
		public static extern int SetDlgItemText(IntPtr hDlg, int nIDDlgItem, string lpString);

		[DllImport("user32")]
		public static extern int SetDoubleClickTime(int wCount);

		[DllImport("user32")]
		public static extern int SetFocus(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int SetForegroundWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int SetKeyboardState(byte lppbKeyState);

		[DllImport("user32")]
		public static extern int SetMenu(IntPtr hwnd, IntPtr hMenu);

		[DllImport("user32")]
		public static extern int SetMenuContextHelpId(IntPtr hMenu, int dw);

		[DllImport("user32")]
		public static extern int SetMenuDefaultItem(IntPtr hMenu, int uItem, int fByPos);

		[DllImport("user32")]
		public static extern int SetMenuItemBitmaps(IntPtr hMenu, int nPosition, int wFlags, IntPtr hBitmapUnchecked, IntPtr hBitmapChecked);

		[DllImport("user32")]
		public static extern int SetMenuItemInfo(IntPtr hMenu, int un, bool b, ref MENUITEMINFO lpcMenuItemInfo);

		[DllImport("user32")]
		public static extern int SetMessageExtraInfo(int lParam);

		[DllImport("user32")]
		public static extern int SetMessageQueue(int cMessagesMax);

		[DllImport("user32")]
		public static extern int SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

		[DllImport("user32")]
		public static extern int SetProcessWindowStation(IntPtr hWinSta);

		[DllImport("user32")]
		public static extern int SetProp(IntPtr hwnd, string lpString, IntPtr hData);

		[DllImport("user32")]
		public static extern int SetRect(ref RECT lpRect, int X1, int Y1, int X2, int Y2);

		[DllImport("user32")]
		public static extern int SetRectEmpty(ref RECT lpRect);

		[DllImport("user32")]
		public static extern int SetScrollInfo(IntPtr hwnd, int n, ref SCROLLINFO lpcScrollInfo, bool redraw);

		[DllImport("user32")]
		public static extern int SetScrollPos(IntPtr hwnd, int nBar, int nPos, int bRedraw);

		[DllImport("user32")]
		public static extern int SetScrollRange(IntPtr hwnd, int nBar, int nMinPos, int nMaxPos, int bRedraw);

		[DllImport("user32")]
		public static extern int SetSysColors(int nChanges, ref int lpSysColor, ref int lpColorValues);

		[DllImport("user32")]
		public static extern int SetSystemCursor(IntPtr hcur, int id);

		[DllImport("user32")]
		public static extern int SetThreadDesktop(IntPtr hDesktop);

		[DllImport("user32")]
		public static extern int SetTimer(IntPtr hwnd, int nIDEvent, int uElapse, ref int lpTimerFunc);

		[DllImport("user32")]
		public static extern int SetUserObjectInformation(IntPtr hObj, int nIndex, IntPtr pvInfo, int nLength);

		[DllImport("user32")]
		public static extern int SetUserObjectSecurity(IntPtr hObj, ref int pSIRequested, ref SECURITY_DESCRIPTOR pSd);

		[DllImport("user32")]
		public static extern int SetWindowContextHelpId(IntPtr hwnd, int dw);

		[DllImport("user32")]
		public static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

		[DllImport("user32")]
		public static extern int SetWindowPlacement(IntPtr hwnd, ref WINDOWPLACEMENT lpwndpl);

		[DllImport("user32")]
		public static extern int SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int cx, int cy, int wFlags);

		[DllImport("user32")]
		public static extern int SetWindowRgn(IntPtr hwnd, IntPtr hRgn, int bRedraw);

		[DllImport("user32")]
		public static extern int SetWindowText(IntPtr hwnd, string lpString);

		[DllImport("user32")]
		public static extern int SetWindowWord(IntPtr hwnd, int nIndex, int wNewWord);

		[DllImport("user32")]
		public static extern int SetWindowsHook(int nFilterType, ref int pfnFilterProc);

		[DllImport("user32")]
		public static extern int SetWindowsHookEx(int idHook, ref int lpfn, IntPtr hmod, int dwThreadId);

		[DllImport("user32")]
		public static extern int ShowCaret(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int ShowCursor(int bShow);

		[DllImport("user32")]
		public static extern int ShowOwnedPopups(IntPtr hwnd, int fShow);

		[DllImport("user32")]
		public static extern int ShowScrollBar(IntPtr hwnd, int wBar, int bShow);

		[DllImport("user32")]
		public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

		[DllImport("user32")]
		public static extern int ShowWindowAsync(IntPtr hwnd, int nCmdShow);

		[DllImport("user32")]
		public static extern int SubtractRect(ref RECT lprcDst, ref RECT lprcSrc1, ref RECT lprcSrc2);

		[DllImport("user32")]
		public static extern int SwapMouseButton(int bSwap);

		[DllImport("user32")]
		public static extern int SwitchDesktop(IntPtr hDesktop);

		[DllImport("user32")]
		public static extern int SystemParametersInfo(int uAction, int uParam, ref IntPtr lpvParam, int fuWinIni);

		[DllImport("user32")]
		public static extern int TabbedTextOut(IntPtr hdc, int x, int y, string lpString, int nCount, int nTabPositions, ref int lpnTabStopPositions, int nTabOrigin);

		[DllImport("user32")]
		public static extern int ToAscii(int uVirtKey, int uScanCode, byte lpbKeyState, ref int lpwTransKey, int fuState);

		[DllImport("user32")]
		public static extern int ToAsciiEx(int uVirtKey, int uScanCode, byte lpKeyState, short lpChar, int uFlags, int dwhkl);

		[DllImport("user32")]
		public static extern int ToUnicode(int wVirtKey, int wScanCode, byte lpKeyState, string pwszBuff, int cchBuff, int wFlags);

		[DllImport("user32")]
		public static extern int TrackPopupMenu(IntPtr hMenu, int wFlags, int x, int y, int nReserved, IntPtr hwnd, ref RECT lprc);

		[DllImport("user32")]
		public static extern int TrackPopupMenuEx(IntPtr hMenu, int un, int n1, int n2, IntPtr hwnd, ref TPMPARAMS lpTPMParams);

		[DllImport("user32")]
		public static extern int TranslateAccelerator(IntPtr hwnd, IntPtr hAccTable, ref MSG lpMsg);

		[DllImport("user32")]
		public static extern int TranslateMDISysAccel(IntPtr hwndClient, ref MSG lpMsg);

		[DllImport("user32")]
		public static extern int TranslateMessage(ref MSG lpMsg);

		[DllImport("user32")]
		public static extern int UnhookWindowsHook(int nCode, ref int pfnFilterProc);

		[DllImport("user32")]
		public static extern int UnhookWindowsHookEx(IntPtr hHook);

		[DllImport("user32")]
		public static extern int UnionRect(ref RECT lpDestRect, ref RECT lpSrc1Rect, ref RECT lpSrc2Rect);

		[DllImport("user32")]
		public static extern int UnloadKeyboardLayout(IntPtr hKL);

		[DllImport("user32")]
		public static extern int UnpackDDElParam(int msg, int lParam, ref int puiLo, ref int puiHi);

		[DllImport("user32")]
		public static extern int UnregisterClass(string lpClassName, IntPtr hInstance);

		[DllImport("user32")]
		public static extern int UnregisterHotKey(IntPtr hwnd, int id);

		[DllImport("user32")]
		public static extern int UpdateWindow(IntPtr hwnd);

		[DllImport("user32")]
		public static extern int ValidateRect(IntPtr hwnd, ref RECT lpRect);

		[DllImport("user32")]
		public static extern int ValidateRgn(IntPtr hwnd, IntPtr hRgn);

		[DllImport("user32")]
		public static extern int WaitForInputIdle(IntPtr hProcess, int dwMilliseconds);

		[DllImport("user32")]
		public static extern int WaitMessage();

		[DllImport("user32")]
		public static extern int WinHelp(IntPtr hwnd, string lpHelpFile, int wCommand, int dwData);

		[DllImport("user32")]
		public static extern int WindowFromDC(IntPtr hdc);

		[DllImport("user32")]
		public static extern int WindowFromPoint(int xPoint, int yPoint);

		[DllImport("user32")]
		public static extern short CascadeWindows(IntPtr hwndParent, int wHow, ref RECT lpRect, int cKids, ref int lpkids);

		[DllImport("user32")]
		public static extern short GetAsyncKeyState(int vKey);

		[DllImport("user32")]
		public static extern short GetKeyState(int nVirtKey);

		[DllImport("user32")]
		public static extern short GetWindowWord(IntPtr hwnd, int nIndex);

		[DllImport("user32")]
		public static extern short RegisterClassEx(ref WNDCLASSEX pcWndClassEx);

		[DllImport("user32")]
		public static extern short TileWindows(IntPtr hwndParent, int wHow, ref RECT lpRect, int cKids, ref int lpKids);

		[DllImport("user32")]
		public static extern short VkKeyScan(byte cChar);

		[DllImport("user32")]
		public static extern short VkKeyScanEx(byte ch, int dwhkl);

		[DllImport("user32")]
		public static extern string CharLower(string lpsz);

		[DllImport("user32")]
		public static extern string CharNext(string lpsz);

		[DllImport("user32")]
		public static extern string CharPrev(string lpszStart, string lpszCurrent);

		[DllImport("user32")]
		public static extern string CharUpper(string lpsz);

		[DllImport("user32")]
		public static extern void PostQuitMessage(int nExitCode);

		[DllImport("user32")]
		public static extern void keybd_event(int bVk, int bScan, int dwFlags, int dwExtraInfo);

		[DllImport("user32")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		[DllImport("user32")]
		public static extern void SetDebugErrorLevel(int dwLevel);

		[DllImport("user32")]
		public static extern void SetLastErrorEx(int dwErrCode, int dwType);

        // my
       	[DllImport("user32")]
		public static extern bool IsHungAppWindow(IntPtr wnd); //проверяет зависло ли приложение

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows (IntPtr hWndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32")]
		public static extern short GetKeyState(System.Windows.Forms.Keys nVirtKey);
        		
        [DllImport("user32")]
		public static extern void keybd_event(System.Windows.Forms.Keys bVk, int bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool PrintWindow( IntPtr hWnd, IntPtr hdcBlt, int nFlags );
    }
}
