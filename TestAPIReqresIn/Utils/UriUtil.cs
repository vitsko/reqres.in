using System.Configuration;
using System.Web;
using TestAPIReqresIn.Models.TestData.GET;

namespace TestAPIReqresIn.Utils
{
	/// <summary>
	/// Утилита для получения URL endpoint сервиса, на который отправляется запрос
	/// </summary>
	internal static class UriUtil
	{
		/// <summary>
		/// Базовый URL для API
		/// </summary>
		private static string _baseAPIUrl;

		static UriUtil()
		{
			_baseAPIUrl = ConfigurationManager.AppSettings["BaseAPIUrl"];

			if (!_baseAPIUrl.EndsWith("/"))
			{
				_baseAPIUrl += "/";
			}
		}

		/// <summary>
		/// Получить URL для вызова API GET LIST USERS
		/// </summary>
		internal static string GetServiceListUsersUrl(InputGetListUsersResponse input)
		{
			var page = HttpUtility.UrlEncode(input.Page);
			var perPage = HttpUtility.UrlEncode(input.PerPage);

			if (string.IsNullOrWhiteSpace(input.Page) && string.IsNullOrWhiteSpace(input.PerPage))
			{
				return $"{_baseAPIUrl}users";
			}

			if (!string.IsNullOrWhiteSpace(input.Page) && !string.IsNullOrWhiteSpace(input.PerPage))
			{
				return $"{_baseAPIUrl}users?page={page}&per_page={perPage}";
			}

			return string.IsNullOrWhiteSpace(input.Page)
				? $"{_baseAPIUrl}users?per_page={perPage}"
				: $"{_baseAPIUrl}users?page={page}";
		}

		/// <summary>
		/// Получить URL для вызова API GET SINGLE USER
		/// </summary>
		internal static string GetServiceSingleUserResponse(string userId)
		{
			return string.IsNullOrWhiteSpace(userId)
				? $"{_baseAPIUrl}users"
				: $"{_baseAPIUrl}users/{HttpUtility.UrlEncode(userId)}";
		}

		/// <summary>
		/// Получить URL для вызова API POST CREATE
		/// </summary>
		internal static string GetServiceCreatedUserResponse()
		{
			return $"{_baseAPIUrl}users";
		}
	}
}