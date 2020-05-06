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

    private bool playanim;
    private int animtimer;

    private Vector3 OGpos;
    private Vector3 CAROGpos;

    // Start is called before the first frame update
    void Start()
    {
        Circle = GameObject.Find("Circle");
        Triangle = GameObject.Find("Triangle");
        Square = GameObject.Find("Square");
        CAR = GameObject.Find("Car");
        spr = gameObject.transform.GetComponent<SpriteRenderer>();
        OGpos = transform.position;
        CAROGpos = CAR.transform.position;

        playanim = false;
        animtimer = 0;


        GENERATE();

        
    }

    // Update is called once per frame
    void Update()
    {

        
                if (Input.GetKeyDown("space")) {
                    GENERATE();
                }

        if (playanim == true) {
            animtimer += 1;
            transform.position += new Vector3(0f, 0.05f, 0f);
            CAR.transform.position += new Vector3(-15f, 0, 0);
            if (animtimer >= 120) {
                playanim = false;
                animtimer = 0;
                transform.position = OGpos;
                CAR.transform.position = CAROGpos;
                Triangle.transform.GetComponent<DragShape>().RETURN();
                Circle.transform.GetComponent<DragShape>().RETURN();
                Square.transform.GetComponent<DragShape>().RETURN();
                GENERATE();
            }
        }


    }

    void GENERATE() {
        rand = Mathf.Round(Random.Range(1f, 3f));
        if (rand == randlast) {
            GENERATE();
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

    public void ENTERCIRCLE() {
        if (rand == 1f)
        {
            Circle.SetActive(false);
            spr.sprite = CIRCLEFILL;
            WINANIM();
        }
        else {
            Circle.transform.GetComponent<DragShape>().RETURN();
        }
    }

    public void ENTERTRIANGLE()
    {
        if (rand == 2f)
        {
            Triangle.SetActive(false);
            spr.sprite = TRIANGLEFILL;
            WINANIM();
        }
        else
        {
            Triangle.transform.GetComponent<DragShape>().RETURN();
        }
    }

    public void ENTERSQUARE()
    {
        if (rand == 3f)
        {
            Square.SetActive(false);
            spr.sprite = SQUAREFILL;
            WINANIM();
        }
        else
        {
            Square.transform.GetComponent<DragShape>().RETURN();
        }
    }


    void WINANIM() {
        Debug.Log("WIN!");
        randlast = rand;
        transform.GetComponent<AudioSource>().Play();
        playanim = true;
    }
}
