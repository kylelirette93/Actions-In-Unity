using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private float zoomInFOV = 30f;
    private float zoomOutFOV = 60f;
    private float zoomDuration = 0.5f;

    private Camera mainCamera;
    private float originalFOV;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
        // Store the original field of view in variable.
        originalFOV = mainCamera.fieldOfView;
    }

    private void OnEnable()
    {
        // Subscribe to the change color event.
        Actions.changeColorEvent += TriggerZoom;
    }

    private void OnDisable()
    {
        // Unsubscribe from the change color event.
        Actions.changeColorEvent -= TriggerZoom;
    }

    private void TriggerZoom()
    {
        // Starts the zoom coroutine.
        StartCoroutine(Zoom());
    }

    private IEnumerator Zoom()
    {
        float elapsedTime = 0f;
        // Zoom in while the elapsed time is less than the zoom duration.
        while (elapsedTime < zoomDuration)
        {
            // Smoothly zooms in and out.
            mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, zoomInFOV, elapsedTime / zoomDuration);
            elapsedTime += Time.deltaTime;
            // Wait for the next frame.
            yield return null;
        }
        // Reset the field of view to original value.
        mainCamera.fieldOfView = originalFOV;
    }
}
