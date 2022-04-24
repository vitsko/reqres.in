using Newtonsoft.Json;
using TestAPIReqresIn.Models.Responses.GET;

namespace TestAPIReqresIn.Models.TestData.GET
{
	/// <summary>
	/// Модель JSON-файла с тестовыми данными для API GET LIST USERS
	/// </summary>
	internal class TestFileListUsersResponse
	{
		[JsonConstructor]
		internal TestFileListUsersResponse(InputGetListUsersResponse input, ListUsersResponse response, ListUsersResponse expectedResult)
		{
			Input = input;
			Response = response;
			ExpectedResult = expectedResult;
		}

		/// <summary>
		/// Данные для проверки API GET LIST USERS
		/// </summary>
		[JsonProperty("input_test")]
		internal InputGetListUsersResponse Input { get; }

		/// <summary>
		/// Результат выполнения API GET LIST USERS в соответствии с данными для проверки
		/// </summary>
		[JsonProperty("response")]
		internal ListUsersResponse Response { get; }

		/// <summary>
		/// Ожидаемый результат выполнения API GET LIST USERS.
		/// Эталонные данные для сравнения с результатом выполнения запроса
		/// </summary>
		[JsonProperty("expected_result")]
		internal ListUsersResponse ExpectedResult { get; }
	}
}