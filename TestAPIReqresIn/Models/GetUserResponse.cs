using System.Collections.Generic;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Ответ на Get-запрос для API list \ single users
	/// </summary>
	internal class GetUserResponse
	{
		internal GetUserResponse(Paging paging, List<User> users, SupportInfo support)
		{
			Paging = paging;
			Users = users;
			Support = support;
		}

		internal Paging Paging { get; }
		internal List<User> Users { get; }
		internal SupportInfo Support { get; }
	}
}
