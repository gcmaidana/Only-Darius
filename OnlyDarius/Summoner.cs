using PoniLCU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PoniLCU.LeagueClient;

namespace OnlyDarius
{
	internal class Summoner
	{

		public async void getData(LeagueClient leagueClient)
		{
			Console.WriteLine("Getting current summoner info...");
			var data = await leagueClient.Request(requestMethod.GET, "/lol-summoner/v1/current-summoner");
			Console.WriteLine(data);
		}

	}
}
