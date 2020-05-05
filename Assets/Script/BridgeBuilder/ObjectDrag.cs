using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{

    private Camera Camera;
    // Start is called before the first frame update
    private Vector3 screenPoint;
    private Vector3 offset;
    private float dragspeed;
    public bool ACTIVE;
    private Vector3 OGpos;
    private Quaternion OGrot;

    void OnMouseDown()
    {
        screenPoint = Camera.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    void Start()
    {
        Camera = GameObject.Find("Camera").transform.GetComponent<Camera>();
        dragspeed = 0.1f;
        ACTIVE = false;
        OGpos = transform.position;
        OGrot = transform.rotation;
    }

    // Update is called once per frame
    public void RESET() {
        gameObject.SetActive(true);
        ACTIVE = false;
        gameObject.transform.position = OGpos;
        gameObject.transform.rotation = OGrot;
    }

    public void GO() {
        if (transform.position == OGpos)
        {
       gameObject.SetActive(false);
        }
        else {
            
        ACTIVE = true;
        gameObject.transform.GetComponent<Rigidbody2D>().WakeUp();

        }
        
    }

    void Update()
    {
        //Debug.Log(Input.mousePosition.x + " " + Input.mousePosition.y);
        if (ACTIVE == false) {
            gameObject.transform.GetComponent<Rigidbody2D>().Sleep();
        }
    }

   void OnMouseDrag() {
        /*
        Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.ScreenToWorldPoint(cursorScreenPoint) + offset;
        transform.position = cursorPosition;
        */
        /*
        Vector3 pz = Camera.ScreenPointToRay(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;
        */

        /*
        float rayLength = 80;
        layerMask layermask;
        RaycastHut hit;
        rayLength ray = Camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, rayLength)) {

        }
        */



        /*
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        Vector3 objPosition = Camera.ScreenToWorldPoint(mousePosition);
        objPosition = new Vector3(objPosition.x - 80f, objPosition.y - 80f, 0f);
        transform.position = objPosition;
        */

        transform.position += new Vector3(Input.GetAxis("Horizontal") * dragspeed, Input.GetAxis("Vertical") * dragspeed, 0);
        
    } 
}
