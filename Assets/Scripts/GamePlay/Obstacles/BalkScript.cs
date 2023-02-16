using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalkScript : MonoBehaviour
{
    private Animator animator;
    private System.Random random;

    void Start()
    {
        animator = GetComponent<Animator>();
        random = new System.Random();
    }

    private void ChangeAnimation()
    {
        animator.SetInteger("AnimationNumber", random.Next(1, 4));
    }
}
