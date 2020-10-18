using SuppliersModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace SuppliersModule
{
    public class SuppliersModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ListSuppliers>();
            containerRegistry.RegisterForNavigation<AddSupplier>();
        }
    }
}