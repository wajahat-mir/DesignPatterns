using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interfaces
{
    interface INotifier
    {
        public void SendNotification();
        public void TrackNotification();
    }
}
