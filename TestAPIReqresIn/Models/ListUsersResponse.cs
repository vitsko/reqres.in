using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Модель "Пользователи", сформированная в ответ на get-запрос для API LIST USERS
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
		/// Номер страницы из набора данных пользователей, возвращаемых API LIST USERS
		/// </summary>
		[JsonProperty("page")]
		internal int Page { get; }

		/// <summary>
		/// Количество пользователей на страницу из набора данных, возвращаемого API LIST USERS
		/// </summary>
		[JsonProperty("per_page")]
		internal int PerPage { get; }

		/// <summary>
		/// Количество пользователей в ответе API list users.
		/// </summary>
		[JsonProperty("total")]
		internal int Total { get; }

		/// <summary>
		/// Количество пользователей на одну страницу из набора данных, возвращаемого API LIST USERS
		/// </summary>
		[JsonProperty("total_pages")]
		internal int TotalPages { get; }

		[JsonProperty("data")]
		internal List<User> Users { get; }

		[JsonProperty("support")]
		internal SupportInfo Support { get; }
	}
}