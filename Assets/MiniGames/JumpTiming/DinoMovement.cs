using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{

    public float speed;
    public float jumpforce;
    private float moveinput;

    public Rigidbody2D rb;
    public BoxCollider2D floorAllow;

    public Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }

    private void OnCollisionStay2D(Collision2D collision2D)
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Work");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("JumpAnim", 0, 0.25f);
        }
    }
}
