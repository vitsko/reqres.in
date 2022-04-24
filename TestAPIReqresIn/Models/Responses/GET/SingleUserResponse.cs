using Newtonsoft.Json;

namespace TestAPIReqresIn.Models.Responses.GET
{
	/// <summary>
	/// Модель "Пользователь", сформированная в ответ на запрос для API GET SINGLE USER
	/// </summary>
	internal class SingleUserResponse
	{
		[JsonConstructor]
		internal SingleUserResponse(User user, SupportInfo support)
		{
			User = user;
			Support = support;
		}

		/// <summary>
		/// Пользователь, полученный в ответ на запрос API GET SINGLE USERS
		/// </summary>
		[JsonProperty("data")]
		internal User User { get; }

		/// <summary>
		/// Информация по support, сформированная в ответ на запрпрос API GET SINGLE USERS
		/// </summary>
		[JsonProperty("support")]
		internal SupportInfo Support { get; }
	}
}