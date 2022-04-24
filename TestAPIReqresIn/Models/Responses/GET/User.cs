using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models.Responses.GET
{
	/// <summary>
	/// Модель "Пользователь", сформированная в ответе запроса для API GET LIST USERS \ SINGLE USER
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

		/// <summary>
		/// ID пользователя
		/// </summary>
		[JsonProperty("id")]
		internal int ID { get; }

		/// <summary>
		/// Адрес электронной почты пользователя
		/// </summary>
		[JsonProperty("email")]
		internal string Email { get; }

		/// <summary>
		/// Имя пользователя
		/// </summary>
		[JsonProperty("first_name")]
		internal string FirstName { get; }

		/// <summary>
		/// Фамилия пользователя
		/// </summary>
		[JsonProperty("last_name")]
		internal string LastName { get; }

		/// <summary>
		/// URL с фото пользователя
		/// </summary>
		[JsonProperty("avatar")]
		internal Uri AvatarUrl { get; }
	}
}