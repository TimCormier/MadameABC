using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingScript : MonoBehaviour
{
    private GameObject MANAGER;
    
    // Start is called before the first frame update
    void Start()
    {
        MANAGER = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other) {
        switch (other.transform.name) {
            case "KingTriggerRed":
                MANAGER.GetComponent<CastleScript>().WINBLUE();
                break;

            case "KingTriggerBlue":
                MANAGER.GetComponent<CastleScript>().WINRED();
                break;

            default:
                Debug.Log("you niggas done gone and broke my viddy game");
                break;
        }
    }
}


