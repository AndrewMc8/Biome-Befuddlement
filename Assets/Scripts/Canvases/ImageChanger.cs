using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    [SerializeField] Sprite woodKey;
    [SerializeField] Sprite stoneKey;
    [SerializeField] Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.Instance.woodKey == true)
        {
            canvas.enabled = true;
            image.sprite = woodKey;
        }
        else if(Player.Instance.stoneKey == true)
        {
            canvas.enabled = true;
            image.sprite = stoneKey;
        }
        else
        {
            canvas.enabled = false;
        }
    }
}
