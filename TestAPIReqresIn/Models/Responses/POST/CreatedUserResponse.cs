using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models.Responses.POST
{
	/// <summary>
	///  Модель "Пользователь", сформированная в ответ на запрос для API POST CREATE
	/// </summary>
	internal class CreatedUserResponse : UserInfo, IEquatable<CreatedUserResponse>
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

		public bool Equals(CreatedUserResponse other)
		{
			if (other is null)
			{
				return false;
			}

			return ReferenceEquals(this, other) || ID == other.ID;
		}

		public override bool Equals(object obj) => Equals(obj as CreatedUserResponse);

		public override int GetHashCode() => 1;

		public static bool operator ==(CreatedUserResponse left, CreatedUserResponse right)
		{
			return left is null
				? right is null
				: left.Equals(right);
		}

		public static bool operator !=(CreatedUserResponse left, CreatedUserResponse right) => !(left == right);
	}
}