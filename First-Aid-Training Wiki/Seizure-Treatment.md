[```SeizureTreatment```](https://github.com/CMotley8/First-Aid-Training/blob/fbd0b6dbcfd6fc0de5c2af9fdf740ab95b557441/Assets/Scripts/Treatment%20Type%20and%20Treatment%20Object%20Scripts/SeizureTreatment.cs) derives from [```Treatment```](Treatment) and handles all of the interactions between the player and the patient.

***

The following variables must be adjusted in the inspector in Unity.
- ```menuButtons```, the ```GameObject``` named ```Menu Buttons``` in the scene.
- ```animator```, the ```Animator``` component attached to the patient in the scene.
- ```Step```, an array for the number of steps— it contains a user-defined number of elements of type ```bool```.