using NUnit.Framework;
using Problem52;

namespace Tests.Problem52Tests
{
	[TestFixture]
	public class GetTests
	{
		[TestCase("somekey")]
		public void TestGet_ElementDoesNotExist_ShouldReturnNull(string key)
		{
			// Arrange
			var cache = new LeastRecentlyUsedCache(10);

			// Act
			var result = cache.Get(key);

			// Assert
			Assert.IsNull(result);
		}
	}
}
