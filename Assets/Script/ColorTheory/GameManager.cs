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

    public float RepMauve = 0f;
    public float RepOrange = 0f;
    public float RepVert = 0f;

    public GameObject CouleurJaune;
    public GameObject CouleurRouge;
    public GameObject CouleurBleu;
    public GameObject CouleurMauve;
    public GameObject CouleurOrange;
    public GameObject CouleurVert;
    public GameObject MauveAnswer;
    public GameObject OrangeAnswer;
    public GameObject VertAnswer;

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

        if (Bleu == 1 && Jaune == 0 && Rouge == 0)
        {
            CouleurJaune.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurMauve.SetActive(false);
            CouleurOrange.SetActive(false);
            CouleurVert.SetActive(false);
            CouleurBleu.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 1 && Rouge == 0)
        {
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurMauve.SetActive(false);
            CouleurOrange.SetActive(false);
            CouleurVert.SetActive(false);
            CouleurJaune.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 0 && Rouge == 1)
        {
            CouleurBleu.SetActive(false);
            CouleurJaune.SetActive(false);
            CouleurMauve.SetActive(false);
            CouleurOrange.SetActive(false);
            CouleurVert.SetActive(false);
            CouleurRouge.SetActive(true);
        }

        if (Bleu == 1 && Jaune == 0 && Rouge == 1)
        {
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurJaune.SetActive(false);
            CouleurOrange.SetActive(false);
            CouleurVert.SetActive(false);
            CouleurMauve.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 1 && Rouge == 1)
        {
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurJaune.SetActive(false);
            CouleurMauve.SetActive(false);
            CouleurVert.SetActive(false);
            CouleurOrange.SetActive(true);
        }

        if (Bleu == 1 && Jaune == 1 && Rouge == 0)
        { 
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurJaune.SetActive(false);
            CouleurOrange.SetActive(false);
            CouleurMauve.SetActive(false);
            CouleurVert.SetActive(true);
        }

        if (Bleu == 0 && Jaune == 0 && Rouge == 0)
        {
            CouleurBleu.SetActive(false);
            CouleurRouge.SetActive(false);
            CouleurJaune.SetActive(false);
            CouleurOrange.SetActive(false);
            CouleurMauve.SetActive(false);
            CouleurVert.SetActive(false);
        }

        if (Bleu == 1 && Jaune == 1 && Rouge == 1)
        {
            Recommencer();
        }

        if (RepMauve == 1 && Bleu == 1 && Rouge == 1)
        {
            Victory();
        }

        if (RepOrange == 1 && Jaune == 1 && Rouge == 1)
        {
            Victory();
        }

        if (RepVert == 1 && Bleu == 1 && Jaune == 1)
        {
            Victory();
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

    public void Recommencer()
    {
        Jaune = 0;
        Rouge = 0;
        Bleu = 0;
        Mauve = 0;
        Orange = 0;
        Vert = 0;
    }

    public void Victory()
    {

    }
}
