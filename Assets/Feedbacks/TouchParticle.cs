using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchParticle : MonoBehaviour
{
    //To Add : Fading effect

    public Camera cam;
    public GameObject Particle;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnPosition.z = 0f;

            GameObject objectInstance = Instantiate(Particle, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
    }
}
