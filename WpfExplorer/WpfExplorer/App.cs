using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Forms.UI.Views;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer
{
    /*
        JamesApplication클래스를 상속받으면
            - PrismApplication
            - PrismApplicationBase
            - Application
        순서로 상속받기 때문에, App.xaml의 기능을 대체할 수 있다.
     */
    internal class App : JamesApplication
    {
        // CreateShell -- 시작 윈도우를 지정한다.
        protected override Window CreateShell()
        {
            // 임시 윈도우 반환
            //return new Window();
            //return new DarkWindow();
            return new ExplorerWindow();
        }
    }
}
