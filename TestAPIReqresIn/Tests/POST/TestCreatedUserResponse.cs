using NUnit.Framework;
using TestAPIReqresIn.Utils;

namespace TestAPIReqresIn.Tests.POST
{
	/// <summary>
	/// Тесты для API POST CREATE
	/// </summary>
	[TestFixture]
	class TestCreatedUserResponse
	{
		private HttpUtil _httpUtil;

		[SetUp]
		public void SetUpHttpUtil()
		{
			_httpUtil = new HttpUtil();
		}

		/// <summary>
		/// Проверить, что API POST CREATE создает учетную запись пользователя при указании name, job 
		/// </summary>
		[TestCase(@"POST\POST_UserWithNameAndJob_ReturnsUser.json",
		TestName = "POST_UserWithNameAndJob_ReturnsUser")]
		public void POST_UserWithNameAndJob_ReturnsUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API POST CREATE создает учетную запись пользователя при указании пустого значения для name, job
		/// </summary>
		[TestCase(@"POST\POST_UserWithoutNameAndJob_ReturnsUser.json",
		TestName = "POST_UserWithoutNameAndJob_ReturnsUser")]
		public void POST_UserWithoutNameAndJob_ReturnsUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API POST CREATE создает учетную запись пользователя при указании null для name, job
		/// </summary>
		[TestCase(@"POST\POST_UserWithNullNameAndJob_ReturnsUser.json",
		TestName = "POST_UserWithNullNameAndJob_ReturnsUser")]
		public void POST_UserWithNullNameAndJob_ReturnsUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		private void CoreTest(string pathToFile)
		{
			// Arrange 
			var testCreatedUserResponse = FileReaderUtil.GetTestDataCreatedUserResponse(pathToFile);
			var serviceUrl = UriUtil.GetServiceCreatedUserResponse();

			// Action
			var userResponse = _httpUtil.PostCreatedUserResponse(serviceUrl, testCreatedUserResponse.UserInfo);
			testCreatedUserResponse.ExpectedResult.CreatedAt = userResponse.CreatedAt;
			testCreatedUserResponse.ExpectedResult.ID = userResponse.ID;

			// Assert
			var equalsUser = userResponse.Equals(testCreatedUserResponse.ExpectedResult);
			Assert.IsTrue(equalsUser,
				$"Результат вызова API POST CREATE не совпадает с ожидаемым результатом для serviceUrl='{serviceUrl} и параметрами создания пользователя '{testCreatedUserResponse.UserInfo}'");
		}
	}
}
