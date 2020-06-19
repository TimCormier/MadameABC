using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternKiller : MonoBehaviour
{
    public int currentPattern = 2;


    public GameObject pattern1;
    public GameObject pattern2;
    public GameObject pattern3;
    public GameObject pattern4;
    public GameObject pattern5;
    public GameObject bravoButton;
   // public Transform[] NotePos;

    public GameObject GlobalPattern;    

    private void Start()
    {
        currentPattern = 2;


        //boucle (non fonctionnelle?) pour stocker les transfroms des notes dans un tableau
        /*
        for (int j = 0; j < GlobalPattern.transform.childCount; j++)
        {
            for (int i = 0; i < GlobalPattern.transform.GetChild(j).childCount; i++)
            {
                if (GlobalPattern.transform.GetChild(j).transform.GetChild(i).tag == "NoteTapRythme")
                {
                    NotePos = new Transform[GlobalPattern.transform.GetChild(j).transform.GetChild(i).childCount];
                    NotePos[i] = GlobalPattern.transform.GetChild(j).transform.GetChild(i);
                }
            }
        }*/

    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Pattern")
        {
            collision.transform.parent.gameObject.SetActive(false);

            switch (currentPattern)
            {
                case 1:
                    pattern5.SetActive(false);
                    pattern1.SetActive(true);
                    currentPattern = currentPattern + 1;
                    break;

                case 2:
                    pattern1.SetActive(false);
                    pattern2.SetActive(true);
                    currentPattern = currentPattern + 1;
                    break;

                case 3:
                    pattern2.SetActive(false);
                    pattern3.SetActive(true);
                    currentPattern = currentPattern + 1;
                    break;

                case 4:
                    pattern3.SetActive(false);
                    pattern4.SetActive(true);
                    currentPattern = currentPattern + 1;
                    break;

                case 5:
                    pattern4.SetActive(false);
                    pattern5.SetActive(true);
                    currentPattern = currentPattern + 1;
                    break;
                case 6:

                    bravoButton.SetActive(true);

                    //Boucle pour récupérer toutes les notes et les set actives
                    for (int j = 0; j < GlobalPattern.transform.childCount; j++)
                    {
                        for (int i = 0; i < GlobalPattern.transform.GetChild(j).childCount; i++)
                        {
                            if (GlobalPattern.transform.GetChild(j).transform.GetChild(i).tag == "NoteTapRythme")
                            {
                                GlobalPattern.transform.GetChild(j).transform.GetChild(i).gameObject.SetActive(true);
                            }
                        }
                    }
                    break;
            }
        }
       

    }
}
