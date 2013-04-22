using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Models
{
	public static class StringExtensions
	{
		public static bool IsValidEmail(this String strIn)
		{
			if (String.IsNullOrEmpty(strIn))
				return false;

			// Use IdnMapping class to convert Unicode domain names. 
			try
			{
				strIn = Regex.Replace(strIn, @"(@)(.+)$", ExtensionHelpers.DomainMapper,
				                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}

			// Return true if strIn is in valid e-mail format. 
			try
			{
				return Regex.IsMatch(strIn,
				                     @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
				                     @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
				                     RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

		public static string ToMd5Hash(this String input, params string[] args)
		{
			var bytes = Convert.FromBase64String(String.Concat(input, args));
			var md5 = new MD5CryptoServiceProvider();
			return Convert.ToBase64String(md5.ComputeHash(bytes));
		}
	}

	public class ExtensionHelpers
	{
		public static string DomainMapper(Match match)
		{
			// IdnMapping class with default property values.
			var idn = new IdnMapping();

			var domainName = match.Groups[2].Value;
			domainName = idn.GetAscii(domainName);
			return match.Groups[1].Value + domainName;
		}
	}
}
