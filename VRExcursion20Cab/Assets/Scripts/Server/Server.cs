using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
    [SerializeField]
    private string ip;

    [SerializeField]
    private bool isInstalled;

    public string Ip { get => ip; }
    public bool IsInstalled { get => isInstalled; }
}
