using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_PoC
{
	public class Word
	{
		public String KeyWord;
		public List<object> Argument;
		public String Original;
		public String LineNumber;

		public Word()
		{
			Argument = new List<object>();
			KeyWord = "";
			Original = "";
			LineNumber = "";
		}
	}
}
