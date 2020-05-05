using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBuilderScript : MonoBehaviour
{
    private GameObject BALL;
    private bool GO;
  //  private GameObject SLOT1;
  //  private GameObject SLOT2;
    private GameObject ENDTRIGGER;

    public GameObject CIRCLESLOT;
    public GameObject CIRCLEOBJECT;
    public GameObject TRIANGLESLOT;
    public GameObject TRIANGLEOBJECT;
    public GameObject SQUARESLOT;
    public GameObject SQUAREOBJECT;
    public GameObject GROUND;

    private float rand1;
    private float rand2;

    public Vector3 CIRCLESPAWN1;
    public Vector3 TRIANGLESPAWN1;
    public Vector3 SQUARESPAWN1;
    public Vector3 GROUNDSPAWN1;

    public Vector3 CIRCLESPAWN2;
    public Vector3 TRIANGLESPAWN2;
    public Vector3 SQUARESPAWN2;
    public Vector3 GROUNDSPAWN2;

    // Start is called before the first frame update
    void Start()
    {

        BALL = GameObject.Find("Ball");
        ENDTRIGGER = GameObject.Find("EndTrigger");
        //CIRCLESPAWN1 = new Vector3(-66.9f, 74.198f, 0);
        GENERATE();
        GO = false;



    }

    // Update is called once per frame
    void Update()
    {
        if (GO == false) {
            BALL.transform.GetComponent<Rigidbody2D>().Sleep();
        }

        if (Input.GetKeyDown("space")) {
            //this is the debug key

            // Instantiate(CIRCLESLOT, CIRCLESPAWN1, Quaternion.identity);
            //Instantiate(TRIANGLESLOT, TRIANGLESPAWN1, Quaternion.identity);
            //Instantiate(SQUARESLOT, SQUARESPAWN1, Quaternion.identity);
           // Instantiate(GROUND, GROUNDSPAWN1, Quaternion.identity);
        }

    }

    public void RESET()
    {
        GO = false;
        BALL.transform.position = new Vector3(-17f, 130.6f, 0);
    }

    public void GOMETHOD() {
        GO = true;
        BALL.transform.GetComponent<Rigidbody2D>().WakeUp();
    }

    void GENERATE() {

        /*
         1 = circleslot
         2 = squareslot
         3 = triangleslot
         4 = ground
         
         */

        rand1 = Mathf.Round(Random.Range(1f, 4f));
        Debug.Log("rand1 value is " + rand1);
        switch (rand1) {
            case 1f:
                Instantiate(CIRCLESLOT, CIRCLESPAWN1, Quaternion.identity);
                break;

            case 2f:
                Instantiate(TRIANGLESLOT, TRIANGLESPAWN1, Quaternion.identity);
                break;

            case 3f:
                Instantiate(SQUARESLOT, SQUARESPAWN1, Quaternion.identity);
                break;
            case 4f:
                Instantiate(GROUND, GROUNDSPAWN1, Quaternion.identity);
                break;
            
            default:
                Debug.Log("something fRIcked up in GENERATE() chief");
                break;
        }
        GENERATE2();

    }

    void GENERATE2() {
        //Debug.Log("Generate2 goes here");
        rand2 = Mathf.Round(Random.Range(1f, 4f));
        if (rand2 == rand1)
        {
            GENERATE2();
        }
        else {
            Debug.Log("rand2 value is " + rand2);
            switch (rand2)
            {
                case 1f:
                    Instantiate(CIRCLESLOT, CIRCLESPAWN2, Quaternion.identity);
                    break;

                case 2f:
                    Instantiate(TRIANGLESLOT, TRIANGLESPAWN2, Quaternion.identity);
                    break;

                case 3f:
                    Instantiate(SQUARESLOT, SQUARESPAWN2, Quaternion.identity);
                    break;
                case 4f:
                    Instantiate(GROUND, GROUNDSPAWN2, Quaternion.identity);
                    break;

                default:
                    Debug.Log("something fRIcked up in GENERATE() chief");
                    break;
            }


        }

    }
}
