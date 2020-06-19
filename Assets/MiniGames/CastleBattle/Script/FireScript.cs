using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireScript : MonoBehaviour
{
    private GameObject MANAGER;
   
    private GameObject VISUAL;
   // private SpriteRenderer RENDERER;
    public Sprite UP;
    public Sprite DOWN;
    private Image IMAGE;
    
    


    // Start is called before the first frame update
    void Start()
    {
        MANAGER = GameObject.Find("GameManager");
       
        VISUAL = GameObject.Find("FireButton_visual");
        IMAGE = VISUAL.GetComponent<Image>();
       // RENDERER = VISUAL.transform.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag() {
        //RENDERER.sprite = DOWN;
        if (GameObject.Find("Cannonball(Clone)") == null) {
        IMAGE.sprite = DOWN;
        MANAGER.GetComponent<CastleScript>().FIREBUTTONDOWN();
        }
        
    }
    void OnMouseUp() {
        //RENDERER.sprite = UP;
        if (GameObject.Find("Cannonball(Clone)") == null) {
        IMAGE.sprite = UP;
        MANAGER.GetComponent<CastleScript>().FIREBUTTONUP();
        }
        
    }
}
