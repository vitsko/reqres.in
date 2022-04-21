using System;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Пользователь, информация по которому возвращается из сервиса reqres.in
	/// </summary>
	internal class User
	{
		internal User(int id, string email, string firstName, string lastName, Uri avatarUrl)
		{
			ID = id;
			Email = email;
			FirstName = firstName;
			LastName = lastName;
			AvatarUrl = avatarUrl;
		}

		internal int ID { get; }
		internal string Email { get; }
		internal string FirstName { get; }
		internal string LastName { get; }
		internal Uri AvatarUrl { get; }
	}
}