using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
   /* public Camera cam; 
    public Texture2D dirtBrush; 

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        RaycastHit hit;
        if (!Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
            return;

        Renderer rend = hit.transform.GetComponent<Renderer>();
        MeshCollider meshCollider = hit.collider as MeshCollider;

        if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
            return;

        Texture2D tex = rend.material.mainTexture as Texture2D;
        Vector2 pixelUV = hit.textureCoord;
        pixelUV.x *= tex.width;
        pixelUV.y *= tex.height;

        tex.SetPixel((int)pixelUV.x, (int)pixelUV.y, Color.black);
        tex.Apply();
       
       
       if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out RaycastHit raycastHit))
       {
            Vector2 textureCoord = raycastHit.textureCoord; 
            int pixelX = (int)(textureCoord.x* tex.width);
            int pixelY = (int)(textureCoord.y* tex.height);

            Vector2Int paintPixelPosition = new Vector2Int(pixelX, pixelY);
            Debug.Log("UV:" + textureCoord + "; Pixels: "+ paintPixelPosition);  
       } 

       int pixelXOffset = pixelX - (dirtBrush.width/2); 
       int pixelYOffset = pixelY - (dirtBrush.height/2); 
       for (int x = 0; x <dirtBrush; x++)
       {
            for (int y =0; y <dirtBrush.height; y++)
            {
                Color pixelDirt = dirtBrush.GetPixel (x, y); 
                Color pixelDirtMask = dirtMaskTexture.GetPixel(pixelXOffset + x, pixelYOffset +y);

                dirtMaskTexture.SetPixel(pixelXOffet + x, pixelYOffset + y, new Color (o, pixelDirtMask.g * pixelDirt.g, 0)); 
            }
        }
    } */
}
