using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class User
	{
		private string name;
		private string id;
		private string role;

		public User(string name, string id, string role)
		{
			this.name = name;
			this.id = id;
			this.role = role;
		}

		public string Name { get => name; set => name = value; }
		public string Id { get => id; set => id = value; }
		public string Role { get => role; set => role = value; }
	}
}
