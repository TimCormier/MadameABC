using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorFill_GameManager : MonoBehaviour
{
    public Color selectedColor;

    public GameObject Humain;
    public GameObject Cat;
    public GameObject Oiseau;
    public GameObject Bateau;

    public GameObject allDraws;

    public GameObject playAgainButton;
    public GameObject nextDraw;

    //array des couleurs
    public Component[] HumanColors;
    public Component[] CatColors;
    public Component[] OiseauColors;
    public Component[] BateauColors;

    public int currentDraw = 1;
    public int activeDraw = 0;
    public int isColored = 0;
    public int currentFilled = 0;

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        selectedColor = Color.white;
        replay();
        HumanColors = Humain.GetComponentsInChildren<Image>();
        CatColors = Cat.GetComponentsInChildren<Image>();
        OiseauColors = Oiseau.GetComponentsInChildren<Image>();
        BateauColors = Bateau.GetComponentsInChildren<Image>();

        foreach (Image image in HumanColors)
            image.color = Color.white;
        foreach (Image imageCat in CatColors)
            imageCat.color = Color.white;
        foreach (Image imageOiseau in OiseauColors)
            imageOiseau.color = Color.white;
        foreach (Image imageBateau in BateauColors)
            imageBateau.color = Color.white;

    }

    //reset
    private void replay()
    {
        foreach (Image image in HumanColors)
            image.color = Color.white;
        foreach (Image imageCat in CatColors)
            imageCat.color = Color.white;
        foreach (Image imageOiseau in OiseauColors)
            imageOiseau.color = Color.white;
        foreach (Image imageBateau in BateauColors)
            imageBateau.color = Color.white;

        Humain.SetActive(false);
        Cat.SetActive(false);
        Oiseau.SetActive(false);
        Bateau.SetActive(false);
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
        currentFilled = 0;

        if (selectedColor != Color.white)
        { 
            switch (currentDraw)
            {
                case 1:
                    foreach (Image image in HumanColors)
                        if (image.color != Color.white)
                        {
                            if (currentFilled != isColored)
                            {

                                currentFilled = currentFilled + 1;
                            }

                        }
                    break;
                case 2:
                    foreach (Image imageCat in CatColors)
                        if (imageCat.color != Color.white)
                        {
                            if (currentFilled != isColored)
                            {

                                currentFilled = currentFilled + 1;
                            }

                        }
                    break;
                case 3:
                    foreach (Image imageOiseau in OiseauColors)
                        if (imageOiseau.color != Color.white)
                        {
                            if (currentFilled != isColored)
                            {

                                currentFilled = currentFilled + 1;
                            }

                        }
                    break;
                case 4:
                    foreach (Image imageBateau in BateauColors)
                        if (imageBateau.color != Color.white)
                        {
                            if (currentFilled != isColored)
                            {

                                currentFilled = currentFilled + 1;
                            }

                        }
                    break;
            }

            if (currentFilled == isColored && currentDraw == activeDraw)
            {
                currentDraw = currentDraw + 1;
                currentFilled = 0;
                nextDraw.SetActive(true);
            }
        }
        
    }

    //go next draw
    public void goNextDraw()
    {
        foreach (Image image in HumanColors)
            image.color = Color.white;
        foreach (Image imageCat in CatColors)
            imageCat.color = Color.white;
        foreach (Image imageOiseau in OiseauColors)
            imageOiseau.color = Color.white;
        foreach (Image imageBateau in BateauColors)
            imageBateau.color = Color.white;

        currentFilled = 0;
        switch (currentDraw)
        {
            case 1:
                activeDraw = 1;
                Bateau.SetActive(false);
                Humain.SetActive(true);
                isColored = 6;
                nextDraw.SetActive(false);
                break;
            case 2:
                activeDraw = 2;
                Cat.SetActive(true);
                Humain.SetActive(false);
                isColored = 5;
                nextDraw.SetActive(false);

                break;
            case 3:
                activeDraw = 3;
                Cat.SetActive(false);
                Oiseau.SetActive(true);
                nextDraw.SetActive(false);

                isColored = 6;
                break;
            case 4:
                activeDraw = 4;
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
