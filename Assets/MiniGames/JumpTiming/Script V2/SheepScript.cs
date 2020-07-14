using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SheepScript : MonoBehaviour
{
    private GameObject PLAYER;
    private float velocity;
    public float gravity;
    public float JumpStrength;

    private bool jumping = false;
    private float jumpTimer = 0f;
    public float jumpTimerLimit;

    private bool grounded = false;

    private GameObject FenceSpawner;
    public GameObject Fence;
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        FenceSpawner = GameObject.Find("FenceSpawner");
        PLAYER = GameObject.Find("Player");
        velocity = 0f;

        SPAWNFENCE();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //Debug.Log("Click");
            if (grounded == true) {
                jumping = true;
                grounded = false;
                velocity += JumpStrength;
                
            }
           
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 8f)) {
            if (hit.transform.name == "Ground") {
               // Debug.Log("Raycast hit ground");
                if (jumping == false) {
                    velocity = 0;
                    grounded = true;
                }
                
            }
           
        }

        if (jumping == true) {
            jumpTimer += Time.deltaTime;
            if (jumpTimer >= jumpTimerLimit) {
                jumping = false;
            }
        }


        if (grounded == false) {
            velocity -= gravity;
            PLAYER.transform.position += new Vector3(0f, velocity, 0f);
        }
       // Debug.Log("velocity is " + velocity);
    }

    public void SPAWNFENCE() {
        Instantiate(Fence, FenceSpawner.transform.position, FenceSpawner.transform.rotation, canvas.transform);
    }

    void OnTriggerEnter(Collider col) {
        if (col.transform.tag == "FENCE") {
            Debug.Log("touched fence");
            string temp = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(temp);
        }
    }
}
