using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSports.Core
{
    public class TestNotifier : IUserNotifier
    {
        public void NotifyUser(int customerId)
        {
            Console.WriteLine($"Sending test notification to customer {customerId}");
        }
    }
}