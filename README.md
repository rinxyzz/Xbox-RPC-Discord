# Xbox Rich Presence
***Another note: Please before doing anything read this README, many people tried to clone the repository instead of downloading the release***

*Note: Discord already haves an integrated presence for Xbox Live, but if you want to show more information about what you are playing on Xbox Live u can use this*
## This Rich Presence contains:
1. Game/app name
2. Game/app image (not all games/apps haves an image, you can add images by [contributing](https://github.com/Yumekawaiii/Xbox-RPC-Discord#contribute))
3. Timestamp
4. Device name (Xbox One, Xbox 360, etc) and image
5. Xbox Live Rich Presence (if game/app supports it)

## Example
![logo](https://github.com/YumeKawaiii/Xbox-RPC-Discord/raw/main/Example2.png)


## Installation
1. Download the [latest release](https://github.com/YumeKawaiii/Xbox-RPC-Discord/releases) and install it following instructions on the setup

2. Go to [OpenXBL](https://xbl.io) and login with your Xbox Live account and you will get an API key, save it on a .txt file

3. Open the app and insert your Gamertag and API key

4. Press Start!


## To-Do list
- [ ] Show Xbox Live party
- [ ] Multi-language Rich Presence
- [x] GUI App
- [x] Database for games
- [x] Cool animations and effects
- [x] Device selector

## Contribute
Wanna contribute on adding games with pictures and backgrounds? Now you can! Just do a pull request editing the [Games List.json](https://github.com/YumeKawaiii/Xbox-RPC-Discord/blob/main/Games%20List.json) file!
- "titlename" should have the original name of the game that shows on Xbox, remove any Copyright or Trademark symbols
- Images on "titleicon" should be 1024x1024, and "titlebackground" can be any size but choose one that fits on the app correctly
- "titleimage" is a Discord parameter, give it any name or the game name, i will edit it after the pull request
- "type" (number) is the kind of game or app, Use the following numbers depending of the type of app or game:
  - (1) For games, it will show "Playing (game)"
  - (2) For video apps, it will show "Watching (app)"
  - (3) For another kind of apps, it will show "Using (app)"

## Contributors
People that helped me creating the app!
- Klaudex17 (Games pictures and design)
- J_Felipe (Ideas for the app)
- ! Kyousuke
- Elaina

People who contributed adding games!


<a href="https://github.com/YumeKawaiii/Xbox-RPC-Discord/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=YumeKawaiii/Xbox-RPC-Discord" />
</a>


*Made with [contrib.rocks](https://contrib.rocks).*


And many people on Discord!

If you're not seeing any image while playing your game or you need help with anything else, join to my [Discord](https://discord.gg/y22ujrB5e2) and i will gladly help you!
