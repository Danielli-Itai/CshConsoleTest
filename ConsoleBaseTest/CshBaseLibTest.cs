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
	public class CshBaseLibTest
	{
		const string HELLO_WORLD_TRIMED = "Hello World";

		[TestMethod]
		//	Right left string trimming test.
		public void TestTrim()
		{
			string trimmed = CStrTrim.trim(" \t\n  Hello World  ");
			Assert.IsTrue(trimmed == HELLO_WORLD_TRIMED);
		}
	}
}
