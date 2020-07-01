using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixAndMatchGameManager : MonoBehaviour
{
    public GameObject c1, c2, c3, c4, c5, c6;
    public GameObject letterZone, numberZone;

   // public GameObject lastClickedObject;

    private int seedMaM;
    public int previousSeed = 8;

    public int goodAnswersN = 0;
    public int goodAnswersL = 0;

    void Start()
    {
        mixAndMatchCalcul();
    }

    private void mixAndMatchCalcul()
    {
        seedMaM = Random.Range(1, 7);

        if (seedMaM != previousSeed)
        {
            switch (seedMaM)
            {
                case 1:
                    c1.SetActive(true);
                    break;
                case 2:
                    c2.SetActive(true);
                    break;
                case 3:
                    c3.SetActive(true);
                    break;
                case 4:
                    c4.SetActive(true);
                    break;
                case 5:
                    c5.SetActive(true);
                    break;
                case 6:
                    c6.SetActive(true);
                    break;

            }
        }
        else
        {
            mixAndMatchCalcul();
        }
    }


    void Update()
    {
        
    }
}
