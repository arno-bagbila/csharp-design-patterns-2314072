using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSports.Core
{
    public interface IUserNotifier
    {
        void NotifyUser(int customerId);
    }
}