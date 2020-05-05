using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMath_Buttons : MonoBehaviour
{
    public SpriteRenderer reponse;
    public Sprite image1, image2, image3;
    GameObject manager;
    GameManagerSimpleMath managerScript;

    void Start()
    {
        reponse = GetComponent<SpriteRenderer>();
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<GameManagerSimpleMath>();
    }

    public void SetImage1()
    {
        reponse.sprite = image1;
        managerScript.answer = 1;
        managerScript.verification();
    }
    public void SetImage2()
    {
        reponse.sprite = image2;
        managerScript.answer = 2;
        managerScript.verification();
    }
    public void SetImage3()
    {
        reponse.sprite = image3;
        managerScript.answer = 3;
        managerScript.verification();
    }
}
