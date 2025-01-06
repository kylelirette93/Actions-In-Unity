using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    private void OnEnable()
    {
        Actions.changeColorEvent += ChangeMaterialColor;
    }

    private void OnDisable()
    {
        Actions.changeColorEvent -= ChangeMaterialColor;
    }

    void ChangeMaterialColor()
    {
        renderer.material.color = Random.ColorHSV();
    }
}
