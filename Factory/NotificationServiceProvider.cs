public class NotificationServiceProvider{

    public IUserNotifier GetNotifier(){

    #if DEBUG
            return new TestUserNotifier();
    #else
            return new EmailNotifier();
    #endif   
    }
}