using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMath_Buttons : MonoBehaviour
{
    public SpriteRenderer reponse;
    public Sprite image1, image2, image3;
    private int seed;


    // Start is called before the first frame update
    void Start()
    {
        reponse = GetComponent<SpriteRenderer>();
        seed = Random.Range(1, 5);
        Debug.Log(seed);
    }

    public void SetImage1()
    {
        reponse.sprite = image1;
    }
    public void SetImage2()
    {
        reponse.sprite = image2;
    }
    public void SetImage3()
    {
        reponse.sprite = image3;
    }
}
