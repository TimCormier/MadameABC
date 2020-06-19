using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballScript : MonoBehaviour
{
    private float timer = 0;
    public float despawnTime;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= despawnTime) {
            GameObject.Find("GameManager").GetComponent<CastleScript>().CHANGETURNS();
           
            Destroy(gameObject);
        }


       
       
    }
}
