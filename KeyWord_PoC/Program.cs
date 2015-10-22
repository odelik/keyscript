using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_PoC
{
	class Program
	{
		public static Commands Command = new Commands();

		static void Main(string[] args)
		{
			KeyWordLibrary WordLibrary = new KeyWordLibrary();

			Interpreter interepter = new Interpreter("Tests//Keyword_Poc.txt");

			Command = interepter.ParseCommands();

			foreach (Word command in Command.Command)
			{
				KeywordExecutor.ExecuteKeyWord(command, WordLibrary.keyWords);
			}

			Console.ReadLine();
		}
	}
}
