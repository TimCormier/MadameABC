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

    public float difficulty;
    public float difficultyIncrease;

    private int score = 0;
    private Text ScoreText;

    public GameObject[] FenceList;
    private int FenceIndex = -1;

    private bool freeze = false;

    private GameObject ResetButton;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        FenceSpawner = GameObject.Find("FenceSpawner");
        PLAYER = GameObject.Find("Player");
        velocity = 0f;
        ScoreText = GameObject.Find("Score").GetComponent<Text>();
        ResetButton = GameObject.Find("ResetButton");
        ResetButton.GetComponent<Button>().onClick.AddListener(RESETCLICK);
        ResetButton.SetActive(false);

        SPAWNFENCE();
    }

    // Update is called once per frame
    void Update()
    {
        if (!freeze) {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Click");
                if (grounded == true)
                {
                    jumping = true;
                    grounded = false;
                    velocity += JumpStrength;

                }

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

        difficulty += difficultyIncrease;
        FenceIndex++;
        if (FenceIndex > FenceList.Length - 1) {
            FenceIndex = 0;
        }
        Instantiate(FenceList[FenceIndex], FenceSpawner.transform.position, FenceSpawner.transform.rotation, canvas.transform);
    }

    public void SCOREPOINT() {
        score++;
        ScoreText.text = score.ToString();
    }

    private void RESETCLICK() {
        string temp = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(temp);
    }

   

    void OnTriggerEnter(Collider col) {
        if (col.transform.tag == "FENCE") {
            Debug.Log("touched fence");
            freeze = true;
           // GameObject.FindGameObjectsWithTag("FENCE").transform.GetComponent<FenceScript>().FREEZE();
            GameObject[] tempfence = GameObject.FindGameObjectsWithTag("FENCE");
            for (int i = 0; i < tempfence.Length; i++) {
                tempfence[i].transform.GetComponent<FenceScript>().FREEZE();
            }
            ResetButton.SetActive(true);

           // string temp = SceneManager.GetActiveScene().name;
           // SceneManager.LoadScene(temp);
        }
    }
}
