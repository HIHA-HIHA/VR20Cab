using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider),typeof(Rigidbody))]
public class PlaceForBuild : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPlaceObject;

    [SerializeField]
    private int id;

    [SerializeField]
    private TypeObjectForBuild typeObjectForBuild;

    private string tagHand = "Hand";

    [SerializeField]
    private Transform mainParent;

    [SerializeField]
    private bool useDefaultRotation;


    [SerializeField]
    private Vector3 newRotation; 


    private void OnTriggerEnter(Collider other)
    {
        if (CheckOnHand(other.gameObject) && other.gameObject.TryGetComponent<ObjectForBuild>(out var objectForBuild) && objectForBuild.TypeObjectForBuild == typeObjectForBuild)
        {
            other.GetComponent<DestroyerComponents>().DestroyComponents();
            SetParent(other.transform);
            SetPosition(other.transform);
            SetRotation(other.transform);
            onPlaceObject?.Invoke();
            Destroy(gameObject);
        }

    }

    /// <summary>
    /// Проверяет есть ли объект в руке или нет.
    /// </summary>
    /// <param name="otherGameObject"></param>
    /// <returns>true - если объект в руке нет. false - если объект в руке</returns>
    private bool CheckOnHand(GameObject otherGameObject)
    {
        if(otherGameObject.transform.parent == null)
        {
            return true;
        }

        if (otherGameObject.transform.parent.CompareTag(tagHand))
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    /// <summary>
    /// Устанавливает позицию другому объекту
    /// </summary>
    /// <param name="otherTransform"></param>
    private void SetPosition(Transform  otherTransform)
    {
        otherTransform.position = transform.position;
    }

    private void SetRotation(Transform otherTransform)
    {
        if (useDefaultRotation)
        {
            otherTransform.localRotation = transform.localRotation;
        }
        else
        {
            otherTransform.localRotation = Quaternion.Euler(newRotation);
        }
    }

    private void SetParent(Transform otherTransform)
    {
        otherTransform.parent = mainParent;
    }
}
