using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onUseObject;

    public void Use()
    {
        onUseObject?.Invoke();
    }
}
