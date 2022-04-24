using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models.Responses.POST
{
	/// <summary>
	///  Модель "Пользователь", чьи данные используются на вход API
	/// </summary>
	internal class UserInfo
	{
		[JsonConstructor]
		internal UserInfo(string name, DateTime birthday, string job)
		{
			Name = string.IsNullOrWhiteSpace(name) ? string.Empty : name;
			Job = string.IsNullOrWhiteSpace(job) ? string.Empty : job;
			Birthday = birthday;
		}

		/// <summary>
		/// Имя пользователя
		/// </summary>
		[JsonProperty("name")]
		internal string Name { get; }

		/// <summary>
		/// Рабочая обязанность пользователя
		/// </summary>
		[JsonProperty("job")]
		internal string Job { get; }

		/// <summary>
		/// Дата рождения пользователя
		/// </summary>
		[JsonProperty("birthday")]
		internal DateTime Birthday { get; }
	}
}