using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryQuizHomePage : MonoBehaviour
{
    public GameObject story1Btn, story2Btn, story3Btn;
    public GameObject story1, story2, story3;
    public GameObject homePage;

    private Button s1Btn;
    private Button s2Btn;
    private Button s3Btn;

    void Start()
    {
        s1Btn = story1Btn.transform.GetComponent<Button>();
        s1Btn.onClick.AddListener(OnClickBook1);

        s2Btn = story2Btn.transform.GetComponent<Button>();
        s2Btn.onClick.AddListener(OnClickBook2);

        s3Btn = story3Btn.transform.GetComponent<Button>();
        s3Btn.onClick.AddListener(OnClickBook3);
    }
    
    private void OnClickBook1()
    {
        homePage.SetActive(false);
        story1.SetActive(true);
    }

    private void OnClickBook2()
    {
        homePage.SetActive(false);
        story2.SetActive(true);
    }

    private void OnClickBook3()
    {
        homePage.SetActive(false);
        story3.SetActive(true);
    }

    public void GoToMenu()
    {
        SceneManager.UnloadSceneAsync("StoryQuiz");
    }
}
