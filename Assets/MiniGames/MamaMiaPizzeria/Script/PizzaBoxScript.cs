using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaBoxScript : MonoBehaviour
{
    public GameObject PizzaBox;
    private bool HasPizza = false;
    private GameObject PizzaSpawner;



    // Start is called before the first frame update
    void Start()
    {
        PizzaSpawner = GameObject.Find("PizzaSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col) {
        Debug.Log("Collider name is " + col.transform.name);
        if (col.transform.name == "PizzeriaTrigger") {
            Debug.Log("You're at the pizza place");
            if (HasPizza == false) {
                Instantiate(PizzaBox, PizzaSpawner.transform.position, PizzaSpawner.transform.rotation);
                HasPizza = false;
            }
        }
    }
}
