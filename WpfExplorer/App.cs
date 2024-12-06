using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Forms.UI.Views;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        /* JamesApplication이 prismApplication을 직접 상속받기 때문에, PrismApplication의 추상 클래스의 특성을 갖게 되며,
           PrismApplication의 CreateShell의 추상 메서드의 구현이 필수로 필요함. 
                - 이 메서드의 반환값으로 시작 윈도우를 지정하는 것이 특징임.
         */
        protected override Window CreateShell()
        {
            bool DarkModel = true;
            if(DarkModel)
            {
                return new ExplorerWindow();
                //return new DarkWindow(); // 설정됐는지 확인
                //return new DarkThemeWindow(); // 다크모드 설정
            }
            else
            {
                return new Window(); // 기본모드
            }
        }
    }
}
