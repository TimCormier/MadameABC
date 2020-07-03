using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaTruckScript : MonoBehaviour
{
    private Rigidbody rb;
    private float velocity = 0;
    public float acceleration;
    public float decceleration;
    public float limit;
    public float turnrate;

    private bool turning;
    private Vector3 pos;
  //  private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        turning = false;
        rb = gameObject.transform.GetComponent<Rigidbody>();
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (velocity != 0) {
            if (velocity > 0)
            {
                velocity -= decceleration;
            }
            else
            {
                velocity += decceleration;
            }
        }
      //  Debug.Log("velocity is " + velocity);

        

        if (Input.GetKey("up")) {
            //do this
            //  moving = true;
            /*  if(velocity < limit){
                  velocity += acceleration;
              }*/
            /* if (turning == true)
             {
                 rb.AddRelativeForce(Vector3.up * (acceleration / 3f), ForceMode.Acceleration);
             }
             else {
                 rb.AddRelativeForce(Vector3.up * acceleration);
             }*/
            rb.AddRelativeForce(Vector3.up * acceleration, ForceMode.Force);



        }
        else if (Input.GetKey("down")){
            //do that
            // moving = true;
            /* if (velocity > (limit * -1f)) {
                 velocity -= acceleration;
             }*/
            if (turning == true)
            {
                rb.AddRelativeForce(Vector3.down * (acceleration / 3f));
            }
            else
            {
                rb.AddRelativeForce(Vector3.down * acceleration);
            }
        }

        if (Input.GetKey("right")) {
            turning = true;
            gameObject.transform.Rotate(0f, 0f, turnrate);

        }

        if (Input.GetKey("left"))
        {
            turning = true;
            gameObject.transform.Rotate(0f, 0f, turnrate * -1f);

        }

        if (Input.GetKeyUp("left") || Input.GetKeyUp("right")) {
            turning = false;

        }

        /*
        if (turning == true) {
            if (gameObject.transform.position != pos) {
                rb.AddRelativeForce(Vector3.down * decceleration);
            }
           
        }*/



        pos = gameObject.transform.position;

       // rb.AddRelativeForce(Vector3.up * velocity);
    }
}
