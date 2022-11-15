using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivation : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    // Update is called once per frame
    void Start()
    {
        canvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.enabled = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canvas.enabled = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
