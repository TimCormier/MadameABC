using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour
{
    public Camera MAINCAM;
    public float turnrate;

    private float inertiaR = 0;
    private float inertiaL = 0;
    private float inertiaU = 0;
    private float inertiaD = 0;



    private Collider COL;
    private bool Clicking;
   // private Button BTN;

    // Start is called before the first frame update
    void Start()
    {
        COL = gameObject.transform.GetComponent<Collider>();
        //BTN = gameObject.transform.GetComponent<Button>();
        //BTN.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {



        // RIGHT
        if (Clicking == false) {
            //inertiaR -= turnrate*2f;
        }
        inertiaR -= turnrate / 2f;
        if (inertiaR >= turnrate * 10)
        {
            inertiaR = turnrate * 10;
        }
        //inertiaR -= turnrate / 2f;

        if (inertiaR < 0)
        {
            inertiaR = 0;
        }
        
        //float tempR = MAINCAM.transform.rotation.y + inertiaR;
        MAINCAM.transform.Rotate(0, inertiaR, 0);
        
        

        // LEFT
       // inertiaL -= (turnrate / 2f);
        if (inertiaL < 0)
        {
            inertiaL = 0;
        }
        float tempL = MAINCAM.transform.rotation.y + (inertiaL * -1);
        MAINCAM.transform.Rotate(0, tempL, 0);


        //DEBUGLOGS
        /*
        Debug.Log("inertiaR is at " + inertiaR);
        Debug.Log("inertiaL is at" + inertiaL);
        Debug.Log("inertiaU is at" + inertiaU);
        Debug.Log("inertiaD is at" + inertiaD);
        */
        /*
        if (Input.GetKey("s")) {
            OnMouseDrag();
        }
        if (Input.GetKeyUp("s"))
        {
            OnMouseUp();
        }*/
    }


    void OnMouseDrag() {
        //  inertia += turnrate;
        Clicking = true;

        switch (gameObject.transform.name)
        {
            case "lookRight":
                //Vector3 temp = MAINCAM.transform.rotation.eulerAngles + new Vector3(inertia, 0, 0);
                //float temp = MAINCAM.transform.rotation.x + inertia;
                //MAINCAM.transform.Rotate(Quaternion.Euler(temp));
                // MAINCAM.transform.Rotate(temp, MAINCAM.transform.rotation.y, MAINCAM.transform.rotation.z);
                // MAINCAM.transform.Rotate(temp, 0, 0);
                Debug.Log("Clicking R");
                inertiaR += turnrate;
                
                break;

            case "lookLeft":

                inertiaL += turnrate;
                break;

            default:
                Debug.Log("Something is wrong with button");
                break;


        }
    }

    void OnMouseUp() {
        Clicking = false;
    }


    


    /*
    void Click()
    {
        if (Input.GetMouseButton(0)) {

        }
        inertia += 1f;
        switch (gameObject.transform.name)
        {
            case "lookRight":
                //Vector3 temp = MAINCAM.transform.rotation.eulerAngles + new Vector3(inertia, 0, 0);
                float temp = MAINCAM.transform.rotation.x + inertia;
                //MAINCAM.transform.Rotate(Quaternion.Euler(temp));
                // MAINCAM.transform.Rotate(temp, MAINCAM.transform.rotation.y, MAINCAM.transform.rotation.z);
                MAINCAM.transform.Rotate(temp, 0, 0);
                break;

            default:
                Debug.Log("Something is wrong with button");
                break;


        }
    }
    */
}
