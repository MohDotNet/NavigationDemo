using Prism.Ioc;
using NavigationDemo.Views;
using System.Windows;
using Prism.Modularity;
using SuppliersModule;

namespace NavigationDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<SuppliersModuleModule>();
        }
    }
}
