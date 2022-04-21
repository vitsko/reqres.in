using System;

namespace TestAPIReqresIn.Models
{
	/// <summary>
	/// Информация по Support-объекту ответа API
	/// </summary>
	internal class SupportInfo
	{
		internal SupportInfo(Uri url, string text)
		{
			Url = url;
			Text = text;
		}

		/// <summary>
		/// Url для пожертвования сервису reqres.in
		/// </summary>
		internal Uri Url { get; }

		/// <summary>
		/// Текст с просьбой поддержать сервис reqres.in
		/// </summary>
		internal string Text { get; }
	}
}