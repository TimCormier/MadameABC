using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class SoundButton : MonoBehaviour
{
    public AudioClip chat, chien, guitare, flute, piano, tigre;
    private AudioSource[] allAudioSources;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
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
        source.PlayOneShot(chat);
        managerScript.answer = 1;
        Debug.Log("Cat Sound");
        StopAllAudio();
    }
    public void SetDog()
    {
        source.PlayOneShot(chien);
        managerScript.answer = 2;
        Debug.Log("Dog Sound");
        StopAllAudio();
    }
    public void SetGuitare()
    {
        source.PlayOneShot(guitare);
        managerScript.answer = 3;
        Debug.Log("Guitar Sound");
        StopAllAudio();
    }
    public void SetFlute()
    {
        source.PlayOneShot(flute);
        managerScript.answer = 4;
        Debug.Log("Flute Sound");
        StopAllAudio();
    }
    public void SetPiano()
    {
        source.PlayOneShot(piano);
        managerScript.answer = 5;
        Debug.Log("Piano Sound");
        StopAllAudio();
    }
    public void SetTiger()
    {
        source.PlayOneShot(tigre);
        managerScript.answer = 6;
        Debug.Log("Tiger Sound");
        StopAllAudio();
    }

    //Stop all sounds
    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.Stop();
        }
    }
}
