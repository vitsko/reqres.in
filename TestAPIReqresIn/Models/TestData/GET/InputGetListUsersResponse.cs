using Newtonsoft.Json;

namespace TestAPIReqresIn.Models.TestData.GET
{
	/// <summary>
	/// Модель тестовых данных для API GET LIST USERS
	/// </summary>
	internal class InputGetListUsersResponse
	{
		[JsonConstructor]
		internal InputGetListUsersResponse(string page, string perPage)
		{
			Page = string.IsNullOrWhiteSpace(page) ? string.Empty : page;
			PerPage = string.IsNullOrWhiteSpace(perPage) ? string.Empty : perPage;
		}

		/// <summary>
		/// Номер страницы из набора данных пользователей, возвращаемых API GET LIST USERS
		/// </summary>
		[JsonProperty("page")]
		internal string Page { get; }

		/// <summary>
		/// Количество пользователей на страницу из набора данных, возвращаемого API GET LIST USERS
		/// </summary>
		[JsonProperty("per_page")]
		internal string PerPage { get; }
	}
}