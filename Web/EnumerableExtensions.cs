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

	public static class DictionaryExtensions
	{
		public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> lookup, TKey key, TValue defaultValue = default(TValue))
		{
			TValue value;
			return lookup.TryGetValue(key, out value) ? value : defaultValue;
		}
	}
}