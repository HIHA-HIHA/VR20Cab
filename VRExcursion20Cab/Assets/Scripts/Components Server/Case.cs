using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    [SerializeField]
    private int maxCountComponents;

    [SerializeField]
    private int nowCountComponents;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private GameObject cap;

    [SerializeField]
    private GameObject emptyServer;



    public void AddComponent()
    {
        nowCountComponents++;
        if(nowCountComponents >= maxCountComponents)
        {
            cap.SetActive(true);
            emptyServer.SetActive(true);
            animator.SetTrigger("End");
        }
    }

    public void SetInServer()
    {
        if(nowCountComponents >= maxCountComponents)
        {
            animator.SetTrigger("Set Server");
        }
    }
}
