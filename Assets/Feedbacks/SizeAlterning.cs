using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeAlterning : MonoBehaviour
{
    public Component rt;

    public float Height;
    public float Width;

    public float timer = 0;
    public float timeout = 10;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
        rt.GetComponent<RectTransform>().sizeDelta = new Vector2(500, 500);

    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeout)
        {
            timer -= timeout;
            rt.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
            timerReset();

        }
    }

    public void timerReset()
    {
        
        timer = 0;
        timeout = 10;
        rt.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
        Debug.Log("A");
    }
}
