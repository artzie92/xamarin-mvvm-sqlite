using System.Threading.Tasks;

namespace MVVMApplication.Mobile.Services
{
    public interface INotificationsService
    {
        Task ShowSuccessMessageAsync(string message);
        Task ShowErrorMessageAsync(string message);
    }
}