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
    public float Error14 = 0f;
    public float Error15 = 0f;
    public float Error16 = 0f;
    //Group being turned ON or OFF for quick puzzle shift
    public GameObject Case1;
    //
    //public Text text1;
    public float ER1 = 7f;
    public float Error10A = 0f;
    public float Error11A = 0f;
    public float Error12A = 0f;
    public float Error13A = 0f;
    public float Error14A = 0f;
    public float Error15A = 0f;
    public float Error16A = 0f;
    //Case 1 Feedbacks
    public GameObject Error10F;
    public GameObject Error11F;
    public GameObject Error12F;
    public GameObject Error13F;
    public GameObject Error14F;
    public GameObject Error15F;
    public GameObject Error16F;

    //Case 2 
    public float Error20 = 0f;
    public float Error21 = 0f;
    public float Error22 = 0f;
    public float Error23 = 0f;
    public float Error24 = 0f;
    public float Error25 = 0f;
    public float Error26 = 0f;
    public GameObject Case2;
   // public Text text2;
    public float ER2 = 7f;
    public float Error20A = 0f;
    public float Error21A = 0f;
    public float Error22A = 0f;
    public float Error23A = 0f;
    public float Error24A = 0f;
    public float Error25A = 0f;
    public float Error26A = 0f;
    //Case 2 Feedbacks
    public GameObject Error20F;
    public GameObject Error21F;
    public GameObject Error22F;
    public GameObject Error23F;
    public GameObject Error24F;
    public GameObject Error25F;
    public GameObject Error26F;


    //Case 3 
    public float Error30 = 0f;
    public float Error31 = 0f;
    public float Error32 = 0f;
    public float Error33 = 0f;
    public float Error34 = 0f;
    public float Error35 = 0f;
    public float Error36 = 0f;
    public GameObject Case3;
    //public Text text3;
    public float ER3 = 7f;
    public float Error30A = 0f;
    public float Error31A = 0f;
    public float Error32A = 0f;
    public float Error33A = 0f;
    public float Error34A = 0f;
    public float Error35A = 0f;
    public float Error36A = 0f;

    //Case 3 Feedbacks
    public GameObject Error30F;
    public GameObject Error31F;
    public GameObject Error32F;
    public GameObject Error33F;
    public GameObject Error34F;
    public GameObject Error35F;
    public GameObject Error36F;

    public AudioClip Bravo;
    public bool timerActive;
    public int timer;

    public GameObject Error7;
    public GameObject Error6;
    public GameObject Error5;
    public GameObject Error4;
    public GameObject Error3;
    public GameObject Error2;
    public GameObject Error1;

    public void Start()
    {
        timer = 0;
        timerActive = false;
        Generate();
    }

    public void Update()
    {
        //text1.text = "Érreur restante " + ER1;
        //text2.text = "Érreur restante " + ER2;
        //text3.text = "Érreur restante " + ER3;

        if (timerActive == true)
        {
            timer += 1;

            if (timer >= 60)
            {
                timerActive = false;
                timer = 0;

            }
        }

        if(ER1 == 7)
        {
            Error7.SetActive(true);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER1 == 6)
        {
            Error7.SetActive(false);
            Error6.SetActive(true);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER1 == 5)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(true);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER1 == 4)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(true);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER1 == 3)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(true);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER1 == 2)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(true);
            Error1.SetActive(false);
        }

        if (ER1 == 1)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(true);
        }

        if (ER2 == 7)
        {
            Error7.SetActive(true);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER2 == 6)
        {
            Error7.SetActive(false);
            Error6.SetActive(true);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER2 == 5)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(true);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER2 == 4)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(true);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER2 == 3)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(true);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER2 == 2)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(true);
            Error1.SetActive(false);
        }

        if (ER2 == 1)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(true);
        }

        if (ER3 == 7)
        {
            Error7.SetActive(true);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER3 == 6)
        {
            Error7.SetActive(false);
            Error6.SetActive(true);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER3 == 5)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(true);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER3 == 4)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(true);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER3 == 3)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(true);
            Error2.SetActive(false);
            Error1.SetActive(false);
        }

        if (ER3 == 2)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(true);
            Error1.SetActive(false);
        }

        if (ER3 == 1)
        {
            Error7.SetActive(false);
            Error6.SetActive(false);
            Error5.SetActive(false);
            Error4.SetActive(false);
            Error3.SetActive(false);
            Error2.SetActive(false);
            Error1.SetActive(true);
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
                    ResetError();
                    PreviousRand = Rand;
                    break;

                case 2f:
                    ImageTwo();
                    ResetError();
                    PreviousRand = Rand;
                    break;

                case 3f:
                    ImageThree();
                    ResetError();
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
                Error10F.SetActive(true);

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
                Error11F.SetActive(true);

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
                Error12F.SetActive(true);

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
                Error13F.SetActive(true);

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

    public void Error14B()
    {
        if (Error14A == 0)
        {
            Error14 = 1;

            //This handle the score
            if (Error14 == 1)
            {
                ER1 -= 1;
                Error14A -= 1;
                Error14F.SetActive(true);

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

    public void Error15B()
    {
        if (Error15A == 0)
        {
            Error15 = 1;

            //This handle the score
            if (Error15 == 1)
            {
                ER1 -= 1;
                Error15A -= 1;
                Error15F.SetActive(true);

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

    public void Error16B()
    {
        if (Error16A == 0)
        {
            Error16 = 1;

            //This handle the score
            if (Error16 == 1)
            {
                ER1 -= 1;
                Error16A -= 1;
                Error10F.SetActive(true);

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
                Error20F.SetActive(true);

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
                Error21F.SetActive(true);

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
                Error22F.SetActive(true);

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
                Error23F.SetActive(true);

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
    public void Error24B()
    {
        if (Error24A == 0)
        {
            Error24 = 1;

            //This handle the score
            if (Error24 == 1)
            {
                ER2 -= 1;
                Error24A -= 1;
                Error24F.SetActive(true);

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
    public void Error25B()
    {
        if (Error25A == 0)
        {
            Error25 = 1;

            //This handle the score
            if (Error25 == 1)
            {
                ER2 -= 1;
                Error25A -= 1;
                Error25F.SetActive(true);

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
    public void Error26B()
    {
        if (Error26A == 0)
        {
            Error26 = 1;

            //This handle the score
            if (Error26 == 1)
            {
                ER2 -= 1;
                Error26A -= 1;
                Error26F.SetActive(true);

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
                Error30F.SetActive(true);

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
                Error31F.SetActive(true);

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
                Error32F.SetActive(true);

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
                Error33F.SetActive(true);

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
                Error34F.SetActive(true);

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

    public void Error35B()
    {
        if (Error35A == 0)
        {
            Error35 = 1;

            //This handle the score
            if (Error35 == 1)
            {
                ER3 -= 1;
                Error35A -= 1;
                Error35F.SetActive(true);

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

    public void Error36B()
    {
        if (Error36A == 0)
        {
            Error36 = 1;

            //This handle the score
            if (Error36 == 1)
            {
                ER3 -= 1;
                Error36A -= 1;
                Error36F.SetActive(true);

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
        

        ER1 = 7;
        Error10 = 0;
        Error10A = 0;
        Error11 = 0;
        Error11A = 0;
        Error12 = 0;
        Error12A = 0;
        Error13 = 0;
        Error13A = 0;
        Error10F.SetActive(false);
        Error11F.SetActive(false);
        Error12F.SetActive(false);
        Error13F.SetActive(false);
        Error14F.SetActive(false);
        Error15F.SetActive(false);
        Error16F.SetActive(false);

        ER2 = 7;
        Error20 = 0;
        Error20A = 0;
        Error21 = 0;
        Error21A = 0;
        Error22 = 0;
        Error22A = 0;
        Error23 = 0;
        Error23A = 0;
        Error20F.SetActive(false);
        Error21F.SetActive(false);
        Error22F.SetActive(false);
        Error23F.SetActive(false);
        Error24F.SetActive(false);
        Error25F.SetActive(false);
        Error26F.SetActive(false);


        ER3 = 7;
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
        Error30F.SetActive(false);
        Error31F.SetActive(false);
        Error32F.SetActive(false);
        Error33F.SetActive(false);
        Error34F.SetActive(false);
        Error35F.SetActive(false);
        Error36F.SetActive(false);

        timerActive = true;

    }
}
