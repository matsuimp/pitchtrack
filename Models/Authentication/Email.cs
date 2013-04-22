using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Authentication
{
	public class Email
	{
		public Email(string email)
		{
			_email = email;
		}

		private readonly string _email;
		public String EmailAddress
		{
			get
			{
				return _email.IsValidEmail() ? _email : null;
			}
		}

	}
}
