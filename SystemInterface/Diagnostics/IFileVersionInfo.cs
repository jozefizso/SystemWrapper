namespace SystemInterface.Diagnostics
{
    public interface IFileVersionInfo : IWrapper<System.Diagnostics.FileVersionInfo>
    {
        string Comments { get; }
        //
        // Summary:
        //     Gets the name of the company that produced the file.
        //
        // Returns:
        //     The name of the company that produced the file or null if the file did not contain
        //     version information.
        string CompanyName { get; }
        //
        // Summary:
        //     Gets the build number of the file.
        //
        // Returns:
        //     A value representing the build number of the file or null if the file did not
        //     contain version information.
        int FileBuildPart { get; }
        //
        // Summary:
        //     Gets the description of the file.
        //
        // Returns:
        //     The description of the file or null if the file did not contain version information.
        string FileDescription { get; }
        //
        // Summary:
        //     Gets the major part of the version number.
        //
        // Returns:
        //     A value representing the major part of the version number or 0 (zero) if the
        //     file did not contain version information.
        int FileMajorPart { get; }
        //
        // Summary:
        //     Gets the minor part of the version number of the file.
        //
        // Returns:
        //     A value representing the minor part of the version number of the file or 0 (zero)
        //     if the file did not contain version information.
        int FileMinorPart { get; }
        //
        // Summary:
        //     Gets the name of the file that this instance of System.Diagnostics.FileVersionInfo
        //     describes.
        //
        // Returns:
        //     The name of the file described by this instance of System.Diagnostics.FileVersionInfo.
        string FileName { get; }
        //
        // Summary:
        //     Gets the file private part number.
        //
        // Returns:
        //     A value representing the file private part number or null if the file did not
        //     contain version information.
        int FilePrivatePart { get; }
        //
        // Summary:
        //     Gets the file version number.
        //
        // Returns:
        //     The version number of the file or null if the file did not contain version information.
        string FileVersion { get; }
        //
        // Summary:
        //     Gets the internal name of the file, if one exists.
        //
        // Returns:
        //     The internal name of the file. If none exists, this property will contain the
        //     original name of the file without the extension.
        string InternalName { get; }
        //
        // Summary:
        //     Gets a value that specifies whether the file contains debugging information or
        //     is compiled with debugging features enabled.
        //
        // Returns:
        //     true if the file contains debugging information or is compiled with debugging
        //     features enabled; otherwise, false.
        bool IsDebug { get; }
        //
        // Summary:
        //     Gets a value that specifies whether the file has been modified and is not identical
        //     to the original shipping file of the same version number.
        //
        // Returns:
        //     true if the file is patched; otherwise, false.
        bool IsPatched { get; }
        //
        // Summary:
        //     Gets a value that specifies whether the file is a development version, rather
        //     than a commercially released product.
        //
        // Returns:
        //     true if the file is prerelease; otherwise, false.
        bool IsPreRelease { get; }
        //
        // Summary:
        //     Gets a value that specifies whether the file was built using standard release
        //     procedures.
        //
        // Returns:
        //     true if the file is a private build; false if the file was built using standard
        //     release procedures or if the file did not contain version information.
        bool IsPrivateBuild { get; }
        //
        // Summary:
        //     Gets a value that specifies whether the file is a special build.
        //
        // Returns:
        //     true if the file is a special build; otherwise, false.
        bool IsSpecialBuild { get; }
        //
        // Summary:
        //     Gets the default language string for the version info block.
        //
        // Returns:
        //     The description string for the Microsoft Language Identifier in the version resource
        //     or null if the file did not contain version information.
        string Language { get; }
        //
        // Summary:
        //     Gets all copyright notices that apply to the specified file.
        //
        // Returns:
        //     The copyright notices that apply to the specified file.
        string LegalCopyright { get; }
        //
        // Summary:
        //     Gets the trademarks and registered trademarks that apply to the file.
        //
        // Returns:
        //     The trademarks and registered trademarks that apply to the file or null if the
        //     file did not contain version information.
        string LegalTrademarks { get; }
        //
        // Summary:
        //     Gets the name the file was created with.
        //
        // Returns:
        //     The name the file was created with or null if the file did not contain version
        //     information.
        string OriginalFilename { get; }
        //
        // Summary:
        //     Gets information about a private version of the file.
        //
        // Returns:
        //     Information about a private version of the file or null if the file did not contain
        //     version information.
        string PrivateBuild { get; }
        //
        // Summary:
        //     Gets the build number of the product this file is associated with.
        //
        // Returns:
        //     A value representing the build number of the product this file is associated
        //     with or null if the file did not contain version information.
        int ProductBuildPart { get; }
        //
        // Summary:
        //     Gets the major part of the version number for the product this file is associated
        //     with.
        //
        // Returns:
        //     A value representing the major part of the product version number or null if
        //     the file did not contain version information.
        int ProductMajorPart { get; }
        //
        // Summary:
        //     Gets the minor part of the version number for the product the file is associated
        //     with.
        //
        // Returns:
        //     A value representing the minor part of the product version number or null if
        //     the file did not contain version information.
        int ProductMinorPart { get; }
        //
        // Summary:
        //     Gets the name of the product this file is distributed with.
        //
        // Returns:
        //     The name of the product this file is distributed with or null if the file did
        //     not contain version information.
        string ProductName { get; }
        //
        // Summary:
        //     Gets the private part number of the product this file is associated with.
        //
        // Returns:
        //     A value representing the private part number of the product this file is associated
        //     with or null if the file did not contain version information.
        int ProductPrivatePart { get; }
        //
        // Summary:
        //     Gets the version of the product this file is distributed with.
        //
        // Returns:
        //     The version of the product this file is distributed with or null if the file
        //     did not contain version information.
        string ProductVersion { get; }
        //
        // Summary:
        //     Gets the special build information for the file.
        //
        // Returns:
        //     The special build information for the file or null if the file did not contain
        //     version information.
        string SpecialBuild { get; }
    }
}
