using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    private void OnEnable()
    {
        // Subscribes to the change color event.
        Actions.changeColorEvent += ChangeMaterialColor;
    }

    private void OnDisable()
    {
        // Unsubscribes from the change color event.
        Actions.changeColorEvent -= ChangeMaterialColor;
    }

    void ChangeMaterialColor()
    {
        // Change the material color of the renderer to a random color.
        _renderer.material.color = Random.ColorHSV();
    }
}
