using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CastleScript : MonoBehaviour
{

    public Camera MAINCAM;
    public Camera PROFILECAM;
    public Camera REDCINEMATICCAM;
    public Camera BLUECINEMATICCAM;
    public Camera SELECTIONCAM;

    private GameObject BLUETURNSWITCH;
    private GameObject REDTURNSWITCH;

    public GameObject CANNONBALL;
    private GameObject MANAGER;

    private GameObject KingSquareRed;
    private GameObject KingSquareBlue;
    private GameObject KingTriggerRed;
    private GameObject KingTriggerBlue;

    float cannonforce = 0;
    float cannoninput = 0;
    public float strength;
    private GameObject POWERBAR;

    private GameObject FireButton;
    private GameObject FireButtonVisual;
    public Sprite BtnUp;
    public Sprite BtnDown;

    private bool win = false;
    private bool camlock = false;
    // win is used to activate camlock after CYCLECAM() is called where camlock prevents CYCLECAM() from executing its code
    private Text wintext;
    private GameObject wintextobject;

    private bool turn = true;
    // false for blue, true for red
    // this stores who's turn it was *last*, since blue always starts, this is set to true so blue doesnt play twice at the beginning


    private Button btnMenu;
    private Button btnReplay;
    private GameObject menuObject;
    private GameObject replayObject;

    private GameObject SELECTIONARROW;

    // Start is called before the first frame update
    void Start()
    {

        //MAINCAM = GameObject.Find("MainCamera");
        //Selection Ui

        SELECTIONARROW = GameObject.Find("SelectionUp_blue");
        SELECTIONARROW.transform.GetComponent<SelectionScript>().INITIATE();
        wintextobject = GameObject.Find("WinText");
        wintext = GameObject.Find("WinText").GetComponent<Text>();
        MANAGER = GameObject.Find("GameManager");
        KingSquareBlue = GameObject.Find("KingSquareBlue");
        KingSquareRed = GameObject.Find("KingSquareRed");
        KingTriggerRed = GameObject.Find("KingTriggerRed");
        KingTriggerBlue = GameObject.Find("KingTriggerBlue");
        POWERBAR = GameObject.Find("PowerBar");
        FireButton = GameObject.Find("FireButton");
        FireButtonVisual = GameObject.Find("FireButton_visual");
        PROFILECAM.enabled = false;
        REDCINEMATICCAM.enabled = false;
        BLUECINEMATICCAM.enabled = false;
        BLUETURNSWITCH = GameObject.Find("BlueTurnDetector");
        REDTURNSWITCH = GameObject.Find("RedTurnDetector");
        btnMenu = GameObject.Find("MenuButton").GetComponent<Button>();
        btnReplay = GameObject.Find("ReplayButton").GetComponent<Button>();
        menuObject = GameObject.Find("MenuButton");
        replayObject = GameObject.Find("ReplayButton");

        btnMenu.onClick.AddListener(MenuClick);
        btnReplay.onClick.AddListener(ReplayClick);

        //TURNBLUE();
        CYCLECAM("SELECTIONCAM");
        //this TURNBLUE() is for testing purposes;

        

    }

    void MenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void ReplayClick() {
        SceneManager.LoadScene("CastleBattle");
    }

    // Update is called once per frame
    void Update()
    {
        //test key
        if (Input.GetKey("space")) {
            //TURNBLUE();
            // =======> THIS IS IMPORTANT Debug.Log(MAINCAM.transform.eulerAngles.y);
            // EulerAngles dont really work with negatives, a -10 value is like 360 - 10, which results in a eulerAngle value of 350f
            // Debug.Log(20f * -1f);
            CYCLECAM("SELECTIONCAM");
        }
        //end test key

        //SHOOTING START
        // Using the "a" key was mainly for developpment purposes, this should be disabled later

        if (GameObject.Find("Cannonball(Clone)") == null) {
            if (Input.GetKey("a"))
            {

                /*
                cannonforce += 1f;
                if (cannonforce > 100f) {
                    cannonforce = 100f;
                }

        */

                cannoninput += strength;
                cannonforce = Mathf.Sin(cannoninput);
               // Debug.Log("cannonforce is " + cannonforce);
                POWERBAR.transform.localScale = new Vector2(cannonforce, 1f);

            }
            if (Input.GetKeyUp("a"))
            {
                Vector3 temprot = MAINCAM.transform.rotation.eulerAngles + new Vector3(0, 15f, 0);
                Instantiate(CANNONBALL, MAINCAM.transform.position, Quaternion.Euler(temprot));

                GameObject temp = GameObject.Find("Cannonball(Clone)");
                Rigidbody temprb = temp.transform.GetComponent<Rigidbody>();
                // temp.transform.rotation.y += 15f;

                if (cannonforce < 0)
                {
                    temprb.AddRelativeForce(transform.forward * ((cannonforce * -1) * 10000f));
                }
                else
                {
                    temprb.AddRelativeForce(transform.forward * (cannonforce * 10000f));
                }

                cannonforce = 0f;
                cannoninput = 0f;
            }
        }

        //SHOOTING END

        //test
        /*if (Input.GetKey("space")) {
            MAINCAM.transform.Rotate(2f, 2f, 0);

        
       */
       /*
        if (MAINCAM.transform.rotation.y > 50) {
            Debug.Log("Camera out of bounds from RIGHT boundary");
            MAINCAM.transform.eulerAngles = new Vector3(MAINCAM.transform.rotation.x, 50, MAINCAM.transform.rotation.z);
        }*/
    }

    //Fire Button Methods
    public void FIREBUTTONDOWN() {
        //Debug.Log("Fire Button Down");
        cannoninput += strength;
        cannonforce = Mathf.Sin(cannoninput);
        POWERBAR.transform.localScale = new Vector2(cannonforce, 1f);
    }
    public void FIREBUTTONUP() {
        // Debug.Log("Fire Button Up");
        CYCLECAM("PROFILECAM");
        Vector3 temprot = MAINCAM.transform.rotation.eulerAngles + new Vector3(-5f, 0, 0);
        // Instantiate(CANNONBALL, MAINCAM.transform.position, Quaternion.Euler(temprot));
        Instantiate(CANNONBALL, MAINCAM.transform.position, MAINCAM.transform.rotation);

        GameObject temp = GameObject.Find("Cannonball(Clone)");
        Rigidbody temprb = temp.transform.GetComponent<Rigidbody>();
        

        if (cannonforce < 0)
        {
            temprb.AddRelativeForce(transform.forward * ((cannonforce * -1) * 10000f));
        }
        else
        {
            temprb.AddRelativeForce(transform.forward * (cannonforce * 10000f));
        }

        cannonforce = 0f;
        cannoninput = 0f;

        GameObject.Find("SoundEffectKeeper").transform.GetComponent<AudioSource>().Stop();
        GameObject.Find("SoundEffectKeeper").transform.GetComponent<AudioSource>().Play();
    }




    //Turn Methods
    public void CHANGETURNS() {
        if (turn == false)
        {
            TURNBLUE();
            turn = true;
        }
        else {
            TURNRED();
            turn = false;
        }
    }

 public void TURNBLUE() {
        if (GameObject.Find("SelectionCam") != null) {
            Destroy(GameObject.Find("SelectionCam"));
        }
        //Called when it's blue player(Player2)'s turn
        REDTURNSWITCH.SetActive(false);
        BLUETURNSWITCH.SetActive(true);
        MAINCAM.transform.position = KingSquareBlue.transform.position + new Vector3(0f, 20f, 0f);
        // MAINCAM.transform.Rotate(0, 0, 0);
        MAINCAM.transform.eulerAngles = new Vector3(0, 0, 0);
        CYCLECAM("MAINCAM");
    }

   public void TURNRED() {
        REDTURNSWITCH.SetActive(true);
        BLUETURNSWITCH.SetActive(false);
        MAINCAM.transform.position = KingSquareRed.transform.position + new Vector3(0f, 20f, 0f);
        // MAINCAM.transform.Rotate(0, 0, 0);
        MAINCAM.transform.eulerAngles = new Vector3(0, 180f, 0);
        CYCLECAM("MAINCAM");
    }

    //Camera Methods
    public void CYCLECAM(string TargetCam) {
        if (camlock == false) {

        
        for (int i = 1; i < GameObject.Find("Camera Container").transform.childCount; i++)
        {
            // i = Camera.allCameras.Length
           // Debug.Log("disabled camera " + GameObject.Find("Camera Container").transform.GetChild(i).transform.name);
            GameObject.Find("Camera Container").transform.GetChild(i).GetComponent<Camera>().enabled = false;

        }
        GameObject VCANVAS = GameObject.Find("Canvas (Visual)");
        GameObject CCANVAS = GameObject.Find("Canvas (Clickable)");
        for (int i = 0; i < VCANVAS.transform.childCount; i++) {
            //Debug.Log(VCANVAS.transform.GetChild(i).name);
            VCANVAS.transform.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 0; i < CCANVAS.transform.childCount; i++)
        {
            CCANVAS.transform.GetChild(i).gameObject.SetActive(false);
        }


        switch (TargetCam) {
            case "MAINCAM":
                MAINCAM.enabled = true;
                for (int i = 0; i < VCANVAS.transform.childCount - 5; i++)
                {
                    VCANVAS.transform.GetChild(i).gameObject.SetActive(true);
                }
                for (int i = 0; i < CCANVAS.transform.childCount; i++)
                {
                    CCANVAS.transform.GetChild(i).gameObject.SetActive(true);
                }
               
                break;

            case "PROFILECAM":
                PROFILECAM.enabled = true;
                break;

            case "REDCINEMATICCAM":
                REDCINEMATICCAM.enabled = true;
                break;

            case "BLUECINEMATICCAM":
                BLUECINEMATICCAM.enabled = true;
                break;

                case "SELECTIONCAM":
                    SELECTIONCAM.enabled = true;

                    for (int i = VCANVAS.transform.childCount; i > VCANVAS.transform.childCount - 5; i--)
                    {
                      //  Debug.Log("i is " + i);
                        VCANVAS.transform.GetChild(i - 1).gameObject.SetActive(true);
                    }

                    /*for (int i = CCANVAS.transform.childCount; i > CCANVAS.transform.childCount - 4; i--)
                    {
                      //  Debug.Log("i is " + i);
                        CCANVAS.transform.GetChild(i - 1).gameObject.SetActive(true);
                    }*/
                    break;


            default:
                Debug.Log("Could not find target camera, check your references");
                break;


        }

        }

        if (win == true) {
            wintextobject.SetActive(true);
            camlock = true;
            replayObject.SetActive(true);
            menuObject.SetActive(true);
            
        }

    }

    // Victory Methods

    public void WINBLUE() {
        win = true;
        CYCLECAM("REDCINEMATICCAM");
        wintext.text = "Le joueur bleu a gagné!";
        
    }

    public void WINRED() {
        win = true;
        CYCLECAM("BLUECINEMATICCAM");
        wintext.text = "Le joueur rouge a gagné!";
      
    }

    /*
    void ACTIVATEMAINCAM() {
        Camera.allCameras.enabled = false;
        MAINCAM.enabled = true;
    }

    void ACTIVATEPROFILECAM() {
        Camera.allCameras.enabled = false;
        PROFILECAM.enabled = true;
    }
    */
    }


    

