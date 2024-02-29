using System;
using UnityEngine.Events;
using UnityEngine;


    public class EventTrigger : MonoBehaviour
    {
    public Camera firstCamera;
    public Camera secondCamera;

    private bool firstCameraon = true;

    void Start()
    {
        secondCamera.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            firstCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(false);
            firstCameraon = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            
            firstCamera.gameObject.SetActive(false);
            secondCamera.gameObject.SetActive(true);
            firstCameraon = false;
        }
    }
}




