using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    void Awake()
    {
        var arrayString = treatmentInstructions.text.Split('\n');
        foreach(var line in arrayString)
        {
            lines.Add(line);
        }
        stepInstructionUI.text = lines[currentIndex];
        stepNumUI.text = "Step " + (currentIndex + 1) + "/" + lines.Count;
    }

    public void NextStep()
    {
        if(currentIndex < lines.Count-1)
        {
            currentIndex++;
            stepInstructionUI.text = lines[currentIndex];
            UpdateStepNumber();
        }
    }

    public void PreviousStep()
    {
        if (currentIndex < lines.Count-1 && currentIndex > 0)
        {
            currentIndex--;
            stepInstructionUI.text = lines[currentIndex];
            UpdateStepNumber();
        }
    }

    public void UpdateStepNumber()
    {
        stepNumUI.text = "Step " + (currentIndex + 1) + "/" + lines.Count;
    }
}