using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public static CursorController instance;
    public Texture2D cursor;
    public Texture2D cursorClick;
    public Texture2D cursorDrag;


    void Awake()
    {
        instance = this;
        this.ActiveCursor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ActiveCursorClick()
    {
        Cursor.SetCursor(cursorClick, Vector2.zero, CursorMode.Auto);
    }

    public void ActiveCursorDrag()
    {
        Cursor.SetCursor(cursorDrag, Vector2.zero, CursorMode.Auto);
    }

    public void ActiveCursor()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

}
