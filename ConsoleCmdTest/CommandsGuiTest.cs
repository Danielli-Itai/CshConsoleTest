using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CshConsoleAPI;



namespace CshConsoleTest
{

	[TestClass]
	public class CommandsGuiTest
	{
		private const string CMD_GUI_SHOW = DialogCommands.GUI_SHOW + "()";
		private const string CMD_GUI_MULT = DialogCommands.GUI_MULT + "(2,3)";
		private const string CMD_GUI_CLOSE = DialogCommands.GUI_CLOSE + "()";




		//	Test the commands list using the echo command function.
		[TestMethod]
		public void TestCommandGui()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding echo command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_SHOW, DialogCommands.CommandGuiShow));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_MULT, DialogCommands.CommandGuiMult));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_CLOSE, DialogCommands.CommandGuiClose));

			//	Execute the echo command in the command list.
			//Assert.IsTrue(AppCommands.CMD_TRUE == CommandsApi.CommandExec(ref pCommands, CMD_GUI_SHOW));
			Assert.IsTrue("6" == CommandsApi.CommandExec(ref pCommands, CMD_GUI_MULT));
			Assert.IsTrue(AppCommands.CMD_OK == CommandsApi.CommandExec(ref pCommands, CMD_GUI_CLOSE));

			return;
		}

	};
}
