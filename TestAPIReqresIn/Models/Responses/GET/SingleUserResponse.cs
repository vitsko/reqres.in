using Newtonsoft.Json;

namespace TestAPIReqresIn.Models.Responses.GET
{
	/// <summary>
	/// Модель "Пользователь", сформированная в ответ на запрос для API GET SINGLE USER
	/// </summary>
	internal class SingleUserResponse
	{
		[JsonConstructor]
		internal SingleUserResponse(User user)
		{
			User = user;
		}

		/// <summary>
		/// Пользователь, полученный в ответ на запрос API GET SINGLE USERS
		/// </summary>
		[JsonProperty("data")]
		internal User User { get; }
	}
}