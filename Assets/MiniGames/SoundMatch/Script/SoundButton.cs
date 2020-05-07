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

    public AudioClip previousSound;
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
                source.PlayOneShot(chat);
                break;
            case 2:
                source.PlayOneShot(chien);
                break;
            case 3:
                source.PlayOneShot(guitare);
                break;
            case 4:
                source.PlayOneShot(flute);
                break;
            case 5:
                source.PlayOneShot(piano);
                break;
            case 6:
                source.PlayOneShot(tigre);
                break;
        }
        Debug.Log(source);
    }

    public void SetCat()
    {
        actualSound.PlayOneShot(chat);
        managerScript.answer = 1;
        previousSound = chat;
        stopPreviousSound();
    }
    public void SetDog()
    {

        actualSound.PlayOneShot(chien);
        managerScript.answer = 2;
        previousSound = chien;
        stopPreviousSound();
    }
    public void SetGuitare()
    {
        actualSound.PlayOneShot(guitare);
        managerScript.answer = 3;
        previousSound = guitare;
        stopPreviousSound();
    }
    public void SetFlute()
    {
        actualSound.PlayOneShot(flute);
        managerScript.answer = 4;
        previousSound = flute;
        stopPreviousSound();
    }
    public void SetPiano()
    {
        actualSound.PlayOneShot(piano);
        managerScript.answer = 5;
        previousSound = piano;
        stopPreviousSound();
    }
    public void SetTiger()
    {
        actualSound.PlayOneShot(tigre);
        managerScript.answer = 6;
        previousSound = tigre;
        stopPreviousSound();
    }

    //Stop all sounds
    public void stopPreviousSound()
    {
        if(source != null)
        {
            Debug.Log(source);
            source.Stop();
        }
    }
}
