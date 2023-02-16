using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private Animator animator;
    private System.Random random;

    void Start()
    {
        animator = GetComponent<Animator>();
        random = new System.Random();
    }

    private void Change()
    {
        animator.SetInteger("Change", random.Next(10, 15));
    }

}
