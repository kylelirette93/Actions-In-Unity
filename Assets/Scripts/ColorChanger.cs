using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Button changeColorButton;

    void Start()
    {
        changeColorButton.onClick.AddListener(ChangeColorEvent);
    }

    void ChangeColorEvent()
    {
        Actions.changeColorEvent?.Invoke();
    }
}
