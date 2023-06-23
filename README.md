# Unity-echo3D-Demo-RoadCrossing
This road crossing game loads its animals and decorations at runtime using the echo3D API. 
Please help the river otter from getting hit by other crazy animals!
Your goal is to dodge the animals and get the river otter to the goal safely.

## How to Play
* Play the game in game play mode from the Main Menu Scene
* Press start to begin
* Move the river otter by pressing direction keys in your keyboard



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
Press Play in Unity. There are 2 player controllers: S and W for the left player, and the Up Arrow and Down Arrow for the right player.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
* Background asset: [freepik](https://medium.com/r/?url=https%3A%2F%2Fwww.freepik.com%2Ffree-vector%2Fdetailed-table-tennis-logo_9891974.htm%23query%3Dping%2520pong%2520logo%26position%3D4%26from_view%3Dsearch)

## Screenshots
![PingPongGIF](https://user-images.githubusercontent.com/99516371/176971241-345a9051-654f-4868-97e7-b80846fa876b.gif)
![Cover](https://user-images.githubusercontent.com/99516371/176971315-14af730a-795d-4b00-bf63-23cf6ed455f5.png)

