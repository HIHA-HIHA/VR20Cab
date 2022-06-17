using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerElement : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabElement;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private Transform parent;

    public void Spawn()
    {
        GameObject spawnedObject = Instantiate(prefabElement);
        spawnedObject.transform.parent = parent;
        spawnedObject.transform.position = spawnPoint.transform.position;
        
    }
}
