using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleScript : MonoBehaviour
{

    public Camera MAINCAM;
    public GameObject CANNONBALL;
    private GameObject MANAGER;

    private GameObject KingSquareRed;
    private GameObject KingSquareBlue;

    float cannonforce = 0;

    // Start is called before the first frame update
    void Start()
    {

        //MAINCAM = GameObject.Find("MainCamera");
        MANAGER = GameObject.Find("GameManager");
        KingSquareBlue = GameObject.Find("KingSquareBlue");
        

    }

    // Update is called once per frame
    void Update()
    {
        //test key
        if (Input.GetKey("space")) {
            TURNBLUE();
        }
        //end test key

        if (Input.GetKeyDown("a")) {
            cannonforce += 1f;
            if (cannonforce > 100f) {
                cannonforce = 100f;
            }
        }
        if (Input.GetKeyUp("a")) {
            Instantiate(CANNONBALL, MAINCAM.transform.position, MAINCAM.transform.rotation);
            GameObject temp = GameObject.Find("Cannonball(Clone)");
            Rigidbody temprb = temp.transform.GetComponent<Rigidbody>();
            temprb.AddForce(transform.forward * (cannonforce * 5000f));
            cannonforce = 0f;
        }


    }


    void TURNBLUE() {
        //Called when it's blue player(Player2)'s turn
        MAINCAM.transform.position = KingSquareBlue.transform.position + new Vector3(0f, 20f, 0f);
        MAINCAM.transform.Rotate(0, 0, 0);
    }
}
