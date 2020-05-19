using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{

    private AudioSource AUDIO;

    // Start is called before the first frame update
    void Start()
    {
        AUDIO = gameObject.transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.transform.name == "Line") {
            Debug.Log(gameObject.name);
            AUDIO.Play();
        }
    }
}
/*
 switch()



  */
