using MVVMApplication.Mobile.Services;
using MVVMApplication.Mobile.ViewModels;
using Xamarin.Forms;

namespace MVVMApplication.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            BindingContext = vm;
            InitializeComponent();
        }
    }
}