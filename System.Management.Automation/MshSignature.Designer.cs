﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Management.Automation {
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
    public class MshSignature {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MshSignature() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.MshSignature", typeof(MshSignature).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The contents of file {0} may have been tampered because the hash of the file does not match the hash stored in the digital signature. The script will not execute on the system. Please see &quot;get-help about_signing&quot; for more details..
        /// </summary>
        public static string MshSignature_HashMismatch {
            get {
                return ResourceManager.GetString("MshSignature_HashMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature cannot be verified because it is incompatible with the current system..
        /// </summary>
        public static string MshSignature_Incompatible {
            get {
                return ResourceManager.GetString("MshSignature_Incompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature cannot be verified because it is incompatible with the current system. The hash algorithm is invalid..
        /// </summary>
        public static string MshSignature_Incompatible_HashAlgorithm {
            get {
                return ResourceManager.GetString("MshSignature_Incompatible_HashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is not digitally signed. The script will not execute on the system. For more information, see about_Execution_Policies at http://go.microsoft.com/fwlink/?LinkID=135170.
        /// </summary>
        public static string MshSignature_NotSigned {
            get {
                return ResourceManager.GetString("MshSignature_NotSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot sign file because the system does not support signing operations on {0} files..
        /// </summary>
        public static string MshSignature_NotSupportedFileFormat {
            get {
                return ResourceManager.GetString("MshSignature_NotSupportedFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot sign file because the system does not support signing operations on files without a file extension..
        /// </summary>
        public static string MshSignature_NotSupportedFileFormat_NoExtension {
            get {
                return ResourceManager.GetString("MshSignature_NotSupportedFileFormat_NoExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} is signed but the signer is not trusted on this system..
        /// </summary>
        public static string MshSignature_NotTrusted {
            get {
                return ResourceManager.GetString("MshSignature_NotTrusted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature verified..
        /// </summary>
        public static string MshSignature_Valid {
            get {
                return ResourceManager.GetString("MshSignature_Valid", resourceCulture);
            }
        }
    }
}