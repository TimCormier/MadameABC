﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorScript : MonoBehaviour
{
    public void startTheGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
