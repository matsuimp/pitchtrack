using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Models.Authentication
{
	public class Account
	{
		public String UserName { get; set; }
		public Email Email { get; set; }

		public String Key
		{
			get { return UserName.ToMd5Hash(Email.EmailAddress); }
		}
	}
}
