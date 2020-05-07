using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class SoundButton : MonoBehaviour
{
    //audioclip bank
    public AudioClip chaton, chien, guitare, flute, piano, tigre;
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
            case "chaton":
                if (previousSound != null)
                {
                    source.PlayOneShot(chaton);
                    StopSound();
                }
                else
                {
                    source.PlayOneShot(chaton);
                    previousSound = actualSound;
                }
                break;
            case "chien":
                if (previousSound != null)
                {
                    source.PlayOneShot(chien);
                    StopSound();
                }
                else
                {
                    source.PlayOneShot(chien);
                    previousSound = actualSound;
                }
                break;
            case "guitare":
                if (previousSound != null)
                {
                    StopSound();
                    source.PlayOneShot(guitare);
                }
                else
                {
                    source.PlayOneShot(guitare);
                    previousSound = actualSound;
                }
                break;
            case "flute":
                if (previousSound != null)
                {
                    StopSound();
                    source.PlayOneShot(flute);
                }
                else
                {
                    source.PlayOneShot(flute);
                    previousSound = actualSound;
                }
                break;
            case "piano":
                if (previousSound != null)
                {
                    StopSound();
                    source.PlayOneShot(piano);
                }
                else
                {
                    source.PlayOneShot(piano);
                    previousSound = actualSound;
                }
                break;
            case "tigre":
                if (previousSound != null)
                {
                    StopSound();
                    source.PlayOneShot(tigre);
                }
                else
                {
                    source.PlayOneShot(tigre);
                    previousSound = actualSound;
                }
                break;
        }
    }

    public void SetCat()
    {
        managerScript.answer = "chat";
        managerScript.Verification();

        if (previousSound != null)
        {
            actualSound.Play();
            StopSound();
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetDog()
    {
        managerScript.answer = "chien";
        managerScript.Verification();

        if (previousSound != null)
        {
            actualSound.Play();
            StopSound();
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetGuitare()
    {
        managerScript.answer = "guitare";
        managerScript.Verification();

        if (previousSound != null)
        {
            actualSound.Play();
            StopSound();
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetFlute()
    {
        managerScript.answer = "flute";
        managerScript.Verification();

        if (previousSound != null)
        {
            actualSound.Play();
            StopSound();
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetPiano()
    {
        managerScript.answer = "piano";
        managerScript.Verification();

        if (previousSound != null)
        {
            actualSound.Play();
            StopSound();
        }
        else
        {
            actualSound.Play();
            previousSound = actualSound;
        }
    }
    public void SetTiger()
    {
        
        managerScript.answer = "tigre";
        managerScript.Verification();
        if (previousSound != null)
        {
            actualSound.Play();
            StopSound();
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
            source.volume = 0;

            actualSound.volume = 1;
            actualSound.Play();
        }

    }
}
