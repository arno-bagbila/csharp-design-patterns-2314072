using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSports.Core
{
    public class EmailNotifer : IUserNotifier
    {
        public void NotifyUser(int customerId)
        {
            Console.WriteLine($"Sending email to customer {customerId}");
        }
    }
}