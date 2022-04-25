using NUnit.Framework;
using TestAPIReqresIn.Models.Responses.GET;
using TestAPIReqresIn.Utils;

namespace TestAPIReqresIn.Tests.GET
{
	/// <summary>
	/// Тесты для API GET SINGLE USER
	/// </summary>
	[TestFixture]
	public class TestSingleUserResponse
	{
		private HttpUtil _httpUtil;

		[SetUp]
		public void SetUpHttpUtil()
		{
			_httpUtil = new HttpUtil();
		}

		/// <summary>
		/// Проверить, что API GET SINGLE USER возвращает данные по пользователю по существующему userId 
		/// </summary>
		[TestCase(@"GET\SingleUser\Get_UserIdOne_ReturnsUserWithUserIdOne.json",
		TestName = "Get_UserIdOne_ReturnsUserWithUserIdOne",
		Category = "HasUser")]
		public void Get_UserIdOne_ReturnsUserWithUserIdOne(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET SINGLE USER не возвращает данные по пользователю по несуществующему числовому userId 
		/// </summary>
		[TestCase(@"GET\SingleUser\Get_UserIdNotFound_NotReturnsUser.json",
		TestName = "Get_UserIdNotFound_NotReturnsUser",
		Category = "NotFoundUser")]
		public void Get_UserIdNotFound_NotReturnsUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET SINGLE USER не возвращает данные по пользователю по несуществующему нечисловому userId 
		/// </summary>
		[TestCase(@"GET\SingleUser\Get_UserIdNotFoundByStringUserId_NotReturnsUser.json",
		TestName = "Get_UserIdNotFoundByStringUserId_NotReturnsUser",
		Category = "NotFoundUser")]
		public void Get_UserIdNotFoundByStringUserId_NotReturnsUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET SINGLE USER не возвращает данные по пользователю по userId=null 
		/// </summary>
		[TestCase(@"GET\SingleUser\Get_UserIdNotFoundByUserIdIsNull_NotReturnsUser.json",
		TestName = "Get_UserIdNotFoundByUserIdIsNull_NotReturnsUser",
		Category = "NotFoundUser")]
		public void Get_UserIdNotFoundByUserIdIsNull_NotReturnsUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		private void CoreTest(string pathToFile)
		{
			// Arrange 
			var testSingleUserResponse = FileReaderUtil.GetTestDataSingleUserResponse(pathToFile);
			var serviceUrl = UriUtil.GetServiceSingleUserResponse(testSingleUserResponse.UserId);

			// Action
			var userResponse = _httpUtil.GetSingleUserResponse(serviceUrl);
			var user = userResponse == null ? new User() : userResponse.User;

			// Assert
			var equalsUser = user.Equals(testSingleUserResponse.ExpectedResult.User);
			Assert.IsTrue(equalsUser, $"Результат вызова API GET SINGLE USER не совпадает с ожидаемым результатом для serviceUrl='{serviceUrl}'");
		}
	}
}
