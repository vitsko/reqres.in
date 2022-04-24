using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestAPIReqresIn.Models.Responses.GET
{
	/// <summary>
	/// Модель "Пользователи", сформированная в ответ на запрос для API GET LIST USERS
	/// </summary>
	internal class ListUsersResponse
	{
		[JsonConstructor]
		internal ListUsersResponse(int page, int perPage, int total, int totalPages, List<User> users, SupportInfo support)
		{
			Page = page;
			PerPage = perPage;
			Total = total;
			TotalPages = totalPages;
			Users = users;
			Support = support;
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

		/// <summary>
		/// Количество пользователей в ответе API GET LIST USERS
		/// </summary>
		[JsonProperty("total")]
		internal int Total { get; }

		/// <summary>
		/// Количество пользователей на одну страницу из набора данных, возвращаемого API GET LIST USERS
		/// </summary>
		[JsonProperty("total_pages")]
		internal int TotalPages { get; }

		/// <summary>
		/// Список пользователей, сформированный в ответ на запрпрос API GET LIST USERS
		/// </summary>
		[JsonProperty("data")]
		internal List<User> Users { get; }

		/// <summary>
		/// Информация по support, сформированная в ответ на запрпрос API GET LIST USERS
		/// </summary>
		[JsonProperty("support")]
		internal SupportInfo Support { get; }
	}
}