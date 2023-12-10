using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCursor : MonoBehaviour
{
    public Texture2D cursorArrow; 
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor (cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
