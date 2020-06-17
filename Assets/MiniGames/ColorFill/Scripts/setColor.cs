using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setColor : MonoBehaviour
{
    //public Color ColorSelected;
    GameObject manager;
    ColorFill_GameManager managerScript;

    void Start()
    {
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<ColorFill_GameManager>();
        //ColorSelected = managerScript.selectedColor;
    }

    public void setColorPart()
    {
        GetComponent<Image>().color = managerScript.selectedColor;
    }
}
