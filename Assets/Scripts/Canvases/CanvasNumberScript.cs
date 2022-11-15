using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasNumberScript : MonoBehaviour
{
    [SerializeField] TMP_Text textUI;

    public void Start()
    {
        textUI.text = GameManager.Instance.GetNumberCode();
    }
}
