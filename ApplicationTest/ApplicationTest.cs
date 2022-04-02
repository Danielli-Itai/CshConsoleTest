using CshApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;






namespace CshConsoleTest.ApplicationTest
{
	/// <summary>
	/// Summary description for ApplicationTest
	/// </summary>
	[TestClass]
	public class ApplicationTest
	{
		public ApplicationTest()
		{
			//
			// TODO: Add constructor logic here
			return;
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		[ClassInitialize()]
		public static void MyClassInitialize(TestContext testContext) {
		}
		
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void TestIntegersMultiply()
		{
			ApplicationGUI dut = new ApplicationGUI();
			try{
				string result = dut.CmdMultiply("5", "5");
				Assert.AreEqual("25", result);
			}
			catch(Exception e){
				Assert.Fail(e.Message);
			}
		}

		[TestMethod]
		public void TestIntegersMultiply2()
		{
			ApplicationGUI dut = new ApplicationGUI();
			try
			{
				string result = dut.CmdMultiply("50", "50");
				Assert.AreEqual("2500", result);
			}
			catch (Exception e)
			{
				Assert.Fail(e.Message);
			}
		}

	}
}
