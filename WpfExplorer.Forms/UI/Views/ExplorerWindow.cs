using System.Windows;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer.Forms.UI.Views
{

    public class ExplorerWindow : DarkWindow
    {
        static ExplorerWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerWindow), new FrameworkPropertyMetadata(typeof(ExplorerWindow)));
        }

        public ExplorerWindow()
        {
            //DataContext = new ExplorerViewModel();

        }
    }
}
