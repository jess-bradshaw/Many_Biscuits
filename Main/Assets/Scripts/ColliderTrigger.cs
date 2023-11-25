using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject TriggerObject;
    public GameObject ObjectToActivate;
    public Canvas CanvasToActivate;

    private void OnTriggerEnter(Collider other)
    {
       ObjectToActivate.SetActive(true);
       CanvasToActivate.gameObject.SetActive(true);
    }

}
