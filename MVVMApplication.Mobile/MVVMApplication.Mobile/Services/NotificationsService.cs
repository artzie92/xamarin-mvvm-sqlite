using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMApplication.Mobile.Services
{
    public class NotificationsService : INotificationsService
    {
        public async Task ShowSuccessMessageAsync(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Info", message, "Ok");
        }

        public async Task ShowErrorMessageAsync(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Error", message, "Ok");
        }
    }
}