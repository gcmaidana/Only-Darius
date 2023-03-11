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



			// This auto picks Darius, but now I need to make sure that all conditions are taken into account,
			// otherwise we will run into errors. For ex: this works if you are selecting champ, but if it's not 
			// your turn to pick, it will throw an error, and likewise, it will throw an error if you are not in the champ select.
			var body = "{\"championId\": 122, \"completed\": true }";
			var data = await leagueClient.Request(requestMethod.PATCH, "/lol-champ-select/v1/session/actions/1", body);
			Console.WriteLine(data);
			
			
			
			



		}
	}
}
