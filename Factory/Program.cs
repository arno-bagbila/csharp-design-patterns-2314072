using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationServiceProvider = new NotificationServiceProvider();
            var shippingService = new ShippingService(notificationServiceProvider);
            shippingService.ShipItem();
        }
    }
}
