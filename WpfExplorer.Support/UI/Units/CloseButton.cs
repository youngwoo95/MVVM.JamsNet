using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    // 기본 button 컨트롤을 상속받아 동작은 유지하면서, 외형(스타일이나 템플릿)을 커스터마이징 함.
    public class CloseButton : Button
    {
        static CloseButton()
        {
            /*
                - DefaultStyleKeyProperty라는 속성을 통해 기본 스타일을 참조함.
                
                - 이 메서드는 CloseButton 클래스의 기본 스타일을 Button의 기본 스타일에서 새롭게 정의된 스타일로 변경

                - 새 스타일은 Generic.xaml 또는 커스텀 리소스 파일에 정의해야한다.
             */

            /*
                typeof(CloseButton)
                    - 이 코드는 CloseButton 클래스에 대한 스타일을 정의한 리소스를 찾도록 지시한다.

                    - WPF는 CloseButton 타입의 스타일을 XAML 리소스에서 검색한다.
             */
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton), new FrameworkPropertyMetadata(typeof(CloseButton)));

        }
    }
}
