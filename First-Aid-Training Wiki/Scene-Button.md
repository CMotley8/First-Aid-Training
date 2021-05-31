[```SceneButton```](https://github.com/CMotley8/First-Aid-Training/blob/d1d3a9e8d2c5cebfae482eee766b5b282edbddc4/Assets/Scripts/Menu%20Button%20Scripts/SceneButton.cs) is an abstract class that the scene buttons inherit from.

Make sure to add the scene from the ```Scenes``` folder in the project folder to the ```Scenes In Build``` in the ```Build Settings```, otherwise there is no way to access the scene.

***

Methods:
- ```LoadScene(string)```, using the scenes available in the ```Scenes In Build```— loads the scene that correlates to the ```string``` passed to the method.
- ```ReloadScene()```, reloads the current scene.

***

Derived Classes:
- [Burn Treatment Scene Button](Burn-Treatment-Scene-Button)
- [CPR Treatment Scene Button](CPR-Treatment-Scene-Button)
- [Choking Treatment Scene Button](Choking-Treatment-Scene-Button)
- [Heart Attack Treatment Scene Button](Heart-Attack-Treatment-Scene-Button)
- [Main Menu Button](Main-Menu-Button)
- [Replay Scene Button](Replay-Scene-Button)
- [Seizure Treatment Scene Button](Seizure-Treatment-Scene-Button)
