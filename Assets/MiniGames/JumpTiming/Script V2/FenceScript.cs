using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceScript : MonoBehaviour
{

    private float speed;
    private bool freeze = false;
    // base speed value set previously is 0.25f
    private GameObject PLAYER;

    // Start is called before the first frame update
    void Start()
    {
        PLAYER = GameObject.Find("Player");
        speed = PLAYER.GetComponent<SheepScript>().difficulty;
    }

    // Update is called once per frame
    void Update()
    {
        if (!freeze) {
            gameObject.transform.position -= new Vector3(speed, 0f, 0f);
        }
        

        if (gameObject.transform.position.x <= -150f) {
            //The following if statement is used to call SPAWNFENCE() when the last object in the fence object is offscreen, said last object is detected by having a child named "LastItemChecker"
            //Addendum: the comment above is retarded lmao it causes errors, last obstacle in a fence prefab needs atleast one child
            if (gameObject.transform.childCount != 0)
            {
                PLAYER.GetComponent<SheepScript>().SPAWNFENCE();
            }
            PLAYER.GetComponent<SheepScript>().SCOREPOINT();
            Destroy(gameObject);
        }
      //  Debug.Log("Fence " + gameObject.transform.name + " is at x " + gameObject.transform.position.x);
    }

    public void FREEZE()
    {
        freeze = true;
    }
}
