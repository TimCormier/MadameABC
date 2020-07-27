using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseMakeBigger : MonoBehaviour
{
    public Component rt;

    public float baseHeight;
    public float baseWidth;

    public float maxHeight;
    public float maxWidth;

    public float currentHeight;
    public float currentWidth;

    public float timer = 0;
    public bool timerBool;

    public void Start()
    {
        rt = GetComponent<RectTransform>();

        maxHeight = baseHeight * 2;
        maxWidth = baseWidth * 2;

        currentWidth = baseWidth;
        currentHeight = baseHeight;
        timerBool = false;

    }

    private void Update()
    {
        if(timerBool == true)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }


    }


    public void MouseOnIt()
    {
        timerBool = true;

        if (currentHeight < maxHeight && timer < 10)
        {

            GetBigger();
        }

    }

    public void GetBigger()
    {
        if(currentHeight < maxHeight && currentWidth < maxWidth)
        {
            Debug.Log("Work");
            rt.GetComponent<RectTransform>().sizeDelta = new Vector2(currentWidth + 12, currentHeight + 4);

        }

        
        
        //rt.GetComponent<RectTransform>().sizeDelta = new Vector2(maxWidth, maxHeight);
    }

    public void GetSmaller()
    {
        rt.GetComponent<RectTransform>().sizeDelta = new Vector2(baseWidth, baseHeight);
    }


    public void MouseNotOnIt()
    {
        timerBool = false;


    }
}

