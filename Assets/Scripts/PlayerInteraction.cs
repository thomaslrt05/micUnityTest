using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerInteraction : MonoBehaviour
    {
        public float playerReach = 3f;
        Interactable currentInteractable;
        private int value = 0;

        private void Update()
        {
            CheckInteraction();
            if (Input.GetKeyDown(KeyCode.E) && currentInteractable is not null) 
            {
                currentInteractable.Interact();
            }
        }

        void CheckInteraction()
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            // Si il y a collision entre un objet et le player
             if(Physics.Raycast(ray, out hit, playerReach)) 
             {
                if(hit.collider.tag == "Interactable")
                {
                    ObjectInteractable interactableObject = hit.collider.gameObject.GetComponent<ObjectInteractable>();
                    if (interactableObject != null)
                    {
                        interactableObject.IncrementeValue();
                    }
                }
             }
        }

        void SetNewCurrentInteractable(Interactable newInterrac)
        {
            currentInteractable = newInterrac;
            currentInteractable.EnableOutline();
        }

        void DisableCurrentInteractable()
        {
            if(currentInteractable)
            {
                currentInteractable.DisableOutline();
                currentInteractable = null;
            }
        }
    }
}