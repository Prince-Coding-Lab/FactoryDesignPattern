using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
	class EmailUserNotifier : IUserNotifier
	{
		public void NotifyUser(int id)
		{
			Console.WriteLine($"Notified User {id} By Email");
		}
	}
}
