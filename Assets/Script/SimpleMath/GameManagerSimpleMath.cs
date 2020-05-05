using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSimpleMath : MonoBehaviour
{
    public GameObject questionPack1, questionPack2;
    private int seed;
    public int answer;
    public int goodAnswer;
    public GameObject bonneReponse;
    public GameObject mauvaiseReponse;
   
    void Start()
    {
        seed = Random.Range(1, 3);

        switch (seed)
        {
            case 1:
                questionPack1.SetActive(true);
                goodAnswer = 1;
                break;
            case 2:
                questionPack2.SetActive(true);
                goodAnswer = 2;
                break;
        }
    }

    public void verification()
    {
        if (answer == goodAnswer)
        {
            bonneReponse.SetActive(true);
        }
        else
        {
            mauvaiseReponse.SetActive(true);
        }
    }
}
