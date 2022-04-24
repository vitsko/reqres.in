﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestAPIReqresIn.Models.GET;
using TestAPIReqresIn.Models.POST;

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
		/// Получить список пользователей. API LIST USERS
		/// </summary>
		/// <param name="urlService"></param>
		/// <returns></returns>
		internal ListUsersResponse GetListUsersResponse(string urlService)
		{
			return (ListUsersResponse)GetResponse(urlService, typeof(ListUsersResponse)).Result;
		}

		/// <summary>
		/// Получить данные по пользователю. API SINGLE USER
		/// </summary>
		/// <param name="urlService"></param>
		/// <returns></returns>
		internal SingleUserResponse GetSingleUserResponse(string urlService)
		{
			return (SingleUserResponse)GetResponse(urlService, typeof(SingleUserResponse)).Result;
		}

		/// <summary>
		/// Создать учетную запись пользователя. API POST CREATE
		/// </summary>
		/// <param name="urlService"></param>
		/// <param name="user"></param>
		/// <returns></returns>
		internal CreatedUserResponse PostCreatedUserResponse(string urlService, InputUserInfo user)
		{
			return (CreatedUserResponse)PostResponse(urlService, user).Result;
		}

		private async Task<object> PostResponse(string urlService, InputUserInfo user)
		{
			var postData = JsonConvert.SerializeObject(user);
			var strContent = new StringContent(postData);
			strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			var response = await _client.PostAsync(urlService, strContent);

			if (response.IsSuccessStatusCode)
			{
				var responseBody = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject(responseBody, typeof(CreatedUserResponse));
			}

			return null;
		}

		private async Task<object> GetResponse(string urlService, Type typeResponseObject)
		{
			var response = await _client.GetAsync(urlService);

			if (response.IsSuccessStatusCode)
			{
				var responseBody = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject(responseBody, typeResponseObject);
			}

			return null;
		}
	}
}