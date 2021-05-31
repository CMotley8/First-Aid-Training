[```Video```](https://github.com/CMotley8/First-Aid-Training/blob/d1d3a9e8d2c5cebfae482eee766b5b282edbddc4/Assets/Scripts/Video%20and%20Text%20Scripts/Video.cs) handles all of the interaction between the video player-related buttons ([Next Video Button](Next-Video-Button), [Play Video Button](Play-Vide-Button), [Previous Video Button](Previous-Video-Button), etc.)

***

The following variables must be adjusted in the inspector in Unity.
- ```textReader```, the [```TextReader```](Text-Reader) component that is attached to a ```GameObject``` in the scene.
- ```playButtonMaterial```, the ```Material``` named [```PlayButtonMat```](https://github.com/CMotley8/First-Aid-Training/blob/d1d3a9e8d2c5cebfae482eee766b5b282edbddc4/Assets/Materials/PlayButtonMat.mat) located inside of the ```Materials``` folder in the project folder.
- ```pauseButtonMaterial```, the ```Material``` named [```PauseButtonMat```](https://github.com/CMotley8/First-Aid-Training/blob/d1d3a9e8d2c5cebfae482eee766b5b282edbddc4/Assets/Materials/PauseButtonMat.mat) located inside of the ```Materials``` folder in the project folder.
- ```replayButtonMaterial```, the ```Material``` named [```ReplayButtonMat```](https://github.com/CMotley8/First-Aid-Training/blob/d1d3a9e8d2c5cebfae482eee766b5b282edbddc4/Assets/Materials/ReplayButtonMat.mat) located inside of the ```Materials``` folder in the project folder.
- ```playButtonRenderer```, the ```Renderer``` component that is attached to the ```Play Video Button``` in the scene.
- ```videoClips```, an array of ```VideoClips``` that contains all of the video clips that will be played in the scene; populate the array with video clips from the ```Videos``` folder in the project folder.
- ```previousButton```, the GameObject named ```Previous Button``` in the scene.
- ```nextButton```, the GameObject named ```Next Button``` in the scene.