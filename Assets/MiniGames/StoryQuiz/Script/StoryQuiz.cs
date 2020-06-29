using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryQuiz : MonoBehaviour
{
    //éléments de scène assignable
    public GameObject quizBad1, quizBad2;
    public GameObject quizGood;
    public GameObject activePart;
    public GameObject nextPart;

    //pour déclarer ce que font les boutons
    private Button goodBtn;
    private Button badBtn1;
    private Button badBtn2;

    //timer après réussite
    private int timeMax = 0;
    private int timerInt = 0;
    private bool timerActive = false;

    //Audio Clip de bonne réponse
    //public AudioClip goodClip;
    //AudioSource goodClipSource;
    
    void Start()
    {
        minigameStart();

        goodBtn = quizGood.transform.GetComponent<Button>();
        goodBtn.onClick.AddListener(OnClickGood);

        badBtn1 = quizBad1.transform.GetComponent<Button>();
        badBtn1.onClick.AddListener(OnClickBad);

        badBtn2 = quizBad2.transform.GetComponent<Button>();
        badBtn2.onClick.AddListener(OnClickBad);

        timerActive = false;
        timerInt = 0;

        //goodClipSource = GetComponent<AudioSource>();
    }

    private void minigameStart()
    {
        activePart.SetActive(true);
    }

    private void OnClickGood()
    {
        timerActive = true;
    }

    private void Update()
    {
        if(timerActive == true)
        {
            //goodClipSource.clip = goodClip;
            //goodClipSource.Play();
            //Debug.Log("Are you playing?");
            timerInt++;
            if(timerInt >= timeMax/*!goodClipSource.isPlaying*/)
            {
                timerActive = false;
                timerInt = 0;
                activePart.SetActive(false);
                nextPart.SetActive(true);
                Debug.Log("timed correctly");
            }
        }
    }

    private void OnClickBad()
    {
        //nothing is happening here until sound integration
    }
}