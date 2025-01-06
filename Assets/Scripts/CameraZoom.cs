using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    private void OnEnable()
    {
        MoveBackFromPlayer();
        Actions.changeColorEvent += MoveTowardsPlayer;
    }

    private void OnDisable()
    {
        Actions.changeColorEvent -= MoveTowardsPlayer;
    }

    // Update is called once per frame
    void MoveTowardsPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(5f, 0, 0), Time.deltaTime);
    }

    void MoveBackFromPlayer()
    {
        transform.position -= new Vector3(-5f, 0, 0);
    }
}
