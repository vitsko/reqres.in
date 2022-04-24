using Newtonsoft.Json;

namespace TestAPIReqresIn.Models.TestData.GET
{
	/// <summary>
	/// Модель тестовых данных для API GET LIST USERS
	/// </summary>
	internal class InputGetListUsersResponse
	{
		[JsonConstructor]
		internal InputGetListUsersResponse(int page, int perPage)
		{
			Page = page;
			PerPage = perPage;
		}

		/// <summary>
		/// Номер страницы из набора данных пользователей, возвращаемых API GET LIST USERS
		/// </summary>
		[JsonProperty("page")]
		internal int Page { get; }

		/// <summary>
		/// Количество пользователей на страницу из набора данных, возвращаемого API GET LIST USERS
		/// </summary>
		[JsonProperty("per_page")]
		internal int PerPage { get; }
	}
}