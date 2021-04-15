using System;
using Microsoft.Extensions.DependencyInjection;
using MVVMApplication.Mobile.Database;
using MVVMApplication.Mobile.Services;
using MVVMApplication.Mobile.ViewModels;

namespace MVVMApplication.Mobile
{
    public class Dependencies
    {
        private IServiceCollection services = new ServiceCollection();

        public Dependencies Load()
        {
            services.AddTransient<INotificationsService, NotificationsService>();
            services.AddTransient<MainPageViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<PeopleDb>((p) => new PeopleDb(Constants.DatabasePath));
            return this;
        }
        
        public IServiceProvider GetServiceProvider()
            => services.BuildServiceProvider();
    }
}