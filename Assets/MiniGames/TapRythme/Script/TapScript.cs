using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{
    public GameObject noteOnCollider;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && noteOnCollider != null)
            noteOnCollider.SetActive(false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        noteOnCollider = collision.gameObject;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        noteOnCollider = null;
    }
}
