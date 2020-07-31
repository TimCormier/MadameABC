using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleUpLaunch : MonoBehaviour
{
    //To use, change your canvas's render mode to Screen Space - Camera

    public ParticleSystem particleLauncher;
    public float particleRelauncher;

    void Start()
    {
        particleRelauncher = 0f;
    }


    void Update()
    {
        if(particleRelauncher >= 1f)
        {
            particleLauncher.Emit(5);
            particleRelauncher -= 1f;
        }
    }

    public void LaunchParticle()
    {
        particleRelauncher += 1f;
    }
}
