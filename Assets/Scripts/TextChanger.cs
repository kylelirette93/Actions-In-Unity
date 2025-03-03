using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    private TextMeshProUGUI colorSelectedText;

    private void Start()
    {
        colorSelectedText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        // Subscribe to the change color event.
        Actions.changeColorEvent += UpdateText;
    }

    private void OnDisable()
    {
        // Unsubscribe from the change color event.
        Actions.changeColorEvent -= UpdateText;
    }


    public void UpdateText()
    {
        // Update the text to display that the color has been changed.
        colorSelectedText.text = $"       Color selected!";
        Invoke("ResetText", 0.5f);
    }

    void ResetText()
    {
        colorSelectedText.text = "Click button to change color";
    }
}
