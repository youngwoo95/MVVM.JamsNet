using Jamesnet.Wpf.Controls;
using System.IO;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Support.Local.Helpers
{
    public class FileService
    {
        private readonly DirectoryManager _directoryManager;

        public FileService(DirectoryManager directoryManager)
        {
            _directoryManager = directoryManager;
        }

        public List<FolderInfo> GenerateRootNodes()
        {
            List<FolderInfo> roots = new()
            {
                CreateFolderInfo(1, "Download", IconType.ArrowDownBox, _directoryManager.DownloadDirectory),
                CreateFolderInfo(1, "Documents", IconType.TextBox, _directoryManager.DocumentsDirectory),
                CreateFolderInfo(1, "Pictures", IconType.Image, _directoryManager.PicturesDirectory)
            };

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if(drive.IsReady)
                {
                    var name = $"{drive.VolumeLabel} ({drive.RootDirectory.FullName.Replace("\\", "")})";
                    roots.Add(CreateFolderInfo(1, name, IconType.MicrosoftWindows, drive.Name));
                }
            }

            return roots;
        }

        private static FolderInfo CreateFolderInfo
            (int depth, string name, IconType iconType, string fullPath)
        {
            return new FolderInfo
            {
                Depth = depth,
                Name = name,
                IconType = iconType,
                FullPath = fullPath,
                Children = new()
            };
        }

    }
}
