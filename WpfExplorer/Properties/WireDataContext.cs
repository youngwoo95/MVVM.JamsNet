using Jamesnet.Wpf.Global.Location;
using WpfExplorer.Forms.Local.ViewModels;
using WpfExplorer.Forms.UI.Views;

namespace WpfExplorer.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<ExplorerWindow, ExplorerViewModel>();
        }
    }
}
