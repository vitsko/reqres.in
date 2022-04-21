namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Информация по построничному отображению данных в API "List Users".
	/// </summary>
	internal class Paging
	{
		internal Paging(int page, int perPage, int total)
		{
			Page = page;
			PerPage = perPage;
			Total = total;
		}

		/// <summary>
		/// Номер страницы из набора данных пользователей, возвращаемых API list users.
		/// </summary>
		internal int Page { get; }

		/// <summary>
		/// Количество пользователей на страницу из набора данных, возвращаемого API list users.
		/// </summary>
		internal int PerPage { get; }

		/// <summary>
		/// Количество пользователей в ответе API list users.
		/// </summary>
		internal int Total { get; }
	}
}