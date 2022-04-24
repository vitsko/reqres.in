using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models.POST
{
	/// <summary>
	///  Модель "Пользователь", чьи данные используются на вход API
	/// </summary>
	internal class InputUserInfo
	{
		[JsonConstructor]
		internal InputUserInfo(string name, DateTime birthday, string job)
		{
			Name = name;
			Job = job;
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