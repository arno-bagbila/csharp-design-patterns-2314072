using System;

public class EmailNotifier : IUserNotifier{
    public void NotifyUser(int id){
        Console.WriteLine($"Notified User {id} via Email");
    }
}