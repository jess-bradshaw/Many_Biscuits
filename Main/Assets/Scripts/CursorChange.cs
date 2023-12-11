using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChange : MonoBehaviour
{
   public Texture2D cursorTexture; 
   public Texture2D cursorTextureOG; 
   public CursorMode cursorMode = CursorMode.ForceSoftware;
   public Vector2 hotSpot = Vector2.zero; 

   void OnMouseEnter()
   {
    Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
   
   }
   
   void OnMouseExit()
   {
    Cursor.SetCursor(cursorTextureOG, Vector2.zero, cursorMode);
   }
 
}
