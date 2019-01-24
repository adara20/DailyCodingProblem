using System.Collections.Generic;

namespace Problem52
{
	public class LeastRecentlyUsedCache
	{
		private readonly IDictionary<string, object> cache = new Dictionary<string, object>();

		public LeastRecentlyUsedCache(int size)
		{
			Size = size;
		}

		public int Size { get; set; }

		public void Set(string key, object value)
		{

		}

		public object Get(string key)
		{
			var result = (object)null;

			cache.TryGetValue(key, out result);

			return result;
		}
	}
}
