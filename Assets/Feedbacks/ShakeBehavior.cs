using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
    //This script DOESN'T work on canvas, as they cannot be moved

    //Instruction
    // 1. Put this script on your Camera

    public Transform transform;
    public Vector3 initialPosition;

    //Don't changes these if not REALLY needed
    //Duration is set on the event, make another event to change it if needed
    private float shakeDuration = 0f;
    public float shakeMagnitude = 70f;
    public float dampingSpeed = 1f;

    private void Awake()
    {
        if (transform == null)
        {
            transform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    private void OnEnable()
    {
        initialPosition = transform.localPosition;
    }

    private void Update()
    {

        if (shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampingSpeed;
        }

        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }


    }

    public void TriggerShake()
    {
        //Function to call for the effect
        shakeDuration = 2.0f;
        Debug.Log("Shaking");
    }
}
