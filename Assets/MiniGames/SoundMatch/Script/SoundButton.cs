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
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioSource playingSound;
    //access to the gamemanger script
    GameObject manager;
    GameManagerSoundMatch managerScript;

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
    }

    public void SetCat()
    {
        StartCoroutine(CoroutineAudio(AudioSource));
        source.PlayOneShot(chat);
        managerScript.answer = 1;
        Debug.Log("Cat Sound");
    }
    public void SetDog()
    {
        StartCoroutine(CoroutineAudio(AudioSource));
        source.PlayOneShot(chien);
        managerScript.answer = 2;
        Debug.Log("Dog Sound");
    }
    public void SetGuitare()
    {
        StartCoroutine(CoroutineAudio(AudioSource));
        source.PlayOneShot(guitare);
        managerScript.answer = 3;
        Debug.Log("Guitar Sound");
    }
    public void SetFlute()
    {
        StartCoroutine(CoroutineAudio(AudioSource));
        source.PlayOneShot(flute);
        managerScript.answer = 4;
        Debug.Log("Flute Sound");
    }
    public void SetPiano()
    {
        StartCoroutine(CoroutineAudio(AudioSource));
        source.PlayOneShot(piano);
        managerScript.answer = 5;
        Debug.Log("Piano Sound");
    }
    public void SetTiger()
    {
        StartCoroutine(CoroutineAudio(AudioSource));
        source.PlayOneShot(tigre);
        managerScript.answer = 6;
        Debug.Log("Tiger Sound");
    }

    //Stop all sounds
    private IEnumerator CoroutineAudio(AudioSource playingSound)
    {
        while ()
        {
            allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (AudioSource audioSource in allAudioSources)
            {
                audioSource.Stop();
            }
        }
    }
}
