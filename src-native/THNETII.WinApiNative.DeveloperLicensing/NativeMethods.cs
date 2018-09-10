﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace THNETII.WinApiNative.ApplicationInstallationServicing.DeveloperLicensing
{
    public static class NativeMethods
    {
        private const string WSClientDll = @"WSClient.dll";

        #region AcquireDeveloperLicense function
        /// <summary>
        /// Acquires a developer license.
        /// </summary>
        /// <param name="hwndParent">The handler to the parent window.</param>
        /// <returns>Indicates when the developer license expires.</returns>
        /// <remarks>
        /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/wsdevlicensing/nf-wsdevlicensing-acquiredeveloperlicense">AcquireDeveloperLicense function</a></para>
        /// </remarks>
        /// <exception cref="ArgumentException">One or more arguments are invalid.</exception>
        /// <exception cref="COMException">
        /// The <see cref="Exception.HResult"/> property of the thrown exception indicate the nature of the error that occurred.
        /// Possible value include, but are not limited to, the values listed in the table below.
        /// <list type="table">
        /// <listheader><term>Error code</term><description>Description</description></listheader>
        /// <item><term><see cref=""/></term><description></description></item>
        /// <item><term><see cref=""/></term><description></description></item>
        /// <item><term><see cref=""/></term><description></description></item>
        /// <item><term><see cref=""/></term><description></description></item>
        /// <item><term><see cref=""/></term><description></description></item>
        /// </list>
        /// </exception>
        [DllImport(WSClientDll, CallingConvention = CallingConvention.StdCall, PreserveSig = false)]
        public static extern FILETIME AcquireDeveloperLicense(
            [In] IntPtr hwndParent
            );
        #endregion
    }
}
