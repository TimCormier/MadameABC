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
  //  private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.transform.GetComponent<Rigidbody>();
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
        Debug.Log("velocity is " + velocity);

        

        if (Input.GetKey("up")) {
            //do this
          //  moving = true;
            if(velocity < limit){
                velocity += acceleration;
            }
           

        }
        else if (Input.GetKey("down")){
            //do that
            // moving = true;
            if (velocity > (limit * -1f)) {
                velocity -= acceleration;
            }
           
        }


        rb.AddRelativeForce(Vector3.up * velocity);
    }
}
