using PoniLCU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PoniLCU.LeagueClient;

namespace OnlyDarius
{
	internal class PickDarius
	{
		public async void pickDarius(LeagueClient leagueClient)
		{
			Console.WriteLine("Starting picking session...");
			// darius champion id 122

			// check if owned

			// select
			var champId = 122; // darius champion id;
			var spell1Id = 4; // flash
			var spell2Id = 6; // ghost

			// var data = await leagueClient.Request(requestMethod.GET, "/lol-champ-select/v1/session");
			
		}
	}
}
