using PoniLCU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PoniLCU.LeagueClient;

namespace OnlyDarius
{
	internal class Rune
	{
		// The way we handle setting runes is by deleting the current rune page we have selected, creating a 
		// new rune page and populating that new rune page with the runes we want.
		// 
		// Why? Because if the player already has the max amount of rune pages possible, then we 
		// can't simply create another one. That's why it's a better approach to just delete
		// the current rune page and create another one, completely avoiding the situation
		// where they might have the max number of rune pages created already.
		//
		// Rune JSON values:
		// https://raw.communitydragon.org/latest/plugins/rcp-be-lol-game-data/global/default/v1/perks.json
		//
		//
		// Once Darius is locked in, we will set the runes to the proper runes for the champion.
		// The runes we will set and use throughout game are:
		// -------------------------------------------------------------------------------------
		// Rune Tree 1										Rune Tree 2
		//
		// Precision										Resolve
		// Conqueror (id:8010)								Second Wind (id:8444)
		// Triumph (id:9111)								Overgrowth (id:8451)
		// Legend: Alacrity (9104)									
		// Last Stand(id:8299)
		//
		//												    +10% Attack Speed (id:5005)
		//													+9 Adaptive Force(id:5008)
		//													+6 Armor (id:5002)
		// -------------------------------------------------------------------------------------
		public async void createNewRunePage(LeagueClient leagueClient)
		{
			// We need to get the ID of the current rune page in order to delete because
			// when we do a PUT request to delete the current rune page, we have to pass an ID

			// So first we get current rune page info JSON response
			Console.WriteLine("Getting current rune page info...");
			var data = await leagueClient.Request(requestMethod.GET, "/lol-perks/v1/currentpage");
			Console.WriteLine(data);

			// Now that we have the current rune page info, we know the ID of the current
			// rune page, so let's use that ID to delete the rune page
			var rune = Newtonsoft.Json.Linq.JObject.Parse(data);
			Console.WriteLine("Your current rune page name is " + "'" + rune["name"] + "'");
			Console.WriteLine("Your rune page ID is " + rune["id"]);
			Console.WriteLine();

			await leagueClient.Request(requestMethod.DELETE, "/lol-perks/v1/pages/" + rune["id"]);
			Console.WriteLine("Current rune page was successfully deleted.");
			Console.WriteLine();

			// Now we can finally create a new rune page for our Only Darius
			// program!

			// Okay, so how the selectedPerkIds works
			// is that the 9 ids are for the inner part of the two rune trees PLUS the three
			// little bonus statss (+10% Attack Speed, +9 Adapative Force, +6 Armor), e.g. perks,
			//
			// and the primaryStyleId is the outer part of the primary rune tree e.g.: Precision Tree
			//
			// and the subStyleId is the outer part of the the secondary rune tree e.g.: Resolve Tree
			//
			// We have one problem though, the runes JSON values page does not list any JSON values for the primary rune tree (Precision) or
			// a value for the secondary rune tree (Resolve), it only lists the perks' ids.
			// 
			// I spent hours trying to figure out what the ID of the precision rune was, I thought it between 8300 and 8700
			// since resolve rune was id of 8300... turns out it was 8000. I was stuck for so long
			// because it didn't fail 100% of the time, there were cases where the runes got
			// made correctly, but then it would fail other times.
			// Thanks to DarkIntaqt for his very helpful website that lists the IDs of the rune trees.
			// Link: https://darkintaqt.com/blog/lol-perks/
			var body = "{\"name\":\"King Darius\", \"selectedPerkIds\": [8010,9111,9104,8299,8444,8451,5005,5008,5002], \"primaryStyleId\":8000, \"subStyleId\":8400, \"current\": true}";
			await leagueClient.Request(requestMethod.POST, "lol-perks/v1/pages", body);
			Console.WriteLine("ONLY DARIUS RUNES ACTIVATED.");
		}

	}
}
