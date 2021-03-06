﻿using System;

namespace THNETII.WinApi.Native.WinNT
{
    [Flags]
    public enum SE_SECURITY_DESCRIPTOR_FLAGS
    {
        SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE = WinNTConstants.SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE,
        SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE = WinNTConstants.SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE,
        SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE = WinNTConstants.SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE,
        SE_SECURITY_DESCRIPTOR_VALID_FLAGS = WinNTConstants.SE_SECURITY_DESCRIPTOR_VALID_FLAGS,
    }
}
