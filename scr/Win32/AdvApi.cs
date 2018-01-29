using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Win32
{
	public abstract class AdvApi
	{
		[DllImport("AdvApi32")]
		public static extern int ImpersonateLoggedOnUser(IntPtr hToken);

		[DllImport("advapi32")]
		public static extern int IsTextUnicode(IntPtr lpBuffer, int cb, ref int lpi);

		[DllImport("advapi32")]
		public static extern int LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref int phToken);

		[DllImport("advapi32")]
		public static extern int NotifyChangeEventLog(IntPtr hEventLog, IntPtr hEvent);

		[DllImport("advapi32")]
		public static extern int SetThreadToken(int Thread, int Token);

		[DllImport("advapi32")]
		public static extern byte GetSidSubAuthorityCount(IntPtr pSid);

		[DllImport("advapi32")]
		public static extern SID_IDENTIFIER_AUTHORITY GetSidIdentifierAuthority(IntPtr pSid);

		[DllImport("advapi32")]
		public static extern int AbortSystemShutdown(string lpMachineName);

		[DllImport("advapi32")]
		public static extern int AccessCheck(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int ClientToken, int DesiredAccess, GENERIC_MAPPING GenericMapping, PRIVILEGE_SET PrivilegeSet, int PrivilegeSetLength, int GrantedAccess, int Status);

		[DllImport("advapi32")]
		public static extern int AccessCheckAndAuditAlarm(string SubsystemName, IntPtr HandleId, string ObjectTypeName, string ObjectName, SECURITY_DESCRIPTOR SecurityDescriptor, int DesiredAccess, GENERIC_MAPPING GenericMapping, int ObjectCreation, int GrantedAccess, int AccessStatus, ref int pfGenerateOnClose);

		[DllImport("advapi32")]
		public static extern int AddAccessAllowedAce(ref ACL pAcl, int dwAceRevision, int AccessMask, IntPtr pSid);

		[DllImport("advapi32")]
		public static extern int AddAccessDeniedAce(ref ACL pAcl, int dwAceRevision, int AccessMask, IntPtr pSid);

		[DllImport("advapi32")]
		public static extern int AddAce(ref ACL pAcl, int dwAceRevision, int dwStartingAceIndex, IntPtr pAceList, int nAceListLength);

		[DllImport("advapi32")]
		public static extern int AddAuditAccessAce(ref ACL pAcl, int dwAceRevision, int dwAccessMask, IntPtr pSid, int bAuditSuccess, int bAuditFailure);

		[DllImport("advapi32")]
		public static extern int AdjustTokenGroups(int TokenHandle, int ResetToDefault, TOKEN_GROUPS NewState, int BufferLength, TOKEN_GROUPS PreviousState, int ReturnLength);

		[DllImport("advapi32")]
		public static extern int AdjustTokenPrivileges(int TokenHandle, int DisableAllPrivileges, TOKEN_PRIVILEGES NewState, int BufferLength, TOKEN_PRIVILEGES PreviousState, int ReturnLength);

		[DllImport("advapi32")]
		public static extern int AllocateAndInitializeSid(ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount, int nSubAuthority0, int nSubAuthority1, int nSubAuthority2, int nSubAuthority3, int nSubAuthority4, int nSubAuthority5, int nSubAuthority6, int nSubAuthority7, ref int lpPSid);

		[DllImport("advapi32")]
		public static extern int AllocateLocallyUniqueId(LARGE_INTEGER Luid);

		[DllImport("advapi32")]
		public static extern int AreAllAccessesGranted(int GrantedAccess, int DesiredAccess);

		[DllImport("advapi32")]
		public static extern int AreAnyAccessesGranted(int GrantedAccess, int DesiredAccess);

		[DllImport("advapi32")]
		public static extern int BackupEventLog(IntPtr hEventLog, string lpBackupFileName);

		[DllImport("advapi32")]
		public static extern int ChangeServiceConfig(IntPtr hService, int dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, ref int lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);

		[DllImport("advapi32")]
		public static extern int ClearEventLog(IntPtr hEventLog, string lpBackupFileName);

		[DllImport("advapi32")]
		public static extern int CloseEventLog(IntPtr hEventLog);

		[DllImport("advapi32")]
		public static extern int CloseServiceHandle(IntPtr hSCObject);

		[DllImport("advapi32")]
		public static extern int ControlService(IntPtr hService, int dwControl, ref SERVICE_STATUS lpServiceStatus);

		[DllImport("advapi32")]
		public static extern int CopySid(int nDestinationSidLength, IntPtr pDestinationSid, IntPtr pSourceSid);

		[DllImport("advapi32")]
		public static extern int CreatePrivateObjectSecurity(ref SECURITY_DESCRIPTOR ParentDescriptor, SECURITY_DESCRIPTOR CreatorDescriptor, SECURITY_DESCRIPTOR NewDescriptor, int IsDirectoryObject, int Token, GENERIC_MAPPING GenericMapping);

		[DllImport("advapi32")]
		public static extern int CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, int dwCreationFlags, string lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

		[DllImport("advapi32")]
		public static extern int CreateService(IntPtr hSCManager, string lpServiceName, string lpDisplayName, int dwDesiredAccess, int dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, ref int lpdwTagId, string lpDependencies, string lp, string lpPassword);

		[DllImport("advapi32")]
		public static extern int DeleteAce(ref ACL pAcl, int dwAceIndex);

		[DllImport("advapi32")]
		public static extern int DeleteService(IntPtr hService);

		[DllImport("advapi32")]
		public static extern int DeregisterEventSource(IntPtr hEventLog);

		[DllImport("advapi32")]
		public static extern int DestroyPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor);

		[DllImport("advapi32")]
		public static extern int DuplicateToken(int ExistingTokenHandle, short ImpersonationLevel, int DuplicateTokenHandle);

		[DllImport("advapi32")]
		public static extern int EnumDependentServices(IntPtr hService, int dwServiceState, ref ENUM_SERVICE_STATUS lpServices, int cbBufSize, ref int pcbBytesNeeded, ref int lpServicesReturned);

		[DllImport("advapi32")]
		public static extern int EnumServicesStatus(IntPtr hSCManager, int dwServiceType, int dwServiceState, ref ENUM_SERVICE_STATUS lpServices, int cbBufSize, ref int pcbBytesNeeded, ref int lpServicesReturned, ref int lpResumeHandle);

		[DllImport("advapi32")]
		public static extern int EqualPrefixSid(IntPtr pSid1, IntPtr pSid2);

		[DllImport("advapi32")]
		public static extern int EqualSid(IntPtr pSid1, IntPtr pSid2);

		[DllImport("advapi32")]
		public static extern int FindFirstFreeAce(ref ACL pAcl, ref int pAce);

		[DllImport("advapi32")]
		public static extern int GetAce(ref ACL pAcl, int dwAceIndex, IntPtr pAce);

		[DllImport("advapi32")]
		public static extern int GetAclInformation(ref ACL pAcl, IntPtr pAclInformation, int nAclInformationLength, short dwAclInformationClass);

		[DllImport("advapi32")]
		public static extern int GetFileSecurity(string lpFileName, int RequestedInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor, int nLength, ref int lpnLengthNeeded);

		[DllImport("advapi32")]
		public static extern int GetKernelObjectSecurity(IntPtr handle, int RequestedInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor, int nLength, ref int lpnLengthNeeded);

		[DllImport("advapi32")]
		public static extern int GetLengthSid(IntPtr pSid);

		[DllImport("advapi32")]
		public static extern int GetNumberOfEventLogRecords(IntPtr hEventLog, int NumberOfRecords);

		[DllImport("advapi32")]
		public static extern int GetOldestEventLogRecord(IntPtr hEventLog, int OldestRecord);

		[DllImport("advapi32")]
		public static extern int GetPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor, int SecurityInformation, SECURITY_DESCRIPTOR ResultantDescriptor, int DescriptorLength, int ReturnLength);

		[DllImport("advapi32")]
		public static extern int GetSecurityDescriptorControl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, short pControl, ref int lpdwRevision);

		[DllImport("advapi32")]
		public static extern int GetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref int lpbDaclPresent, ref ACL pDacl, ref int lpbDaclDefaulted);

		[DllImport("advapi32")]
		public static extern int GetSecurityDescriptorGroup(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pGroup, ref int lpbGroupDefaulted);

		[DllImport("advapi32")]
		public static extern int GetSecurityDescriptorLength(ref SECURITY_DESCRIPTOR pSecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int GetSecurityDescriptorOwner(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pOwner, ref int lpbOwnerDefaulted);

		[DllImport("advapi32")]
		public static extern int GetSecurityDescriptorSacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref int lpbSaclPresent, ref ACL pSacl, ref int lpbSaclDefaulted);

		[DllImport("advapi32")]
		public static extern int GetServiceDisplayName(IntPtr hSCManager, string lpServiceName, StringBuilder lpDisplayName, ref int cchBuffer);

		[DllImport("advapi32")]
		public static extern int GetServiceKeyName(IntPtr hSCManager, string lpDisplayName, StringBuilder lpServiceName, ref int cchBuffer);

		[DllImport("advapi32")]
		public static extern int GetSidLengthRequired(byte nSubAuthorityCount);

		[DllImport("advapi32")]
		public static extern int GetSidSubAuthority(IntPtr pSid, int nSubAuthority);

		[DllImport("advapi32")]
		public static extern int GetTokenInformation(int TokenHandle, short TokenInformationClass, IntPtr TokenInformation, int TokenInformationLength, int ReturnLength);

		[DllImport("advapi32")]
		public static extern int GetUserName(StringBuilder lpBuffer, int nSize);

		[DllImport("advapi32")]
		public static extern int ImpersonateNamedPipeClient(IntPtr hNamedPipe);

		[DllImport("advapi32")]
		public static extern int ImpersonateSelf(short ImpersonationLevel);

		[DllImport("advapi32")]
		public static extern int InitializeAcl(ref ACL pAcl, int nAclLength, int dwAclRevision);

		[DllImport("advapi32")]
		public static extern int InitializeSecurityDescriptor(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int dwRevision);

		[DllImport("advapi32")]
		public static extern int InitializeSid(IntPtr Sid, ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount);

		[DllImport("advapi32")]
		public static extern int InitiateSystemShutdown(string lpMachineName, string lpMessage, int dwTimeout, int bForceAppsClosed, int bRebootAfterShutdown);

		[DllImport("advapi32")]
		public static extern int IsValidAcl(ref ACL pAcl);

		[DllImport("advapi32")]
		public static extern int IsValidSecurityDescriptor(ref SECURITY_DESCRIPTOR pSecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int IsValidSid(IntPtr pSid);

		[DllImport("advapi32")]
		public static extern int LockServiceDatabase(IntPtr hSCManager);

		[DllImport("advapi32")]
		public static extern int LookupAccountName(string lpSystemName, string lpAccountName, int Sid, int cbSid, string ReferencedDomainName, int cbReferencedDomainName, int peUse);

		[DllImport("advapi32")]
		public static extern int LookupAccountSid(string lpSystemName, IntPtr Sid, string name, int cbName, string ReferencedDomainName, int cbReferencedDomainName, int peUse);

		[DllImport("advapi32")]
		public static extern int LookupPrivilegeDisplayName(string lpSystemName, string lpName, string lpDisplayName, int cbDisplayName, ref int lpLanguageID);

		[DllImport("advapi32")]
		public static extern int LookupPrivilegeName(string lpSystemName, ref LARGE_INTEGER lpLuid, string lpName, int cbName);

		[DllImport("advapi32")]
		public static extern int LookupPrivilegeValue(string lpSystemName, string lpName, ref LARGE_INTEGER lpLuid);

		[DllImport("advapi32")]
		public static extern int MakeAbsoluteSD(ref SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor, ref SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor, ref int lpdwAbsoluteSecurityDescriptorSize, ref ACL pDacl, ref int lpdwDaclSize, ref ACL pSacl, ref int lpdwSaclSize, IntPtr pOwner, ref int lpdwOwnerSize, IntPtr pPrimaryGroup, ref int lpdwPrimaryGroupSize);

		[DllImport("advapi32")]
		public static extern int MakeSelfRelativeSD(ref SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor, ref SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor, ref int lpdwBufferLength);

		[DllImport("advapi32")]
		public static extern int NotifyBootConfigStatus(int BootAcceptable);

		[DllImport("advapi32")]
		public static extern int ObjectCloseAuditAlarm(string SubsystemName, IntPtr HandleId, int GenerateOnClose);

		[DllImport("advapi32")]
		public static extern int ObjectPrivilegeAuditAlarm(string SubsystemName, IntPtr HandleId, int ClientToken, int DesiredAccess, PRIVILEGE_SET Privileges, int AccessGranted);

		[DllImport("advapi32")]
		public static extern int OpenBackupEventLog(string lpUNCServerName, string lpFileName);

		[DllImport("advapi32")]
		public static extern int OpenEventLog(string lpUNCServerName, string lpSourceName);

		[DllImport("advapi32")]
		public static extern int OpenSCManager(string lpMachineName, string lpDatabaseName, int dwDesiredAccess);

		[DllImport("advapi32")]
		public static extern int OpenService(IntPtr hSCManager, string lpServiceName, int dwDesiredAccess);

		[DllImport("advapi32")]
		public static extern int OpenThreadToken(int ThreadHandle, int DesiredAccess, int OpenAsSelf, int TokenHandle);

		[DllImport("advapi32")]
		public static extern int PrivilegeCheck(int ClientToken, PRIVILEGE_SET RequiredPrivileges, ref int pfResult);

		[DllImport("advapi32")]
		public static extern int PrivilegedServiceAuditAlarm(string SubsystemName, string ServiceName, int ClientToken, PRIVILEGE_SET Privileges, int AccessGranted);

		[DllImport("advapi32")]
		public static extern int QueryServiceConfig(IntPtr hService, ref QUERY_SERVICE_CONFIG lpServiceConfig, int cbBufSize, ref int pcbBytesNeeded);

		[DllImport("advapi32")]
		public static extern int QueryServiceLockStatus(IntPtr hSCManager, ref QUERY_SERVICE_LOCK_STATUS lpLockStatus, int cbBufSize, ref int pcbBytesNeeded);

		[DllImport("advapi32")]
		public static extern int QueryServiceObjectSecurity(IntPtr hService, int dwSecurityInformation, IntPtr lpSecurityDescriptor, int cbBufSize, ref int pcbBytesNeeded);

		[DllImport("advapi32")]
		public static extern int QueryServiceStatus(IntPtr hService, ref SERVICE_STATUS lpServiceStatus);

		[DllImport("advapi32")]
		public static extern int ReadEventLog(IntPtr hEventLog, int dwReadFlags, int dwRecordOffset, ref EVENTLOGRECORD lpBuffer, int nNumberOfBytesToRead, ref int pnBytesRead, ref int pnMinNumberOfBytesNeeded);

		[DllImport("advapi32")]
		public static extern int RegCloseKey(IntPtr hKey);

		[DllImport("advapi32")]
		public static extern int RegConnectRegistry(string lpMachineName, IntPtr hKey, ref int phkResult);

		[DllImport("advapi32")]
		public static extern int RegCreateKey(IntPtr hKey, string lpSubKey, ref int phkResult);

		[DllImport("advapi32")]
		public static extern int RegCreateKeyEx(IntPtr hKey, string lpSubKey, int Reserved, string lpClass, int dwOptions, int samDesired, ref SECURITY_ATTRIBUTES lpSecurityAttributes, ref int phkResult, ref int lpdwDisposition);

		[DllImport("advapi32")]
		public static extern int RegDeleteKey(IntPtr hKey, string lpSubKey);

		[DllImport("advapi32")]
		public static extern int RegDeleteValue(IntPtr hKey, string lpValueName);

		[DllImport("advapi32")]
		public static extern int RegEnumKey(IntPtr hKey, int dwIndex, string lpName, int cbName);

		[DllImport("advapi32")]
		public static extern int RegEnumKeyEx(IntPtr hKey, int dwIndex, string lpName, ref int lpcbName, ref int lpReserved, string lpClass, ref int lpcbClass, ref FILETIME lpftLastWriteTime);

		[DllImport("advapi32")]
		public static extern int RegEnumValue(IntPtr hKey, int dwIndex, string lpValueName, ref int lpcbValueName, ref int lpReserved, ref int lpType, byte lpData, ref int lpcbData);

		[DllImport("advapi32")]
		public static extern int RegFlushKey(IntPtr hKey);

		[DllImport("advapi32")]
		public static extern int RegGetKeySecurity(IntPtr hKey, int SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref int lpcbSecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int RegLoadKey(IntPtr hKey, string lpSubKey, string lpFile);

		[DllImport("advapi32")]
		public static extern int RegNotifyChangeKeyValue(IntPtr hKey, int bWatchSubtree, int dwNotifyFilter, IntPtr hEvent, int fAsynchronus);

		[DllImport("advapi32")]
		public static extern int RegOpenKey(IntPtr hKey, string lpSubKey, ref int phkResult);

		[DllImport("advapi32")]
		public static extern int RegOpenKeyEx(IntPtr hKey, string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

		[DllImport("advapi32")]
		public static extern int RegQueryInfoKey(IntPtr hKey, string lpClass, ref int lpcbClass, ref int lpReserved, ref int lpcSubKeys, ref int lpcbMaxSubKeyLen, ref int lpcbMaxClassLen, ref int lpcValues, ref int lpcbMaxValueNameLen, ref int lpcbMaxValueLen, ref int lpcbSecurityDescriptor, ref FILETIME lpftLastWriteTime);

		[DllImport("advapi32")]
		public static extern int RegQueryValue(IntPtr hKey, string lpSubKey, string lpValue, ref int lpcbValue);

		[DllImport("advapi32")]
		public static extern int RegQueryValueEx(IntPtr hKey, string lpValueName, ref int lpReserved, ref int lpType, IntPtr lpData, ref int lpcbData);

		[DllImport("advapi32")]
		public static extern int RegReplaceKey(IntPtr hKey, string lpSubKey, string lpNewFile, string lpOldFile);

		[DllImport("advapi32")]
		public static extern int RegRestoreKey(IntPtr hKey, string lpFile, int dwFlags);

		[DllImport("advapi32")]
		public static extern int RegSaveKey(IntPtr hKey, string lpFile, ref SECURITY_ATTRIBUTES lpSecurityAttributes);

		[DllImport("advapi32")]
		public static extern int RegSetKeySecurity(IntPtr hKey, int SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int RegSetValue(IntPtr hKey, string lpSubKey, int dwType, string lpData, int cbData);

		[DllImport("advapi32")]
		public static extern int RegSetValueEx(IntPtr hKey, string lpValueName, int Reserved, int dwType, IntPtr lpData, int cbData);

		[DllImport("advapi32")]
		public static extern int RegUnLoadKey(IntPtr hKey, string lpSubKey);

		[DllImport("advapi32")]
		public static extern int RegisterEventSource(string lpUNCServerName, string lpSourceName);

		[DllImport("advapi32")]
		public static extern int RegisterServiceCtrlHandler(string lpServiceName, ref int lpHandlerProc);

		[DllImport("advapi32")]
		public static extern int ReportEvent(IntPtr hEventLog, int wType, int wCategory, int dwEventID, IntPtr lpUserSid, int wNumStrings, int dwDataSize, ref int lpStrings, IntPtr lpRawData);

		[DllImport("advapi32")]
		public static extern int RevertToSelf();

		[DllImport("advapi32")]
		public static extern int SetAclInformation(ref ACL pAcl, IntPtr pAclInformation, int nAclInformationLength, short dwAclInformationClass);

		[DllImport("advapi32")]
		public static extern int SetFileSecurity(string lpFileName, int SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int SetKernelObjectSecurity(IntPtr handle, int SecurityInformation, SECURITY_DESCRIPTOR SecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int SetPrivateObjectSecurity(int SecurityInformation, SECURITY_DESCRIPTOR ModificationDescriptor, SECURITY_DESCRIPTOR ObjectsSecurityDescriptor, GENERIC_MAPPING GenericMapping, int Token);

		[DllImport("advapi32")]
		public static extern int SetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int bDaclPresent, ref ACL pDacl, int bDaclDefaulted);

		[DllImport("advapi32")]
		public static extern int SetSecurityDescriptorGroup(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pGroup, int bGroupDefaulted);

		[DllImport("advapi32")]
		public static extern int SetSecurityDescriptorOwner(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pOwner, int bOwnerDefaulted);

		[DllImport("advapi32")]
		public static extern int SetSecurityDescriptorSacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int bSaclPresent, ref ACL pSacl, int bSaclDefaulted);

		[DllImport("advapi32")]
		public static extern int SetServiceObjectSecurity(IntPtr hService, int dwSecurityInformation, IntPtr lpSecurityDescriptor);

		[DllImport("advapi32")]
		public static extern int SetServiceStatus(IntPtr hServiceStatus, ref SERVICE_STATUS lpServiceStatus);

		[DllImport("advapi32")]
		public static extern int SetTokenInformation(int TokenHandle, short TokenInformationClass, IntPtr TokenInformation, int TokenInformationLength);

		[DllImport("advapi32")]
		public static extern int StartService(IntPtr hService, int dwNumServiceArgs, ref int lpServiceArgVectors);

		[DllImport("advapi32")]
		public static extern int StartServiceCtrlDispatcher(ref SERVICE_TABLE_ENTRY lpServiceStartTable);

		[DllImport("advapi32")]
		public static extern int UnlockServiceDatabase(IntPtr ScLock);

		[DllImport("advapi32")]
		public static extern void FreeSid(IntPtr pSid);

		[DllImport("advapi32")]
		public static extern void MapGenericMask(int AccessMask, GENERIC_MAPPING GenericMapping);

		[DllImport("advapi32")]
		public static extern int GetUserNameW(byte lpBuffer, int nSize);

		[DllImport("advapi32")]
		public static extern int OpenProcessToken(int ProcessHandle, int DesiredAccess, int TokenHandle);
	}
}
