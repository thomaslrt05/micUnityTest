using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class ObjectInteractable : MonoBehaviour
    {
        private int value;
        Outline outline;
        public string message;


        public UnityEvent onInteraction;

        void Start()
        {
            value = 0;
            outline = GetComponent<Outline>();
            outline.enabled = false;
        }

        public void Interact()
        {
            IncrementeValue();
            HUDController.instance.UpdateText(value);
        }


        public void IncrementeValue()
        {
            value++;
        }

  
    }
}