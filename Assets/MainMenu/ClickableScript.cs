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
        classe.SetActive(false);
        musique.SetActive(false);
        librairie.SetActive(false);
        yoga.SetActive(false);
        craft.SetActive(false);
        switch (name) {
            case "DoorMusic":
                MANAGER.GetComponent<NavScript>().MUSIC();
                Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
                break;

            case "BackButton":
                MANAGER.GetComponent<NavScript>().MAIN();
                break;

            case "DoorClass":
                MANAGER.GetComponent<NavScript>().CLASS();
                Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
                break;

            case "DoorLibrary":
                MANAGER.GetComponent<NavScript>().LIBRARY();
                Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
                break;

            case "DoorYoga":
                MANAGER.GetComponent<NavScript>().YOGA();
                Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
                break;

            case "DoorCraft":
                MANAGER.GetComponent<NavScript>().CRAFT();
                Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
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
                classe.SetActive(false);
                musique.SetActive(false);
                librairie.SetActive(false);
                yoga.SetActive(false);
                craft.SetActive(false);
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
