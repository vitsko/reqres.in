using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestAPIReqresIn.Models;

namespace TestAPIReqresIn.Utils
{
	internal class HttpUtil
	{
		private static readonly HttpClient _client = new HttpClient();

		internal HttpUtil()
		{
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		internal async Task<object> GetListUsersResponse(string urlService)
		{
			return await GetResponse(urlService, typeof(ListUsersResponse));
		}

		internal async Task<object> GetSingleUserResponse(string urlService)
		{
			return await GetResponse(urlService, typeof(SingleUserResponse));
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