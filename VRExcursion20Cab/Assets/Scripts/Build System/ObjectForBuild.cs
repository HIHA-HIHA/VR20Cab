using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DestroyerComponents))]
[RequireComponent(typeof(BoxCollider))]
public class ObjectForBuild : MonoBehaviour
{
    [SerializeField]
    private TypeObjectForBuild typeObjectForBuild;

    public TypeObjectForBuild TypeObjectForBuild { get => typeObjectForBuild; set => typeObjectForBuild = value; }
}
