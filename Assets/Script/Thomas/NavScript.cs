﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavScript : MonoBehaviour
{


    private GameObject DOORMUSIC;
    private GameObject DOORCLASS;
    private GameObject DOORLIBRARY;
    private GameObject DOORYOGA;
    private GameObject DOORCRAFT;
    private GameObject BACKBUTTON;

    private RawImage rawimg;
    public Texture defaultTexture;
    public Texture MusicRoom;
    public Texture ClassRoom;
    public Texture LibraryRoom;
    public Texture YogaRoom;
    public Texture CraftRoom;
    
    // Start is called before the first frame update
    void Start()
    {
        rawimg = gameObject.GetComponent<RawImage>();
        rawimg.texture = defaultTexture;
        DOORMUSIC = GameObject.Find("DoorMusic");
        DOORCLASS = GameObject.Find("DoorClass");
        DOORLIBRARY = GameObject.Find("DoorLibrary");
        DOORYOGA = GameObject.Find("DoorYoga");
        DOORCRAFT = GameObject.Find("DoorCraft");
        BACKBUTTON = GameObject.Find("BackButton");
        BACKBUTTON.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
       
        /*//following code is not mine
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
        }*/


    }

    private void HIDE() {
        DOORMUSIC.SetActive(false);
        DOORCLASS.SetActive(false);
        DOORLIBRARY.SetActive(false);
        DOORYOGA.SetActive(false);
        DOORCRAFT.SetActive(false);
        BACKBUTTON.SetActive(true);
    }

    private void SHOW()
    {
        DOORMUSIC.SetActive(true);
        DOORCLASS.SetActive(true);
        DOORLIBRARY.SetActive(true);
        DOORYOGA.SetActive(true);
        DOORCRAFT.SetActive(true);
        BACKBUTTON.SetActive(false);
    }


    public void MUSIC() {
        rawimg.texture = MusicRoom;
        HIDE();
   
    }
    public void CLASS()
    {
        rawimg.texture = ClassRoom;
        HIDE();

    }
    public void LIBRARY()
    {
        rawimg.texture = LibraryRoom;
        HIDE();

    }
    public void YOGA()
    {
        rawimg.texture = YogaRoom;
        HIDE();

    }
    public void CRAFT()
    {
        rawimg.texture = CraftRoom;
        HIDE();

    }

    public void MAIN()
    {
        rawimg.texture = defaultTexture;
        SHOW();

    }


}
