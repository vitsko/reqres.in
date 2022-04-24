using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models.Responses.POST
{
	/// <summary>
	///  Модель "Пользователь", сформированная в ответ на запрос для API POST CREATE
	/// </summary>
	internal class CreatedUserResponse : UserInfo
	{
		[JsonConstructor]
		internal CreatedUserResponse(int id, string name, DateTime birthday, string job, DateTime createdAt) : base(name, birthday, job)
		{
			ID = id;
			CreatedAt = createdAt;
		}

		/// <summary>
		/// ID пользователя, учетная запись которого сформирована API POST CREATE
		/// </summary>
		[JsonProperty("id")]
		internal int ID { get; }

		/// <summary>
		/// Время создания учетной записи пользователя, сформированной API POST CREATE
		/// </summary>
		[JsonProperty("createdAt")]
		internal DateTime CreatedAt { get; }
	}
}