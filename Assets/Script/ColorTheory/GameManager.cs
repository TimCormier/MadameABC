using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Jaune = 0f;
    public float Rouge = 0f;
    public float Bleu = 0f;
    public float Mauve = 0f;
    public float Orange = 0f;
    public float Vert = 0f;

    public void Update()
    {
        if (Jaune > 1)
        {
            Jaune -= 1;
        }

        if (Rouge > 1)
        {
            Rouge -= 1;
        }

        if (Bleu > 1)
        {
            Bleu -= 1;
        }

        if (Mauve > 1)
        {
            Mauve -= 1;
        }

        if (Orange > 1)
        {
            Orange -= 1;
        }

        if (Vert > 1)
        {
            Vert -= 1;
        }

        if (Bleu == 1 && Rouge == 1)
        {
            Mauve += 1;
        }

        if (Jaune == 1 && Rouge == 1)
        {
            Orange += 1;
        }

        if (Bleu == 1 && Jaune == 1)
        {
            Vert += 1;
        }
    }

    public void AjoutJaune()
    {
        Jaune += 1;
    }

    public void AjoutRouge()
    {
        Rouge += 1;
    }

    public void AjoutBleu()
    {
        Bleu += 1;
    }
}
