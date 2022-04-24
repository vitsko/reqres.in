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
		internal TestFileSingleUserResponse(int userId, SingleUserResponse response, SingleUserResponse expectedResult)
		{
			UserId = userId;
			Response = response;
			ExpectedResult = expectedResult;
		}

		/// <summary>
		/// ID пользователя для API GET LIST USERS
		/// </summary>
		[JsonProperty("userId")]
		internal int UserId { get; }

		/// <summary>
		/// Результат выполнения API GET SINGLE USER в соответствии с UserId
		/// </summary>
		[JsonProperty("response")]
		internal SingleUserResponse Response { get; }

		/// <summary>
		/// Ожидаемый результат выполнения API GET SINGLE USER.
		/// Эталонные данные для сравнения с результатом выполнения запроса
		/// </summary>
		[JsonProperty("expected_result")]
		internal SingleUserResponse ExpectedResult { get; }
	}
}