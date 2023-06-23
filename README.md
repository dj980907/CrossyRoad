# Unity-echo3D-Demo-RoadCrossing
This road crossing game loads its animals and decorations at runtime using the echo3D API. <br>
Please help the river otter from getting hit by other crazy animals!<br>
Your goal is to dodge the animals and get the river otter to the goal safely.


## Setup
* Built with Unity 2022.3.0.  _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_
* Register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
* Clone this repo. 


## Setup
* [Add these models](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity Assets/Models folder:  <br>
      - River Otter <br>
      - Goat <br>
      - Bison <br>
      - Ferret <br>
      - Tree <br>
      - Rock chunk <br>
      - Flower <br>
      - Soccer goal <br>
      - Fence1 <br>
      - Fence2 <br>
      - Fence3 <br>
      - Fence4 <br>
      - Fence5 <br>
      - Fence6 <br>
      - Fence7 <br>
      - Fence8 <br>
      - Fence9 <br>
      - Fence10 <br>
      - Fence11 <br>
      - Fence12 <br>


* Open the _Game_ scene.
  
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs for those same models in the Inspector. <br>
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
![NEWAPIKeyandEntryID](https://user-images.githubusercontent.com/99516371/205407613-b746840f-8e8a-4ec8-b056-a680395dfab4.png)<br>

* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>


* (Recommended) To move, resize or edit the assets live in your Scene view, check the boxes for “Editor Preview” and “Ignore Model Transforms”. To enable this, click Echo3D > Load Editor Holograms in your Unity toolbar. <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>


## Run
* Press Play in Unity to play the game from _MainMenu_ Scene
* Press start button on the game play screen
* Move the river otter by pressing direction keys in your keyboard (left arrow: move left, right arrow: move right, upward arrow: move forward, downward arrow: move back)
  
## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
This demo implements background music from Unity Asset Store:
 - [8bit Music](https://assetstore.unity.com/packages/audio/music/8bit-music-062022-225623)

## Screenshots
* Main Menu Screen: This is where you will begin your game.
  <img width="762" alt="mainMenu" src="https://github.com/dj980907/CrossyRoad/assets/108609222/267f3f4a-fe90-459a-a445-469382ff6930">
* Game Screen: This is where you play the actual game.
  <img width="762" alt="gameScreen" src="https://github.com/dj980907/CrossyRoad/assets/108609222/79e111ba-e685-4208-b41e-b961e2822f4a">
* Game Over Screen: This will be shown when you run into other animals.
  <img width="762" alt="gameOver" src="https://github.com/dj980907/CrossyRoad/assets/108609222/dfffa7b9-d9b5-42d5-ab24-e18809e02f30">
* Game Finished Screen: This will be shown when you successfully move river otter to the goal.
  <img width="762" alt="GameFinished" src="https://github.com/dj980907/CrossyRoad/assets/108609222/1bc47deb-f903-42a7-a97a-b677a68b7266">
* Game Play GIF: <br>
![gameRecording](https://github.com/dj980907/CrossyRoad/assets/108609222/947f827f-f93e-424f-bbfb-c757a73d5fdd)


