using NUnit.Framework;
using TestAPIReqresIn.Extensions;
using TestAPIReqresIn.Utils;

namespace TestAPIReqresIn.Tests.GET
{
	[TestFixture]
	public class TestListUsersResponse
	{
		private HttpUtil _httpUtil;

		[SetUp]
		public void SetUpHttpUtil()
		{
			_httpUtil = new HttpUtil();
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные, 
		/// когда в запросе не указаны параметры page, per_page;
		/// используются значения параметров по умолчанию
		/// </summary>
		[TestCase(@"GET\Get_DefaultInputValue_ReturnsAllUsers.json",
		TestName = "Get_DefaultInputValue_ReturnsAllUsers")]
		public void Get_DefaultInputValue_ReturnsAllUsers(string pathToFile)
		{
			// Arrange 
			var testListUsersResponse = FileReaderUtil.GetTestDataListUsersResponse(pathToFile);
			var serviceUrl = UriUtil.GetServiceListUsersUrl(testListUsersResponse.Input);

			// Action
			var listUsersResponse = _httpUtil.GetListUsersResponse(serviceUrl);

			// Assert
			var hasResponseAndTestUsersDiff = !listUsersResponse.Users.ScrambledEquals(testListUsersResponse.ExpectedResult.Users);
			Assert.IsFalse(hasResponseAndTestUsersDiff, $"Результат вызова API GET LIST USERS не совпадает с ожидаемым результатом для serviceUrl='{serviceUrl}'");
		}
	}
}
