using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringboardScript : MonoBehaviour
{
    private Animator animator;
    private System.Random r;

    void Start()
    {
        animator = GetComponent<Animator>();
        r = new System.Random();
    }

    private void ChangeAnimation()
    {
        animator.SetInteger("Change", r.Next(4, 7));
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(Vector3.up * 7, ForceMode.Impulse);
    }
    private void OnCollisionStay(Collision collision)
    {
        collision.rigidbody.AddForce(Vector3.up * 7, ForceMode.Impulse);
    }
}
