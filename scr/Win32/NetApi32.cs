using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public abstract class NetApi32
	{
		public const int CNLEN = 15;

		public const int CONNECT_UPDATE_PROFILE = 1;

		public const int FILTER_INTERDOMAIN_TRUST_ACCOUNT = 8;

		public const int FILTER_NORMAL_ACCOUNT = 2;

		public const int FILTER_PROXY_ACCOUNT = 4;

		public const int FILTER_SERVER_TRUST_ACCOUNT = 32;

		public const int FILTER_TEMP_DUPLICATE_ACCOUNT = 1;

		public const int FILTER_WORKSTATION_TRUST_ACCOUNT = 16;

		public const int GNLEN = 256;

		public const int LG_INCLUDE_INDIRECT = 1;

		public const int LM20_PWLEN = 14;

		public const int MAXCOMMENTSZ = 256;

		public const int NERR_BASE = 2100;

		public const int NERR_GroupExists = 2223;

		public const int NERR_InvalidComputer = 2351;

		public const int NERR_NotPrimary = 2226;

		public const int NERR_PasswordTooShort = 2245;

		public const int NERR_Success = 0;

		public const int NERR_UserExists = 2224;

		public const int PWLEN = 256;

		public const int RESOURCEDISPLAYTYPE_DOMAIN = 1;

		public const int RESOURCEDISPLAYTYPE_FILE = 4;

		public const int RESOURCEDISPLAYTYPE_GENERIC = 0;

		public const int RESOURCEDISPLAYTYPE_GROUP = 5;

		public const int RESOURCEDISPLAYTYPE_SERVER = 2;

		public const int RESOURCEDISPLAYTYPE_SHARE = 3;

		public const int RESOURCETYPE_ANY = 0;

		public const int RESOURCETYPE_DISK = 1;

		public const int RESOURCETYPE_PRINT = 2;

		public const int RESOURCETYPE_UNKNOWN = 65535;

		public const int RESOURCEUSAGE_ALL = 0;

		public const int RESOURCEUSAGE_CONNECTABLE = 1;

		public const int RESOURCEUSAGE_CONTAINER = 2;

		public const int RESOURCEUSAGE_RESERVED = -2147483648;

		public const int RESOURCE_CONNECTED = 1;

		public const int RESOURCE_ENUM_ALL = 65535;

		public const int RESOURCE_GLOBALNET = 2;

		public const int RESOURCE_PUBLICNET = 2;

		public const int RESOURCE_REMEMBERED = 3;

		public const int TIMEQ_FOREVER = -1;

		public const int UF_ACCOUNTDISABLE = 2;

		public const int UF_HOMEDIR_REQUIRED = 8;

		public const int UF_LOCKOUT = 16;

		public const int UF_PASSWD_CANT_CHANGE = 64;

		public const int UF_PASSWD_NOTREQD = 32;

		public const int UF_SCRIPT = 1;

		public const int UNITS_PER_DAY = 24;

		public const int UNITS_PER_WEEK = 168;

		public const int UNLEN = 256;

		public const int USER_MAXSTORAGE_UNLIMITED = -1;

		public const int USER_NO_LOGOFF = -1;

		public const int USER_PRIV_ADMIN = 2;

		public const int USER_PRIV_GUEST = 0;

		public const int USER_PRIV_MASK = 3;

		public const int USER_PRIV_USER = 1;

		public const int WN_ACCESS_DENIED = 5;

		public const int WN_ALREADY_CONNECTED = 85;

		public const int WN_BAD_LOCALNAME = 1200;

		public const int WN_BAD_NETNAME = 67;

		public const int WN_BAD_PASSWORD = 86;

		public const int WN_BAD_POINTER = 487;

		public const int WN_BAD_PROFILE = 1206;

		public const int WN_BAD_PROVIDER = 1204;

		public const int WN_BAD_USER = 2202;

		public const int WN_BAD_VALUE = 87;

		public const int WN_CANNOT_OPEN_PROFILE = 1205;

		public const int WN_CONNECTION_CLOSED = 1201;

		public const int WN_DEVICE_ERROR = 31;

		public const int WN_DEVICE_IN_USE = 2404;

		public const int WN_EXTENDED_ERROR = 1208;

		public const int WN_FUNCTION_BUSY = 170;

		public const int WN_MORE_DATA = 234;

		public const int WN_NET_ERROR = 59;

		public const int WN_NOT_CONNECTED = 2250;

		public const int WN_NOT_SUPPORTED = 50;

		public const int WN_NO_NETWORK = 1222;

		public const int WN_NO_NET_OR_BAD_PATH = 1203;

		public const int WN_OPEN_FILES = 2401;

		public const int WN_OUT_OF_MEMORY = 8;

		public const int WN_SUCCESS = 0;

		public const int WN_WINDOWS_ERROR = 59;

		[DllImport("Netapi32")]
		public static extern int NetApiBufferFree(int lpBuffer);

		[DllImport("Netapi32")]
		public static extern int NetRemoteTOD(IntPtr yServer, int pBuffer);

		[DllImport("Netapi32")]
		public static extern int NetUserChangePassword(IntPtr Domain, IntPtr User, byte OldPass, byte NewPass);

		[DllImport("Netapi32")]
		public static extern int NetUserGetGroups(IntPtr lpServer, byte UserName, int Level, ref int lpBuffer, int PrefMaxLen, ref int lpEntriesRead, ref int lpTotalEntries);

		[DllImport("Netapi32")]
		public static extern int NetUserGetInfo(IntPtr lpServer, byte UserName, int Level, ref int lpBuffer);

		[DllImport("Netapi32")]
		public static extern int NetUserGetLocalGroups(IntPtr lpServer, byte UserName, int Level, int Flags, ref int lpBuffer, int MaxLen, ref int lpEntriesRead, ref int lpTotalEntries);

		[DllImport("Netapi32")]
		public static extern int NetWkstaGetInfo(IntPtr lpServer, int Level, IntPtr lpBuffer);

		[DllImport("Netapi32")]
		public static extern int NetWkstaUserGetInfo(IntPtr reserved, int Level, IntPtr lpBuffer);

		[DllImport("netapi32")]
		public static extern int NetUserAdd(IntPtr lpServer, int Level, ref USER_INFO_3 lpUser, ref int lpError);

		[DllImport("netapi32")]
		public static extern int NetLocalGroupDelMembers(int psServer, int psLocalGroup, int lLevel, ref LOCALGROUP_MEMBERS_INFO_0 uMember, int lMemberCount);

		[DllImport("netapi32")]
		public static extern int NetLocalGroupGetMembers(int psServer, int psLocalGroup, int lLevel, int pBuffer, int lMaxLength, int plEntriesRead, int plTotalEntries, int phResume);
	}
}
