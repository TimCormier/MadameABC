using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class SoundButton : MonoBehaviour
{
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    GameObject manager;
    GameManagerSoundMatch managerScript;

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        button.onClick.AddListener(() => PlaySound());
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<GameManagerSoundMatch>();
    }

    // Update is called once per frame
    void PlaySound()
    {
        source.PlayOneShot(sound);
    }
}
