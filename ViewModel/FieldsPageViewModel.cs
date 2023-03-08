using Prism.Mvvm;
using Prism.Regions;

namespace RhymeThemeDemo.ViewModel
{
    internal class FieldsPageViewModel : BindableBase, INavigationAware
    {
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        private string _ruleStr = string.Empty;

        public string RuleStr
        {
            get => _ruleStr;
            set => SetProperty(ref _ruleStr, value);
        }

        private string _rulesStr1 = string.Empty;

        public string RulesStr1
        {
            get => _rulesStr1;
            set => SetProperty(ref _rulesStr1, value);
        }

        private string _ruleStr2 = string.Empty;

        public string RulesStr2
        {
            get => _ruleStr2;
            set => SetProperty(ref _ruleStr2, value);
        }

        private string _ruleStr3=string.Empty;

        public string RulesStr3
        {
            get => _ruleStr3;
            set => SetProperty(ref _ruleStr3, value);
        }

        private string _ruleStr4=string.Empty;

        public string RulesStr4
        {
            get => _ruleStr4;
            set => SetProperty(ref _ruleStr4, value);
        }
    }
}
