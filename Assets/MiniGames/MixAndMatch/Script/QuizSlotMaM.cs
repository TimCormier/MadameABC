using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuizSlotMaM : MonoBehaviour, IDropHandler
{

    GameObject manager;
    MixAndMatchGameManager managerScript;

    public int typeBox;

    public GameObject yeah;

    private void Start()
    {
        manager = GameObject.Find("MixAndMatchGameManager");
        managerScript = manager.GetComponent<MixAndMatchGameManager>();

        if (this.gameObject.name == "BoxNumbers")
        {
            typeBox = 1;

        }
        else
        {
            typeBox = 2;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
       // Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }

        if(typeBox == 1)
        {
            if (eventData.pointerDrag.tag == "Number")
            {
                //eventData.pointerDrag.SetActive(false);
                managerScript.goodAnswersN = managerScript.goodAnswersN + 1;
                testVictoire();
            }
        }

        if (typeBox == 2)
        {
            if (eventData.pointerDrag.tag == "Letter")
            {
                // eventData.pointerDrag.SetActive(false);
                managerScript.goodAnswersL = managerScript.goodAnswersL + 1;
                testVictoire();
            }
        }
    }

    private void testVictoire()
    {
        if(managerScript.goodAnswersN == 3 && managerScript.goodAnswersL == 3)
        {
            yeah.SetActive(true);
        }
    }
}
