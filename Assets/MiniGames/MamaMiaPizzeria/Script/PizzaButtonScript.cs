using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PizzaButtonScript : MonoBehaviour
{
    private GameObject TRUCK;
    private Image IMG;


    public Sprite UP;
    public Sprite DOWN;

    // Start is called before the first frame update
    void Start()
    {
       TRUCK = GameObject.Find("PizzaTruck");
        IMG = gameObject.transform.GetComponent<Image>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag() {
        //Debug.Log("Clicking on " + gameObject.transform.name);

        switch (gameObject.transform.name) {
            case "Gas":
                TRUCK.GetComponent<NewPizzaTruckScript>().GASDOWN();
                
                break;

            case "TurnLeft":
                TRUCK.GetComponent<NewPizzaTruckScript>().LEFTDOWN();
                break;

            case "TurnRight":
                TRUCK.GetComponent<NewPizzaTruckScript>().RIGHTDOWN();
                break;

            default:
                Debug.Log("This button is not named correctly");
                break;


        }
        IMG.sprite = DOWN;

    }

    void OnMouseUp() {
       // Debug.Log("MouseUp on " + gameObject.transform.name);

        switch (gameObject.transform.name)
        {
            case "Gas":
                TRUCK.GetComponent<NewPizzaTruckScript>().GASUP();
                break;

            case "TurnLeft":
                TRUCK.GetComponent<NewPizzaTruckScript>().LEFTUP();
                break;

            case "TurnRight":
                TRUCK.GetComponent<NewPizzaTruckScript>().RIGHTUP();
                break;

            default:
                Debug.Log("This button is not named correctly");
                break;


        }
        IMG.sprite = UP;

    }
}
