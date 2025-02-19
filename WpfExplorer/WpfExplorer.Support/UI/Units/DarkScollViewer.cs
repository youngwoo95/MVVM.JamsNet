using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkScollViewer : ScrollViewer
    {
        static DarkScollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkScollViewer),
                new FrameworkPropertyMetadata(typeof(DarkScollViewer)));
        }
    }
}
