using System;
using UnityEngine.Events;
using UnityEngine;
    public class CameraManager : MonoBehaviour
    {
        [SerializeField] private string tagFilter;
        [SerializeField] private UnityEvent onTriggerEnter;
        [SerializeField] private UnityEvent onTriggerExit;

        void OnTriggerEnter(Collider other)
        {
            if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
            onTriggerEnter.Invoke();
        }

        private void OnTriggerExit(Collider other)
        {
            if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
            onTriggerExit.Invoke();
        }
    }
