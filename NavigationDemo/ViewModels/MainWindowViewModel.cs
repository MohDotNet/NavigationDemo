using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace NavigationDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public DelegateCommand<string> NavigateCommand { get; set; }
        IRegionManager _regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            NavigateCommand = new DelegateCommand<string>(navigate);
            _regionManager = regionManager;
        }

        private void navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
         }
    }
}
