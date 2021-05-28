using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextReader : MonoBehaviour
{
	[Tooltip("This is the TextAsset that will be read from, drag it from your project folder to here.")]
	public TextAsset treatmentInstructions;
	[Tooltip("This is the Text Mesh Pro Text (UI) component that will be used to display the information for the current step.")]
	public TextMeshProUGUI stepInstructionUI;
	[Tooltip("This is the Text Mesh Pro Text (UI) component that will be used to display the current and total number of steps.")]
	public TextMeshProUGUI stepNumUI;

	private int currentIndex = 0;
	private List<string> lines = new List<string>();

	private void Awake()
	{
		//Spliting the text by checking for the new line character "\n" (automatically added by writing on a new line in a text editor).
		var arrayString = treatmentInstructions.text.Split('\n');
		foreach (var line in arrayString)
		{
			lines.Add(line);
		}
		stepInstructionUI.text = lines[currentIndex];
		stepNumUI.text = "Step " + (currentIndex + 1) + "/" + lines.Count;
	}

	//Changes the step instructions to the next step.
	public void NextStep()
	{
		if (currentIndex < lines.Count - 1)
		{
			currentIndex++;
			stepInstructionUI.text = lines[currentIndex];
			UpdateStepNumber();
		}
	}

	//Changes the step instructions to the previous step.
	public void PreviousStep()
	{
		if (currentIndex < lines.Count - 1 && currentIndex > 0)
		{
			currentIndex--;
			stepInstructionUI.text = lines[currentIndex];
			UpdateStepNumber();
		}
	}

	//Updates the step instruction number displayed.
	private void UpdateStepNumber()
	{
		stepNumUI.text = "Step " + (currentIndex + 1) + "/" + lines.Count;
	}
}