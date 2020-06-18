﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleScript : MonoBehaviour
{

    public Camera MAINCAM;
    public GameObject CANNONBALL;
    private GameObject MANAGER;

    private GameObject KingSquareRed;
    private GameObject KingSquareBlue;

    float cannonforce = 0;
    float cannoninput = 0;
    public float strength;
    private GameObject POWERBAR;

    // Start is called before the first frame update
    void Start()
    {

        //MAINCAM = GameObject.Find("MainCamera");
        MANAGER = GameObject.Find("GameManager");
        KingSquareBlue = GameObject.Find("KingSquareBlue");
        POWERBAR = GameObject.Find("PowerBar");
        //this TURNBLUE() is for testing purposes;
        TURNBLUE();

    }

    // Update is called once per frame
    void Update()
    {
        //test key
        if (Input.GetKey("space")) {
            //TURNBLUE();
            // =======> THIS IS IMPORTANT Debug.Log(MAINCAM.transform.eulerAngles.y);
            // EulerAngles dont really work with negatives, a -10 value is like 360 - 10, which results in a eulerAngle value of 350f
            // Debug.Log(20f * -1f);
            if (MAINCAM.transform.eulerAngles.y > 0)
            {
                Debug.Log("SUPERIOR");
            }
            else {
                Debug.Log("INFERIOR");
            }
        }
        //end test key

        //SHOOTING START

        if (GameObject.Find("Cannonball(Clone)") == null) {
            if (Input.GetKey("a"))
            {

                /*
                cannonforce += 1f;
                if (cannonforce > 100f) {
                    cannonforce = 100f;
                }

        */

                cannoninput += strength;
                cannonforce = Mathf.Sin(cannoninput);
               // Debug.Log("cannonforce is " + cannonforce);
                POWERBAR.transform.localScale = new Vector2(cannonforce, 1f);

            }
            if (Input.GetKeyUp("a"))
            {
                Vector3 temprot = MAINCAM.transform.rotation.eulerAngles + new Vector3(0, 15f, 0);
                Instantiate(CANNONBALL, MAINCAM.transform.position, Quaternion.Euler(temprot));

                GameObject temp = GameObject.Find("Cannonball(Clone)");
                Rigidbody temprb = temp.transform.GetComponent<Rigidbody>();
                // temp.transform.rotation.y += 15f;

                if (cannonforce < 0)
                {
                    temprb.AddForce(transform.forward * ((cannonforce * -1) * 10000f));
                }
                else
                {
                    temprb.AddForce(transform.forward * (cannonforce * 10000f));
                }

                cannonforce = 0f;
                cannoninput = 0f;
            }
        }

        //SHOOTING END

        //test
        /*if (Input.GetKey("space")) {
            MAINCAM.transform.Rotate(2f, 2f, 0);

        
       */
       /*
        if (MAINCAM.transform.rotation.y > 50) {
            Debug.Log("Camera out of bounds from RIGHT boundary");
            MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.rotation.x, 50, MAINCAM.transform.rotation.z);
        }*/
    }

void TURNBLUE() {
        //Called when it's blue player(Player2)'s turn
        MAINCAM.transform.position = KingSquareBlue.transform.position + new Vector3(0f, 20f, 0f);
        MAINCAM.transform.Rotate(0, 0, 0);
    }

    }


    

