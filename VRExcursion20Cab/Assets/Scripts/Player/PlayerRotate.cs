using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField]
    private Transform playerCamera;

    [SerializeField]
    private Transform player;

    private void Update()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mouseY = Mathf.Clamp(mouseY, -90, 90);
        playerCamera.rotation *= Quaternion.Euler(-mouseY, 0, 0);
        player.rotation *= Quaternion.Euler(player.rotation.x, mouseX, player.rotation.z);
    }
}
