using Prism.Mvvm;
using Prism.Regions;

namespace RhymeThemeDemo.ViewModel
{
    internal class CheckBoxPageViewModel : BindableBase, INavigationAware
    {
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        private bool _radioCheck;

        public bool RadioCheck
        {
            get => _radioCheck;
            set => SetProperty(ref _radioCheck, value);
        }
    }
}
