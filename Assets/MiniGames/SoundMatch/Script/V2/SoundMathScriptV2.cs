using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMathScriptV2 : MonoBehaviour
{
    //public image and sprite data
    public Sprite CHAT;
    public Sprite CHIEN;
    public Sprite FLUTE;
    public Sprite GUITARE;
    public Sprite PIANO;
    public Sprite TIGRE;
    private Sprite CorrectSprite;

    public AudioClip CHATSON;
    public AudioClip CHIENSON;
    public AudioClip FLUTESON;
    public AudioClip GUITARESON;
    public AudioClip PIANOSON;
    public AudioClip TIGRESON;


    private Sprite tempSprite;
    private AudioClip tempAudio;

    private GameObject btnObject1;
    private GameObject btnObject2;
    private GameObject btnObject3;

    private Button btn1;
    private Button btn2;
    private Button btn3;

    private Button NextButton;
    private GameObject NextButtonObject;

    private Button SoundButton;
    private GameObject SoundButtonObject;

    // private string CorrectAnswer;
    // private float lastAnswer = 0f;

    private Sprite CorrectAnswerSprite;
    private AudioClip CorrectAnswerAudio;
    private Sprite LastAnswerSprite;
    private bool preventData = false;
    

    // Start is called before the first frame update
    void Start()
    {

        btnObject1 = GameObject.Find("Button1");
        btnObject2 = GameObject.Find("Button2");
        btnObject3 = GameObject.Find("Button3");
        btn1 = GameObject.Find("Button1").GetComponent<Button>();
        btn2 = GameObject.Find("Button2").GetComponent<Button>();
        btn3 = GameObject.Find("Button3").GetComponent<Button>();
        NextButton = GameObject.Find("Next").GetComponent<Button>();
        NextButtonObject = GameObject.Find("Next");
        SoundButtonObject = GameObject.Find("SoundButton");
        SoundButton = GameObject.Find("SoundButton").GetComponent<Button>();

        //Listeners
        NextButton.onClick.AddListener(OnNextClick);
        SoundButton.onClick.AddListener(OnSoundClick);
        btn1.onClick.AddListener(OnBtn1Click);
        btn2.onClick.AddListener(OnBtn2Click);
        btn3.onClick.AddListener(OnBtn3Click);


        btnObject1.SetActive(false);
        btnObject2.SetActive(false);
        btnObject3.SetActive(false);
        SoundButtonObject.SetActive(false);

        


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")) {
            CorrectAnswerSprite = CHAT;
            preventData = true;
            d6Roll();
            Debug.Log("test temp sprite value is " + tempSprite);
        }

    }

    void StopAllAudio() {
        SoundButtonObject.GetComponent<AudioSource>().Stop();
        btnObject1.GetComponent<AudioSource>().Stop();
        btnObject2.GetComponent<AudioSource>().Stop();
        btnObject3.GetComponent<AudioSource>().Stop();
    }

    void d6Roll()
    {
        tempSprite = null;
        tempAudio = null;
        float value = Mathf.Round(Random.Range(1f, 6f));


        // Debug.Log("Value is " + value);
       

            switch (value)
            {
                case 1f:
                // CorrectAnswer = "Chat";
                tempSprite = CHAT;
                tempAudio = CHATSON;

                if (preventData == true)
                {
                    if (tempSprite == CorrectAnswerSprite || btnObject1.GetComponent<Image>().sprite == CHAT || btnObject2.GetComponent<Image>().sprite == CHAT || btnObject3.GetComponent<Image>().sprite == CHAT)
                    {
                        d6Roll();
                    }
                   
                }
               

                    break;

                case 2f:

                tempSprite = CHIEN;
                tempAudio = CHIENSON;
                if (preventData == true)
                {
                    if (tempSprite == CorrectAnswerSprite || btnObject1.GetComponent<Image>().sprite == CHIEN || btnObject2.GetComponent<Image>().sprite == CHIEN || btnObject3.GetComponent<Image>().sprite == CHIEN)
                    {
                        d6Roll();
                    }
                   
                }
                
                break;

                case 3f:
                tempSprite = FLUTE;
                tempAudio = FLUTESON;
                if (preventData == true)
                {
                    if (tempSprite == CorrectAnswerSprite || btnObject1.GetComponent<Image>().sprite == FLUTE || btnObject2.GetComponent<Image>().sprite == FLUTE || btnObject3.GetComponent<Image>().sprite == FLUTE)
                    {
                        d6Roll();
                    }
                    
                }
                
                break;

                case 4f:
                tempSprite = GUITARE;
                tempAudio = GUITARESON;
                if (preventData == true)
                {
                    if (tempSprite == CorrectAnswerSprite || btnObject1.GetComponent<Image>().sprite == GUITARE || btnObject2.GetComponent<Image>().sprite == GUITARE || btnObject3.GetComponent<Image>().sprite == GUITARE)
                    {
                        d6Roll();
                    }
                   
                }
               
                break;

                case 5f:
                tempSprite = PIANO;
                tempAudio = PIANOSON;
                if (preventData == true)
                {
                    if (tempSprite == CorrectAnswerSprite || btnObject1.GetComponent<Image>().sprite == PIANO || btnObject2.GetComponent<Image>().sprite == PIANO || btnObject3.GetComponent<Image>().sprite == PIANO)
                    {
                        d6Roll();
                    }
                   
                }
                
                break;

                case 6f:
                tempSprite = TIGRE;
                tempAudio = TIGRESON;
                if (preventData == true)
                {
                    if (tempSprite == CorrectAnswerSprite || btnObject1.GetComponent<Image>().sprite == TIGRE || btnObject2.GetComponent<Image>().sprite == TIGRE || btnObject3.GetComponent<Image>().sprite == TIGRE)
                    {
                        d6Roll();
                    }
                   
                }
               
                break;

                default:
                    Debug.Log("correct answer roll went wrong");
                    break;
            }
        
        
        
       
    }

    void OnBtn1Click() {
        StopAllAudio();
        btnObject1.GetComponent<AudioSource>().Play();
        if (btnObject1.GetComponent<Image>().sprite == CorrectAnswerSprite) {
            Debug.Log("Good Answer!");
            NextButtonObject.SetActive(true);
        }
    }

    void OnBtn2Click()
    {
        StopAllAudio();
        btnObject2.GetComponent<AudioSource>().Play();
        if (btnObject2.GetComponent<Image>().sprite == CorrectAnswerSprite)
        {
            Debug.Log("Good Answer!");
            NextButtonObject.SetActive(true);
        }
    }

    void OnBtn3Click()
    {
        StopAllAudio();
        btnObject3.GetComponent<AudioSource>().Play();
        if (btnObject3.GetComponent<Image>().sprite == CorrectAnswerSprite)
        {
            Debug.Log("Good Answer!");
            NextButtonObject.SetActive(true);
        }
    }

    void OnSoundClick() {

        StopAllAudio();
        SoundButtonObject.GetComponent<AudioSource>().Play();
    }

    void OnNextClick() {
        // float value = Mathf.Round(Random.range(1f, 6f));
        btnObject1.SetActive(true);
        btnObject2.SetActive(true);
        btnObject3.SetActive(true);
        SoundButtonObject.SetActive(true);

        d6Roll();
        CorrectAnswerSprite = tempSprite;
        CorrectAnswerAudio = tempAudio;
        preventData = true;

        if (CorrectAnswerSprite != LastAnswerSprite)
        {
            /*
            d6Roll();
            btnObject1.GetComponent<Image>().sprite = tempSprite;
            btnObject1.GetComponent<AudioSource>().clip = tempAudio;

            d6Roll();
            btnObject2.GetComponent<Image>().sprite = tempSprite;
            btnObject2.GetComponent<AudioSource>().clip = tempAudio;

            d6Roll();
            btnObject3.GetComponent<Image>().sprite = tempSprite;
            btnObject3.GetComponent<AudioSource>().clip = tempAudio;
            */



            float CorrectButton = Mathf.Round(Random.Range(1f, 3f));
            switch (CorrectButton)
            {
                case 1f:
                    btnObject1.GetComponent<Image>().sprite = CorrectAnswerSprite;
                    btnObject1.GetComponent<AudioSource>().clip = CorrectAnswerAudio;

                    d6Roll();
                    btnObject2.GetComponent<Image>().sprite = tempSprite;
                    btnObject2.GetComponent<AudioSource>().clip = tempAudio;

                    d6Roll();
                    btnObject3.GetComponent<Image>().sprite = tempSprite;
                    btnObject3.GetComponent<AudioSource>().clip = tempAudio;
                    break;

                case 2f:
                    btnObject2.GetComponent<Image>().sprite = CorrectAnswerSprite;
                    btnObject2.GetComponent<AudioSource>().clip = CorrectAnswerAudio;

                    d6Roll();
                    btnObject1.GetComponent<Image>().sprite = tempSprite;
                    btnObject1.GetComponent<AudioSource>().clip = tempAudio;

                    d6Roll();
                    btnObject3.GetComponent<Image>().sprite = tempSprite;
                    btnObject3.GetComponent<AudioSource>().clip = tempAudio;
                    break;

                case 3f:
                    btnObject3.GetComponent<Image>().sprite = CorrectAnswerSprite;
                    btnObject3.GetComponent<AudioSource>().clip = CorrectAnswerAudio;

                    d6Roll();
                    btnObject1.GetComponent<Image>().sprite = tempSprite;
                    btnObject1.GetComponent<AudioSource>().clip = tempAudio;

                    d6Roll();
                    btnObject2.GetComponent<Image>().sprite = tempSprite;
                    btnObject2.GetComponent<AudioSource>().clip = tempAudio;
                    break;

                default:
                    Debug.Log("Something is acting up");
                    break;
            }
            




        }
        else {
            OnNextClick();
        }
        SoundButtonObject.GetComponent<AudioSource>().clip = CorrectAnswerAudio;
        Debug.Log("Correct answer is " + CorrectAnswerSprite);
        preventData = false;
        StopAllAudio();
        SoundButtonObject.GetComponent<AudioSource>().Play();


        NextButtonObject.SetActive(false);
    }
}
