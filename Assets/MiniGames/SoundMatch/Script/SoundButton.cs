using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class SoundButton : MonoBehaviour
{
    //audioclip bank
    public AudioClip chat, chien, guitare, flute, piano, tigre;
    //sound button
    private AudioSource[] allAudioSources;
    private Button button { get { return GetComponent<Button>(); } }
    //stop all audio script
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioSource playingSound;
    //access to the gamemanger script
    GameObject manager;
    GameManagerSoundMatch managerScript;
    //previous and actual sound
    public AudioSource previousSound;
    public AudioSource actualSound { get { return GetComponent<AudioSource>(); } }

 

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
                if (previousSound != null)
                {
                    actualSound.PlayOneShot(chat);
                    StopSound();
                }
                else
                {
                    actualSound.PlayOneShot(chat);
                    previousSound = actualSound;
                }
                break;
            case 2:
                if (previousSound != null)
                {
                    actualSound.PlayOneShot(chien);
                    StopSound();
                }
                else
                {
                    actualSound.PlayOneShot(chien);
                    previousSound = actualSound;
                }
                break;
            case 3:
                if (previousSound != null)
                {
                    StopSound();
                    actualSound.PlayOneShot(guitare);
                }
                else
                {
                    actualSound.PlayOneShot(guitare);
                    previousSound = actualSound;
                }
                break;
            case 4:
                if (previousSound != null)
                {
                    StopSound();
                    actualSound.PlayOneShot(flute);
                }
                else
                {
                    actualSound.PlayOneShot(flute);
                    previousSound = actualSound;
                }
                break;
            case 5:
                if (previousSound != null)
                {
                    StopSound();
                    actualSound.PlayOneShot(piano);
                }
                else
                {
                    actualSound.PlayOneShot(piano);
                    previousSound = actualSound;
                }
                break;
            case 6:
                if (previousSound != null)
                {
                    StopSound();
                    actualSound.PlayOneShot(tigre);
                }
                else
                {
                    actualSound.PlayOneShot(tigre);
                    previousSound = actualSound;
                }
                break;
        }
    }

    public void SetCat()
    {
        if (previousSound != null)
        {
            StopSound();
            actualSound.Play();
            managerScript.answer = 1;
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetDog()
    {
        if (previousSound != null)
        {
            StopSound();
            actualSound.Play();
            managerScript.answer = 1;
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetGuitare()
    {
        if (previousSound != null)
        {
            StopSound();
            actualSound.Play();
            managerScript.answer = 1;
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetFlute()
    {
        if (previousSound != null)
        {
            StopSound();
            actualSound.Play();
            managerScript.answer = 1;
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetPiano()
    {
        if (previousSound != null)
        {
            StopSound();
            actualSound.Play();
            managerScript.answer = 1;
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetTiger()
    {
        if (previousSound != null)
        {
            StopSound();
            actualSound.Play();
            managerScript.answer = 1;
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }

    }

    public void StopSound()
    {
        if (previousSound != null)
        {
            previousSound.Stop();
            previousSound = actualSound;

            AudioSource[] audios = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (AudioSource aud in audios)
                aud.volume = 0;

            actualSound.volume = 1;
            actualSound.Play();
        }

    }
}
