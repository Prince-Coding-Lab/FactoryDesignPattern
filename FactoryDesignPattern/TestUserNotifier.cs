using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
	class TestUserNotifier : IUserNotifier
	{
		public void NotifyUser(int id)
		{
			Console.WriteLine($"Pretending to notify User {id}");
		}
	}
}
