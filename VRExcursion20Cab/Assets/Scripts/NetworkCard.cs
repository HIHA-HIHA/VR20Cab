using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkCard : MonoBehaviour
{
    [SerializeField]
    private OS os;

    [SerializeField]
    private string ip;

    [SerializeField]
    private Router router;

    public string Ip { get => ip; }
    public Router Router { get => router; }
    public OS Os { get => os; }
}
