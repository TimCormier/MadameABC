using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempScript : MonoBehaviour
{
    private GameObject PLAYER;
    private Rigidbody rb;


    private bool jumping = false;
    private bool grounded;
    private float timer;

    public float jumpstrength;
    public float yThreshold;
    // for some reason position.y returns a really different value that doesnt match the inspector


    // Start is called before the first frame update
    void Start()
    {
        PLAYER = GameObject.Find("Player");
        rb = PLAYER.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("player y value is " + PLAYER.transform.position.y);
        if (PLAYER.transform.position.y <= yThreshold)
        {
            if (jumping == false) {
                grounded = true;
                Debug.Log("PLAYER is lower than treshold");
            }
           
        }
        else {
            grounded = false;
        }

        if (jumping == true) {
            timer += Time.deltaTime;
            if (timer >= 1f) {
                timer = 0;
                jumping = false;

            }
        }


        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("tempscript detects click");
            if (grounded == true)
            {
                //uhhh do the jump code here
                Debug.Log("grounded is TRUE, jumping");
                jumping = true;
                rb.AddForce(transform.up * jumpstrength);
            }
            else {
                Debug.Log("grounded is FALSE, you may not jump");
            }
        }

        
    }
}
