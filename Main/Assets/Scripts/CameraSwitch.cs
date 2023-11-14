using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    //public Text UILabel;
    //public string text;
    public Vector3 cameraPos;
    public Vector3 cameraRot;

    public void SwitchToHere()
    {
        Camera.main.transform.position = cameraPos;
        Camera.main.transform.rotation = Quaternion.Euler(cameraRot);
        //UILabel.text = text;
    }
}
