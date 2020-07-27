using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeAlterning : MonoBehaviour
{
    public Component rt;

    public float baseHeight = 0;
    public float baseWidth = 0;

    public float maxHeight = 0;
    public float maxWidth = 0;

    public float currentHeight = 0;
    public float currentWidth = 0;

    public bool widthIncrease;
    //public bool widthDecrease;

    public bool heightIncrease;
    //public bool heightDecrease;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
        

        maxHeight = baseHeight * 3;
        maxWidth = baseWidth * 3;

        widthIncrease = true;
        heightIncrease = true;

        currentWidth = baseWidth -1;
        currentHeight = baseHeight -1;

    }

    private void Update()
    {
        rt.GetComponent<RectTransform>().sizeDelta = new Vector2(currentWidth, currentHeight);

        if (heightIncrease == false && heightIncrease == true)
        {
            Debug.Log("Increase");

            HeightDrop();
            if (currentHeight < baseHeight)
            {
                heightIncrease = true;
                
            }
        }

        if (heightIncrease == true && heightIncrease == false)
        {
            Debug.Log("Drop");
            HeightBoost();
            if (currentHeight < maxHeight)
            {
                heightIncrease = false;
            }
        }

        if (currentWidth < maxWidth && widthIncrease == false)
        {
            
            WidthBoost();
            widthIncrease = true;
        }

        if (currentWidth > maxWidth && widthIncrease == true)
        {
            
            WidthDrop();
            widthIncrease = false;
        }
    }

    public void WidthDrop()
    {
        currentWidth -= 5;
    }

    public void WidthBoost()
    {
        currentWidth += 5;
    }

    public void HeightDrop()
    {
        currentHeight -= 5;
    }

    public void HeightBoost()
    {
        currentHeight += 5;
    }
}

