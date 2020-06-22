using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{

    private GameObject MANAGER;
    public GameObject[] CastleList;
    private int ListIndex;

    // Start is called before the first frame update
    void Start()
    {
        MANAGER = GameObject.Find("GameManager");
        ListIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseOver() {
        Debug.Log("MouseOver " + gameObject.transform.name);
    }

    void OnMouseDown() {
        Debug.Log("you clicked " + gameObject.transform.name);

        switch (gameObject.transform.name) {
            case "SelectionUp_Blue_c":
                Debug.Log(CastleList[1].transform.name);
                break;

            default:
                Debug.Log("Somethig is bugged with " + gameObject.transform.name);
                break;
        }
    }
}
