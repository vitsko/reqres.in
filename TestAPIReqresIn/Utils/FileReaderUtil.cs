using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.IO;
using TestAPIReqresIn.Models.TestData.GET;
using TestAPIReqresIn.Models.TestData.POST;

namespace TestAPIReqresIn.Utils
{
	/// <summary>
	/// Утилита получения тестовых данных для проверки API
	/// </summary>
	internal static class FileReaderUtil
	{
		/// <summary>
		/// Адрес папки с json-файлами для проведения тестирования
		/// </summary>
		private static string _fileFolderPath;

		static FileReaderUtil()
		{
			_fileFolderPath = ConfigurationManager.AppSettings["FolderWithTestFile"];
		}

		/// <summary>
		/// Получить данные для тестирования API GET LIST USERS
		/// </summary>
		/// <param name="testFileName">Имя \ путь относительно FolderWithTestFile до JSON-файла с тестовыми данными для API GET LIST USERS</param>
		internal static TestFileListUsersResponse GetTestDataListUsersResponse(string testFileName)
		{
			return (TestFileListUsersResponse)GetTestObject(testFileName, typeof(TestFileListUsersResponse));
		}

		/// <summary>
		/// Получить данные для тестирования API GET SINGLE USER
		/// </summary>
		/// <param name="testFileName">Имя \ путь относительно FolderWithTestFile до JSON-файла с тестовыми данными для API GET SINGLE USER</param>
		internal static TestFileSingleUserResponse GetTestDataSingleUserResponse(string testFileName)
		{
			return (TestFileSingleUserResponse)GetTestObject(testFileName, typeof(TestFileSingleUserResponse));
		}

		/// <summary>
		/// Получить данные для тестирования API POST CREATE
		/// </summary>
		/// <param name="testFileName">Имя \ путь относительно FolderWithTestFile до JSON-файла с тестовыми данными для API POST CREATE</param>
		internal static TestFileCreatedUserResponse GetTestDataCreatedUserResponse(string testFileName)
		{
			return (TestFileCreatedUserResponse)GetTestObject(testFileName, typeof(TestFileCreatedUserResponse));
		}

		private static object GetTestObject(string testFileName, Type objectType)
		{
			var filePath = Path.Combine(_fileFolderPath, testFileName);
			var jsonObject = JObject.Parse(File.ReadAllText(filePath));
			return JsonConvert.DeserializeObject(jsonObject.ToString(), objectType);
		}
	}
}