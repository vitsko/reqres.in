using NUnit.Framework;
using System;
using TestAPIReqresIn.Models;
using TestAPIReqresIn.Models.Responses.POST;
using TestAPIReqresIn.Utils;

namespace TestAPIReqresIn
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			var qw = FileReaderUtil.GetTestDataListUsersResponse("json1.json");

			Assert.IsTrue(true);

			var httpUtil = new HttpUtil();
			var response = httpUtil.GetSingleUserResponse("https://reqres.in/api/users/7");
		}
	}
}
