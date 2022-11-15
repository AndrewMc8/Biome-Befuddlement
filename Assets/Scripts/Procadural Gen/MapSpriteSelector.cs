using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpriteSelector : MonoBehaviour
{
    public GameObject mN, mE, mS, mW, mNE, mNS, mNW, mSE, mSW, mEW, mNES, mNEW, mNSW, mESW, mNESW;

    public bool north;
    public bool east;
    public bool south;
    public bool west;

    public int type;

    public Material normalColor;
    public Material enterColor;

    Material mainColor;

    MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("3");
        rend = GetComponent<MeshRenderer>();
        mainColor = normalColor;
        PickSprite();
        PickColor();
        Debug.Log("4");
    }

    void PickSprite()
    {
        Debug.Log(north);
        Debug.Log(south);
        Debug.Log(east);
        Debug.Log(west);
        if(north)
        {
            if(south)
            {
                if(east)
                {
                    if(west)
                    {
                        //filter.mesh = mNESW;
                        Instantiate(mNESW, transform.position, transform.rotation);
                    }
                    else
                    {
                        //filter.mesh = mNES;
                        Instantiate(mNES, transform.position, transform.rotation);
                    }
                }
                else if(west)
                {
                    //filter.mesh = mNSW;
                    Instantiate(mNSW, transform.position, transform.rotation);
                }
                else
                {
                    //filter.mesh = mNS;
                    Instantiate(mNS, transform.position, transform.rotation);
                }
            }
            else
            {
                if(east)
                {
                    if(west)
                    {
                        //filter.mesh = mNEW;
                        Instantiate(mNEW, transform.position, transform.rotation);
                    }
                    else
                    {
                        //filter.mesh = mNE;
                        Instantiate(mNE, transform.position, transform.rotation);
                    }
                }
                else if(west)
                {
                    //filter.mesh = mNW;
                    Instantiate(mNW, transform.position, transform.rotation);
                }
                else
                {
                    //filter.mesh = mN;
                    Instantiate(mN, transform.position, transform.rotation);
                }
            }
            return;
        }

        if(south)
        {
            if(east)
            {
                if(west)
                {
                    //filter.mesh = mESW;
                    Instantiate(mESW, transform.position, transform.rotation);
                }
                else
                {
                    //filter.mesh = mSE;
                    Instantiate(mSE, transform.position, transform.rotation);
                }
            }
            else if(west)
            {
                //filter.mesh = mSW;
                Instantiate(mSW, transform.position, transform.rotation);
            }
            else
            {
                //filter.mesh = mS;
                Instantiate(mS, transform.position, transform.rotation);
            }
        }
        else if(east)
        {
            if(west)
            {
                //filter.mesh = mEW;
                Instantiate(mEW, transform.position, transform.rotation);
            }
            else
            {
                //filter.mesh = mE;
                Instantiate(mE, transform.position, transform.rotation);
            }
        }
        else
        {
            //filter.mesh = mW;
            Instantiate(mW, transform.position, transform.rotation);
        }
    }

    void PickColor()
    {
        if(type == 0)
        {
            mainColor = normalColor;
        }
        else if(type == 1)
        {
            mainColor = enterColor;
        }

        rend.material = mainColor;
    }
}
