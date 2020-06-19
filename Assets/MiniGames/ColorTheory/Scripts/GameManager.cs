using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float Jaune = 0f;
    public float Rouge = 0f;
    public float Bleu = 0f;
    public float Mauve = 0f;
    public float Orange = 0f;
    public float Vert = 0f;

    public float SpotJaune = 0f;
    public float SpotRouge = 0f;
    public float SpotBleu = 0f;
    public float SpotMauve = 0f;
    public float SpotOrange = 0f;
    public float SpotVert = 0f;

    public float RepMauve = 0f;
    public float RepOrange = 0f;
    public float RepVert = 0f;

    public float SpotOne = 0f;
    private float Rand = 0f;

    public Text scoreText;
    public float Score = 0f;

    public AudioClip Bravo;
    public AudioClip TryAgain;


    public GameObject CouleurJaune;
    public GameObject CouleurRouge;
    public GameObject CouleurBleu;
    public GameObject CouleurMauve;
    public GameObject CouleurOrange;
    public GameObject CouleurVert;
    public GameObject SpotTwoCouleurJaune;
    public GameObject SpotTwoCouleurRouge;
    public GameObject SpotTwoCouleurBleu;
    public GameObject SpotTwoCouleurMauve;
    public GameObject SpotTwoCouleurOrange;
    public GameObject SpotTwoCouleurVert;

    public GameObject MauveAnswer;
    public GameObject OrangeAnswer;
    public GameObject VertAnswer;

    public GameObject UiGame;
    public GameObject UiVictory;

    public float PreviousRand;

    public bool timerActive;
    public int timer;

    public bool timerActiveTryAgain;
    public int timerTryAgain;

    public void Start()
    {
        timer = 0;
        timerTryAgain = 0;
        timerActive = false;
        timerActiveTryAgain = false;
        Generate();
    }

    public void Update()
    {
        if(timerActive == true)
        {
            timer += 1;

            if(timer >= 60)
            {
                timerActive = false;
                timer = 0;
                Victory();
            }
        }

        if (timerActiveTryAgain == true)
        {
            timerTryAgain += 1;

            if (timerTryAgain >= 60)
            {
                timerActiveTryAgain = false;
                timerTryAgain = 0;
                Recommencer2();
            }
        }

        scoreText.text = "Score " + Score;

        if (Jaune > 1)
        {
            Jaune -= 1;
        }

        if (Rouge > 1)
        {
            Rouge -= 1;
        }

        if (Bleu > 1)
        {
            Bleu -= 1;
        }

        if (SpotJaune > 1)
        {
            SpotJaune -= 1;
        }

        if (SpotRouge > 1)
        {
            SpotRouge -= 1;
        }

        if (SpotBleu > 1)
        {
            SpotBleu -= 1;
        }

        if (Bleu == 1 && Jaune == 0 && Rouge == 0)
        {
            CouleurJaune.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurBleu.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 1 && Rouge == 0)
        {
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurJaune.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 0 && Rouge == 1)
        {
            CouleurBleu.SetActive(false);
            CouleurJaune.SetActive(false);
            CouleurRouge.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 0 && Rouge == 0)
        {
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurJaune.SetActive(false);
        }

        if (SpotBleu == 1 && SpotJaune == 0 && SpotRouge == 0)
        {
            SpotTwoCouleurJaune.SetActive(false);
            SpotTwoCouleurRouge.SetActive(false);
            SpotTwoCouleurBleu.SetActive(true);
        }

        if (SpotBleu == 0 && SpotJaune == 1 && SpotRouge == 0)
        {
            SpotTwoCouleurBleu.SetActive(false);
            SpotTwoCouleurRouge.SetActive(false);
            SpotTwoCouleurJaune.SetActive(true);
        }

        if (SpotBleu == 0 && SpotJaune == 0 && SpotRouge == 1)
        {
            SpotTwoCouleurJaune.SetActive(false);
            SpotTwoCouleurBleu.SetActive(false);
            SpotTwoCouleurRouge.SetActive(true);
        }

        if (SpotBleu == 0 && SpotJaune == 0 && SpotRouge == 0)
        {
            SpotTwoCouleurJaune.SetActive(false);
            SpotTwoCouleurBleu.SetActive(false);
            SpotTwoCouleurRouge.SetActive(false);
        }

        if (SpotBleu == 1 && SpotJaune == 1)
        {
            Recommencer();
        }

        if (SpotBleu == 1 && SpotRouge == 1)
        {
            Recommencer();
        }

        if (SpotRouge == 1 && SpotJaune == 1)
        {
            Recommencer();
        }

        if (SpotBleu == 1 && Bleu == 1)
        {
            Recommencer();
        }

        if (SpotRouge == 1 && Rouge == 1)
        {
            Recommencer();
        }

        if (Jaune == 1 && SpotJaune == 1)
        {
            Recommencer();
        }
        //
        if (RepMauve == 1 && Jaune == 1 && SpotRouge == 1)
        {
            Recommencer();
        }

        if (RepMauve == 1 && SpotJaune == 1 && Rouge == 1)
        {
            Recommencer();
        }

        if (RepMauve == 1 && SpotJaune == 1 && Bleu == 1)
        {
            Recommencer();
        }

        if (RepMauve == 1 && SpotBleu == 1 && Jaune == 1)
        {
            Recommencer();
        }
        //
        if (RepOrange == 1 && Bleu == 1 && SpotRouge == 1)
        {
            Recommencer();
        }

        if (RepOrange == 1 && SpotJaune == 1 && Bleu == 1)
        {
            Recommencer();
        }

        if (RepOrange == 1 && SpotBleu == 1 && Jaune == 1)
        {
            Recommencer();
        }

        if (RepOrange == 1 && SpotBleu == 1 && Rouge == 1)
        {
            Recommencer();
        }
        //
        if (RepVert == 1 && Bleu == 1 && SpotRouge == 1)
        {
            Recommencer();
        }

        if (RepVert == 1 && SpotJaune == 1 && Rouge == 1)
        {
            Recommencer();
        }

        if (RepVert == 1 && SpotRouge == 1 && Jaune == 1)
        {
            Recommencer();
        }

        if (RepVert == 1 && SpotBleu == 1 && Rouge == 1)
        {
            Recommencer();
        }
        //
        if (RepMauve == 1 && Bleu == 1 && SpotRouge == 1)
        {
            if(timerActive == false)
            {
                AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            }

            PreviousRand = Rand;
            timerActive = true;
        }

        if (RepOrange == 1 && Jaune == 1 && SpotRouge == 1)
        {
            if (timerActive == false)
            {
                AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            }
            PreviousRand = Rand;
            timerActive = true;
        }

        if (RepVert == 1 && Bleu == 1 && SpotJaune == 1)
        {
            if (timerActive == false)
            {
                AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            }
            PreviousRand = Rand;
            timerActive = true;
        }

        if (RepMauve == 1 && SpotBleu == 1 && Rouge == 1)
        {
            if (timerActive == false)
            {
                AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            }
            PreviousRand = Rand;
            timerActive = true;
        }

        if (RepOrange == 1 && SpotJaune == 1 && Rouge == 1)
        {
            if (timerActive == false)
            {
                AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            }
            PreviousRand = Rand;
            timerActive = true;
        }

        if (RepVert == 1 && SpotBleu == 1 && Jaune == 1)
        {
            if (timerActive == false)
            {
                AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            }
            PreviousRand = Rand;
            timerActive = true;
        }
    }

    public void AjoutJaune()
    {
        if (Jaune == 1 || Bleu == 1 || Rouge == 1)
        {
            SpotJaune += 1;
        }
        else
        {
            Jaune += 1;
        }

    }

    public void AjoutRouge()
    {
        if (Jaune == 1 || Bleu == 1 || Rouge == 1)
        {
            SpotRouge += 1;
        }
        else
        {
            Rouge += 1;
        }
    }

    public void AjoutBleu()
    {
        if (Jaune == 1 || Bleu == 1 || Rouge == 1)
        {
            SpotBleu += 1;
        }
        else
        {
            Bleu += 1;
        }
    }

    public void Recommencer()
    {
        if(timerActiveTryAgain == false)
        {
            AudioSource.PlayClipAtPoint(TryAgain, Camera.main.transform.position);
        }

        timerActiveTryAgain = true;

    }

    public void Recommencer2()
    {
        Jaune = 0;
        Rouge = 0;
        Bleu = 0;
        SpotJaune = 0;
        SpotRouge = 0;
        SpotBleu = 0;
    }

    public void ButtonRecommencer()
    {
        Jaune = 0;
        Rouge = 0;
        Bleu = 0;
        SpotJaune = 0;
        SpotRouge = 0;
        SpotBleu = 0;
    }

    public void Victory()
    {
        Jaune = 0;
        Rouge = 0;
        Bleu = 0;
        SpotJaune = 0;
        SpotRouge = 0;
        SpotBleu = 0;
        RepMauve = 0;
        RepOrange = 0;
        RepVert = 0;
        Score += 1;


        Generate();
    }

    public void Retry()
    {
        UiVictory.SetActive(false);
        UiGame.SetActive(true);
        Generate();
    }

    public void ScoreHandler()
    {
        scoreText.text = "Score" + Score;
    }

    public void Generate()
    {
        Rand = Mathf.Round(Random.Range(1f, 3f));

        if (Rand != PreviousRand)
        {
            switch (Rand)
            {
                case 1f:
                    RepMauve = 1;
                    OrangeAnswer.SetActive(false);
                    VertAnswer.SetActive(false);
                    MauveAnswer.SetActive(true);
                    break;

                case 2f:
                    RepOrange = 1;
                    MauveAnswer.SetActive(false);
                    VertAnswer.SetActive(false);
                    OrangeAnswer.SetActive(true);
                    break;

                case 3f:
                    RepVert = 1;
                    OrangeAnswer.SetActive(false);
                    MauveAnswer.SetActive(false);
                    VertAnswer.SetActive(true);
                    break;

                default:

                    break;

            }
        }
        else
        {
            Generate();
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}