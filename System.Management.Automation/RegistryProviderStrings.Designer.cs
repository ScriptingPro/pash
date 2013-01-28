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
    public class RegistryProviderStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RegistryProviderStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.RegistryProviderStrings", typeof(RegistryProviderStrings).Assembly);
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
        ///   Looks up a localized string similar to The security identifier is not allowed to be the primary group of this object..
        /// </summary>
        public static string AccessControl_InvalidGroup {
            get {
                return ResourceManager.GetString("AccessControl_InvalidGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handle specified is not valid..
        /// </summary>
        public static string AccessControl_InvalidHandle {
            get {
                return ResourceManager.GetString("AccessControl_InvalidHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The security identifier is not allowed to be the owner of this object..
        /// </summary>
        public static string AccessControl_InvalidOwner {
            get {
                return ResourceManager.GetString("AccessControl_InvalidOwner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to perform a security operation on an object that has no associated security. This can happen when trying to get an ACL of an anonymous kernel object..
        /// </summary>
        public static string AccessControl_NoAssociatedSecurity {
            get {
                return ResourceManager.GetString("AccessControl_NoAssociatedSecurity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method failed with unexpected error code {0}..
        /// </summary>
        public static string AccessControl_UnexpectedError {
            get {
                return ResourceManager.GetString("AccessControl_UnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Property Value At.
        /// </summary>
        public static string AddPropertyValueAtAction {
            get {
                return ResourceManager.GetString("AddPropertyValueAtAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1} At: {2}.
        /// </summary>
        public static string AddPropertyValueAtResourceTemplate {
            get {
                return ResourceManager.GetString("AddPropertyValueAtResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal enum value: {0}..
        /// </summary>
        public static string Arg_EnumIllegalVal {
            get {
                return ResourceManager.GetString("Arg_EnumIllegalVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A name argument must be specified..
        /// </summary>
        public static string Arg_Name {
            get {
                return ResourceManager.GetString("Arg_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified RegistryValueKind is a value that is not valid..
        /// </summary>
        public static string Arg_RegBadKeyKind {
            get {
                return ResourceManager.GetString("Arg_RegBadKeyKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry key name must start with a valid base key name..
        /// </summary>
        public static string Arg_RegInvalidKeyName {
            get {
                return ResourceManager.GetString("Arg_RegInvalidKeyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified registry key does not exist..
        /// </summary>
        public static string Arg_RegKeyNotFound {
            get {
                return ResourceManager.GetString("Arg_RegKeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-empty subkey name must be specified..
        /// </summary>
        public static string Arg_RegKeyStrEmpty {
            get {
                return ResourceManager.GetString("Arg_RegKeyStrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry subkeys should not be greater than 255 characters..
        /// </summary>
        public static string Arg_RegKeyStrLenBug {
            get {
                return ResourceManager.GetString("Arg_RegKeyStrLenBug", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RegistryKey.SetValue does not support arrays of type &apos;{0}&apos;. Only Byte[] and String[] are supported..
        /// </summary>
        public static string Arg_RegSetBadArrType {
            get {
                return ResourceManager.GetString("Arg_RegSetBadArrType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of the value object did not match the specified RegistryValueKind or the object could not be properly converted..
        /// </summary>
        public static string Arg_RegSetMismatchedKind {
            get {
                return ResourceManager.GetString("Arg_RegSetMismatchedKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RegistryKey.SetValue does not allow a String[] that contains a null String reference..
        /// </summary>
        public static string Arg_RegSetStrArrNull {
            get {
                return ResourceManager.GetString("Arg_RegSetStrArrNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete a subkey tree because the subkey does not exist..
        /// </summary>
        public static string Arg_RegSubKeyAbsent {
            get {
                return ResourceManager.GetString("Arg_RegSubKeyAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No value exists with that name..
        /// </summary>
        public static string Arg_RegSubKeyValueAbsent {
            get {
                return ResourceManager.GetString("Arg_RegSubKeyValueAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of the specified value name exceeds the maximum of 16383 characters..
        /// </summary>
        public static string Arg_RegValueNameStrLenBug {
            get {
                return ResourceManager.GetString("Arg_RegValueNameStrLenBug", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value argument must be specified..
        /// </summary>
        public static string Arg_Value {
            get {
                return ResourceManager.GetString("Arg_Value", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length of the specified value data exceeds the maximum of 1 MB..
        /// </summary>
        public static string Arg_ValueDataLenBug {
            get {
                return ResourceManager.GetString("Arg_ValueDataLenBug", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The subkey argument is not valid..
        /// </summary>
        public static string ArgRegKeyDelHive {
            get {
                return ResourceManager.GetString("ArgRegKeyDelHive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified privilege name is not valid..
        /// </summary>
        public static string Argument_InvalidPrivilegeName {
            get {
                return ResourceManager.GetString("Argument_InvalidPrivilegeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified RegistryKeyPermissionCheck value is not valid..
        /// </summary>
        public static string Argument_InvalidRegistryKeyPermissionCheck {
            get {
                return ResourceManager.GetString("Argument_InvalidRegistryKeyPermissionCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SafeHandle is not valid..
        /// </summary>
        public static string Argument_InvalidSafeHandle {
            get {
                return ResourceManager.GetString("Argument_InvalidSafeHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified registry subkey does not exist..
        /// </summary>
        public static string ArgumentException_RegSubKeyAbsent {
            get {
                return ResourceManager.GetString("ArgumentException_RegSubKeyAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A transaction argument must be specified..
        /// </summary>
        public static string ArgumentException_TransactionAbsent {
            get {
                return ResourceManager.GetString("ArgumentException_TransactionAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The at parameter must be an integer to index a specific property value..
        /// </summary>
        public static string BadAtParam {
            get {
                return ResourceManager.GetString("BadAtParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear Item.
        /// </summary>
        public static string ClearItemAction {
            get {
                return ResourceManager.GetString("ClearItemAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0}.
        /// </summary>
        public static string ClearItemResourceTemplate {
            get {
                return ResourceManager.GetString("ClearItemResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear Property.
        /// </summary>
        public static string ClearPropertyAction {
            get {
                return ResourceManager.GetString("ClearPropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1}.
        /// </summary>
        public static string ClearPropertyResourceTemplate {
            get {
                return ResourceManager.GetString("ClearPropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation not processed. Location provided does not allow this operation..
        /// </summary>
        public static string ContainerInvalidOperationTemplate {
            get {
                return ResourceManager.GetString("ContainerInvalidOperationTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy Key.
        /// </summary>
        public static string CopyKeyAction {
            get {
                return ResourceManager.GetString("CopyKeyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Destination: {1}.
        /// </summary>
        public static string CopyKeyResourceTemplate {
            get {
                return ResourceManager.GetString("CopyKeyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy property..
        /// </summary>
        public static string CopyPropertyAction {
            get {
                return ResourceManager.GetString("CopyPropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} SourceProperty: {1} DestinationItem: {2} DestinationProperty: {3}.
        /// </summary>
        public static string CopyPropertyResourceTemplate {
            get {
                return ResourceManager.GetString("CopyPropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (default).
        /// </summary>
        public static string DefaultValueName {
            get {
                return ResourceManager.GetString("DefaultValueName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be performed because the destination path is subordinate to the source path..
        /// </summary>
        public static string DestinationChildOfSource {
            get {
                return ResourceManager.GetString("DestinationChildOfSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation not allowed on destination location..
        /// </summary>
        public static string DestinationContainerInvalidOperationTemplate {
            get {
                return ResourceManager.GetString("DestinationContainerInvalidOperationTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The software settings for the current user..
        /// </summary>
        public static string HKCUDriveDescription {
            get {
                return ResourceManager.GetString("HKCUDriveDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration settings for the local computer.
        /// </summary>
        public static string HKLMDriveDescription {
            get {
                return ResourceManager.GetString("HKLMDriveDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect thread for enabling or disabling a privilege..
        /// </summary>
        public static string InvalidOperation_MustBeSameThread {
            get {
                return ResourceManager.GetString("InvalidOperation_MustBeSameThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Privilege must be reverted before changing its state again..
        /// </summary>
        public static string InvalidOperation_MustRevertPrivilege {
            get {
                return ResourceManager.GetString("InvalidOperation_MustRevertPrivilege", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified transaction or Transaction.Current must match the transaction used to create or open this TransactedRegistryKey..
        /// </summary>
        public static string InvalidOperation_MustUseSameTransaction {
            get {
                return ResourceManager.GetString("InvalidOperation_MustUseSameTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a KTM handle without a Transaction.Current or specified transaction..
        /// </summary>
        public static string InvalidOperation_NeedTransaction {
            get {
                return ResourceManager.GetString("InvalidOperation_NeedTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object does not contain a security descriptor..
        /// </summary>
        public static string InvalidOperation_NoSecurityDescriptor {
            get {
                return ResourceManager.GetString("InvalidOperation_NoSecurityDescriptor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TransactedRegistryKey object is not associated with a transaction because it is for a predefined key..
        /// </summary>
        public static string InvalidOperation_NotAssociatedWithTransaction {
            get {
                return ResourceManager.GetString("InvalidOperation_NotAssociatedWithTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry key has subkeys and recursive removes are not supported by this method..
        /// </summary>
        public static string InvalidOperation_RegRemoveSubKey {
            get {
                return ResourceManager.GetString("InvalidOperation_RegRemoveSubKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remote registry operations are not allowed with transactions..
        /// </summary>
        public static string InvalidOperation_RemoteNotAllowed {
            get {
                return ResourceManager.GetString("InvalidOperation_RemoteNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A key at this path already exists.
        /// </summary>
        public static string KeyAlreadyExists {
            get {
                return ResourceManager.GetString("KeyAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key {0} has been created, however default value could not be set..
        /// </summary>
        public static string KeyCreatedValueFailed {
            get {
                return ResourceManager.GetString("KeyCreatedValueFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The registry key at the specified path does not exist..
        /// </summary>
        public static string KeyDoesNotExist {
            get {
                return ResourceManager.GetString("KeyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move Item.
        /// </summary>
        public static string MoveItemAction {
            get {
                return ResourceManager.GetString("MoveItemAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Destination: {1}.
        /// </summary>
        public static string MoveItemResourceTemplate {
            get {
                return ResourceManager.GetString("MoveItemResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move Property.
        /// </summary>
        public static string MovePropertyAction {
            get {
                return ResourceManager.GetString("MovePropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} SourceProperty: {1} DestinationItem: {2} DestinationProperty: {3}.
        /// </summary>
        public static string MovePropertyResourceTemplate {
            get {
                return ResourceManager.GetString("MovePropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create a drive with the specified root. The root path does not exist..
        /// </summary>
        public static string NewDriveRootDoesNotExist {
            get {
                return ResourceManager.GetString("NewDriveRootDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Item.
        /// </summary>
        public static string NewItemAction {
            get {
                return ResourceManager.GetString("NewItemAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0}.
        /// </summary>
        public static string NewItemResourceTemplate {
            get {
                return ResourceManager.GetString("NewItemResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Type: {1}.
        /// </summary>
        public static string NewItemResourceTemplateWithType {
            get {
                return ResourceManager.GetString("NewItemResourceTemplateWithType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Property.
        /// </summary>
        public static string NewPropertyAction {
            get {
                return ResourceManager.GetString("NewPropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1}.
        /// </summary>
        public static string NewPropertyResourceTemplate {
            get {
                return ResourceManager.GetString("NewPropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry transactions are not supported on this platform..
        /// </summary>
        public static string NotSupported_KernelTransactions {
            get {
                return ResourceManager.GetString("NotSupported_KernelTransactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a closed registry key..
        /// </summary>
        public static string ObjectDisposed_RegKeyClosed {
            get {
                return ResourceManager.GetString("ObjectDisposed_RegKeyClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property already exists..
        /// </summary>
        public static string PropertyAlreadyExists {
            get {
                return ResourceManager.GetString("PropertyAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property {0} does not exist at path {1}..
        /// </summary>
        public static string PropertyNotAtPath {
            get {
                return ResourceManager.GetString("PropertyNotAtPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property is not a multi-valued property. To remove this property, use Remove-ItemProperty..
        /// </summary>
        public static string PropertyNotMultivalued {
            get {
                return ResourceManager.GetString("PropertyNotMultivalued", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property is not a multi-valued property and values cannot be added to it. To change the value use Set-ItemProperty..
        /// </summary>
        public static string PropertyNotMultivaluedChange {
            get {
                return ResourceManager.GetString("PropertyNotMultivaluedChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove key..
        /// </summary>
        public static string RemoveKeyAction {
            get {
                return ResourceManager.GetString("RemoveKeyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0}.
        /// </summary>
        public static string RemoveKeyResourceTemplate {
            get {
                return ResourceManager.GetString("RemoveKeyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Property.
        /// </summary>
        public static string RemovePropertyAction {
            get {
                return ResourceManager.GetString("RemovePropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1}.
        /// </summary>
        public static string RemovePropertyResourceTemplate {
            get {
                return ResourceManager.GetString("RemovePropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Property Value At.
        /// </summary>
        public static string RemovePropertyValueAtAction {
            get {
                return ResourceManager.GetString("RemovePropertyValueAtAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1} At: {2}.
        /// </summary>
        public static string RemovePropertyValueAtResourceTemplate {
            get {
                return ResourceManager.GetString("RemovePropertyValueAtResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename Item.
        /// </summary>
        public static string RenameItemAction {
            get {
                return ResourceManager.GetString("RenameItemAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The item cannot be renamed because an item with that name already exists in the same container..
        /// </summary>
        public static string RenameItemAlreadyExists {
            get {
                return ResourceManager.GetString("RenameItemAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} NewName: {1}.
        /// </summary>
        public static string RenameItemResourceTemplate {
            get {
                return ResourceManager.GetString("RenameItemResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename property..
        /// </summary>
        public static string RenamePropertyAction {
            get {
                return ResourceManager.GetString("RenamePropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} SourceProperty: {1} DestinationProperty: {2}.
        /// </summary>
        public static string RenamePropertyResourceTemplate {
            get {
                return ResourceManager.GetString("RenamePropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested registry access is not allowed..
        /// </summary>
        public static string Security_RegistryPermission {
            get {
                return ResourceManager.GetString("Security_RegistryPermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Item.
        /// </summary>
        public static string SetItemAction {
            get {
                return ResourceManager.GetString("SetItemAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Value: {1}.
        /// </summary>
        public static string SetItemResourceTemplate {
            get {
                return ResourceManager.GetString("SetItemResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Property.
        /// </summary>
        public static string SetPropertyAction {
            get {
                return ResourceManager.GetString("SetPropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1}.
        /// </summary>
        public static string SetPropertyResourceTemplate {
            get {
                return ResourceManager.GetString("SetPropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Property Value At.
        /// </summary>
        public static string SetPropertyValueAtAction {
            get {
                return ResourceManager.GetString("SetPropertyValueAtAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1} At: {2}.
        /// </summary>
        public static string SetPropertyValueAtResourceTemplate {
            get {
                return ResourceManager.GetString("SetPropertyValueAtResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation not allowed on source location..
        /// </summary>
        public static string SourceContainerInvalidOperationTemplate {
            get {
                return ResourceManager.GetString("SourceContainerInvalidOperationTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction related error {0} occurred..
        /// </summary>
        public static string Transaction_Error {
            get {
                return ResourceManager.GetString("Transaction_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not bind parameter &apos;Type&apos;. Could not convert &quot;{0}&quot; to &quot;{1}&quot;. The possible enumeration values are &quot;String, ExpandString, Binary, DWord, MultiString, QWord, Unknown&quot;..
        /// </summary>
        public static string TypeParameterBindingFailure {
            get {
                return ResourceManager.GetString("TypeParameterBindingFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to the registry key &apos;{0}&apos; is denied..
        /// </summary>
        public static string UnauthorizedAccess_RegistryKeyGeneric_Key {
            get {
                return ResourceManager.GetString("UnauthorizedAccess_RegistryKeyGeneric_Key", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write to the registry key..
        /// </summary>
        public static string UnauthorizedAccess_RegistryNoWrite {
            get {
                return ResourceManager.GetString("UnauthorizedAccess_RegistryNoWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error: {0}..
        /// </summary>
        public static string UnknownError_Num {
            get {
                return ResourceManager.GetString("UnknownError_Num", resourceCulture);
            }
        }
    }
}