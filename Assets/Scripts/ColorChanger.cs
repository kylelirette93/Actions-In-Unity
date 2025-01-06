using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Button changeColorButton;

    void Start()
    {
        // Add a listener to the button.
        changeColorButton.onClick.AddListener(ChangeColorEvent);
    }

    void ChangeColorEvent()
    {
        // Invoke the change color event with a null check.
        Actions.changeColorEvent?.Invoke();
    }
}
