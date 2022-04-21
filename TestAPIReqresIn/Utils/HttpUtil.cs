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
		private string _urlService;

		internal HttpUtil(string urlService)
		{
			_urlService = urlService;
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json; charset=utf-8"));
		}

		internal async Task<GetUserResponse> GetResponseAsync()
		{
			var response = await _client.GetAsync(_urlService);

			if (response.IsSuccessStatusCode)
			{
				var responseBody = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<GetUserResponse>(responseBody);
			}

			return null;
		}
	}
}
