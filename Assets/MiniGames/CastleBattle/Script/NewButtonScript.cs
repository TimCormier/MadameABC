using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewButtonScript : MonoBehaviour
{

    public Camera MAINCAM;
    public float turnrate;
    public float boundaryH;
    public float boundaryV;

   // private GameObject REDTURNSWITCH;
   // private GameObject BLUETURNSWITCH;
    
    //private Vector3 limitH;
    // Start is called before the first frame update
    void Start()
    {
       // REDTURNSWITCH = GameObject.Find("RedTurnSwitch");
        //BLUETURNSWITCH = GameObject.Find("BlueTurnSwitch");


    }

    // Update is called once per frame
    void Update()
    {
        MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.eulerAngles.x, MAINCAM.transform.eulerAngles.y, 0f);
    }

    

    void OnMouseDrag() {
        Debug.Log("Clicked NewButton named " + gameObject.transform.name);
        switch (gameObject.transform.name) {
            case "lookRight":
                if (GameObject.Find("BlueTurnDetector") != null)
                {
                    if (MAINCAM.transform.eulerAngles.y >= boundaryH)
                    {
                        if (MAINCAM.transform.eulerAngles.y < 100f)
                        {
                            Debug.Log("Hit Boundary right");
                            MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.eulerAngles.x, boundaryH, MAINCAM.transform.eulerAngles.z);
                        }
                        else
                        {
                            MAINCAM.transform.Rotate(0, turnrate, 0);
                        }

                    }
                    else
                    {
                        // Debug.Log(MAINCAM.transform.rotation.y * 100f);
                        MAINCAM.transform.Rotate(0, turnrate, 0);
                        // Debug.Log(MAINCAM.transform.eulerAngles.y);
                    }
                }
                else {
                    if (MAINCAM.transform.eulerAngles.y <= 180f - boundaryH || MAINCAM.transform.eulerAngles.y >= 180f + boundaryH)
                    {
                        if (MAINCAM.transform.eulerAngles.y <= 180f - boundaryH)
                        {
                            MAINCAM.transform.Rotate(0, turnrate, 0);
                        }
                        else {
                            Debug.Log("Hit Boundary right");
                            MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.eulerAngles.x, 180f + boundaryH, MAINCAM.transform.eulerAngles.z);
                        }

                        
                        /*
                        if (MAINCAM.transform.eulerAngles.y < 100f)
                        {
                            
                        }
                        else
                        {
                           // MAINCAM.transform.Rotate(0, turnrate, 0);
                        }
                        */
                    }
                    else
                    {
                        // Debug.Log(MAINCAM.transform.rotation.y * 100f);
                        MAINCAM.transform.Rotate(0, turnrate, 0);
                        // Debug.Log(MAINCAM.transform.eulerAngles.y);
                    }
                }

                
                
                break;
            case "lookLeft":
                if (GameObject.Find("BlueTurnDetector") != null)
                {
                    if (MAINCAM.transform.eulerAngles.y <= 360 - boundaryH)
                    {
                        if (MAINCAM.transform.eulerAngles.y > 200f)
                        {
                            Debug.Log("Hit Boundary left");
                            MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.eulerAngles.x, 360f - boundaryH, MAINCAM.transform.eulerAngles.z);
                        }
                        else
                        {
                            MAINCAM.transform.Rotate(0, turnrate * -1, 0);
                        }

                    }
                    else
                    {
                        // Debug.Log(MAINCAM.transform.rotation.y * 100f);
                        // Debug.Log(MAINCAM.transform.eulerAngles.y);
                        MAINCAM.transform.Rotate(0, turnrate * -1, 0);
                    }
                }
                else {
                   
                        if (MAINCAM.transform.eulerAngles.y <= 180f - boundaryH || MAINCAM.transform.eulerAngles.y >= 180f + boundaryH)
                        {

                        if (MAINCAM.transform.eulerAngles.y >= 180f + boundaryH)
                        {
                            MAINCAM.transform.Rotate(0, turnrate * -1, 0);
                        }
                        else {
                            Debug.Log("Hit Boundary left");
                            MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.eulerAngles.x, 180f - boundaryH, MAINCAM.transform.eulerAngles.z);
                        }
                       
                        /*
                        if (MAINCAM.transform.eulerAngles.y > 200f)
                            {
                               
                            }
                            else
                            {
                                MAINCAM.transform.Rotate(0, turnrate * -1, 0);
                            }
                            */
                        }
                        else
                        {
                            // Debug.Log(MAINCAM.transform.rotation.y * 100f);
                            // Debug.Log(MAINCAM.transform.eulerAngles.y);
                            MAINCAM.transform.Rotate(0, turnrate * -1, 0);
                        }
                    
                }

               
                break;
            case "lookUp":
                if (MAINCAM.transform.eulerAngles.x <= 360 - boundaryV)
                {
                    if (MAINCAM.transform.eulerAngles.x > 200f)
                    {
                        Debug.Log("Hit Boundary Down");
                        MAINCAM.transform.eulerAngles = new Vector3(360f - boundaryV, MAINCAM.transform.eulerAngles.y, MAINCAM.transform.eulerAngles.z);
                    }
                    else
                    {
                        MAINCAM.transform.Rotate(turnrate * -1f, 0, 0);
                    }

                }
                else
                {
                    // Debug.Log(MAINCAM.transform.rotation.y * 100f);
                    // Debug.Log(MAINCAM.transform.eulerAngles.y);
                    MAINCAM.transform.Rotate(turnrate * -1f, 0, 0);
                }
                break;
            case "lookDown":
                if (MAINCAM.transform.eulerAngles.x >= boundaryV)
                {
                    if (MAINCAM.transform.eulerAngles.x < 100f)
                    {
                        Debug.Log("Hit Boundary Up");
                        MAINCAM.transform.eulerAngles = new Vector3(boundaryV, MAINCAM.transform.eulerAngles.y, MAINCAM.transform.eulerAngles.z);
                    }
                    else
                    {
                        MAINCAM.transform.Rotate(turnrate, 0, 0);
                    }

                }
                else
                {
                    // Debug.Log(MAINCAM.transform.rotation.y * 100f);
                    // Debug.Log(MAINCAM.transform.eulerAngles.y);
                    MAINCAM.transform.Rotate(turnrate, 0, 0);
                }
                break;

            default:
                Debug.Log("This button is busted");
                break;
        }

        void OnMouseOver() {
            Debug.Log("MouseOver " + gameObject.transform.name);
        }


       
    }
}
