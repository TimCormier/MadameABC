using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleScript : MonoBehaviour
{

    public Camera MAINCAM;
    public Camera PROFILECAM;


    public GameObject CANNONBALL;
    private GameObject MANAGER;

    private GameObject KingSquareRed;
    private GameObject KingSquareBlue;

    float cannonforce = 0;
    float cannoninput = 0;
    public float strength;
    private GameObject POWERBAR;

    private GameObject FireButton;
    private GameObject FireButtonVisual;
    public Sprite BtnUp;
    public Sprite BtnDown;

    private bool turn = true;
    // false for blue, true for red
    // this stores who's turn it was *last*, since blue always starts, this is set to true so blue doesnt play twice at the beginning


    // Start is called before the first frame update
    void Start()
    {

        //MAINCAM = GameObject.Find("MainCamera");
        MANAGER = GameObject.Find("GameManager");
        KingSquareBlue = GameObject.Find("KingSquareBlue");
        KingSquareRed = GameObject.Find("KingSquareRed");
        POWERBAR = GameObject.Find("PowerBar");
        FireButton = GameObject.Find("FireButton");
        FireButtonVisual = GameObject.Find("FireButton_visual");
        PROFILECAM.enabled = false;
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
        // Using the "a" key was mainly for developpment purposes, this should be disabled later

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
                    temprb.AddRelativeForce(transform.forward * ((cannonforce * -1) * 10000f));
                }
                else
                {
                    temprb.AddRelativeForce(transform.forward * (cannonforce * 10000f));
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

    //Fire Button Methods
    public void FIREBUTTONDOWN() {
        //Debug.Log("Fire Button Down");
        cannoninput += strength;
        cannonforce = Mathf.Sin(cannoninput);
        POWERBAR.transform.localScale = new Vector2(cannonforce, 1f);
    }
    public void FIREBUTTONUP() {
        // Debug.Log("Fire Button Up");
        CYCLECAM("PROFILECAM");
        Vector3 temprot = MAINCAM.transform.rotation.eulerAngles + new Vector3(-5f, 0, 0);
        // Instantiate(CANNONBALL, MAINCAM.transform.position, Quaternion.Euler(temprot));
        Instantiate(CANNONBALL, MAINCAM.transform.position, MAINCAM.transform.rotation);

        GameObject temp = GameObject.Find("Cannonball(Clone)");
        Rigidbody temprb = temp.transform.GetComponent<Rigidbody>();
        

        if (cannonforce < 0)
        {
            temprb.AddRelativeForce(transform.forward * ((cannonforce * -1) * 10000f));
        }
        else
        {
            temprb.AddRelativeForce(transform.forward * (cannonforce * 10000f));
        }

        cannonforce = 0f;
        cannoninput = 0f;
    }




    //Turn Methods
    public void CHANGETURNS() {
        if (turn == false)
        {
            TURNBLUE();
            turn = true;
        }
        else {
            TURNRED();
            turn = false;
        }
    }

 void TURNBLUE() {
        //Called when it's blue player(Player2)'s turn
        MAINCAM.transform.position = KingSquareBlue.transform.position + new Vector3(0f, 20f, 0f);
        // MAINCAM.transform.Rotate(0, 0, 0);
        MAINCAM.transform.eulerAngles = new Vector3(0, 0, 0);
        CYCLECAM("MAINCAM");
    }

   void TURNRED() {
        MAINCAM.transform.position = KingSquareRed.transform.position + new Vector3(0f, 20f, 0f);
        // MAINCAM.transform.Rotate(0, 0, 0);
        MAINCAM.transform.eulerAngles = new Vector3(0, 180f, 0);
        CYCLECAM("MAINCAM");
    }

    //Camera Methods
    public void CYCLECAM(string TargetCam) {
        for (int i = 0; i <= Camera.allCameras.Length; i++)
        {
            GameObject.Find("Camera Container").transform.GetChild(i).GetComponent<Camera>().enabled = false;

        }
        GameObject VCANVAS = GameObject.Find("Canvas (Visual)");
        GameObject CCANVAS = GameObject.Find("Canvas (Clickable)");
        for (int i = 1; i < VCANVAS.transform.childCount; i++) {
          //  Debug.Log(VCANVAS.transform.GetChild(i).name);
            VCANVAS.transform.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 1; i < CCANVAS.transform.childCount; i++)
        {
            CCANVAS.transform.GetChild(i).gameObject.SetActive(false);
        }


        switch (TargetCam) {
            case "MAINCAM":
                MAINCAM.enabled = true;
                for (int i = 1; i < VCANVAS.transform.childCount; i++)
                {
                    VCANVAS.transform.GetChild(i).gameObject.SetActive(true);
                }
                for (int i = 1; i < CCANVAS.transform.childCount; i++)
                {
                    CCANVAS.transform.GetChild(i).gameObject.SetActive(true);
                }
               
                break;

            case "PROFILECAM":
                PROFILECAM.enabled = true;
                break;


            default:
                Debug.Log("Could not find target camera, check your references");
                break;


        }


    }

    /*
    void ACTIVATEMAINCAM() {
        Camera.allCameras.enabled = false;
        MAINCAM.enabled = true;
    }

    void ACTIVATEPROFILECAM() {
        Camera.allCameras.enabled = false;
        PROFILECAM.enabled = true;
    }
    */
    }


    

