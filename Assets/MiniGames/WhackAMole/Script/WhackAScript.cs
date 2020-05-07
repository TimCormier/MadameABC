using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhackAScript : MonoBehaviour
{
    private GameObject Mole1;
    private GameObject Mole2;
    private GameObject Mole3;
    private GameObject Mole4;
    private GameObject Mole5;
    private GameObject Mole6;

    private int score;
    private bool MOLEACTIVE;
    private int timer;

    private float randlast;

    private Text text;
    private GameObject TextObject;

    private AudioSource SOUND;


    // Start is called before the first frame update
    void Start()
    {
        randlast = 0;
        score = 0;
        Mole1 = GameObject.Find("Mole1");
        Mole2 = GameObject.Find("Mole2");
        Mole3 = GameObject.Find("Mole3");
        Mole4 = GameObject.Find("Mole4");
        Mole5 = GameObject.Find("Mole5");
        Mole6 = GameObject.Find("Mole6");


        for (int i = 1; i <= 6; i++) {
            GameObject.Find("Mole" + i.ToString()).SetActive(false);
        }

        TextObject = GameObject.Find("Score");
        text = TextObject.GetComponent<Text>();
        SOUND = gameObject.transform.GetComponent<AudioSource>();
        SPAWNMOLE();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")) {
            // SPAWNMOLE();
           // Debug.Log(GameObject.Find("MASSIVE Cookie"));
        }

        if (MOLEACTIVE == false)
        {
            timer += 1;
            if (timer >= 60)
            {

                SPAWNMOLE();

            }
        }
        else {
            timer += 1;
            if (timer >= 300) {
                GameObject.Find("Mole" + randlast.ToString()).SetActive(false);
                SPAWNMOLE();
                GameObject DelHammmer = GameObject.Find("HammerUp");
                if (DelHammmer != null) {
                    GameObject.Find("HammerUp").SetActive(false);
                }
            }
        }

        text.text = score.ToString();
    }

    void SPAWNMOLE() {

        MOLEACTIVE = true;
        timer = 0;

       float rand = Mathf.Round(Random.Range(1f, 6f));
        if (rand == randlast)
        {
            //reset or do SPAWNMOLE() again
            SPAWNMOLE();
        }
        else
        {
           // GameObject.Find("Mole" + rand.ToString()).SetActive(true);
            Debug.Log("Mole" + rand.ToString() + " active");
            randlast = rand;

            switch (rand) {
                case 1f:
                    Mole1.SetActive(true);
                break;
                case 2f:
                    Mole2.SetActive(true);
                break;
                case 3f:
                    Mole3.SetActive(true);
                break;
                case 4f:
                    Mole4.SetActive(true);
                break;
                case 5f:
                    Mole5.SetActive(true);
                break;
                case 6f:
                    Mole6.SetActive(true);
                break;

                default:
                    Debug.Log("Something bugged out");
                        break;

            }

        }

    }

    public void SCORE() {
        score++;

        Debug.Log("Score: " + score);
        MOLEACTIVE = false;
        timer = 0;
        

    }

    public void BONK() {
        SOUND.Play();
    }


    public void GoToMenu()
    {
        SceneManager.UnloadSceneAsync("WhackAMole");
    }
}
