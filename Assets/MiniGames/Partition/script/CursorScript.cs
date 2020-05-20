using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CursorScript : MonoBehaviour
{


    private GameObject CURSOR;
    private GameObject LINE;


    private Button PLAYBTN;
    private Button STOPBTN;
    private Button RESETBTN;
    private Button SHEETBTN;

    private Vector3 ogpos;
    public float speed;

    private bool playing = false;
    // Start is called before the first frame update
    void Start()
    {
        CURSOR = GameObject.Find("Cursor");
        LINE = GameObject.Find("Line");
        PLAYBTN = GameObject.Find("PlayButton").transform.GetComponent<Button>();
        PLAYBTN.onClick.AddListener(OnClick);
        STOPBTN = GameObject.Find("StopButton").transform.GetComponent<Button>();
        STOPBTN.onClick.AddListener(OnClickStop);
        RESETBTN = GameObject.Find("ResetButton").transform.GetComponent<Button>();
        RESETBTN.onClick.AddListener(OnClickReset);
        SHEETBTN = GameObject.Find("SheetButton").transform.GetComponent<Button>();
        SHEETBTN.onClick.AddListener(OnClickSheet);
        ogpos = CURSOR.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true) {
            CURSOR.transform.position += new Vector3(speed, 0f, 0f);

            //raycast code
            /*
            RaycastHit hit;
            if (Physics.Raycast(CURSOR.transform.position, transform.TransformDirection(Vector3.down),out hit, 1f)) {
                Debug.Log(hit.transform.name);
                //Debug.DrawRay(CURSOR.transform.position, transform.TransformDirection(Vector3.down));
            }
            */


            if (CURSOR.transform.position.x >= 7.6) {
                if (CURSOR.transform.position.y < ogpos.y)
                {
                    CURSOR.transform.position = ogpos;
                }
                else {
                    CURSOR.transform.position = new Vector3(ogpos.x, 0.7f, ogpos.z);
                }
              //  CURSOR.transform.position = new Vector3(ogpos.x, 0.7f, ogpos.z);
            }
        }
    }

    void OnClick() {
        Debug.Log("You clicked the play button!");
        playing = true;
    }
    void OnClickStop()
    {
        Debug.Log("You clicked the Stop button!");
        playing = false;
        CURSOR.transform.position = ogpos;

    }
    void OnClickReset()
    {
        Debug.Log("You clicked the Reset button!");
        SceneManager.LoadScene("Partition");
       // playing = true;
    }
    void OnClickSheet()
    {
        Debug.Log("You clicked the Sheet button!");
       // playing = true;
       //add the sheet data here, we'll figure this out some other day lol
    }
}
