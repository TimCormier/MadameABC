using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickableScript : MonoBehaviour
{
    private Button btn;
    private string name;
    private GameObject MANAGER;

    // Start is called before the first frame update
    void Start()
    {
        btn = gameObject.transform.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        name = gameObject.transform.name;
        MANAGER = GameObject.Find("background and GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        



    }

    void OnMouseDown() {
        Debug.Log("You Clicked" + gameObject.transform.name);//
    }

    void OnClick() {
        Debug.Log("You have clicked " + gameObject.transform.name);

        /*
         about switch
            switch(variable to compare for case){
            case //variable value goes here//:
                code instrucitons;
                break;

            default: //this is for when the variable doesnt apply to any case
                code instructions;
                break;
    
        } 

          */

        switch (name) {
            case "DoorMusic":
                Debug.Log("Going to music room");
                MANAGER.GetComponent<NavScript>().MUSIC();
                break;

            case "BackButton":
                Debug.Log("clicked on backbutton");
                MANAGER.GetComponent<NavScript>().MAIN();
                break;

            case "DoorClass":
                MANAGER.GetComponent<NavScript>().CLASS();
                break;

            case "DoorLibrary":
                MANAGER.GetComponent<NavScript>().LIBRARY();
                break;

            case "DoorYoga":
                MANAGER.GetComponent<NavScript>().YOGA();
                break;

            case "DoorCraft":
                MANAGER.GetComponent<NavScript>().CRAFT();
                break;

            default:
                Debug.Log("idk what that is chief");
                break;
        }
    }
    
}
