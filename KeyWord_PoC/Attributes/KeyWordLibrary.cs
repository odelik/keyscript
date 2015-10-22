using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace KeyWord_PoC
{
	public class KeyWordLibrary : Attribute
	{
		public Dictionary<string, KeyWordInfo> keyWords = new Dictionary<string,KeyWordInfo>();

		public KeyWordLibrary()
		{
			Initalise();
		}

		public void Initalise()
		{
			var Words = GetKeyWords();

			RegisterKeyWords(Words);
		}

		private IEnumerable<MemberInfo> GetKeyWords()
		{
			Assembly assembly = Assembly.GetAssembly(typeof(KeyWordLibrary));

			var Words = assembly.GetTypes()
			.SelectMany(type => type.GetMembers())
			.Union(assembly.GetTypes())
			.Where(type => Attribute.IsDefined(type, typeof(KeyWord)));
			return Words;
		}

		private void RegisterKeyWords(IEnumerable<MemberInfo> Words)
		{
			foreach (var word in Words)
			{
				KeyWordInfo wordInfo = new KeyWordInfo(word, word.DeclaringType);
				keyWords.Add(GetKeyWordAttribute(word), wordInfo);
			}
		}

		private string GetKeyWordAttribute(MemberInfo word)
		{
			return word.GetCustomAttribute(typeof(KeyWord)).ToString();;
		}
	}
}