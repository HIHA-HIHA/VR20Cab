using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerComponents : MonoBehaviour
{
    [SerializeField]
    private Component[] componentsForDestroyer;

    public void DestroyComponents()
    {
        foreach(var component in componentsForDestroyer)
        {
            Destroy(component);
        }
    }
}
