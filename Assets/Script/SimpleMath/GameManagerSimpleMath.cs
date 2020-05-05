using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerSimpleMath : MonoBehaviour
{
    public GameObject addPack1, addPack2, addPack3;
    public GameObject sousPack1, sousPack2, sousPack3;
    public GameObject setReponseAdd1, setReponseSous1;
    private int seedCalcul;
    public int answer;
    public int goodAnswer;
    public GameObject bonneReponse;
    public GameObject mauvaiseReponse;
    public GameObject goNext;
   
    void Start()
    {
        seedCalcul = Random.Range(1, 7);

        switch (seedCalcul)
        {
            case 1:
                addPack1.SetActive(true);
                setReponseAdd1.SetActive(true);
                goodAnswer = 1;
                break;
            case 2:
                addPack2.SetActive(true);
                setReponseAdd1.SetActive(true);
                goodAnswer = 2;
                break;
            case 3:
                addPack3.SetActive(true);
                setReponseAdd1.SetActive(true);
                goodAnswer = 3;
                break;
            case 4:
                sousPack1.SetActive(true);
                setReponseSous1.SetActive(true);
                goodAnswer = 3;
                break;
            case 5:
                sousPack2.SetActive(true);
                setReponseSous1.SetActive(true);
                goodAnswer = 2;
                break;
            case 6:
                sousPack3.SetActive(true);
                setReponseSous1.SetActive(true);
                goodAnswer = 3;
                break;
        }
    }

    private void Update()
    {
        if (answer != goodAnswer)
        {
            goNext.SetActive(false);
        }
    }
    public void verification()
    {
        if (answer == goodAnswer)
        {
            bonneReponse.SetActive(true);
            mauvaiseReponse.SetActive(false);
            goNext.SetActive(true);
        }
        else
        {
            mauvaiseReponse.SetActive(true);
            bonneReponse.SetActive(false);
        }
    }
    public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
