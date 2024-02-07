using UnityEditor;
using UnityEngine;
using TMPro;

namespace Assets.Scripts
{
    public class ObjectInteractable : MonoBehaviour
    {
        private int value;
        public TextMeshProUGUI valueText;

        private void Start()
        {
            value = 0;
        }

        public void IncrementeValue()
        {
            value++;
            UpdateText();
        }

        public void UpdateText()
        {
            valueText.text = "Vous avez cliquez " + value.ToString();
        }
    }
}