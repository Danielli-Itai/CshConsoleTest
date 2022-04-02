using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CshConsoleAPI;



namespace CshConsoleTest
{
	[TestClass]
	public class CommandsTest
	{
		public const string CMD_ECHO_PARAM= "hello echo";
		public const string CMD_LINE_ECHO= "echo(" + CMD_ECHO_PARAM + ")";


		[TestMethod]
		public void TestParser()
		{
			//	Check command name parsing.
			Assert.IsTrue(Commands.CMD_ECHO == CommandsApi.CommandName(CMD_LINE_ECHO));

			// Check command parameters parsing.
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_ECHO);
			Assert.IsTrue(1 == parameters.Length);
			return;
		}


		//	Test the commands list using the echo command function.
		[TestMethod]
		public void TestCommandEcho()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding echo command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, AppCommands.CommandEcho));

			//	Execute the echo command in the command list.
			Assert.IsTrue(CMD_ECHO_PARAM == CommandsApi.CommandExec(ref pCommands, CMD_LINE_ECHO));
			return;
		}
	};
}
