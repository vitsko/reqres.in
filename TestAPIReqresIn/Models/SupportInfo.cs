using Newtonsoft.Json;
using System;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Модель "Support", сформированная в ответе get-запроса для API LIST USERS \ SINGLE USER
	/// </summary>
	internal class SupportInfo
	{
		[JsonConstructor]
		internal SupportInfo(Uri url, string text)
		{
			Url = url;
			Text = text;
		}

		/// <summary>
		/// Url для пожертвования сервису reqres.in
		/// </summary>
		[JsonProperty("url")]
		internal Uri Url { get; }

		/// <summary>
		/// Текст с просьбой поддержать сервис reqres.in
		/// </summary>
		[JsonProperty("text")]
		internal string Text { get; }
	}
}