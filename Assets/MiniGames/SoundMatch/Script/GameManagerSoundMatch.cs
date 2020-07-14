using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerSoundMatch : MonoBehaviour
{
    private int seedSon;
    public string goodAnswer;
    public string answer;
    public int previousSeed = 8;
    public GameObject chat, chien, guitare, flute, piano, tigre;
    public GameObject puzzleChat, puzzleChien, puzzleGuitare, puzzleFlute, puzzlePiano, puzzleTigre;
    public GameObject bonneReponse;
    public GameObject mauvaiseReponse;
    public GameObject goNext;


    // Start is called before the first frame update
     void Start()
    {
        nouveauCalcul();
    }

    private void nouveauCalcul()
    {
        seedSon = Random.Range(1, 7);

        if (seedSon != previousSeed)
        {
            switch (seedSon)
            {
                case 1:
                    puzzleChat.SetActive(true);
                    goodAnswer = "chaton";
                    break;
                case 2:
                    puzzleChien.SetActive(true);
                    goodAnswer = "chien";
                    break;
                case 3:
                    puzzleGuitare.SetActive(true);
                    goodAnswer = "guitare";
                    break;
                case 4:
                    puzzleFlute.SetActive(true);
                    goodAnswer = "flute";
                    break;
                case 5:
                    puzzlePiano.SetActive(true);
                    goodAnswer = "piano";
                    break;
                case 6:
                    puzzleTigre.SetActive(true);
                    goodAnswer = "tigre";
                    break;
            }
        }
        else
        {
            nouveauCalcul();
        }
        Debug.Log("good answer is " + goodAnswer);
    }

    private void Update()
    {
        if (answer != goodAnswer)
        {
            goNext.SetActive(false);
        }
    }
    public void Verification()
    {
        if (answer == goodAnswer)
        {
            bonneReponse.SetActive(true);
            mauvaiseReponse.SetActive(false);
            goNext.SetActive(true);
        }
        else
        {
            mauvaiseReponse.SetActive(true);
            bonneReponse.SetActive(false);
            answer = "";
            goNext.SetActive(false);
        }
    }
    public void NextQuestion()
    {
        bonneReponse.SetActive(false);
        mauvaiseReponse.SetActive(false);
        puzzleChat.SetActive(false);
        puzzleChien.SetActive(false);
        puzzleGuitare.SetActive(false);
        puzzleFlute.SetActive(false);
        puzzlePiano.SetActive(false);
        puzzleTigre.SetActive(false);
        previousSeed = seedSon;
        nouveauCalcul();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
