[```TextReader```](https://github.com/CMotley8/First-Aid-Training/blob/d1d3a9e8d2c5cebfae482eee766b5b282edbddc4/Assets/Scripts/Video%20and%20Text%20Scripts/TextReader.cs) reads the treatment step instructions from a ```TextAsset``` and will change the information displayed.

***

The following variables must be adjusted in the inspector in Unity.
- ```treatmentInstructions```, the ```TextAsset``` that contains all of the instructions for the treatment to be performed in the scene; drag the ```TextAsset``` from the ```Resources``` folder in the project folder.
- ```stepInstructionsUI```, the ```TextMeshProUGUI``` component that is attached to the ```GameObject``` named ```Treatment Step Instructions``` in the scene.
- ```stepNumUI```, the ```TextMeshProUGUI``` component that is attached to the ```GameObject``` named ```Treatment Step Number``` in the scene.