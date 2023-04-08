# Only-Darius

*This program is a work in progress.*

This program will pick only the champion Darius when playing League of Legends. In addition the picking Darius, this program selects optimal runes for Darius. It currently does not do any selection for spells, but I would like to add the selection of Ghost and Flash in the future. 

The program selects the champion properly and it runs, but only if you run the program in the game lobby. I will continue to add functionality
so that the selection occurs without fail no matter when you start running the program, e.g.: whether in the game lobby or at the start screen, etc.

Currently, I think I am going to add a FlowHandler class because I think there's a League Client API request that tells you whether you're currently in the lobby, or in a game, etc.
I need to mess around with the API more to figure out a solution.
The code is commented to some degree, but I will add more comments and make everything more readable after I finish and refactor everything.

The motivation behind this project is that Darius is my favorite champion and I want others to experience how great Darius is.

*Please note that this project uses the League Client API, which is different than the official Riot Games API. The League Client API is not officially supported for use with third party applications. As such, there is no guarantee of full documentation or service uptime for the API, so I cannot guarantee that this project will work in the future.*

<img src="https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_0.jpg">

**GitHub is compressing and resizing the splash art image of Darius I upload, so I am not going to upload the splash art of Darius on this repository. Instead I am going to call the image from where [Riot Games hosts the image](https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_0.jpg) in order to prevent the image from being compressed and to preserve the quality of the splash art. This splash art that is being linked is part of the Data Dragon repository that Riot Games maintains and [all of which can be used by third-party developers](https://developer.riotgames.com/docs/lol#data-dragon).**

---
**OnlyDarius isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing Riot Games properties. Riot Games, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.**
