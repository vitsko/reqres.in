using NUnit.Framework;
using TestAPIReqresIn.Extensions;
using TestAPIReqresIn.Utils;

namespace TestAPIReqresIn.Tests.GET
{
	/// <summary>
	/// Тесты для API GET LIST USERS
	/// </summary>
	[TestFixture]
	public class TestListUsersResponse
	{
		private HttpUtil _httpUtil;

		[SetUp]
		public void SetUpHttpUtil()
		{
			_httpUtil = new HttpUtil();
		}

		#region Return user data. DefaultInput, DefaultPerPageInput
		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе не указаны параметры page, per_page;
		/// используются значения параметров по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultParamValues_ReturnsFirstPageWithDefaultUserCount.json",
		TestName = "Get_DefaultParamValues_ReturnsFirstPageWithDefaultUserCount",
		Category = "DefaultInput")]
		public void Get_DefaultParamValues_ReturnsFirstPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page=1 и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithFirstPage_GetFirstPageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithFirstPage_GetFirstPageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithFirstPage_GetFirstPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page=2 и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithSecondPage_GetSecondPageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithSecondPage_GetSecondPageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithSecondPage_GetSecondPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page=0 и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithZeroPage_GetFirstPageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithZeroPage_GetFirstPageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithZeroPage_GetFirstPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page=-1 и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithMinusOnePage_GetMinusOnePageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithMinusOnePage_GetMinusOnePageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithMinusOnePage_GetMinusOnePageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page с нечисловым значением, не содержащим первую цифру,
		/// например qwerty, и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithNotNumberPage_GetFirstPageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithNotNumberPage_GetFirstPageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithNotNumberPage_GetFirstPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page с нечисловым значением, содержащим первую цифру
		/// меньшую общего количества записей total с учетом total = page *  per_page,
		/// например 2qwerty, и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithNotNumberPageFirstCharisDigitLessTotal_GetPageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithNotNumberPageFirstCharisDigitLessTotal_GetPageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithNotNumberPageFirstCharisDigitLessTotal_GetPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр page с нечисловым значением, содержащим первую цифру
		/// меньшую нуля и общего количества записей total с учетом total = page *  per_page,
		/// например -1qwerty, и не указан per_page;
		/// используется значение параметра по умолчанию
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithMinusOnePageWithNotNumber_GetMinusOnePageWithDefaultUserCount.json",
		TestName = "Get_DefaultPerPageWithMinusOnePageWithNotNumber_GetMinusOnePageWithDefaultUserCount",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithMinusOnePageWithNotNumber_GetMinusOnePageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}
		#endregion

		#region Not found user data
		/// <summary>
		/// Проверить, что API GET LIST USERS не возвращает данные по пользователям, 
		/// когда в запросе указан параметр page больше, чем общее количество записей
		/// total с учетом total = page *  per_page, и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithThreePage_ReturnsEmptyUserData.json",
		TestName = "Get_DefaultPerPageWithThreePage_ReturnsEmptyUserData",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithThreePage_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS не возвращает данные по пользователям, 
		/// когда в запросе указан параметр page=-2 и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithMinusTwoPage_ReturnsEmptyUserData.json",
		TestName = "Get_DefaultPerPageWithMinusTwoPage_ReturnsEmptyUserData",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithMinusTwoPage_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS не возвращает данные по пользователям, 
		/// когда в запросе указан параметр page с нечисловым значением, содержащим первую цифру
		/// большую общего количества записей total с учетом total = page *  per_page,
		/// например 3qwerty, и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithNotNumberPageFirstCharisDigitGreatTotal_ReturnsEmptyUserData.json",
		TestName = "Get_DefaultPerPageWithNotNumberPageFirstCharisDigitGreatTotal_ReturnsEmptyUserData",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithNotNumberPageFirstCharisDigitGreatTotal_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS не возвращает данные по пользователям, 
		/// когда в запросе указан параметр page с нечисловым значением, содержащим первую цифру
		/// меньше нуля и большую общего количества записей total с учетом total = page *  per_page,
		/// например 3qwerty, и не указан per_page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithNotNumberPageMinusFirstCharisDigitGreatTotal_ReturnsEmptyUserData.json",
		TestName = "Get_DefaultPerPageWithNotNumberPageMinusFirstCharisDigitGreatTotal_ReturnsEmptyUserData",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPerPageWithNotNumberPageMinusFirstCharisDigitGreatTotal_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS не возвращает данные по пользователям, 
		/// когда в запросе указан параметр per_page с нечисловым значением, содержащим первую цифру
		/// большую общего количества записей total с учетом total = page *  per_page,
		/// например -13qwerty, и не указан page, используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithNotNumberPageFirstCharisDigitGreatTotalAndLessZero_ReturnsEmptyUserData.json",
		TestName = "Get_DefaultPageWithNotNumberPageFirstCharisDigitGreatTotalAndLessZero_ReturnsEmptyUserData",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithNotNumberPageFirstCharisDigitGreatTotalAndLessZero_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS не возвращает данные по пользователям, 
		/// когда в запросе указаны параметры page=-1 и per_page=-1
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_MinusOnePageWithMinusOnePerPage_ReturnsEmptyUserData.json",
		TestName = "Get_MinusOnePageWithMinusOnePerPage_ReturnsEmptyUserData",
		Category = "SelectPageAndPerPage")]
		public void Get_MinusOnePageWithMinusOnePerPage_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователю, 
		/// когда в запросе указаны параметры с нечисловым значением и первый символ цифра меньше,
		/// чем total и ноль, например, page=-1qwerty и per_page=-1qwerty
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_StringPlusMinusOnePageStringPlusMinusOnePerPage_ReturnsEmptyUserData.json",
		TestName = "Get_StringPlusMinusOnePageStringPlusMinusOnePerPage_ReturnsEmptyUserData",
		Category = "SelectPageAndPerPage")]
		public void Get_StringPlusMinusOnePageStringPlusMinusOnePerPage_ReturnsEmptyUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}
		#endregion

		#region Return user data. DefaultPageInput
		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователю, 
		/// когда в запросе не указан параметр page, используется значение по умолчанию,
		/// и указан per_page = 1
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithOnePerPage_GetFirstPageWithOneUser.json",
		TestName = "Get_DefaultPageWithOnePerPage_GetFirstPageWithOneUser",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithOnePerPage_GetFirstPageWithOneUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе не указан параметр page, используется значение по умолчанию,
		/// и указан per_page = 2
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithTwoPerPage_GetFirstPageWithTwoUsers.json",
		TestName = "Get_DefaultPageWithTwoPerPage_GetFirstPageWithTwoUsers",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithTwoPerPage_GetFirstPageWithTwoUsers(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по всем пользователям, 
		/// когда в запросе указан параметр per_page равно общему количеству записей
		/// total с учетом total = page *  per_page, и не указан page,
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithPerPageEqualsTotal_ReturnsAllUserData.json",
		TestName = "Get_DefaultPageWithPerPageEqualsTotal_ReturnsAllUserData",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPageWithPerPageEqualsTotal_ReturnsAllUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по всем пользователям, 
		/// когда в запросе указан параметр per_page больше, чем общее количество записей
		/// total с учетом total = page *  per_page, и не указан page,
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithPerPageGreatTotal_ReturnsAllUserData.json",
		TestName = "Get_DefaultPageWithPerPageGreatTotal_ReturnsAllUserData",
		Category = "DefaultPerPageInput")]
		public void Get_DefaultPageWithPerPageGreatTotal_ReturnsAllUserData(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе не указан параметр page, используется значение по умолчанию,
		/// и указан per_page = 0
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithZeroPerPage_GetFirstPageWithDefaultCountUsers.json",
		TestName = "Get_DefaultPageWithZeroPerPage_GetFirstPageWithDefaultCountUsers",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithZeroPerPage_GetFirstPageWithDefaultCountUsers(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе не указан параметр page, используется значение по умолчанию,
		/// и указан per_page = -1
		[TestCase(@"GET\ListUsers\Get_DefaultPerPageWithMinusOnePage_GetFirstPageWithTotalMinusOneUserCount.json",
		TestName = "Get_DefaultPerPageWithMinusOnePage_GetFirstPageWithTotalMinusOneUserCount",
		Category = "DefaultPageInput")]
		public void Get_DefaultPerPageWithMinusOnePage_GetFirstPageWithTotalMinusOneUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр per_page с нечисловым значением, не содержащим первую цифру,
		/// например qwerty, и не указан page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithNotNumberPerPage_GetFirstPageWithDefaultUserCount.json",
		TestName = "Get_DefaultPageWithNotNumberPerPage_GetFirstPageWithDefaultUserCount",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithNotNumberPerPage_GetFirstPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр per_page с нечисловым значением, содержащим первую цифру
		/// меньшую общего количества записей total с учетом total = page *  per_page,
		/// например 2qwerty, и не указан page;
		/// используется значение параметра по умолчанию
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithNotNumberPerPageFirstCharisDigitLessTotal_GetFirstPageWithTwoUsers.json",
		TestName = "Get_DefaultPageWithNotNumberPerPageFirstCharisDigitLessTotal_GetFirstPageWithTwoUsers",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithNotNumberPerPageFirstCharisDigitLessTotal_GetFirstPageWithTwoUsers(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указан параметр per_page с нечисловым значением, содержащим первую цифру
		/// меньшую нуля и общего количества записей total с учетом total = page *  per_page,
		/// например -1qwerty, и не указан page, используется значение параметра по умолчанию
		[TestCase(@"GET\ListUsers\Get_DefaultPageWithMinusOnePerPageWithNotNumber_GetFirstPageWithTotalMinusOneUserCount.json",
		TestName = "Get_DefaultPageWithMinusOnePerPageWithNotNumber_GetFirstPageWithTotalMinusOneUserCount",
		Category = "DefaultPageInput")]
		public void Get_DefaultPageWithMinusOnePerPageWithNotNumber_GetFirstPageWithTotalMinusOneUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}
		#endregion

		#region Return user data. Page && Per_page
		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователю, 
		/// когда в запросе указаны параметры page=1 и per_page = 1
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_FirstPageWithOnePerPage_GetFirstPageWithOneUser.json",
		TestName = "Get_FirstPageWithOnePerPage_GetFirstPageWithOneUser",
		Category = "SelectPageAndPerPage")]
		public void Get_FirstPageWithOnePerPage_GetFirstPageWithOneUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указаны параметры page=0 и per_page=0
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_ZeroPageWithZeroPerPage_GetFirstPageWithDefaultUserCount.json",
		TestName = "Get_ZeroPageWithZeroPerPage_GetFirstPageWithDefaultUserCount",
		Category = "SelectPageAndPerPage")]
		public void Get_ZeroPageWithZeroPerPage_GetFirstPageWithDefaultUserCount(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указаны параметры page=1 и per_page=-1
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_FirstPageWithMinusOnePerPage_GetFirstPageWithTotalMinusOneUsers.json",
		TestName = "Get_FirstPageWithMinusOnePerPage_GetFirstPageWithTotalMinusOneUsers",
		Category = "SelectPageAndPerPage")]
		public void Get_FirstPageWithMinusOnePerPage_GetFirstPageWithTotalMinusOneUsers(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователю, 
		/// когда в запросе указаны параметры page=-1 и per_page=1
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_MinusOnePageWithOnePerPage_GetOneUser.json",
		TestName = "Get_MinusOnePageWithOnePerPage_GetOneUser",
		Category = "SelectPageAndPerPage")]
		public void Get_MinusOnePageWithOnePerPage_GetOneUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователям, 
		/// когда в запросе указаны параметры с нечисловым значением и первый символ не цифра,
		/// например, page=qwerty и per_page=qwerty
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_StringPageStringPerPage_GetFirstPageWithDefaultCountUser.json",
		TestName = "Get_StringPageStringPerPage_GetFirstPageWithDefaultCountUser",
		Category = "SelectPageAndPerPage")]
		public void Get_StringPageStringPerPage_GetFirstPageWithDefaultCountUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}

		/// <summary>
		/// Проверить, что API GET LIST USERS возвращает данные по пользователю, 
		/// когда в запросе указаны параметры с нечисловым значением и первый символ цифра меньше,
		/// чем total, например, page=1qwerty и per_page=1qwerty
		/// </summary>
		[TestCase(@"GET\ListUsers\Get_StringPlusOnePageStringPlusOnePerPage_GetFirstPageWithUser.json",
		TestName = "Get_StringPlusOnePageStringPlusOnePerPage_GetFirstPageWithUser",
		Category = "SelectPageAndPerPage")]
		public void Get_StringPlusOnePageStringPlusOnePerPage_GetFirstPageWithUser(string pathToFile)
		{
			CoreTest(pathToFile);
		}
		#endregion

		private void CoreTest(string pathToFile)
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
