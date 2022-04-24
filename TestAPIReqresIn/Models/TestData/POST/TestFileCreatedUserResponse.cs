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
		internal TestFileCreatedUserResponse(UserInfo userInfo, CreatedUserResponse expectedResult)
		{
			UserInfo = userInfo;
			ExpectedResult = expectedResult;
		}

		/// <summary>
		/// Данные пользователя для вызова API POST CREATE
		/// </summary>
		[JsonProperty("userId")]
		internal UserInfo UserInfo { get; }

		/// <summary>
		/// Ожидаемый результат выполнения API POST CREATE.
		/// Эталонные данные для сравнения с результатом выполнения запроса
		/// </summary>
		[JsonProperty("expected_result")]
		internal CreatedUserResponse ExpectedResult { get; }
	}
}