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

    public void OnCollisionEnter2D(Collision2D collision)
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
                Debug.Log("test");
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
                currentPattern = 1;
                break;
        }

    }
}
