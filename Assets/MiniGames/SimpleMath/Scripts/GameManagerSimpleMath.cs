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
    public int previousSeed = 8;
    public GameObject bonneReponse;
    public GameObject mauvaiseReponse;
    public GameObject goNext;

    public AudioClip Bravo;
    public AudioClip TryAgain;

    void Start()
    {
        nouveauCalcul();
    }

    private void nouveauCalcul()
    {
        seedCalcul = Random.Range(1, 7);
        
        if(seedCalcul != previousSeed)
        {
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
        else
        {
            nouveauCalcul();
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
            AudioSource.PlayClipAtPoint(Bravo, Camera.main.transform.position);
            goNext.SetActive(true);
        }
        else
        {
            AudioSource.PlayClipAtPoint(TryAgain, Camera.main.transform.position);
            mauvaiseReponse.SetActive(true);
            bonneReponse.SetActive(false);
        }
    }
    public void goToNext()
    {
        bonneReponse.SetActive(false);
        mauvaiseReponse.SetActive(false);
        goNext.SetActive(false);
        addPack1.SetActive(false);
        addPack2.SetActive(false);
        addPack3.SetActive(false);
        sousPack1.SetActive(false);
        sousPack2.SetActive(false);
        sousPack3.SetActive(false);
        setReponseSous1.SetActive(false);
        setReponseAdd1.SetActive(false);
        previousSeed = seedCalcul;
        nouveauCalcul();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMenu()
    {
        SceneManager.UnloadSceneAsync("SimpleMath");
    }
}
