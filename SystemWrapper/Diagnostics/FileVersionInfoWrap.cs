using System;
using SystemInterface.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    public class FileVersionInfoWrap : IFileVersionInfo
    {

        private readonly System.Diagnostics.FileVersionInfo instance;
        public FileVersionInfoWrap(System.Diagnostics.FileVersionInfo instance)
        {
            this.instance = instance;
        }

        public string Comments
        {
            get
            {
                return instance.Comments;
            }
        }

        public string CompanyName
        {
            get
            {
                return instance.CompanyName;
            }
        }

        public int FileBuildPart
        {
            get
            {
                return instance.FileBuildPart;
            }
        }

        public string FileDescription
        {
            get
            {
                return instance.FileDescription;
            }
        }

        public int FileMajorPart
        {
            get
            {
                return instance.FileMajorPart;
            }
        }

        public int FileMinorPart
        {
            get
            {
                return instance.FileMinorPart;
            }
        }

        public string FileName
        {
            get
            {
                return instance.FileName;
            }
        }

        public int FilePrivatePart
        {
            get
            {
                return instance.FilePrivatePart;
            }
        }

        public string FileVersion
        {
            get
            {
                return instance.FileVersion;
            }
        }

        public System.Diagnostics.FileVersionInfo Instance
        {
            get
            {
                return instance;
            }
        }

        public string InternalName
        {
            get
            {
                return instance.InternalName;
            }
        }

        public bool IsDebug
        {
            get
            {
                return instance.IsDebug;
            }
        }

        public bool IsPatched
        {
            get
            {
                return instance.IsPatched;
            }
        }

        public bool IsPreRelease
        {
            get
            {
                return instance.IsPreRelease;
            }
        }

        public bool IsPrivateBuild
        {
            get
            {
                return instance.IsPrivateBuild;
            }
        }

        public bool IsSpecialBuild
        {
            get
            {
                return instance.IsSpecialBuild;
            }
        }

        public string Language
        {
            get
            {
                return instance.Language;
            }
        }

        public string LegalCopyright
        {
            get
            {
                return instance.LegalCopyright;
            }
        }

        public string LegalTrademarks
        {
            get
            {
                return instance.LegalTrademarks;
            }
        }

        public string OriginalFilename
        {
            get
            {
                return instance.OriginalFilename;
            }
        }

        public string PrivateBuild
        {
            get
            {
                return instance.PrivateBuild;
            }
        }

        public int ProductBuildPart
        {
            get
            {
                return instance.ProductBuildPart;
            }
        }

        public int ProductMajorPart
        {
            get
            {
                return instance.ProductMajorPart;
            }
        }

        public int ProductMinorPart
        {
            get
            {
                return instance.ProductMinorPart;
            }
        }

        public string ProductName
        {
            get
            {
                return instance.ProductName;
            }
        }

        public int ProductPrivatePart
        {
            get
            {
                return instance.ProductPrivatePart;
            }
        }

        public string ProductVersion
        {
            get
            {
                return instance.ProductVersion;
            }
        }

        public string SpecialBuild
        {
            get
            {
                return instance.SpecialBuild;
            }
        }

        public override string ToString()
        {
            return instance.ToString();
        }
    }
}
