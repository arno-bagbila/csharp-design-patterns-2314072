public class ShippingService{

    NotificationServiceProvider _notificationServiceProvider;

     public ShippingService(NotificationServiceProvider notificationServiceProvider)
     {
        _notificationServiceProvider = notificationServiceProvider;
     }

     public void ShipItem(){
        //code to ship item
        _notificationServiceProvider.GetNotifier().NotifyUser(1);
     }
        
    
}