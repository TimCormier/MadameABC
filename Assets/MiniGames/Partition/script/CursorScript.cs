using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CursorScript : MonoBehaviour
{
    public float jumpValue;
    public GameObject NOTEHOLDERPREFAB;
    private GameObject CURSOR;
    private GameObject LINE;


    private Button PLAYBTN;
    private Button STOPBTN;
    private Button RESETBTN;
    private Button SHEETBTN;

    private Vector3 ogpos;
    public float speed;

    private bool playing = false;

    public string[] SongData;
    private GameObject NoteList;


    private string SongReset;
    private bool SongResetTrue;

    //public GameObject[] testlist;
    
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
        NoteList = GameObject.Find("NoteList");
        SongReset = "cccccccccccccccc";
        SongResetTrue = true;


        SHEETFUNC();

      //  DEBUGFUNC();

       // SPAWNFUNC();
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


            /*if (Input.GetKeyDown("space")) {
                NoteList.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
            }*/
        }

        /*
        if (Input.GetKeyDown("space")) {
            Debug.Log(SongData.Length);
        }*/
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
        // SceneManager.LoadScene("Partition");
        SongResetTrue = true;
        SHEETFUNC();
       // playing = true;
    }
    void OnClickSheet()
    {
        Debug.Log("You clicked the Sheet button!");
        SHEETFUNC();
       // playing = true;
       //add the sheet data here, we'll figure this out some other day lol
    }
    void SHEETFUNC() {
        //  Debug.Log(SongData.Length);
        string current = "";
        float temp = SongData.Length;
        int fix = 0;
        float songRoll = Mathf.Round(Random.Range(0f, temp -1f));
        Debug.Log(songRoll);
        fix = Mathf.RoundToInt(songRoll);

        current = SongData[fix];
        if (SongResetTrue == true) {
            current = SongReset;
        }

        for (int i = 0; i < current.Length; i++) {
           // Debug.Log("index is at " + i);
            char LIVE = current[i];
            Debug.Log(LIVE);

            for (int x = 0; x <= 14; x++) {
                // NoteList.transform.GetChild(i).transform.GetChild(x).gameObject.SetActive(false);
                GameObject first = NoteList.transform.GetChild(i).gameObject;
                //Debug.Log("index x is " + x);
                first.transform.GetChild(x).gameObject.SetActive(false);
            }

            // Remember, char variables are referenced using these '' not these ""

            /*
             *  A = La
                B = Si
                C = Do
                D = Re
                E = Mi
                F = Fa
                G = Sol
                lowercase for a non-stretch
                x for a mute
                input your 16-digit alphanumeric code within the SongData list in the inspector
             * */
            switch (LIVE)
            {
                case 'c': //DO
                    NoteList.transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(true);
                    break;

                case 'd': //re
                    NoteList.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
                    break;

                case 'e': //MI
                    NoteList.transform.GetChild(i).transform.GetChild(2).gameObject.SetActive(true);
                    break;

                case 'f': //FA
                    NoteList.transform.GetChild(i).transform.GetChild(3).gameObject.SetActive(true);
                    break;

                case 'g': //SOL
                    NoteList.transform.GetChild(i).transform.GetChild(4).gameObject.SetActive(true);
                    break;

                case 'a': //LA
                    NoteList.transform.GetChild(i).transform.GetChild(5).gameObject.SetActive(true);
                    break;

                case 'b': //SI
                    NoteList.transform.GetChild(i).transform.GetChild(6).gameObject.SetActive(true);
                    break;

                case 'C': //DOSTRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(7).gameObject.SetActive(true);
                    break;

                case 'D': //RE STRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(8).gameObject.SetActive(true);
                    break;

                case 'E': //MISTRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(9).gameObject.SetActive(true);
                    break;

                case 'F': //FASTRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(10).gameObject.SetActive(true);
                    break;

                case 'G': //SOLSTRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(11).gameObject.SetActive(true);
                    break;

                case 'A': //LASTRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(12).gameObject.SetActive(true);
                    break;

                case 'B': //SISTRETCH
                    NoteList.transform.GetChild(i).transform.GetChild(13).gameObject.SetActive(true);
                    break;

                case 'x': //MUTE
                    NoteList.transform.GetChild(i).transform.GetChild(14).gameObject.SetActive(true);
                    break;
            }


         

        }
        SongResetTrue = false;
    }

    void SPAWNFUNC()
    {
        // this may be temporary
        // actually this is completely batshit useless
        bool SwitchMe = false;
        float correction = 0f;
        for (float i = 0; i <= 15; i++)
        {



            if (SwitchMe == false)
            {
                if ((i * jumpValue) > ((0 * jumpValue) * -1))
                {
                    correction = i;
                    SwitchMe = true;
                }
                else
                {
                    Instantiate(NOTEHOLDERPREFAB, new Vector3((-6f + (i * jumpValue)), 3f, 0), Quaternion.identity);
                }


            }
            else
            {
                Instantiate(NOTEHOLDERPREFAB, new Vector3((-6f + ((i - correction) * jumpValue)), -1.04f, 0), Quaternion.identity);
            }



            /*
            if (i <= 8)
            {
                Instantiate(NOTEHOLDERPREFAB, new Vector3((-6f + (i * 1.5f)), 3f, 0), Quaternion.identity);
            }
            else {
                Instantiate(NOTEHOLDERPREFAB, new Vector3((-6f + ((i - 9f) * 1.5f)), -1.04f, 0), Quaternion.identity);
            }
            */


        }

       
    }
    /*
    void DEBUGFUNC()
    {

        for (int i = 0; i <= 15; i++)
        {
            // Debug.Log("index is at " + i);

            for (int x = 0; x <= 14; x++)
            {
                // NoteList.transform.GetChild(i).transform.GetChild(x).gameObject.SetActive(false);
                GameObject first = NoteList.transform.GetChild(i).gameObject;
                //Debug.Log("index x is " + x);
                first.transform.GetChild(x).transform.GetComponent<NoteScript>().NEXTNOTE();
            }
        }

    }
    */

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
