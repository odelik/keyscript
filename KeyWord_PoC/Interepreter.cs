using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_PoC
{
	class Interpreter
	{
		FileReader KeywordFile = new FileReader();
		Dictionary<string, string> Variables = new Dictionary<string, string>();
		Commands Command = new Commands();

		public Interpreter(string fileName)
		{
			KeywordFile.OpenFile(fileName);
		}

		public Commands ParseCommands()
		{
			foreach (string line in KeywordFile.Lines)
			{
				if (!String.IsNullOrEmpty(line))
				{
					GetCommandsAndAgruments(line);
				}
			}

			return Command;
		}

		public void GetCommandsAndAgruments(string line)
		{
			Word command = new Word();

			command.Original = line;
			command.LineNumber = (KeywordFile.Lines.FindIndex(i => i.Equals(line)) + 1).ToString();
			
			string[] lines = line.Split('\t');

			command.KeyWord = lines[0];

			for(int i = 1; i < lines.Count(); i++)
			{
				command.Argument.Add(lines[i]);
			}

			Command.Command.Add(command);
		}

	}
}
