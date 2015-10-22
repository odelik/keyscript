using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_PoC
{
	public class Commands
	{
		public List<Word> Command;
		public Dictionary<string, string> Variables;
		// Example of logging test errors
		public List<Exception> KeyWordErrors;

		public Commands()
		{
			Command = new List<Word>();
			Variables = new Dictionary<string, string>();
		}
	}
}
