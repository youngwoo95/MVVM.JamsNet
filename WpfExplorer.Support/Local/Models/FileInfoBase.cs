using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorer.Support.Local.Models
{
    /// <summary>
    /// 파일에 대한 기본정보를 포함하는 모델 클래스
    /// </summary>
    public partial class FileInfoBase : ObservableObject
    {
        /// <summary>
        /// 파일에 접근 제한 유무
        /// </summary>
        [ObservableProperty]
        private bool _isDenied;

        /// <summary>
        /// 파일 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 파일 전체 경로
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// 파일의 계층 구조의 깊이
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// 파일의 크기
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 파일의 아이콘 유형
        /// </summary>
        public IconType IconType { get; set; }


    }
}
