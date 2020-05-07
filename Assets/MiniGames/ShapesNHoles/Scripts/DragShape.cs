using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragShape : MonoBehaviour
{
    public float dragspeed;
    private Camera Camera;
    private Vector3 OGpos;
    private Quaternion OGrot;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main Camera").transform.GetComponent<Camera>();
        OGpos = gameObject.transform.position;
        OGrot = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= 10.5f || transform.position.x <= -10.5f || transform.position.y >= 10.5f || transform.position.y <= -10.5f) {
            RETURN();
        }


    }

    void OnMouseDrag() {

        transform.position += new Vector3(Input.GetAxis("Horizontal") * dragspeed, Input.GetAxis("Vertical") * dragspeed, 0);

        /*
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        Vector3 objPosition = Camera.ScreenToWorldPoint(mousePosition);
        objPosition = new Vector3(objPosition.x - 80f, objPosition.y - 80f, 0f);
        transform.position = objPosition;
        */

    }

    public void RETURN() {
        gameObject.SetActive(true);
        gameObject.transform.position = OGpos;
        gameObject.transform.rotation = OGrot;

    }

    void OnTriggerStay2D(Collider2D col) {
        Debug.Log(col.transform.name);

        if (Input.GetMouseButton(0))
        {
            Debug.Log("You need to release the mouse fun man");
        }
        else {
        if (col.transform.name == "SLOT") {
            Debug.Log("Slot found");
            switch (gameObject.transform.name) {
                case "Circle":
                    col.transform.GetComponent<ShapesNScript>().ENTERCIRCLE();
                    break;

                case "Triangle":
                    col.transform.GetComponent<ShapesNScript>().ENTERTRIANGLE();
                    break;

                case "Square":
                    col.transform.GetComponent<ShapesNScript>().ENTERSQUARE();
                    break;

                default:
                    Debug.Log("Error!");
                    break;
                


            }
        }
        }

       
    }
}
