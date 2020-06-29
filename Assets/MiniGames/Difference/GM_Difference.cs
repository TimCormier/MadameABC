using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM_Difference : MonoBehaviour
{
    //To Add another error on an image.
    //Add float while keeping this method EX: Line 16 - 59
    //Add a Button function, keeping the nomenclature. EX: Line 138-158
    //Add the new floats to the ButtonReset function, Line 447-4xx


    private float Rand = 0f;
    public float PreviousRand;

    //Case 1 
    //Error float that keep in mind if player found the error
    public float Error10 = 0f;
    public float Error11 = 0f;
    public float Error12 = 0f;
    public float Error13 = 0f;
    //Group being turned ON or OFF for quick puzzle shift
    public GameObject Case1;
    //
    public Text text1;
    public float ER1 = 4f;
    public float Error10A = 0f;
    public float Error11A = 0f;
    public float Error12A = 0f;
    public float Error13A = 0f;

    //Case 2 
    public float Error20 = 0f;
    public float Error21 = 0f;
    public float Error22 = 0f;
    public float Error23 = 0f;
    public GameObject Case2;
    public Text text2;
    public float ER2 = 4f;
    public float Error20A = 0f;
    public float Error21A = 0f;
    public float Error22A = 0f;
    public float Error23A = 0f;

    //Case 3 
    public float Error30 = 0f;
    public float Error31 = 0f;
    public float Error32 = 0f;
    public float Error33 = 0f;
    public float Error34 = 0f;
    public GameObject Case3;
    public Text text3;
    public float ER3 = 5f;
    public float Error30A = 0f;
    public float Error31A = 0f;
    public float Error32A = 0f;
    public float Error33A = 0f;
    public float Error34A = 0f;

    public AudioClip Bravo;
    public bool timerActive;
    public int timer;

    public void Start()
    {
        timer = 0;
        timerActive = false;
        Generate();
    }

    public void Update()
    {
        text1.text = "Érreur restante " + ER1;
        text2.text = "Érreur restante " + ER2;
        text3.text = "Érreur restante " + ER3;

        if (timerActive == true)
        {
            timer += 1;

            if (timer >= 60)
            {
                timerActive = false;
                timer = 0;

            }
        }
    }

    //Generate the randomness. Call this function when generating another puzzle.
    //Customizable by adding cases
    public void Generate()
    {
        //This is the randomness, changes the 2nd float to a bigger number to increase the amount of cases
        Rand = Mathf.Round(Random.Range(1f, 3f));

        //This is to counter the game enabling the same puzzle twice in a row
        if (Rand != PreviousRand)
        {
            switch (Rand)
            {
                //To make another case, keep this nomenclature
                case 1f:
                    ImageOne();
                    PreviousRand = Rand;
                    break;

                case 2f:
                    ImageTwo();
                    PreviousRand = Rand;
                    break;

                case 3f:
                    ImageThree();
                    PreviousRand = Rand;
                    break;
            }
        }

        //This should never be called, but it's a safeward
        else
        {
            Generate();
        }
    }

    //Simply turn on the correct puzzle
    public void ImageOne()
    {
        Case1.SetActive(true);
        Case2.SetActive(false);
        Case3.SetActive(false);
    }

    //Simply turn on the correct puzzle
    public void ImageTwo()
    {
        Case1.SetActive(false);
        Case2.SetActive(true);
        Case3.SetActive(false);
    }

    //Simply turn on the correct puzzle
    public void ImageThree()
    {
        Case1.SetActive(false);
        Case2.SetActive(false);
        Case3.SetActive(true);
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error10B()
    {
        if (Error10A == 0)
        {
            Error10 = 1;

            //This handle the score
            if (Error10 == 1)
            {
                ER1 -= 1;
                Error10A -= 1;

                if (ER1 == 0)
                {
                    
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        } 
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error11B()
    {
        if (Error11A == 0)
        {
            Error11 = 1;

            //This handle the score
            if (Error11 == 1)
            {
                ER1 -= 1;
                Error11A -= 1;

                if (ER1 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error12B()
    {
        if (Error12A == 0)
        {
            Error12 = 1;

            //This handle the score
            if (Error12 == 1)
            {
                ER1 -= 1;
                Error12A -= 1;

                if (ER1 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error13B()
    {
        if (Error13A == 0)
        {
            Error13 = 1;

            //This handle the score
            if (Error13 == 1)
            {
                ER1 -= 1;
                Error13A -= 1;

                if (ER1 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error20B()
    {
        if (Error20A == 0)
        {
            Error20 = 1;

            //This handle the score
            if (Error20 == 1)
            {
                ER2 -= 1;
                Error20A -= 1;

                if (ER2 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error21B()
    {
        if (Error21A == 0)
        {
            Error21 = 1;

            //This handle the score
            if (Error21 == 1)
            {
                ER2 -= 1;
                Error21A -= 1;

                if (ER2 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error22B()
    {
        if (Error22A == 0)
        {
            Error22 = 1;

            //This handle the score
            if (Error22 == 1)
            {
                ER2 -= 1;
                Error22A -= 1;

                if (ER2 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error23B()
    {
        if (Error23A == 0)
        {
            Error23 = 1;

            //This handle the score
            if (Error23 == 1)
            {
                ER2 -= 1;
                Error23A -= 1;

                if (ER2 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error30B()
    {
        if (Error30A == 0)
        {
            Error30 = 1;

            //This handle the score
            if (Error30 == 1)
            {
                ER3 -= 1;
                Error30A -= 1;

                if (ER3 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error31B()
    {
        if (Error31A == 0)
        {
            Error31 = 1;

            //This handle the score
            if (Error31 == 1)
            {
                ER3 -= 1;
                Error31A -= 1;

                if (ER3 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error32B()
    {
        if (Error32A == 0)
        {
            Error32 = 1;

            //This handle the score
            if (Error32 == 1)
            {
                ER3 -= 1;
                Error32A -= 1;

                if (ER3 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    //Keep the value if the player pressed the error and handle the Érreur restante Text.
    //To use, put function on the button (The button need to be covering the error)
    public void Error33B()
    {
        if (Error33A == 0)
        {
            Error33 = 1;

            //This handle the score
            if (Error33 == 1)
            {
                ER3 -= 1;
                Error33A -= 1;

                if (ER3 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    public void Error34B()
    {
        if (Error34A == 0)
        {
            Error34 = 1;

            //This handle the score
            if (Error34 == 1)
            {
                ER3 -= 1;
                Error34A -= 1;

                if (ER3 == 0)
                {
                    if (timerActive == false)
                    {
                        AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
                    }
                    timerActive = true;
                    ResetError();
                    Generate();
                }
            }
        }
    }

    public void ResetError()
    {
        

        ER1 = 4;
        Error10 = 0;
        Error10A = 0;
        Error11 = 0;
        Error11A = 0;
        Error12 = 0;
        Error12A = 0;
        Error13 = 0;
        Error13A = 0;

        ER2 = 4;
        Error20 = 0;
        Error20A = 0;
        Error21 = 0;
        Error21A = 0;
        Error22 = 0;
        Error22A = 0;
        Error23 = 0;
        Error23A = 0;

        ER3 = 5;
        Error30 = 0;
        Error30A = 0;
        Error31 = 0;
        Error31A = 0;
        Error32 = 0;
        Error32A = 0;
        Error33 = 0;
        Error33A = 0;
        Error34 = 0;
        Error34A = 0;

        timerActive = true;

    }
}
