using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSoundMatch : MonoBehaviour
{
    private int seedSon;
    public int goodAnwser;
    public GameObject chat,chien,guitare;

    // Start is called before the first frame update
    void Start()
    {
        seedSon = Random.Range(1, 4);

        switch (seedSon)
        {
            case 1:
                goodAnwser = 1;
                break;
            case 2:
                goodAnwser = 2;
                break;
            case 3:
                goodAnwser = 3;
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
