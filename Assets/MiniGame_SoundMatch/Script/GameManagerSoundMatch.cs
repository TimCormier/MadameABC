using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSoundMatch : MonoBehaviour
{
    private int seedSon;
    public int goodAnswer;
    public int answer;
    public GameObject chat, chien, guitare;
    public GameObject bonneReponse;
    public GameObject mauvaiseReponse;
    public GameObject goNext;


    // Start is called before the first frame update
    void Start()
    {
        seedSon = Random.Range(1, 4);

        switch (seedSon)
        {
            case 1:
                goodAnswer = 1;
                break;
            case 2:
                goodAnswer = 2;
                break;
            case 3:
                goodAnswer = 3;
                break;
        }

    }

    private void Update()
    {
        if (answer != 0)
        {
            Verification();
        }
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
            Debug.Log("Bonne Réponse");
        }
        else
        {
            mauvaiseReponse.SetActive(true);
            bonneReponse.SetActive(false);
            Debug.Log("Mauvaise Réponse");
            answer = 0;
        }
    }
}