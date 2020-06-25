using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionScript : MonoBehaviour
{

    private GameObject MANAGER;
    public GameObject[] BlueCastleList;
    public GameObject[] RedCastleList;
    private int BlueListIndex;
    private int RedListIndex;
    private Button btn;
    private GameObject KingSquareRed;
    private GameObject KingSquareBlue;


    // Start is called before the first frame update
    void Start()
    {
        BlueListIndex = 0;
        RedListIndex = 0;
        btn = gameObject.transform.GetComponent<Button>();
        MANAGER = GameObject.Find("GameManager");
        btn.onClick.AddListener(ClickMethod);
        KingSquareBlue = GameObject.Find("KingSquareBlue");
        KingSquareRed = GameObject.Find("KingSquareRed");

        
        //Default Castle Setup
        /*
        if (GameObject.FindWithTag("BLUECASTLE") == null) {
            Instantiate(BlueCastleList[0], KingSquareBlue.transform.position, KingSquareBlue.transform.rotation);
        }

        if (GameObject.FindWithTag("REDCASTLE") == null) {
            Instantiate(RedCastleList[0], KingSquareRed.transform.position, KingSquareRed.transform.rotation);
        }*/
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

    void ClickMethod() {
        Debug.Log("you clicked " + gameObject.transform.name);

        switch (gameObject.transform.name) {
            case "SelectionDown_blue":
                Destroy(GameObject.FindWithTag("BLUECASTLE"));
                BlueListIndex++;
                if (BlueListIndex > BlueCastleList.Length) {
                    BlueListIndex = 0;
                }
                Debug.Log(BlueCastleList[BlueListIndex].transform.name);
                Instantiate(BlueCastleList[BlueListIndex], KingSquareBlue.transform.position, KingSquareBlue.transform.rotation);
                break;

            case "SelectionUp_blue":
                Destroy(GameObject.FindWithTag("BLUECASTLE"));
                BlueListIndex--;
                if (BlueListIndex < 0) {
                    BlueListIndex = BlueCastleList.Length - 1;
                }
                Debug.Log(BlueCastleList[BlueListIndex].transform.name);
                Instantiate(BlueCastleList[BlueListIndex], KingSquareBlue.transform.position, KingSquareBlue.transform.rotation);

                break;

            case "SelectionUp_red":
                Destroy(GameObject.FindWithTag("REDCASTLE"));
                RedListIndex--;
                if (RedListIndex < 0)
                {
                    RedListIndex = RedCastleList.Length - 1;
                }
                Debug.Log(RedCastleList[RedListIndex].transform.name);
                Instantiate(RedCastleList[RedListIndex], KingSquareRed.transform.position, KingSquareRed.transform.rotation);

                break;

            case "SelectionDown_red":
                Destroy(GameObject.FindWithTag("REDCASTLE"));
                RedListIndex++;
                if (RedListIndex > RedCastleList.Length)
                {
                    RedListIndex = 0;
                }
                Debug.Log(RedCastleList[RedListIndex].transform.name);
                Instantiate(RedCastleList[RedListIndex], KingSquareRed.transform.position, KingSquareRed.transform.rotation);

                break;

            case "StartButton":
                /*
                float roll = Mathf.Round(Random.Range(1f, 2f));
                Debug.Log("Coin flip value is " + roll);
                if (roll == 1f)
                {
                    MANAGER.GetComponent<CastleScript>().TURNBLUE();
                }
                else {
                    MANAGER.GetComponent<CastleScript>().TURNRED();
                } */
                //Normally id make it pick a starting player at random but it causes a bug if the red player starts that lets him shoot twice on his first turn
                MANAGER.GetComponent<CastleScript>().TURNBLUE();
                break;

            default:
                Debug.Log("Somethig is bugged with " + gameObject.transform.name);
                break;
        }
    }

    public void INITIATE() {
        Instantiate(BlueCastleList[0], KingSquareBlue.transform.position, KingSquareBlue.transform.rotation);
        Instantiate(RedCastleList[0], KingSquareRed.transform.position, KingSquareRed.transform.rotation);
    }
}
