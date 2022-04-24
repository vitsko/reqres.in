using Newtonsoft.Json;
using TestAPIReqresIn.Models.Responses.GET;

namespace TestAPIReqresIn.Models.TestData.GET
{
	/// <summary>
	///  Модель JSON-файла с тестовыми данными для API GET SINGLE USER
	/// </summary>
	internal class TestFileSingleUserResponse
	{
		[JsonConstructor]
		internal TestFileSingleUserResponse(string userId, SingleUserResponse expectedResult)
		{
			UserId = userId;
			ExpectedResult = expectedResult;
		}

		/// <summary>
		/// ID пользователя для API GET LIST USERS
		/// </summary>
		[JsonProperty("userId")]
		internal string UserId { get; }

		/// <summary>
		/// Ожидаемый результат выполнения API GET SINGLE USER.
		/// Эталонные данные для сравнения с результатом выполнения запроса
		/// </summary>
		[JsonProperty("expected_result")]
		internal SingleUserResponse ExpectedResult { get; }
	}
}