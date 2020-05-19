using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryQuiz : MonoBehaviour
{
    public GameObject quizBad1, quizBad2;
    public GameObject quizGood;
    public GameObject activePart;
    public GameObject nextButton;
    public GameObject nextPart;

    private Button goodBtn;
    private Button badBtn1;
    private Button badBtn2;
    private Button nextBtn;
    
    void Start()
    {
        minigameStart();

        goodBtn = quizGood.transform.GetComponent<Button>();
        goodBtn.onClick.AddListener(OnClickGood);

        badBtn1 = quizBad1.transform.GetComponent<Button>();
        badBtn1.onClick.AddListener(OnClickBad);

        badBtn2 = quizBad2.transform.GetComponent<Button>();
        badBtn2.onClick.AddListener(OnClickBad);

        nextBtn = nextButton.transform.GetComponent<Button>();
        nextBtn.onClick.AddListener(OnClickNext);

        nextButton.SetActive(false);
    }

    private void minigameStart()
    {
        activePart.SetActive(true);
    }

    private void OnClickGood()
    {
        quizGood.SetActive(true);
        quizBad1.SetActive(false);
        quizBad2.SetActive(false);
        nextButton.SetActive(true);
    }

    private void OnClickBad()
    {
        nextButton.SetActive(false);
    }

    private void OnClickNext()
    {
        activePart.SetActive(false);
        nextPart.SetActive(true);
    }
}
