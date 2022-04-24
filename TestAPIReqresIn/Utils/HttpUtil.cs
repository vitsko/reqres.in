﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestAPIReqresIn.Models.Responses.GET;
using TestAPIReqresIn.Models.Responses.POST;

namespace TestAPIReqresIn.Utils
{
	/// <summary>
	/// Утилита для выполнения запросов к API
	/// </summary>
	internal class HttpUtil
	{
		private static readonly HttpClient _client = new HttpClient();

		internal HttpUtil()
		{
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		/// <summary>
		/// Получить список пользователей. API GET LIST USERS
		/// </summary>
		/// <param name="serviceUrl">Адрес endpoint для GET LIST USERS</param>
		internal ListUsersResponse GetListUsersResponse(string serviceUrl)
		{
			return (ListUsersResponse)GetResponse(serviceUrl, typeof(ListUsersResponse)).Result;
		}

		/// <summary>
		/// Получить данные по пользователю. API GET SINGLE USER
		/// </summary>
		/// <param name="serviceUrl">Адрес endpoint для GET SINGLE USER</param>
		internal SingleUserResponse GetSingleUserResponse(string serviceUrl)
		{
			return (SingleUserResponse)GetResponse(serviceUrl, typeof(SingleUserResponse)).Result;
		}

		/// <summary>
		/// Создать учетную запись пользователя. API POST CREATE
		/// </summary>
		/// <param name="serviceUrl">>Адрес endpoint для POST CREATE</param>
		/// <param name="user">Данные по пользователю, для которого создается учетная запись</param>
		internal CreatedUserResponse PostCreatedUserResponse(string serviceUrl, UserInfo user)
		{
			return (CreatedUserResponse)PostResponse(serviceUrl, user).Result;
		}

		private async Task<object> PostResponse(string serviceUrl, UserInfo user)
		{
			var postData = JsonConvert.SerializeObject(user);
			var strContent = new StringContent(postData);
			strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			var response = await _client.PostAsync(serviceUrl, strContent);

			if (response.IsSuccessStatusCode)
			{
				var responseBody = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject(responseBody, typeof(CreatedUserResponse));
			}

			return null;
		}

		private async Task<object> GetResponse(string serviceUrl, Type typeResponseObject)
		{
			var response = await _client.GetAsync(serviceUrl);

			if (response.IsSuccessStatusCode)
			{
				var responseBody = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject(responseBody, typeResponseObject);
			}

			return null;
		}
	}
}