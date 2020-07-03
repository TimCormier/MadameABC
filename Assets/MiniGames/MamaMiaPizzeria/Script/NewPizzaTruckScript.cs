using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPizzaTruckScript : MonoBehaviour
{
    public float acceleration;
    public float speedlimit;
    public float decceleration;
    public float turnrate;
    private CharacterController controller;

    private float stopTimer;


    private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = 0f;
        velocity = 0;
        controller = gameObject.transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //Input
        if (Input.GetKey("up")) {
            velocity += acceleration;
            stopTimer = 0;
        }

        if (Input.GetKey("down")) {
            velocity -= acceleration;
            stopTimer = 0;
        }

        if (Input.GetKey("left")) {
            gameObject.transform.Rotate(0f, 0f, turnrate * -1f);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Rotate(0f, 0f, turnrate);
        }
        //Decceleration and limitations
        if (velocity > speedlimit) {
            velocity = speedlimit;
        }
        if (velocity < speedlimit * -1f) {
            velocity = speedlimit * -1f;
        }


        if (velocity > 0)
        {
            velocity -= decceleration;
        }
        else if (velocity < 0)
        {
            velocity += decceleration;
        }
       

        if (stopTimer >= 2f) {
            Debug.Log("car is stopped");
            velocity = 0;
        }

        //output
        Debug.Log(velocity);
        controller.Move(transform.up * velocity);
        stopTimer += Time.deltaTime;
    }
}
