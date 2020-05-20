using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    /*
     NOTE: ABOUT THROWAWAY NOTEHOLDER
     There's a bug where the last noteholder in hierarchy's colliders dont work and i have no fucking clue why
     just keep it off-screen and everything works fine
     If you plan on increasing the amounts of NoteHolders on-screen, make sure you have one additionnal NoteHolder off-screen to prevent this bug
      */


    private AudioSource AUDIO;
    private Camera CAMERA;
    private GameObject NOTEHOLDER;
    private int NOTECOUNT;
    //private bool debugFreeze = false;
    //private int debugFreezeTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        AUDIO = gameObject.transform.GetComponent<AudioSource>();
        CAMERA = GameObject.Find("Main Camera").transform.GetComponent<Camera>();
        NOTEHOLDER = transform.parent.gameObject;
        NOTECOUNT = NOTEHOLDER.transform.childCount;

        if (transform.GetSiblingIndex() != 0) {
            gameObject.SetActive(false);
            gameObject.transform.GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (debugFreeze == true) {
            debugFreezeTimer++;
            if (debugFreezeTimer >= 16) {
                debugFreeze = false;
                debugFreezeTimer = 0;
            }
        }*/
        //DebugFreeze code here

        /*if (Input.GetMouseButton(0)) {
            debugFreeze = true;
        }*/
        if (Input.GetMouseButtonUp(0)) {
            // debugFreeze = false;
            transform.GetComponent<CapsuleCollider>().enabled = true;
            /*  for (int i = 0; i <= NOTECOUNT; i++)
              {
                  NOTEHOLDER.transform.GetChild(i).transform.GetComponent<CapsuleCollider>().enabled = true;
              }*/
        }



        if (Input.GetMouseButtonDown(0)) {
            /*for (int i = 0; i <= NOTECOUNT; i++)
            {
                NOTEHOLDER.transform.GetChild(i).transform.GetComponent<CapsuleCollider>().enabled = false;
            }*/
            transform.GetComponent<CapsuleCollider>().enabled = false;
            Ray ray = CAMERA.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Debug.Log(hit.transform.name);
                // ON CLICK CODE GOES HERE
                //NEXTNOTE();
               // if (debugFreezeTimer == 0) {
                   // debugFreeze = true;
                   // debugFreezeTimer++;
                hit.transform.GetComponent<NoteScript>().NEXTNOTE();
                Debug.Log("looks live youve clicked on " + hit.transform.name);
               // }
               
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

    public void NEXTNOTE() {
        // ON CLICK CODE GOES HERE
        //debugFreeze = true;
        int INDEX = transform.GetSiblingIndex();
        /*
        for (int i = 0; i <= INDEX; i++) {
            NOTEHOLDER.transform.GetChild(i).transform.GetComponent<CapsuleCollider>().enabled = false;
        }
        */

        if ((transform.GetSiblingIndex() + 1) < NOTECOUNT)
        {
            // debugFreeze = true;
            transform.GetComponent<CapsuleCollider>().enabled = false;
            gameObject.SetActive(false);
            NOTEHOLDER.transform.GetChild(INDEX + 1).gameObject.SetActive(true);
            NOTEHOLDER.transform.GetChild(INDEX + 1).GetComponent<NoteScript>().DING();
          //  NOTEHOLDER.transform.GetChild(INDEX + 1).transform.GetComponent<CapsuleCollider>().enabled = true;


        }
        else {
            // debugFreeze = true;
            transform.GetComponent<CapsuleCollider>().enabled = false;
            gameObject.SetActive(false);
            NOTEHOLDER.transform.GetChild(0).gameObject.SetActive(true);
            NOTEHOLDER.transform.GetChild(0).GetComponent<NoteScript>().DING();
           // NOTEHOLDER.transform.GetChild(0).transform.GetComponent<CapsuleCollider>().enabled = true;

        }

        for (int i = 0; i <= INDEX; i++)
        {
         //   NOTEHOLDER.transform.GetChild(i).transform.GetComponent<CapsuleCollider>().enabled = true;
        }



    }

    public void DING() {
        transform.GetComponent<CapsuleCollider>().enabled = false;
        AUDIO.Play();
    }

}
/*
 switch()



  */
