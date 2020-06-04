using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickableScript : MonoBehaviour
{
    private Button btn;
    private string name;
    private GameObject MANAGER;

    public Texture2D cursor;
    public Texture2D cursorOnEnter;

    public GameObject musique;
    public GameObject classe;
    public GameObject librairie;
    public GameObject yoga;
    public GameObject craft;


    void Start()
    {
        btn = gameObject.transform.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        name = gameObject.transform.name;
        MANAGER = GameObject.Find("background and GameManager");
    }


    void OnMouseDown() {
        Debug.Log("You Clicked" + gameObject.transform.name);//
    }

    void OnClick() {
        Debug.Log("You have clicked " + gameObject.transform.name);

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

    private void OnMouseEnter()
    {
        switch (name)
        {
            case "DoorMusic":
                musique.SetActive(true);
                break;

            case "BackButton":

                break;

            case "DoorClass":
                classe.SetActive(true);

                break;

            case "DoorLibrary":
                librairie.SetActive(true);
                break;

            case "DoorYoga":
                yoga.SetActive(true);
                break;

            case "DoorCraft":
                craft.SetActive(true);
                break;

            default:
                Debug.Log("idk what that is chief");
                break;
        }

        Cursor.SetCursor(cursorOnEnter, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void OnMouseExit()
    {
        switch (name)
        {
            case "DoorMusic":
                musique.SetActive(false);
                break;

            case "BackButton":

                break;

            case "DoorClass":
                classe.SetActive(false);

                break;

            case "DoorLibrary":
                librairie.SetActive(false);
                break;

            case "DoorYoga":
                yoga.SetActive(false);
                break;

            case "DoorCraft":
                craft.SetActive(false);
                break;

            default:
                Debug.Log("idk what that is chief");
                break;
        }

        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }


}
