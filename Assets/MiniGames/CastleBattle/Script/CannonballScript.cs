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

    void OnTriggerEnter(Collider other) {
        switch (other.transform.name) {
            case "RedCinematicCamTrigger":
                if (GameObject.Find("BlueTurnDetector") != null) {
                    gameObject.transform.GetComponent<AudioSource>().Stop();
                  //  GameObject.Find("SoundEffectKeeper").transform.GetComponent<AudioSource>().Stop();
                    GameObject.Find("RedCinematicCamera").transform.GetComponent<AudioSource>().Play();
                    GameObject.Find("GameManager").GetComponent<CastleScript>().CYCLECAM("REDCINEMATICCAM");
                }
                break;

            case "BlueCinematicCamTrigger":
                if (GameObject.Find("RedTurnDetector") != null) {
                    gameObject.transform.GetComponent<AudioSource>().Stop();
                 //   GameObject.Find("SoundEffectKeeper").transform.GetComponent<AudioSource>().Stop();
                    GameObject.Find("BlueCinematicCamera").transform.GetComponent<AudioSource>().Play();
                    GameObject.Find("GameManager").GetComponent<CastleScript>().CYCLECAM("BLUECINEMATICCAM");
                }
                break;

            default:

                break;
        }
    }
}
