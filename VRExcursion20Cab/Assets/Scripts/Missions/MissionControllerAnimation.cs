using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControllerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void ShowMission()
    {
        animator.SetTrigger("Show Mission");
    }

    public void StartMission()
    {
        animator.SetTrigger("Start Mission");
    }
}
