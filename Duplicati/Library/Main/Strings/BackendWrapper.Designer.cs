﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Main.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class BackendWrapper {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BackendWrapper() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Main.Strings.BackendWrapper", typeof(BackendWrapper).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backend {0} ({1}) does not support the CreateFolder operation .
        /// </summary>
        internal static string BackendDoesNotSupportCreateFolder {
            get {
                return ResourceManager.GetString("BackendDoesNotSupportCreateFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find backend for: {0}.
        /// </summary>
        internal static string BackendNotFoundError {
            get {
                return ResourceManager.GetString("BackendNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to decrypt file {0} failed with error: {1}.
        /// </summary>
        internal static string CachedSignatureDecryptWarning {
            get {
                return ResourceManager.GetString("CachedSignatureDecryptWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cache file {0} did not match the expected hash for the same file, ignoring cache file.
        /// </summary>
        internal static string CachedSignatureHashMismatchWarning {
            get {
                return ResourceManager.GetString("CachedSignatureHashMismatchWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while attempting to delete cache file {0}.
        /// </summary>
        internal static string DeleteCacheFileError {
            get {
                return ResourceManager.GetString("DeleteCacheFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was found multiple times in the file list, this is likely an error in the backend, please report it to the developers.
        /// </summary>
        internal static string DuplicateFileEntryWarning {
            get {
                return ResourceManager.GetString("DuplicateFileEntryWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty backupset detected, this is likely an error: {0}.
        /// </summary>
        internal static string EmptyManifestWarning {
            get {
                return ResourceManager.GetString("EmptyManifestWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while closing a connection: {0}.
        /// </summary>
        internal static string FailureWhileDisposingBackendError {
            get {
                return ResourceManager.GetString("FailureWhileDisposingBackendError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete file &quot;{0}&quot;: {1}.
        /// </summary>
        internal static string FileDeleteError2 {
            get {
                return ResourceManager.GetString("FileDeleteError2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download file &quot;{0}&quot;: {1}.
        /// </summary>
        internal static string FileDownloadError2 {
            get {
                return ResourceManager.GetString("FileDownloadError2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve file listing: {0}.
        /// </summary>
        internal static string FileListingError {
            get {
                return ResourceManager.GetString("FileListingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse filenames for the desired volumes.
        /// </summary>
        internal static string FilenameParseError {
            get {
                return ResourceManager.GetString("FilenameParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No files removed, specify --force to remove files..
        /// </summary>
        internal static string FilesNotForceRemovedMessage {
            get {
                return ResourceManager.GetString("FilesNotForceRemovedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to upload file &quot;{0}&quot;: {1}.
        /// </summary>
        internal static string FileUploadError2 {
            get {
                return ResourceManager.GetString("FileUploadError2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find function: {0}.
        /// </summary>
        internal static string FunctionLookupError {
            get {
                return ResourceManager.GetString("FunctionLookupError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hash mismatch on file &quot;{0}&quot;, recorded hash: {1}, actual hash {2}.
        /// </summary>
        internal static string HashMismatchError {
            get {
                return ResourceManager.GetString("HashMismatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid entry type: {0}.
        /// </summary>
        internal static string InvalidEntryTypeError {
            get {
                return ResourceManager.GetString("InvalidEntryTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No backups found at remote location.
        /// </summary>
        internal static string NoBackupsFoundError {
            get {
                return ResourceManager.GetString("NoBackupsFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to match incremental package to a full: {0}.
        /// </summary>
        internal static string OrphanIncrementalFoundMessage {
            get {
                return ResourceManager.GetString("OrphanIncrementalFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found a partial file, run cleanup to remove: {0}.
        /// </summary>
        internal static string PartialFileFoundMessage {
            get {
                return ResourceManager.GetString("PartialFileFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting orphan file: {0}.
        /// </summary>
        internal static string RemoveOrphanFileWarning {
            get {
                return ResourceManager.GetString("RemoveOrphanFileWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing leftover file: {0}.
        /// </summary>
        internal static string RemovingLeftoverFileMessage {
            get {
                return ResourceManager.GetString("RemovingLeftoverFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to save the cached signature file as {0}.
        /// </summary>
        internal static string SaveCacheFileError {
            get {
                return ResourceManager.GetString("SaveCacheFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading: {0}.
        /// </summary>
        internal static string StatusMessageDownloading {
            get {
                return ResourceManager.GetString("StatusMessageDownloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading: {0} ({1}).
        /// </summary>
        internal static string StatusMessageUploading {
            get {
                return ResourceManager.GetString("StatusMessageUploading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto-cleanup specified but there are {0} orphan files, and there should not be more than 2.
        /// </summary>
        internal static string TooManyOrphansFoundError {
            get {
                return ResourceManager.GetString("TooManyOrphansFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was found on the backend but not recognized by Duplicati.
        /// </summary>
        internal static string UnmatchedFilenameWarning {
            get {
                return ResourceManager.GetString("UnmatchedFilenameWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was uploaded to the server, but the reported filesize was {1} and the size was expected to be {2}.
        /// </summary>
        internal static string UploadSizeVerificationFailure {
            get {
                return ResourceManager.GetString("UploadSizeVerificationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was uploaded but not found on the server.
        /// </summary>
        internal static string UploadVerificationFailure {
            get {
                return ResourceManager.GetString("UploadVerificationFailure", resourceCulture);
            }
        }
    }
}
