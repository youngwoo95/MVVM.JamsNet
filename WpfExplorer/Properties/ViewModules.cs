using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Main.UI.Views;

namespace WpfExplorer.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
