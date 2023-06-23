using System;

public class TestUserNotifier : IUserNotifier
{
    public void NotifyUser(int id)
    {
        Console.WriteLine($"Notified User {id} via Test");
    }
}