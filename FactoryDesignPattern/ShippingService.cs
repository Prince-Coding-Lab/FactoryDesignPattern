using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
	class ShippingService
	{
    NotificationServiceProvider _serviceProvider;
    public ShippingService(NotificationServiceProvider serviceProvider)
    {
      _serviceProvider = serviceProvider;
    }

    public void ShipItem()
    {
      //code to ship the item
      _serviceProvider.GetUserNotifier().NotifyUser(1);
    }
  }
}
