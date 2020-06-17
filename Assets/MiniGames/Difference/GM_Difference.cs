using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM_Difference : MonoBehaviour
{
    private float Rand = 0f;
    public float PreviousRand;

    //Case 1 
    public float Error10 = 0f;
    public float Error11 = 0f;
    public float Error12 = 0f;
    public float Error13 = 0f;
    public GameObject PhotoOne;
    public GameObject PhotoOne2;
    public GameObject E10Spot;
    public GameObject E11Spot;
    public GameObject E12Spot;
    public GameObject E13Spot;

    //Case 2 
    public float Error20 = 0f;
    public float Error21 = 0f;
    public float Error22 = 0f;
    public float Error23 = 0f;
    public GameObject PhotoTwo;
    public GameObject PhotoTwo2;
    public GameObject E20Spot;
    public GameObject E21Spot;
    public GameObject E22Spot;
    public GameObject E23Spot;

    //Case 3 
    public float Error30 = 0f;
    public float Error31 = 0f;
    public float Error32 = 0f;
    public float Error33 = 0f;
    public GameObject PhotoThree;
    public GameObject PhotoThree2;
    public GameObject E30Spot;
    public GameObject E31Spot;
    public GameObject E32Spot;
    public GameObject E33Spot;

    public void Start()
    {
        Generate();
    }

    public void Generate()
    {
        Rand = Mathf.Round(Random.Range(1f, 3f));

        if (Rand != PreviousRand)
        {
            switch (Rand)
            {
                case 1f:
                    break;

                case 2f:
                    break;

                case 3f:
                    break;
            }
        }

        else
        {
            Generate();
        }
    }

    public void ImageOne()
    {
        PhotoOne.SetActive(true);
        PhotoOne2.SetActive(true);
        E10Spot.SetActive(true);
        E11Spot.SetActive(true);
        E12Spot.SetActive(true);
        E13Spot.SetActive(true);
        PhotoTwo.SetActive(false);
        PhotoTwo2.SetActive(false);
        E20Spot.SetActive(false);
        E21Spot.SetActive(false);
        E22Spot.SetActive(false);
        E23Spot.SetActive(false);
        PhotoThree.SetActive(false);
        PhotoThree2.SetActive(false);
        E30Spot.SetActive(false);
        E31Spot.SetActive(false);
        E32Spot.SetActive(false);
        E33Spot.SetActive(false);
    }

    public void ImageTwo()
    {
        PhotoOne.SetActive(false);
        PhotoOne2.SetActive(false);
        E10Spot.SetActive(false);
        E11Spot.SetActive(false);
        E12Spot.SetActive(false);
        E13Spot.SetActive(false);
        PhotoTwo.SetActive(true);
        PhotoTwo2.SetActive(true);
        E20Spot.SetActive(true);
        E21Spot.SetActive(true);
        E22Spot.SetActive(true);
        E23Spot.SetActive(true);
        PhotoThree.SetActive(false);
        PhotoThree2.SetActive(false);
        E30Spot.SetActive(false);
        E31Spot.SetActive(false);
        E32Spot.SetActive(false);
        E33Spot.SetActive(false);
    }

    public void ImageThree()
    {
        PhotoOne.SetActive(false);
        PhotoOne2.SetActive(false);
        E10Spot.SetActive(false);
        E11Spot.SetActive(false);
        E12Spot.SetActive(false);
        E13Spot.SetActive(false);
        PhotoTwo.SetActive(false);
        PhotoTwo2.SetActive(false);
        E20Spot.SetActive(false);
        E21Spot.SetActive(false);
        E22Spot.SetActive(false);
        E23Spot.SetActive(false);
        PhotoThree.SetActive(true);
        PhotoThree2.SetActive(true);
        E30Spot.SetActive(true);
        E31Spot.SetActive(true);
        E32Spot.SetActive(true);
        E33Spot.SetActive(true);
    }
}
