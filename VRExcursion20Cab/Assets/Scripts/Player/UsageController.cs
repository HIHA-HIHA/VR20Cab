using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using UnityEngine;
using UnityEngine.UI;

public class UsageController : MonoBehaviour
{
    [SerializeField]
    private Transform playerCamera;

    [SerializeField]
    private Image crosshire;

    [SerializeField]
    private Color defaultColor;

    [SerializeField]
    private Color colorWhenUsing;

    [SerializeField]
    private float distanseRay;

    private void Update()
    {
        TryUse();
    }

    private void TryUse()
    {
        Ray ray = new Ray(playerCamera.position, playerCamera.forward);
        if(Physics.Raycast(ray, out var hit, distanseRay) && hit.collider.TryGetComponent(out InteractableObject interactableObject))
        {
            crosshire.color = colorWhenUsing;
            Debug.DrawRay(ray.origin, ray.direction);

            if (Input.GetMouseButtonDown(0))
            {
                interactableObject.Use();
            }
        }
        else
        {
            crosshire.color = defaultColor;
        }
    }
}
