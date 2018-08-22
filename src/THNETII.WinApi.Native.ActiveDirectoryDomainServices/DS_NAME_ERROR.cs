﻿namespace THNETII.WinApi.Native.ActiveDirectoryDomainServices
{
    /// <summary>
    /// The <see cref="DS_NAME_ERROR"/> enumeration defines the errors returned by the status member of the <see cref="DS_NAME_RESULT_ITEM"/> structure. These are potential errors that may be encountered while a name is converted by the <see cref="DsCrackNames"/> function.
    /// </summary>
    /// <remarks>
    /// <para>Original MSDN documentation page: <a href="https://docs.microsoft.com/en-us/windows/desktop/api/ntdsapi/ne-ntdsapi-ds_name_error">DS_NAME_ERROR Enumeration</a></para>
    /// </remarks>
    /// <seealso cref="DS_NAME_RESULT_ITEM"/>
    /// <seealso cref="DsCrackNames"/>
    public enum DS_NAME_ERROR
    {
        /// <summary>
        /// The conversion was successful.
        /// </summary>
        DS_NAME_NO_ERROR = 0,

        /// <summary>
        /// A generic processing error occurred.
        /// </summary>
        DS_NAME_ERROR_RESOLVING = 1,

        /// <summary>
        /// The name cannot be found or the caller does not have permission to access the name.
        /// </summary>
        DS_NAME_ERROR_NOT_FOUND = 2,

        /// <summary>
        /// The input name is mapped to more than one output name or the desired format did not have a single, unique value for the object found.
        /// </summary>
        DS_NAME_ERROR_NOT_UNIQUE = 3,

        /// <summary>
        /// The input name was found, but the associated output format cannot be found. This can occur if the object does not have all the required attributes.
        /// </summary>
        DS_NAME_ERROR_NO_MAPPING = 4,

        /// <summary>
        /// Unable to resolve entire name, but was able to determine in which domain object resides. The caller is expected to retry the call at a domain controller for the specified domain. The entire name cannot be resolved, but the domain that the object resides in could be determined. The <see cref="DS_NAME_RESULT_ITEM.pDomain"/> member of the <see cref="DS_NAME_RESULT_ITEM"/> contains valid data when this error is specified.
        /// </summary>
        DS_NAME_ERROR_DOMAIN_ONLY = 5,

        /// <summary>
        /// A syntactical mapping cannot be performed on the client without transmitting over the network.
        /// </summary>
        DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 6,

        /// <summary>
        /// The name is from an external trusted forest.
        /// </summary>
        DS_NAME_ERROR_TRUST_REFERRAL = 7
    }
}
