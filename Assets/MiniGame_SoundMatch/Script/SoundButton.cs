﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class SoundButton : MonoBehaviour
{
    public AudioClip chat, chien, guitare;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    GameObject manager;
    GameManagerSoundMatch managerScript;

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.playOnAwake = false;
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<GameManagerSoundMatch>();
    }

    public void SetGoodAnswer()
    {
        switch (managerScript.goodAnswer)
        {
            case 1:
                source.PlayOneShot(chat);
                break;
            case 2:
                source.PlayOneShot(guitare);
                break;
            case 3:
                source.PlayOneShot(chien);
                break;
        }
    }

    public void SetCat()
    {
        source.PlayOneShot(chat);
        managerScript.answer = 1;
    }
    public void Setguitare()
    {
        source.PlayOneShot(guitare);
        managerScript.answer = 2;
    }
    public void SetDog()
    {
        source.PlayOneShot(chien);
        managerScript.answer = 3;
    }
   
}
