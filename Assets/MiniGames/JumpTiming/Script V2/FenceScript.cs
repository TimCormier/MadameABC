using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceScript : MonoBehaviour
{

    public float speed;
    private GameObject PLAYER;

    // Start is called before the first frame update
    void Start()
    {
        PLAYER = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position -= new Vector3(speed, 0f, 0f);

        if (gameObject.transform.position.x <= -150f) {
            PLAYER.GetComponent<SheepScript>().SPAWNFENCE();
            Destroy(gameObject);
        }
      //  Debug.Log("Fence " + gameObject.transform.name + " is at x " + gameObject.transform.position.x);
    }
}
