using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPlusSports.Core
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ISalesPersonService, SalesPersonService>();
            services.AddTransient<IUserNotifier>((IServiceProvider serviceProvider) =>
            {
                var config = serviceProvider.GetService<IConfiguration>();
                if (config.GetValue<bool>("UseEmailNotifier"))
                {
                    return new EmailNotifer();
                }
                else
                {
                    return new TestNotifier();
                }
            });

        }
    }
}
