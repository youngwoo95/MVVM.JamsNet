using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public class ExplorerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public List<FolderInfo>? Roots { get; init; }


        public ExplorerViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable view)
        {
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            
            IViewable mainContent = _containerProvider.Resolve<IViewable>("MainContent");

            if(!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }
            mainRegion.Activate(mainContent);
            
        }
    }
}
