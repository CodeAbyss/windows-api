﻿using System.Runtime.InteropServices;
using THNETII.InteropServices.Bitwise;

namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11564
    /// <summary>
    /// Used to impose restrictions on what system calls can be invoked by a process.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/winnt/ns-winnt-process_mitigation_system_call_disable_policy">PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY structure</a></para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY
    {
        private static readonly Bitfield32 bfDisallowWin32kSystemCalls = Bitfield32.DefineLowerBits(1);
        private static readonly Bitfield32 bfAuditDisallowWin32kSystemCalls = Bitfield32.DefineMiddleBits(1, 1);
        private static readonly Bitfield32 bfReservedFlags = Bitfield32.DefineFromMask(Bitmask.HigherBitsUInt32(30));

        private uint dwFlags;

        public int Flags
        {
            get => (int)dwFlags;
            set => dwFlags = (uint)value;
        }

        public bool DisallowWin32kSystemCalls
        {
            get => bfDisallowWin32kSystemCalls.Read(dwFlags) != 0;
            set => bfDisallowWin32kSystemCalls.Write(ref dwFlags, value ? 1U : 0U);
        }

        public bool AuditDisallowWin32kSystemCalls
        {
            get => bfAuditDisallowWin32kSystemCalls.Read(dwFlags) != 0;
            set => bfAuditDisallowWin32kSystemCalls.Write(ref dwFlags, value ? 1U : 0U);
        }

        public int ReservedFlags
        {
            get => (int)bfReservedFlags.Read(dwFlags);
            set => bfReservedFlags.Write(ref dwFlags, (uint)value);
        }
    }
}