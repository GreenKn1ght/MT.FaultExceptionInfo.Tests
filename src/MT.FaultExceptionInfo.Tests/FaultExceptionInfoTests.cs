using System;
using NUnit.Framework;

namespace MT.FaultExceptionInfo.Tests
{
	[TestFixture]
	public class FaultExceptionInfoTests
	{
		#region Data
		#region Fields
		private Exception _exception1;
		private Exception _exception2;
		#endregion
		#endregion

		#region Setup/Teardown
		[SetUp]
		public void SetUp()
		{
			_exception1 = new Exception("Exception1");
			_exception2 = new Exception("Exception2", _exception1);
		}
		#endregion

		#region Test methods
		[Test]
		public void Test1()
		{
			var faultExceptionInfo = new MassTransit.Events.FaultExceptionInfo(_exception2);

			Assert.AreEqual(_exception2.Message, faultExceptionInfo.Message);
		}

		[Test]
		public void Test2()
		{
			var faultExceptionInfo = new MassTransit.Events.FaultExceptionInfo(_exception2);

			Assert.IsNotNull(faultExceptionInfo.InnerException);
		}
		#endregion
	}
}
