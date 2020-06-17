using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{

    private GameObject MANAGER;

   // public GameObject HAMMERUP;
    //public GameObject HAMMERDOWN;

    private GameObject HAMMERUP;
    private GameObject HAMMERDOWN;

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        MANAGER = GameObject.Find("GameManager");
        HAMMERUP = gameObject.transform.parent.GetChild(1).gameObject;
        HAMMERDOWN = gameObject.transform.parent.GetChild(2).gameObject;
        pos = gameObject.transform.position;
        HAMMERUP.SetActive(false);
        HAMMERDOWN.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            HAMMERUP.SetActive(false);
        }
    }


    void OnMouseOver() {
       // Debug.Log("MouseOver on " + transform.name);
        HAMMERUP.SetActive(true);
       // Instantiate(HAMMERUP, transform.position, Quaternion.identity);
    }

    void OnMouseExit() {
        HAMMERUP.SetActive(false);
    }

    void OnMouseDown()
    {
        //This is what happens on click
        
        HAMMERUP.SetActive(false);
        HAMMERDOWN.SetActive(true);
        MANAGER.transform.GetComponent<WhackAScript>().BONK();


    }

    void OnMouseUp() {

        MANAGER.transform.GetComponent<WhackAScript>().SCORE();
        HAMMERDOWN.SetActive(false);
        gameObject.SetActive(false);
    }
}
