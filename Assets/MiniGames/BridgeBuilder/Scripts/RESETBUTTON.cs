using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RESETBUTTON : MonoBehaviour
{

  
    private Button btnRESET;

    public GameObject TRIANGLE;
    public GameObject SQUARE;
    public GameObject CIRCLE;
    private GameObject BALL;
    private GameObject MANAGER;
    // Start is called before the first frame update
    void Start()
    {
      
        btnRESET = GameObject.Find("RESET").transform.GetComponent<Button>();
       
        btnRESET.onClick.AddListener(OnClick);
        BALL = GameObject.Find("Ball");
        MANAGER = GameObject.Find("GameManager");


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
     
        
        
            MANAGER.transform.GetComponent<BridgeBuilderScript>().RESET();
            TRIANGLE.transform.GetComponent<ObjectDrag>().RESET();
            SQUARE.transform.GetComponent<ObjectDrag>().RESET();
            CIRCLE.transform.GetComponent<ObjectDrag>().RESET();
            Debug.Log("RESET");
        


    }


}
