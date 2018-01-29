using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public abstract class Shell32
	{
		public const int ABE_BOTTOM = 3;

		public const int ABE_LEFT = 0;

		public const int ABE_RIGHT = 2;

		public const int ABE_TOP = 1;

		public const int ABM_ACTIVATE = 6;

		public const int ABM_GETAUTOHIDEBAR = 7;

		public const int ABM_GETSTATE = 4;

		public const int ABM_GETTASKBARPOS = 5;

		public const int ABM_NEW = 0;

		public const int ABM_QUERYPOS = 2;

		public const int ABM_REMOVE = 1;

		public const int ABM_SETAUTOHIDEBAR = 8;

		public const int ABM_SETPOS = 3;

		public const int ABM_WINDOWPOSCHANGED = 9;

		public const int ABN_FULLSCREENAPP = 2;

		public const int ABN_POSCHANGED = 1;

		public const int ABN_STATECHANGE = 0;

		public const int ABN_WINDOWARRANGE = 3;

		public const int ABS_ALWAYSONTOP = 2;

		public const int ABS_AUTOHIDE = 1;

		public const int EIRESID = -1;

		public const int FOF_ALLOWUNDO = 64;

		public const int FOF_CONFIRMMOUSE = 2;

		public const int FOF_FILESONLY = 128;

		public const int FOF_MULTIDESTFILES = 1;

		public const int FOF_NOCONFIRMATION = 16;

		public const int FOF_NOCONFIRMMKDIR = 512;

		public const int FOF_RENAMEONCOLLISION = 8;

		public const int FOF_SILENT = 4;

		public const int FOF_SIMPLEPROGRESS = 256;

		public const int FOF_WANTMAPPINGHANDLE = 32;

		public const int FO_COPY = 2;

		public const int FO_DELETE = 3;

		public const int FO_MOVE = 1;

		public const int FO_RENAME = 4;

		public const int NIF_ICON = 2;

		public const int NIF_MESSAGE = 1;

		public const int NIF_TIP = 4;

		public const int NIM_ADD = 0;

		public const int NIM_DELETE = 2;

		public const int NIM_MODIFY = 1;

		public const int PO_DELETE = 19;

		public const int PO_PORTCHANGE = 32;

		public const int PO_RENAME = 20;

		public const int PO_REN_PORT = 52;

		public const int SEE_MASK_CLASSKEY = 3;

		public const int SEE_MASK_CLASSNAME = 1;

		public const int SEE_MASK_CONNECTNETDRV = 128;

		public const int SEE_MASK_DOENVSUBST = 512;

		public const int SEE_MASK_FLAG_DDEWAIT = 256;

		public const int SEE_MASK_FLAG_NO_UI = 1024;

		public const int SEE_MASK_HOTKEY = 32;

		public const int SEE_MASK_ICON = 16;

		public const int SEE_MASK_IDLIST = 4;

		public const int SEE_MASK_INVOKEIDLIST = 12;

		public const int SEE_MASK_NOCLOSEPROCESS = 64;

		public const int SE_ERR_ACCESSDENIED = 5;

		public const int SE_ERR_ASSOCINCOMPLETE = 27;

		public const int SE_ERR_DDEBUSY = 30;

		public const int SE_ERR_DDEFAIL = 29;

		public const int SE_ERR_DDETIMEOUT = 28;

		public const int SE_ERR_DLLNOTFOUND = 32;

		public const int SE_ERR_FNF = 2;

		public const int SE_ERR_NOASSOC = 31;

		public const int SE_ERR_OOM = 8;

		public const int SE_ERR_PNF = 3;

		public const int SE_ERR_SHARE = 26;

		public const int SHGFI_ATTRIBUTES = 2048;

		public const int SHGFI_DISPLAYNAME = 512;

		public const int SHGFI_EXETYPE = 8192;

		public const int SHGFI_ICON = 256;

		public const int SHGFI_ICONLOCATION = 4096;

		public const int SHGFI_LARGEICON = 0;

		public const int SHGFI_LINKOVERLAY = 32768;

		public const int SHGFI_OPENICON = 2;

		public const int SHGFI_PIDL = 8;

		public const int SHGFI_SELECTED = 65536;

		public const int SHGFI_SHELLICONSIZE = 4;

		public const int SHGFI_SMALLICON = 1;

		public const int SHGFI_SYSICONINDEX = 16384;

		public const int SHGFI_TYPENAME = 1024;

		public const int SHGFI_USEFILEATTRIBUTES = 16;

		public const int SHGNLI_PIDL = 1;

		public const int SHGNLI_PREFIXNAME = 2;

		[DllImport("shell32")]
		public static extern int CommandLineToArgv(string lpCmdLine, short pNumArgs);

		[DllImport("shell32")]
		public static extern int DoEnvironmentSubst(string szString, int cbString);

		[DllImport("shell32")]
		public static extern int DragQueryFile(IntPtr hDROP, int UINT, string lpStr, int ch);

		[DllImport("shell32")]
		public static extern int DragQueryPoint(IntPtr hDROP, ref POINT lpPoint);

		[DllImport("shell32")]
		public static extern int DuplicateIcon(IntPtr hInst, IntPtr hIcon);

		[DllImport("shell32")]
		public static extern int ExtractAssociatedIcon(IntPtr hInst, string lpIconPath, ref int lpiIcon);

		[DllImport("shell32")]
		public static extern int ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

		[DllImport("shell32")]
		public static extern int ExtractIconEx(string lpszFile, int nIconIndex, ref int phiconLarge, ref int phiconSmall, int nIcons);

		[DllImport("shell32")]
		public static extern int FindExecutable(string lpFile, string lpDirectory, string lpResult);

		[DllImport("shell32")]
		public static extern int SHAppBarMessage(int dwMessage, ref APPBARDATA pData);

		[DllImport("shell32")]
		public static extern int SHFileOperation(ref SHFILEOPSTRUCT lpFileOp);

		[DllImport("shell32")]
		public static extern int SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, int uFlags);

		[DllImport("shell32")]
		public static extern int SHGetNewLinkInfo(string pszLinkto, string pszDir, string pszName, ref int pfMustCopy, int uFlags);

		[DllImport("shell32")]
		public static extern int ShellAbout(IntPtr hwnd, string szApp, string szOtherStuff, IntPtr hIcon);

		[DllImport("shell32")]
		public static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

		[DllImport("shell32")]
		public static extern int Shell_NotifyIcon(int dwMessage, ref NOTIFYICONDATA lpData);

		[DllImport("shell32")]
		public static extern void DragAcceptFiles(IntPtr hwnd, int fAccept);

		[DllImport("shell32")]
		public static extern void DragFinish(IntPtr hDrop);

		[DllImport("shell32")]
		public static extern void SHFreeNameMappings(IntPtr hNameMappings);

		[DllImport("shell32")]
		public static extern void WinExecError(IntPtr hwnd, int error, string lpstrFileName, string lpstrTitle);

		[DllImport("shell32")]
		public static extern int SHBrowseForFolder(BROWSEINFO lpbi);

		[DllImport("shell32")]
		public static extern int SHGetPathFromIDList(int pidList, string lpBuffer);
	}
}
