using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextReader : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public TextAsset treatmentInstructions;
    public int currentIndex = 0;
    public List<string> lines = new List<string>();

    void Awake()
    {
        var arrayString = treatmentInstructions.text.Split('\n');
        foreach(var line in arrayString)
        {
            lines.Add(line);
        }
        textField.text = lines[currentIndex];
    }

    public void NextStep()
    {
        if(currentIndex < lines.Count-1)
        {
            currentIndex++;
            textField.text = lines[currentIndex];
        }
    }

    public void PreviousStep()
    {
        if (currentIndex < lines.Count-1 && currentIndex > 0)
        {
            currentIndex--;
            textField.text = lines[currentIndex];
        }
    }
}