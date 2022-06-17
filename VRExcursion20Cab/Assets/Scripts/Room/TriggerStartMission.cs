using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class TriggerStartMission : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onEnterInTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerMove>(out var playerMove))
        {
            onEnterInTrigger?.Invoke();
        }
    }
}
