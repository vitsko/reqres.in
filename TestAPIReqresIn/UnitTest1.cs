using NUnit.Framework;
using System;
using TestAPIReqresIn.Models;
using TestAPIReqresIn.Utils;

namespace TestAPIReqresIn
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			Assert.IsTrue(true);

			var httpUtil = new HttpUtil();
			var response = httpUtil.GetListUsersResponse("https://reqres.in/api/users").Result;
		}
	}
}
