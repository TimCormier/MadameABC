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

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }
}
