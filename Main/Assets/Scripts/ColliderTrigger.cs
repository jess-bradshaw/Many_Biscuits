using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ColliderTrigger : MonoBehaviour
{
    public GameObject TriggerObject;
    //public GameObject ObjectToActivate;
    public Canvas CanvasToActivate;
    [SerializeField] private float MoveToCam = 2.0f;
    public CinemachineVirtualCamera cinemachineCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (cinemachineCamera != null)
        {
            // Activate the Cinemachine camera
            cinemachineCamera.gameObject.SetActive(true);
        }
        //ObjectToActivate.SetActive(true);
        StartCoroutine(WaitForCam());
        
    }

    private IEnumerator WaitForCam()
    {
        yield return new WaitForSeconds(MoveToCam);
        CanvasToActivate.gameObject.SetActive(true);
    }
}
