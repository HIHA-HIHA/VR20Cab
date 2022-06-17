using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Router : MonoBehaviour
{
    public List<NetworkCard> networkCards; 

    public NetworkCard GetNetworkCard(string ip)
    {
        foreach (var networkCard in networkCards)
        {
            if(networkCard.Ip == ip && networkCard.Os.OSInstalled)
            {
                return networkCard;
            }
        }
        return null;
    }
}
