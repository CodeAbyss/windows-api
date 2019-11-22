﻿using System;
using System.Runtime.InteropServices;
using THNETII.InteropServices.Memory;

namespace THNETII.WinApi.Native.Sspi
{
    using static SspiConstants;

    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\shared\sspi.h, line 216
    //
    // SecPkgInfo structure
    //
    //  Provides general information about a security provider
    //
    /// <summary>
    /// The <see cref="SecPkgInfoW"/> structure provides general information about a security package, such as its name and capabilities.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkginfow">SecPkgInfoW structure</a></para>
    /// </remarks>
    /// <seealso cref="EnumerateSecurityPackages"/>
    /// <seealso cref="QuerySecurityPackageInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgInfoW
    {
        #region public SECPKG_FLAGS fCapabilities;
        internal uint fCapabilities;        // Capability bitmask
        /// <summary>
        /// Set of bit flags that describes the capabilities of the security package.
        /// </summary>
        public SECPKG_FLAGS Capabilities
        {
            get => (SECPKG_FLAGS)fCapabilities;
            set => fCapabilities = (uint)value;
        }
        #endregion
        /// <summary>
        /// Specifies the version of the package protocol. Must be 1.
        /// </summary>
        public ushort wVersion;            // Version of driver
        /// <summary>
        /// Specifies a DCE RPC identifier, if appropriate. If the package does not implement one of the DCE registered security systems, the reserved value <see cref="SECPKG_ID_NONE"/> is used.
        /// </summary>
        public ushort wRPCID;              // ID for RPC Runtime
        /// <summary>
        /// Specifies the maximum size, in bytes, of the token.
        /// </summary>
        public uint cbMaxToken;           // Size of authentication token (max)
        #region public Span<char> Name;
        internal IntPtr NamePtr;
        /// <summary>
        /// A span of Unicode characters that contain the name of the security package.
        /// </summary>
        public Span<char> Name => NamePtr.ToZeroTerminatedUnicodeSpan();
        #endregion
        #region public Span<char> Comment;
        internal IntPtr CommentPtr;
        /// <summary>
        /// A span of Unicode characters that contain any additional string passed back by the package.
        /// </summary>
        public Span<char> Comment => CommentPtr.ToZeroTerminatedUnicodeSpan();
        #endregion
    }

    /// <summary>
    /// The <see cref="SecPkgInfoA"/> structure provides general information about a security package, such as its name and capabilities.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/sspi/ns-sspi-secpkginfoa">SecPkgInfoA structure</a></para>
    /// </remarks>
    /// <seealso cref="EnumerateSecurityPackages"/>
    /// <seealso cref="QuerySecurityPackageInfo"/>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SecPkgInfoA
    {
        #region public SECPKG_FLAGS fCapabilities;
        internal uint fCapabilities;        // Capability bitmask
        /// <summary>
        /// Set of bit flags that describes the capabilities of the security package.
        /// </summary>
        public SECPKG_FLAGS Capabilities
        {
            get => (SECPKG_FLAGS)fCapabilities;
            set => fCapabilities = (uint)value;
        }
        #endregion
        /// <summary>
        /// Specifies the version of the package protocol. Must be 1.
        /// </summary>
        public ushort wVersion;            // Version of driver
        /// <summary>
        /// Specifies a DCE RPC identifier, if appropriate. If the package does not implement one of the DCE registered security systems, the reserved value <see cref="SECPKG_ID_NONE"/> is used.
        /// </summary>
        public ushort wRPCID;              // ID for RPC Runtime
        /// <summary>
        /// Specifies the maximum size, in bytes, of the token.
        /// </summary>
        public uint cbMaxToken;           // Size of authentication token (max)
        #region public Span<byte> Name;
        internal IntPtr NamePtr;
        /// <summary>
        /// A span of ANSI character bytes that contain the name of the security package.
        /// </summary>
        public Span<byte> Name => NamePtr.ToZeroTerminatedByteSpan();
        #endregion
        #region public Span<byte> Comment;
        internal IntPtr CommentPtr;
        /// <summary>
        /// A span of ANSI character bytes that contain any additional string passed back by the package.
        /// </summary>
        public Span<byte> Comment => CommentPtr.ToZeroTerminatedByteSpan();
        #endregion
    }
}