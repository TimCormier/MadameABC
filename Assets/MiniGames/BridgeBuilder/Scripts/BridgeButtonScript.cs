using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BridgeButtonScript : MonoBehaviour
{

    private Button btnGO;
   

    public GameObject TRIANGLE;
    public GameObject SQUARE;
    public GameObject CIRCLE;
    private GameObject BALL;
    private GameObject MANAGER;
    // Start is called before the first frame update
    void Start()
    {
        btnGO = GameObject.Find("GO").transform.GetComponent<Button>();
       
        btnGO.onClick.AddListener(OnClick);
       
        BALL = GameObject.Find("Ball");
        MANAGER = GameObject.Find("GameManager");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick() {
        
        
            //  BALL.transform.GetComponent<>
            MANAGER.transform.GetComponent<BridgeBuilderScript>().GOMETHOD();
            TRIANGLE.transform.GetComponent<ObjectDrag>().GO();
            SQUARE.transform.GetComponent<ObjectDrag>().GO();
            CIRCLE.transform.GetComponent<ObjectDrag>().GO();
            Debug.Log("GO");


        
       


    }


}
