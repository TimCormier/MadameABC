using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesNScript : MonoBehaviour
{

    
    private GameObject CAR;
    private SpriteRenderer spr;

    private GameObject Circle;
    private GameObject Triangle;
    private GameObject Square;

    /*
    private string value;
    private string valuelast;
    */
    private float rand;
    private float randlast;

    //textures

    public Sprite CIRCLEHOLE;
    public Sprite CIRCLEFILL;
    public Sprite TRIANGLEHOLE;
    public Sprite TRIANGLEFILL;
    public Sprite SQUAREHOLE;
    public Sprite SQUAREFILL;



    // Start is called before the first frame update
    void Start()
    {
        Circle = GameObject.Find("Circle");
        Triangle = GameObject.Find("Triangle");
        Square = GameObject.Find("Square");
        CAR = GameObject.Find("Car");
        spr = gameObject.transform.GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GENERATE() {
        rand = Mathf.Round(Random.Range(1f, 3f));
        if (rand == randlast) {
            //do not do that shit lmao
        }
        else {
            switch (rand) {
                case 1f:
                    spr.sprite = CIRCLEHOLE;
                    break;

                case 2f:
                    spr.sprite = TRIANGLEHOLE;
                    break;

                case 3f:
                    spr.sprite = SQUAREHOLE;
                    break;

                default:
                    Debug.Log("something bugged out chief");
                    break;


            }


        }

       


    }

    void OnTriggerEnter(Collider col) {
        string colName = col.transform.name;
        switch (colName) {
            case "Circle":
                if (rand == 1f)
                {
                    col.gameObject.SetActive(false);
                    spr.sprite = CIRCLEFILL;
                    WINANIM();

                }
                else {
                    col.transform.GetComponent<DragShape>().RETURN();
                }
                break;

            case "Triangle":
                if (rand == 2f)
                {
                    col.gameObject.SetActive(false);
                    spr.sprite = TRIANGLEFILL;
                    WINANIM();

                }
                else
                {
                    col.transform.GetComponent<DragShape>().RETURN();
                }
                break;

            case "Square":
                if (rand == 3f)
                {
                    col.gameObject.SetActive(false);
                    spr.sprite = SQUAREFILL;
                    WINANIM();

                }
                else
                {
                    col.transform.GetComponent<DragShape>().RETURN();
                }
                break;

            default:
                Debug.Log("Something isnt working right with the collisions");
                col.transform.GetComponent<DragShape>().RETURN();
                break;
        }
    }

    void WINANIM() {
        Debug.Log("WIN!");
    }
}
