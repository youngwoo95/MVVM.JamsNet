using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfExplorer.Support.Local.Models
{
    public partial class FolderInfo : FileInfoBase
    {
        /// <summary>
        /// 폴더가 확장되었는지 여부
        /// </summary>
        [ObservableProperty]
        private bool _isFolderExpanded;

        /// <summary>
        /// 폴더가 선택되었는지 여부
        /// </summary>
        [ObservableProperty]
        private bool _isFolderSelected;
        
        /// <summary>
        /// 해당 폴더의 하위 폴더 목록을 담음
        /// </summary>
        public ObservableCollection<FolderInfo> Children { get; set; }

    }
}
