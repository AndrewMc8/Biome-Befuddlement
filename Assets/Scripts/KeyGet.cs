using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            if(other.gameObject.name == "Wood Key(Clone)")
            {
                Player.Instance.woodKey = true;
            }

            if(other.gameObject.name == "Stone Key(Clone)")
            {
                Player.Instance.stoneKey = true;
            }

            Destroy(other.gameObject);
        }

        if(other.tag == "Door")
        {
            if(other.gameObject.name == "Wood Door" && Player.Instance.woodKey == true)
            {
                Player.Instance.woodKey = false;

                Destroy(other.gameObject);
            }

            if (other.gameObject.name == "Stone Door" && Player.Instance.stoneKey == true)
            {
                Player.Instance.stoneKey = false;

                Destroy(other.gameObject);
            }
        }
    }
}
