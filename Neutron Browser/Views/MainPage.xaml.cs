using System;

using Neutron_Browser.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Neutron_Browser.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
