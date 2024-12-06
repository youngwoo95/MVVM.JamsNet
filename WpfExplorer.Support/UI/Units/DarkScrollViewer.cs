using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{

    public class DarkScrollViewer : ScrollViewer
    {
        /*
            - CustomControl 형식으로 생성 시 아래와 같은 초기 코드가 생성됨.
            - 클래스는 기본적으로 Control을 상속받는다.
            - DefaultStyleKeyProperty는 컨트롤의 기본 스타일을 자동으로 연결한다.
            - 이 기능을 제대로 활용하기 위해선 Generic.xaml에 해당 컨트롤의 스타일이 있어야 하고, AssemblyInfo.cs 파일도 필요하다.

            Static으로 생성하면 한번만 실행됨.
        */
        static DarkScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkScrollViewer), new FrameworkPropertyMetadata(typeof(DarkScrollViewer)));
        }
    }
}
