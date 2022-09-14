using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
	class NotificationServiceProvider
	{
		public IUserNotifier GetUserNotifier()
		{
#if DEBUG
			return new TestUserNotifier();
#else
      return new EmailUserNotifier();
#endif
		}
	}
}
