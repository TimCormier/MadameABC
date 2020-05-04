using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavScript : MonoBehaviour
{


    private GameObject DOORMUSIC;
    private GameObject DOORCLASS;
    private GameObject DOORLIBRARY;
    private GameObject DOORYOGA;
    private GameObject DOORCRAFT;
    
    // Start is called before the first frame update
    void Start()
    {
        DOORMUSIC = GameObject.Find("DoorMusic");
        DOORCLASS = GameObject.Find("DoorClass");
        DOORLIBRARY = GameObject.Find("DoorLibrary");
        DOORYOGA = GameObject.Find("DoorYoga");
        DOORCRAFT = GameObject.Find("DoorCraft");


    }

    // Update is called once per frame
    void Update()
    {
        //following code is not mine
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouseclick");

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }

    }


}
