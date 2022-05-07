/****************************************************************\
* This code written by Itai Danielly                             *
* This program is free software: you can redistribute it and/or  *
* modify it under the terms of the GNU General Public License    *
* as published by the Free Software Foundation, either version 3 *
* of the License, or (at your option) any later version.         *
* This program is distributed in the hope that it will be useful *
* but WITHOUT ANY WARRANTY; without even the implied warranty of *
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.           *
* See the GNU General Public License for more details.           *
\****************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_HIDE, DialogCommands.CommandGuiHide));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_MULT, DialogCommands.CommandGuiMult));
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_CLOSE, DialogCommands.CommandGuiClose));

			//	Execute the echo command in the command list.
			Assert.IsTrue("6" == CommandsApi.CommandExec(pCommands, CMD_GUI_MULT));
			Assert.IsTrue(AppCommands.CMD_OK == CommandsApi.CommandExec(pCommands, CMD_GUI_CLOSE));

			return;
		}

	};
}
