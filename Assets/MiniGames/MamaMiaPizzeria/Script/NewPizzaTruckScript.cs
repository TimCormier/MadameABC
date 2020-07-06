using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPizzaTruckScript : MonoBehaviour
{
    public GameObject PizzaBox;
    private bool HasPizza = false;
    private GameObject PizzaSpawner;

    public float acceleration;
    public float speedlimit;
    public float decceleration;
    public float turnrate;
    private CharacterController controller;

    private float stopTimer;


    private float velocity;

    private string order;
    private int score;

    private Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext = GameObject.Find("Text").GetComponent<Text>();
        PizzaSpawner = GameObject.Find("PizzaSpawner");
        Debug.Log(PizzaSpawner.transform.name);
        stopTimer = 0f;
        velocity = 0;
        controller = gameObject.transform.GetComponent<CharacterController>();
        GameObject[] Pizzalist = GameObject.FindGameObjectsWithTag("Pizza");
      /*
        foreach (GameObject pizza in Pizzalist) {
            Physics.IgnoreCollision(pizza.transform.GetComponent<Collider>(), gameObject.transform.GetComponent<CharacterController>());
        }*/
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            order = "Blue";
        }


        //Input
        if (Input.GetKey("up")) {
            velocity += acceleration;
            stopTimer = 0;
        }

        if (Input.GetKey("down")) {
            velocity -= acceleration;
            stopTimer = 0;
        }

        if (Input.GetKey("left")) {
            gameObject.transform.Rotate(0f, 0f, turnrate * -1f);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Rotate(0f, 0f, turnrate);
        }
        //Decceleration and limitations
        if (velocity > speedlimit) {
            velocity = speedlimit;
        }
        if (velocity < speedlimit * -1f) {
            velocity = speedlimit * -1f;
        }


        if (velocity > 0)
        {
            velocity -= decceleration;
        }
        else if (velocity < 0)
        {
            velocity += decceleration;
        }
       

        if (stopTimer >= 2f) {
            Debug.Log("car is stopped");
            velocity = 0;
        }

        //output
       // Debug.Log(velocity);
        controller.Move(transform.up * velocity);
        stopTimer += Time.deltaTime;
    }

    void OnTriggerEnter(Collider col) {
        switch (col.transform.name) {
            case "PizzeriaTrigger":
               // Debug.Log("Youre at the pizza place");
                if (HasPizza == false)
                {
                    ORDER();
                    /*  GameObject[] Pizzalist = GameObject.FindGameObjectsWithTag("Pizza");
                      foreach (GameObject pizza in Pizzalist)
                      {
                          Physics.IgnoreCollision(pizza.transform.GetComponent<Collider>(), gameObject.transform.GetComponent<CharacterController>());
                      }*/
                }
                break;

            case "BlueHouseTrigger":
               // Debug.Log("You're at the blue house!");
                if (HasPizza == true && order == "Blue") {
                    Destroy(GameObject.FindWithTag("Pizza"));
                    HasPizza = false;
                    score++;
                }

                break;

            case "RedHouseTrigger":
               // Debug.Log("You're at the Red house!");
                if (HasPizza == true && order == "Red")
                {
                    Destroy(GameObject.FindWithTag("Pizza"));
                    HasPizza = false;
                    score++;
                }

                break;

            case "YellowHouseTrigger":
               // Debug.Log("You're at the Yellow house!");
                if (HasPizza == true && order == "Yellow")
                {
                    Destroy(GameObject.FindWithTag("Pizza"));
                    HasPizza = false;
                    score++;
                }

                break;

            case "PurpleHouseTrigger":
               // Debug.Log("You're at the blue house!");
                if (HasPizza == true && order == "Purple")
                {
                    Destroy(GameObject.FindWithTag("Pizza"));
                    HasPizza = false;
                    score++;
                }

                break;

            case "GreenHouseTrigger":
               // Debug.Log("You're at the blue house!");
                if (HasPizza == true && order == "Green")
                {
                    Destroy(GameObject.FindWithTag("Pizza"));
                    HasPizza = false;
                    score++;
                }

                break;

            default:
                Debug.Log("Wrong collider");
                break;

        }

        scoretext.text = score.ToString(); ;



        /*if (col.transform.name == "PizzeriaTrigger") {
            
        }*/
    }


    public void ORDER() {
        Instantiate(PizzaBox, PizzaSpawner.transform.position, PizzaSpawner.transform.rotation);
        GameObject.FindWithTag("Pizza").transform.SetParent(gameObject.transform);
        HasPizza = true;
        float id = Mathf.Round(Random.Range(1f, 5f));

        switch (id) {
            case 1f:
                order = "Blue";
                break;

            case 2f:
                order = "Red";
                break;

            case 3f:
                order = "Yellow";
                break;

            case 4f:
                order = "Purple";
                break;

            case 5f:
                order = "Green";
                break;

            default:
                Debug.Log("id out of bounds");
                break;
        }

        Debug.Log("Order is " + order);
    }

}
