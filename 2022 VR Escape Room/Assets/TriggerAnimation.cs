using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TriggerAnimation : XRSimpleInteractable
{
    public string openAnimation;
    public string closingAnimation;
    private Animator animator;
    private bool enable = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        enable = !enable;
        if(enable == true)
        {
            animator.Play(openAnimation);
        }
        else
        {
            animator.Play(closingAnimation);
        }
    }

}
