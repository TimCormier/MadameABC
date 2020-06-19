using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTapRythme : MonoBehaviour
{
    public float speed = 1;


    public void setSpeedSlow()
    {
        speed = 0.5f;
    }
    public void setSpeedMedium()
    {
        speed = 1f;
    }
    public void setSpeedFast()
    {
        speed = 1.5f;
    }

    void Update()
    {
        
       for (int j = 0; j < this.transform.childCount; j++)
       {                 
           this.transform.GetChild(j).transform.Translate(Vector3.left * speed);
        }
    }
}
