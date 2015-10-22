using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyWord_PoC
{
	class FileReader
	{
		public List<String> Lines = new List<String>();

		public void OpenFile(string fileName)
		{
			var lines = File.ReadAllLines(fileName);
			
			foreach(var line in lines)
			{
				Lines.Add(line);
			}
		}
	}
}
