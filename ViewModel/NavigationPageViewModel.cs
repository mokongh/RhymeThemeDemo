using System.Collections.ObjectModel;
using VirtualDMP.Rhyme.Theme.RhymeControls;

namespace RhymeThemeDemo.ViewModel
{
    internal class NavigationPageViewModel
    {
        public ObservableCollection<RhymeNavigateHelper> NavigationItemSource { get; }

        internal NavigationPageViewModel()
        {
            NavigationItemSource = new ObservableCollection<RhymeNavigateHelper>()
            {
                new(){NavigateLabel = "Label", PackIconKind = PackIconKind.Information},
                new(){NavigateLabel = "Label", PackIconKind = PackIconKind.Function },
                new(){NavigateLabel = "Label", PackIconKind = PackIconKind.RemixIcon}
            };
        }
    }
}
