using Newtonsoft.Json;
using TestAPIReqresIn.Models.Responses.POST;

namespace TestAPIReqresIn.Models.TestData.POST
{
	/// <summary>
	///  Модель JSON-файла с тестовыми данными для API POST CREATE
	/// </summary>
	class TestFileCreatedUserResponse
	{
		[JsonConstructor]
		internal TestFileCreatedUserResponse(UserInfo userInfo, CreatedUserResponse response, CreatedUserResponse expectedResult)
		{
			UserInfo = userInfo;
			Response = response;
			ExpectedResult = expectedResult;
		}

		/// <summary>
		/// ID пользователя для API GET LIST USERS
		/// </summary>
		[JsonProperty("userId")]
		internal UserInfo UserInfo { get; }

		/// <summary>
		/// Результат выполнения API POST CREATE в соответствии с UserInfo
		/// </summary>
		[JsonProperty("response")]
		internal CreatedUserResponse Response { get; }

		/// <summary>
		/// Ожидаемый результат выполнения API POST CREATE.
		/// Эталонные данные для сравнения с результатом выполнения запроса
		/// </summary>
		[JsonProperty("expected_result")]
		internal CreatedUserResponse ExpectedResult { get; }
	}
}
