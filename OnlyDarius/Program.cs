using System;
using PoniLCU;
using static PoniLCU.LeagueClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Special thanks to Ponita0 for the LCU library.
 * Link: https://github.com/Ponita0/PoniLCU
 * 
 * Additionally, special thanks to everyone over hextechdocs for the documentation
 * since Riot Games does not have official documentation available for the League Client Update.
 * Link: https://hextechdocs.dev/
 */
namespace OnlyDarius
{
	internal class Program
	{
		static LeagueClient leagueClient = new LeagueClient(credentials.cmd);
		static void Main(string[] args)
		{
			Summoner summoner = new Summoner();
			Rune rune = new Rune();
			PickDarius darius = new PickDarius();

			summoner.getData(leagueClient);
			Console.WriteLine();
			Console.WriteLine("Function correctly called using SUMMONER object...");
			Console.WriteLine();

			rune.createNewRunePage(leagueClient);
			Console.WriteLine();
			Console.WriteLine("Function correctly called using RUNE object...");
			Console.WriteLine();

			// TO-DO: Implement this
			 darius.pickDarius(leagueClient);

			

			// We have this Console.Read() here to read the next input, but it's just here so the console doesnt close after running all our methods succesfully
			Console.Read(); 
			
		}



		async static void pickDarius()
		{ 
		
		}


	}
}
