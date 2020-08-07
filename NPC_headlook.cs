using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_headlook : MonoBehaviour
{
    public Transform viewTarget;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnAnimatorIK(int layerIndex)
    {
        if (viewTarget)
        {
            anim.SetLookAtPosition(viewTarget.position);

            anim.SetLookAtWeight(2.0f);
        }
    }
}
