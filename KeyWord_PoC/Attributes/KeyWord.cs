using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace KeyWord_PoC
{
	[AttributeUsage(AttributeTargets.Method)]
	public class KeyWord : Attribute
	{
		public readonly string Word;

		public KeyWord(string word)
		{
			this.Word = word;
		}

		public override string ToString()
		{
			return Word;
		}
	}
}
