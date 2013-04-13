using System.Collections.Generic;
using System.Linq;

namespace Pitchtrack.Web
{
	public static class EnumerableExtensions
	{
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
		{
			return null == items || !items.Any();
		}
	}
}