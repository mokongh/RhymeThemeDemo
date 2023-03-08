using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Windows;
using RhymeThemeDemo.View;
using RhymeThemeDemo.ViewModel;

namespace RhymeThemeDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App() { }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// 使用容器服务注册页面/依赖等
        /// </summary>
        /// <param name="containerRegistry"></param>
        /// <exception cref="NotImplementedException"></exception>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<ButtonPage, ButtonPageViewModel>();
            containerRegistry.RegisterForNavigation<CheckBoxPage, CheckBoxPageViewModel>();
            containerRegistry.RegisterForNavigation<FieldsPage, FieldsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProgressBarPage, ProgressBarPageViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage, NavigationPageViewModel>();
            containerRegistry.RegisterForNavigation<CodeViewPage, CodeViewPageViewModel>();
        }
    }
}
