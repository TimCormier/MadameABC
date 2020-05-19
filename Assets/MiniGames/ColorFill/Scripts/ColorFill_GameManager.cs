using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFill_GameManager : MonoBehaviour
{
    public Color selectedColor;

    private void Start()
    {
        selectedColor = Color.white;
    }

    public void setRed()
    {
        selectedColor = Color.red;
    }
    public void setBlue()
    {
        selectedColor = Color.blue;
    }
    public void setYellow()
    {
        selectedColor = Color.yellow;
    }
    public void setGreen()
    {
        selectedColor = Color.green;
    }
    public void setOrange()
    {
        selectedColor = new Color(255,0,100,255);
    }

}
