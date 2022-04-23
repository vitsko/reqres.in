using Newtonsoft.Json;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Модель "Пользователь", сформированная в ответ на get-запрос для API SINGLE USER
	/// </summary>
	internal class SingleUserResponse
	{
		[JsonConstructor]
		internal SingleUserResponse(User user, SupportInfo support)
		{
			User = user;
			Support = support;
		}

		[JsonProperty("data")]
		internal User User { get; }

		[JsonProperty("support")]
		internal SupportInfo Support { get; }
	}
}