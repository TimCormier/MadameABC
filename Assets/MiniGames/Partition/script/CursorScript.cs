using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorScript : MonoBehaviour
{


    private GameObject CURSOR;
    private Button PLAYBTN;
    private Vector3 ogpos;
    public float speed;

    private bool playing = false;
    // Start is called before the first frame update
    void Start()
    {
        CURSOR = GameObject.Find("Cursor");
        PLAYBTN = GameObject.Find("PlayButton").transform.GetComponent<Button>();
        PLAYBTN.onClick.AddListener(OnClick);
        ogpos = CURSOR.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true) {
            CURSOR.transform.position += new Vector3(speed, 0f, 0f);

            //raycast code
            RaycastHit hit;
            if (Physics.Raycast(CURSOR.transform.position, transform.TransformDirection(Vector3.down),out hit, 1f)) {
                Debug.Log(hit.transform.name);
                //Debug.DrawRay(CURSOR.transform.position, transform.TransformDirection(Vector3.down));
            }

            if (CURSOR.transform.position.x >= 7.6) {
                CURSOR.transform.position = new Vector3(ogpos.x, 0.7f, ogpos.z);
            }
        }
    }

    void OnClick() {
        Debug.Log("You clicked the play button!");
        playing = true;
    }
}
