using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWord_PoC
{
	[KeyWordLibrary]
	public static class PokemonKeywords
	{
		[KeyWord("Pokemon Evolution")]
		public static void PokemonEvolution(string name)
		{
			switch (name)
			{
				case "Charmander":
					Console.WriteLine("Charmander evolves to Charmeleon!");
					break;
				case "Charmeleon":
					Console.WriteLine("Charmeleon evolves to Charizard!");
					break;
				case "Pikachu":
					Console.WriteLine("Pikachu encountered a Thunder Stone and willingly evolves into Raichu!");
					break;
				case "Pichu":
					Console.WriteLine("Pichu evolves to Pikachu!");
					break;
				default:
					Console.WriteLine("That Pokemon is not in our database.\nPlease be patient if you know this Pokemon exists, as new Pokemon are added daily!");
					break;
			}
		}

		[KeyWord("Another Pokemon Keyword")]
		public static void AnotherPokemonKeyWord()
		{
			//
		}

		private static void NotAPokemonKeyword()
		{
			//
		}

		[KeyWord("Pokemon Attack")]
		public static void PokemonAttack()
		{
			//
		}
	}
}
