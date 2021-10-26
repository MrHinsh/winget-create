//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.4.3.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Microsoft.WingetCreateCore.Models.Singleton
{
    #pragma warning disable // Disable all warnings

    /// <summary>Enumeration of supported installer types. InstallerType is required in either root level or individual Installer level</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum InstallerType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"msix")]
        Msix = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"msi")]
        Msi = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"appx")]
        Appx = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"exe")]
        Exe = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"zip")]
        Zip = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"inno")]
        Inno = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"nullsoft")]
        Nullsoft = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"wix")]
        Wix = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"burn")]
        Burn = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"pwa")]
        Pwa = 9,
    
    }
    
    /// <summary>Scope indicates if the installer is per user or per machine</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Scope
    {
        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"machine")]
        Machine = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InstallerSwitches 
    {
        /// <summary>Silent is the value that should be passed to the installer when user chooses a silent or quiet install</summary>
        [Newtonsoft.Json.JsonProperty("Silent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string Silent { get; set; }
    
        /// <summary>SilentWithProgress is the value that should be passed to the installer when user chooses a non-interactive install</summary>
        [Newtonsoft.Json.JsonProperty("SilentWithProgress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string SilentWithProgress { get; set; }
    
        /// <summary>Interactive is the value that should be passed to the installer when user chooses an interactive install</summary>
        [Newtonsoft.Json.JsonProperty("Interactive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string Interactive { get; set; }
    
        /// <summary>InstallLocation is the value passed to the installer for custom install location. &lt;INSTALLPATH&gt; token can be included in the switch value so that winget will replace the token with user provided path</summary>
        [Newtonsoft.Json.JsonProperty("InstallLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string InstallLocation { get; set; }
    
        /// <summary>Log is the value passed to the installer for custom log file path. &lt;LOGPATH&gt; token can be included in the switch value so that winget will replace the token with user provided path</summary>
        [Newtonsoft.Json.JsonProperty("Log", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string Log { get; set; }
    
        /// <summary>Upgrade is the value that should be passed to the installer when user chooses an upgrade</summary>
        [Newtonsoft.Json.JsonProperty("Upgrade", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 1)]
        public string Upgrade { get; set; }
    
        /// <summary>Custom switches will be passed directly to the installer by winget</summary>
        [Newtonsoft.Json.JsonProperty("Custom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048, MinimumLength = 1)]
        public string Custom { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The upgrade method</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum UpgradeBehavior
    {
        [System.Runtime.Serialization.EnumMember(Value = @"install")]
        Install = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"uninstallPrevious")]
        UninstallPrevious = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Dependencies 
    {
        /// <summary>List of Windows feature dependencies</summary>
        [Newtonsoft.Json.JsonProperty("WindowsFeatures", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> WindowsFeatures { get; set; }
    
        /// <summary>List of Windows library dependencies</summary>
        [Newtonsoft.Json.JsonProperty("WindowsLibraries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> WindowsLibraries { get; set; }
    
        /// <summary>List of package dependencies from current source</summary>
        [Newtonsoft.Json.JsonProperty("PackageDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<PackageDependencies> PackageDependencies { get; set; }
    
        /// <summary>List of external package dependencies</summary>
        [Newtonsoft.Json.JsonProperty("ExternalDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> ExternalDependencies { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Installer 
    {
        [Newtonsoft.Json.JsonProperty("InstallerLocale", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([a-zA-Z]{2}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*$")]
        public string InstallerLocale { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Platform", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.List<Platform> Platform { get; set; }
    
        [Newtonsoft.Json.JsonProperty("MinimumOSVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])(\.(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])){0,3}$")]
        public string MinimumOSVersion { get; set; }
    
        /// <summary>The installer target architecture</summary>
        [Newtonsoft.Json.JsonProperty("Architecture", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstallerArchitecture Architecture { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstallerType? InstallerType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Scope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Scope? Scope { get; set; }
    
        /// <summary>The installer Url</summary>
        [Newtonsoft.Json.JsonProperty("InstallerUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string InstallerUrl { get; set; }
    
        /// <summary>Sha256 is required. Sha256 of the installer</summary>
        [Newtonsoft.Json.JsonProperty("InstallerSha256", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[A-Fa-f0-9]{64}$")]
        public string InstallerSha256 { get; set; }
    
        /// <summary>SignatureSha256 is recommended for appx or msix. It is the sha256 of signature file inside appx or msix. Could be used during streaming install if applicable</summary>
        [Newtonsoft.Json.JsonProperty("SignatureSha256", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[A-Fa-f0-9]{64}$")]
        public string SignatureSha256 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallModes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.List<InstallModes> InstallModes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerSwitches", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstallerSwitches InstallerSwitches { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerSuccessCodes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<long> InstallerSuccessCodes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("UpgradeBehavior", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UpgradeBehavior? UpgradeBehavior { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Commands", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Commands { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Protocols", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Protocols { get; set; }
    
        [Newtonsoft.Json.JsonProperty("FileExtensions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(256)]
        public System.Collections.Generic.List<string> FileExtensions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Dependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Dependencies Dependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("PackageFamilyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[A-Za-z0-9][-\.A-Za-z0-9]+_[A-Za-z0-9]{13}$")]
        public string PackageFamilyName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ProductCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255, MinimumLength = 1)]
        public string ProductCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Capabilities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(1000)]
        public System.Collections.Generic.List<string> Capabilities { get; set; }
    
        [Newtonsoft.Json.JsonProperty("RestrictedCapabilities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(1000)]
        public System.Collections.Generic.List<string> RestrictedCapabilities { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>A representation of a single-file manifest representing an app in the OWC. v1.0.0</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SingletonManifest 
    {
        [Newtonsoft.Json.JsonProperty("PackageIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}(\.[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}){1,3}$")]
        public string PackageIdentifier { get; set; }
    
        [Newtonsoft.Json.JsonProperty("PackageVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\\/:\*\?""<>\|\x01-\x1f]+$")]
        public string PackageVersion { get; set; }
    
        /// <summary>The package meta-data locale</summary>
        [Newtonsoft.Json.JsonProperty("PackageLocale", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([a-zA-Z]{2}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*$")]
        public string PackageLocale { get; set; }
    
        /// <summary>The publisher name</summary>
        [Newtonsoft.Json.JsonProperty("Publisher", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string Publisher { get; set; }
    
        /// <summary>The publisher home page</summary>
        [Newtonsoft.Json.JsonProperty("PublisherUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PublisherUrl { get; set; }
    
        /// <summary>The publisher support page</summary>
        [Newtonsoft.Json.JsonProperty("PublisherSupportUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PublisherSupportUrl { get; set; }
    
        /// <summary>The publisher privacy page or the package privacy page</summary>
        [Newtonsoft.Json.JsonProperty("PrivacyUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PrivacyUrl { get; set; }
    
        /// <summary>The package author</summary>
        [Newtonsoft.Json.JsonProperty("Author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string Author { get; set; }
    
        /// <summary>The package name</summary>
        [Newtonsoft.Json.JsonProperty("PackageName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string PackageName { get; set; }
    
        /// <summary>The package home page</summary>
        [Newtonsoft.Json.JsonProperty("PackageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PackageUrl { get; set; }
    
        /// <summary>The package license</summary>
        [Newtonsoft.Json.JsonProperty("License", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 3)]
        public string License { get; set; }
    
        /// <summary>The license page</summary>
        [Newtonsoft.Json.JsonProperty("LicenseUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string LicenseUrl { get; set; }
    
        /// <summary>The package copyright</summary>
        [Newtonsoft.Json.JsonProperty("Copyright", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 3)]
        public string Copyright { get; set; }
    
        /// <summary>The package copyright page</summary>
        [Newtonsoft.Json.JsonProperty("CopyrightUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string CopyrightUrl { get; set; }
    
        /// <summary>The short package description</summary>
        [Newtonsoft.Json.JsonProperty("ShortDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 3)]
        public string ShortDescription { get; set; }
    
        /// <summary>The full package description</summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 3)]
        public string Description { get; set; }
    
        /// <summary>The most common package term</summary>
        [Newtonsoft.Json.JsonProperty("Moniker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(40, MinimumLength = 1)]
        public string Moniker { get; set; }
    
        /// <summary>List of additional package search terms</summary>
        [Newtonsoft.Json.JsonProperty("Tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Tags { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Channel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16, MinimumLength = 1)]
        public string Channel { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerLocale", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([a-zA-Z]{2}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*$")]
        public string InstallerLocale { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Platform", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public System.Collections.Generic.List<Platform> Platform { get; set; }
    
        [Newtonsoft.Json.JsonProperty("MinimumOSVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])(\.(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])){0,3}$")]
        public string MinimumOSVersion { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstallerType? InstallerType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Scope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Scope? Scope { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallModes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.List<InstallModes> InstallModes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerSwitches", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstallerSwitches InstallerSwitches { get; set; }
    
        [Newtonsoft.Json.JsonProperty("InstallerSuccessCodes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<long> InstallerSuccessCodes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("UpgradeBehavior", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UpgradeBehavior? UpgradeBehavior { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Commands", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Commands { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Protocols", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Protocols { get; set; }
    
        [Newtonsoft.Json.JsonProperty("FileExtensions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(256)]
        public System.Collections.Generic.List<string> FileExtensions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Dependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Dependencies Dependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("PackageFamilyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[A-Za-z0-9][-\.A-Za-z0-9]+_[A-Za-z0-9]{13}$")]
        public string PackageFamilyName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ProductCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255, MinimumLength = 1)]
        public string ProductCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Capabilities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(1000)]
        public System.Collections.Generic.List<string> Capabilities { get; set; }
    
        [Newtonsoft.Json.JsonProperty("RestrictedCapabilities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(1000)]
        public System.Collections.Generic.List<string> RestrictedCapabilities { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Installers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(1)]
        public System.Collections.Generic.List<Installer> Installers { get; set; } = new System.Collections.Generic.List<Installer>();
    
        /// <summary>The manifest type</summary>
        [Newtonsoft.Json.JsonProperty("ManifestType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ManifestType { get; set; } = "singleton";
    
        /// <summary>The manifest syntax version</summary>
        [Newtonsoft.Json.JsonProperty("ManifestVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])(\.(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])){2}$")]
        public string ManifestVersion { get; set; } = "1.0.0";
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PackageDependencies 
    {
        [Newtonsoft.Json.JsonProperty("PackageIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}(\.[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}){1,3}$")]
        public string PackageIdentifier { get; set; }
    
        [Newtonsoft.Json.JsonProperty("MinimumVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\\/:\*\?""<>\|\x01-\x1f]+$")]
        public string MinimumVersion { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum Platform
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Windows.Desktop")]
        Windows_Desktop = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Windows.Universal")]
        Windows_Universal = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum InstallerArchitecture
    {
        [System.Runtime.Serialization.EnumMember(Value = @"x86")]
        X86 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"x64")]
        X64 = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"arm")]
        Arm = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"arm64")]
        Arm64 = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"neutral")]
        Neutral = 4,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum InstallModes
    {
        [System.Runtime.Serialization.EnumMember(Value = @"interactive")]
        Interactive = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"silent")]
        Silent = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"silentWithProgress")]
        SilentWithProgress = 2,
    
    }
}