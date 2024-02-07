using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public static HUDController instance;

    private void Awake()
    {
        instance = this; 
    }

    [SerializeField] TMP_Text interactionText;

    public void UpdateText(int value)
    {
        interactionText.text = "Vous avez cliqué " + value + " fois";
    }


}
