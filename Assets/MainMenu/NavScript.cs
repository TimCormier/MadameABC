using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavScript : MonoBehaviour
{

    public GameObject classe, music, yoga, craft, library;

    private GameObject DOORMUSIC;
    private GameObject DOORCLASS;
    private GameObject DOORLIBRARY;
    private GameObject DOORYOGA;
    private GameObject DOORCRAFT;
    private GameObject BACKBUTTON;

    private RawImage rawimg;
    public Texture defaultTexture;
    public Texture MusicRoom;
    public Texture ClassRoom;
    public Texture LibraryRoom;
    public Texture YogaRoom;
    public Texture CraftRoom;

    public Texture2D cursor;
    public Texture2D cursorOnEnter;


   /* private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        rawimg = gameObject.GetComponent<RawImage>();
        rawimg.texture = defaultTexture;
        DOORMUSIC = GameObject.Find("DoorMusic");
        DOORCLASS = GameObject.Find("DoorClass");
        DOORLIBRARY = GameObject.Find("DoorLibrary");
        DOORYOGA = GameObject.Find("DoorYoga");
        DOORCRAFT = GameObject.Find("DoorCraft");
        BACKBUTTON = GameObject.Find("BackButton");
        BACKBUTTON.SetActive(false);
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);

    }

    // Update is called once per frame
    void Update()
    {
       
        /*//following code is not mine
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouseclick");

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }*/


    }

    private void HIDE() {
        DOORMUSIC.SetActive(false);
        DOORCLASS.SetActive(false);
        DOORLIBRARY.SetActive(false);
        DOORYOGA.SetActive(false);
        DOORCRAFT.SetActive(false);
        BACKBUTTON.SetActive(true);
    }

    private void SHOW()
    {
        DOORMUSIC.SetActive(true);
        DOORCLASS.SetActive(true);
        DOORLIBRARY.SetActive(true);
        DOORYOGA.SetActive(true);
        DOORCRAFT.SetActive(true);

        music.SetActive(false);
        classe.SetActive(false);
        library.SetActive(false);
        yoga.SetActive(false);
        craft.SetActive(false);

        BACKBUTTON.SetActive(false);
    }


    public void MUSIC() {
        rawimg.texture = MusicRoom;
        HIDE();
        music.SetActive(true);

    }
    public void CLASS()
    {
        rawimg.texture = ClassRoom;
        HIDE();
        classe.SetActive(true);

    }
    public void LIBRARY()
    {
        rawimg.texture = LibraryRoom;
        HIDE();
        library.SetActive(true);

    }
    public void YOGA()
    {
        rawimg.texture = YogaRoom;
        HIDE();
        yoga.SetActive(true);

    }
    public void CRAFT()
    {
        rawimg.texture = CraftRoom;
        HIDE();
        craft.SetActive(true);

    }

    public void MAIN()
    {
        rawimg.texture = defaultTexture;
        SHOW();

    }

    /* Additive scenes 
    //Music
    public void SoundMatch()
    {
        SceneManager.LoadScene("MG_SoundMatch", LoadSceneMode.Additive);
    }

    public void Partition()
    {
        SceneManager.LoadScene("Partition", LoadSceneMode.Additive);
    }

    //Class
    public void SimpleMath()
    {
        SceneManager.LoadScene("SimpleMath", LoadSceneMode.Additive);
    }

    //Library
    public void StoryQuizz()
    {
        SceneManager.LoadScene("StoryQuiz", LoadSceneMode.Additive);
    }

    //Yoga
    public void WhackAMole()
    {
        SceneManager.LoadScene("WhackAMole", LoadSceneMode.Additive);
    }

    //Craft
    public void ColorTheory()
    {
        SceneManager.LoadScene("ColorTheory", LoadSceneMode.Additive);
    }

    public void ShapesNHoles()
    {
        SceneManager.LoadScene("ShapesNHoles", LoadSceneMode.Additive);
    }*/

    //Music
    public void SoundMatch()
    {
        SceneManager.LoadScene("SoundMatch_V2");
    }

    public void Partition()
    {
        SceneManager.LoadScene("Partition");
    }

    public void TapRythme()
    {
        SceneManager.LoadScene("TapRythme");
    }

    //Class
    public void SimpleMath()
    {
        SceneManager.LoadScene("SimpleMath");
    }

    public void UpperAndCapital()
    {
        SceneManager.LoadScene("UpperAndCapital");
    }

    public void MixAndMatch()
    {
        SceneManager.LoadScene("MixAndMatch");
    }

    //Library
    public void StoryQuizz1()
    {
        SceneManager.LoadScene("StoryQuiz");
    }

    public void StoryQuizz2()
    {
        SceneManager.LoadScene("StoryQuiz 1");
    }

    public void StoryQuizz3()
    {
        SceneManager.LoadScene("StoryQuiz 2");
    }

    //Yoga
    public void WhackAMole()
    {
        SceneManager.LoadScene("WhackAMole");
    }

    public void CastleBattle()
    {
        SceneManager.LoadScene("CastleBattle");
    }

    public void PizzaGame()
    {
        SceneManager.LoadScene("MamaMiaPizzeria");
    }

    //Craft
    public void ColorTheory()
    {
        SceneManager.LoadScene("ColorTheory");
    }

    public void ShapesNHoles()
    {
        SceneManager.LoadScene("ShapesNHoles");
    }

    public void JumpTiming()
    {
        SceneManager.LoadScene("JumpTiming_V2");
    }
}
