using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Модель "Пользователь", сформированная в ответе get-запроса для API LIST USERS \ SINGLE USER
	/// </summary>
	internal class User
	{
		[JsonConstructor]
		internal User(int id, string email, string firstName, string lastName, Uri avatarUrl)
		{
			ID = id;
			Email = email;
			FirstName = firstName;
			LastName = lastName;
			AvatarUrl = avatarUrl;
		}

		[JsonProperty("id")]
		internal int ID { get; }

		[JsonProperty("email")]
		internal string Email { get; }

		[JsonProperty("first_name")]
		internal string FirstName { get; }

		[JsonProperty("last_name")]
		internal string LastName { get; }

		[JsonProperty("avatar")]
		internal Uri AvatarUrl { get; }
	}
}