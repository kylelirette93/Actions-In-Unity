using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI colorSelectedText;
    public Player player;


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
        colorSelectedText.text = $"Color has been changed!";
    }
}
