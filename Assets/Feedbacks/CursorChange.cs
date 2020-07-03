using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChange : MonoBehaviour
{
    //Utilisation
    // 1. Mettre ce script sur votre GameManager
    // 2. Mettre les textures requises dans les variables requises
    // 3. Pour activer le cursorHover, metre des box colider sur vos objets


    public Texture2D cursorArrow;
    public Texture2D cursorHover;

    
    void Start()
    {

        //Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorHover, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}
