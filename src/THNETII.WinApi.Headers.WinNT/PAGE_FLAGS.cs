﻿using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum PAGE_FLAGS : int
    {
        PAGE_NOACCESS = WinNTConstants.PAGE_NOACCESS,
        PAGE_READONLY = WinNTConstants.PAGE_READONLY,
        PAGE_READWRITE = WinNTConstants.PAGE_READWRITE,
        PAGE_WRITECOPY = WinNTConstants.PAGE_WRITECOPY,
        PAGE_EXECUTE = WinNTConstants.PAGE_EXECUTE,
        PAGE_EXECUTE_READ = WinNTConstants.PAGE_EXECUTE_READ,
        PAGE_EXECUTE_READWRITE = WinNTConstants.PAGE_EXECUTE_READWRITE,
        PAGE_EXECUTE_WRITECOPY = WinNTConstants.PAGE_EXECUTE_WRITECOPY,
        PAGE_GUARD = WinNTConstants.PAGE_GUARD,
        PAGE_NOCACHE = WinNTConstants.PAGE_NOCACHE,
        PAGE_WRITECOMBINE = WinNTConstants.PAGE_WRITECOMBINE,
        PAGE_ENCLAVE_THREAD_CONTROL = WinNTConstants.PAGE_ENCLAVE_THREAD_CONTROL,
        PAGE_REVERT_TO_FILE_MAP = WinNTConstants.PAGE_REVERT_TO_FILE_MAP,
        PAGE_TARGETS_NO_UPDATE = WinNTConstants.PAGE_TARGETS_NO_UPDATE,
        PAGE_TARGETS_INVALID = WinNTConstants.PAGE_TARGETS_INVALID,
        PAGE_ENCLAVE_UNVALIDATED = WinNTConstants.PAGE_ENCLAVE_UNVALIDATED,
        PAGE_ENCLAVE_DECOMMIT = WinNTConstants.PAGE_ENCLAVE_DECOMMIT,
    }
}
