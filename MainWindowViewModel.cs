using System.Collections.ObjectModel;
using System.Linq;
using Prism.Mvvm;
using Prism.Regions;
using RhymeThemeDemo.View;
using VirtualDMP.Rhyme.Theme.RhymeControls;

namespace RhymeThemeDemo
{
    internal class MainWindowViewModel : BindableBase
    {
        public ObservableCollection<RhymeNavigateHelper> MainItemSource { get; }

        private RhymeNavigateHelper? _navigateHelper;

        public RhymeNavigateHelper? NavigateHelper
        {
            get => _navigateHelper;
            set
            {
                if (SetProperty(ref _navigateHelper, value) && value is not null)
                {
                    _regionManager.RequestNavigate(RequestRegionName, value.ViewName);
                }
            }
        }

        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            MainItemSource = new()
            {
                new RhymeNavigateHelper()
                    { NavigateLabel = "主页", PackIconKind = PackIconKind.Home, ViewName = nameof(HomePage) },
                new RhymeNavigateHelper()
                    { NavigateLabel = "基础按钮", PackIconKind = PackIconKind.Function, ViewName = nameof(ButtonPage) },
                new RhymeNavigateHelper()
                    { NavigateLabel = "选择按钮", PackIconKind = PackIconKind.CheckBox, ViewName = nameof(CheckBoxPage) },
                new RhymeNavigateHelper()
                    { NavigateLabel = "文本输入框", PackIconKind = PackIconKind.Emphasis, ViewName = nameof(FieldsPage) },
                new RhymeNavigateHelper()
                    { NavigateLabel = "进度条", PackIconKind = PackIconKind.Loader, ViewName = nameof(ProgressBarPage) },
                new RhymeNavigateHelper()
                    { NavigateLabel = "导航栏", PackIconKind = PackIconKind.Navigation, ViewName = nameof(NavigationPage) },
                new RhymeNavigateHelper()
                {
                    NavigateLabel = "代码输入框", PackIconKind = PackIconKind.Code,ViewName = nameof(CodeViewPage)
                }
            };

            NavigateHelper = MainItemSource.First();
        }

        private string RequestRegionName => "MainContentRegion";

    }
}
