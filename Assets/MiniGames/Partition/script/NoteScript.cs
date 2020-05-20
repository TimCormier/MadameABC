using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{

    private AudioSource AUDIO;
    private Camera CAMERA;
    private GameObject NOTEHOLDER;

    // Start is called before the first frame update
    void Start()
    {
        AUDIO = gameObject.transform.GetComponent<AudioSource>();
        CAMERA = GameObject.Find("Main Camera").transform.GetComponent<Camera>();
        NOTEHOLDER = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = CAMERA.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Debug.Log("looks live youve clicked on " + hit.transform.name);
            }
        }

        if (Input.GetKeyDown("space")) {
            // Debug.Log(transform.parent.transform.childCount);
            //Debug.Log(transform.GetSiblingIndex());
        }
        

    }

    void OnTriggerEnter(Collider other) {
        if (other.transform.name == "Line") {
            Debug.Log(gameObject.name);
            AUDIO.Play();
        }
    }
}
/*
 switch()



  */
