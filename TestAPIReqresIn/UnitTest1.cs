using NUnit.Framework;
using System;
using TestAPIReqresIn.Models;
using TestAPIReqresIn.Models.POST;
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
			var response = httpUtil.PostCreatedUserResponse("https://reqres.in/api/users", new InputUserInfo("Vitaliy", new DateTime(1988, 11, 26), "STE"));
		}
	}
}
