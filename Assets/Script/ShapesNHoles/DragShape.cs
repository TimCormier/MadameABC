using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragShape : MonoBehaviour
{
    public float dragspeed;
    private Camera Camera;
    private Vector3 OGpos;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main Camera").transform.GetComponent<Camera>();
        OGpos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
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

    }
}
