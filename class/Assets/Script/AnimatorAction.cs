using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorAction : MonoBehaviour
{
    public Animator animator;
   public void Kick()
    {
        animator.Play("Kick");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
