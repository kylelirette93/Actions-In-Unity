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
        Actions.changeColorEvent += UpdateText;
    }

    private void OnDisable()
    {
        Actions.changeColorEvent -= UpdateText;
    }


    public void UpdateText()
    {
        colorSelectedText.text = $"Color has been changed!";
    }
}
