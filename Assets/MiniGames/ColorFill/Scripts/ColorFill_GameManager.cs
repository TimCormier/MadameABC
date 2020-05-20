using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorFill_GameManager : MonoBehaviour
{
    public Color selectedColor;

    public GameObject Humain;
    public GameObject Cat;
    public GameObject Oiseau;
    public GameObject Bateau;

    public GameObject playAgainButton;
    public GameObject nextDraw;

    //array des couleurs
    public Component[] HumanColors;

    public int currentDraw = 1;
    public int isColored = 0;
    public int currentFilled = 0;

    private void Start()
    {
        selectedColor = Color.white;
        replay();
        HumanColors = Humain.GetComponentsInChildren<Image>();
        foreach (Image image in HumanColors)
            image.color = Color.white;
    }

    //reset
    private void replay()
    {
        Humain.SetActive(false);
        Cat.SetActive(false);
        Oiseau.SetActive(false);
        Bateau.SetActive(false);
        selectedColor = Color.white;
        currentDraw = 1;
        goNextDraw();
    }

    //set color with button

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

    //check if drawing is full
    public void isFull()
    {
        if (selectedColor != Color.white)
        { 
           if (currentFilled == isColored)
               {
                 currentDraw = currentDraw + 1;
                 currentFilled = 1;
                 nextDraw.SetActive(true);
               }

            foreach (Image image in HumanColors)
                if (image.color != Color.white)
                {
                    if (currentFilled != isColored && image.color != Color.white)
                    {

                        currentFilled = currentFilled + 1;
                    }

                }
        }
        
    }

    //go next draw
    public void goNextDraw()
    {
        switch (currentDraw)
        {
            case 1:
                Bateau.SetActive(false);
                Humain.SetActive(true);
                isColored = 5;
                nextDraw.SetActive(false);
                break;
            case 2:
                Cat.SetActive(true);
                Humain.SetActive(false);
                isColored = 5;
                nextDraw.SetActive(false);

                break;
            case 3:
                Cat.SetActive(false);
                Oiseau.SetActive(true);
                nextDraw.SetActive(false);

                isColored = 6;
                break;
            case 4:
                Oiseau.SetActive(false);
                Bateau.SetActive(true);
                nextDraw.SetActive(false);
                isColored = 4;
                break;
            case 5:
                replay();
                break;
        }
    }
}
