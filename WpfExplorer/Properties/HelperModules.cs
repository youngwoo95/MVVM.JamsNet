﻿using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Support.Local.Helpers;


namespace WpfExplorer.Properties
{
    internal class HelperModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<DirectoryManager>();
        }
    }
}
