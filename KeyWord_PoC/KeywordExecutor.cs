using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace KeyWord_PoC
{
	public static class KeywordExecutor
	{
		public static void ExecuteKeyWord(Word command, Dictionary<string, KeyWordInfo> wordLibrary)
		{
			try
			{
				Type KeyWordClass = wordLibrary[command.KeyWord].ParentClass;
				MethodInfo method = KeyWordClass.GetMethod(wordLibrary[command.KeyWord].Method.Name);
				method.Invoke(null, command.Argument.ToArray());
			}
			catch
			{
				Console.WriteLine("");
				Console.WriteLine("Error: The Command on line " + command.LineNumber + " does not exist in the keyword DB!");
				Console.WriteLine("Error: Command: " + command.KeyWord);
				Console.WriteLine("Error: Source: " + command.Original);
				Console.WriteLine("");
			}
			
		}
	}
}
