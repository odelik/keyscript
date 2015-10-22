using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_PoC
{
	[KeyWordLibrary]
	public static class GenericKeyWords
	{
		[KeyWord("Hello World")]
		public static void HelloWorld()
		{
			Console.WriteLine("Hello World");
		}

		[KeyWord("Goodbye World")]
		public static void GoodbyeWorld()
		{
			Console.WriteLine("Goodbye Cruel World!");
		}

		[KeyWord("Random Number")]
		public static void RandomNumber(string lower, string upper)
		{
			Random random = new Random();

			Console.WriteLine(random.Next(Convert.ToInt32(lower) + 1, Convert.ToInt32(upper) + 1));
		}

		public static void NotAKeyWord()
		{
			//
		}
	}
}
