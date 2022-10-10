using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpriteSelector : MonoBehaviour
{
    public Mesh mN, mE, mS, mW, mNE, mNS, mNW, mSE, mSW, mEW, mNES, mNEW, mNSW, mESW, mNESW;

    public bool north;
    public bool east;
    public bool south;
    public bool west;

    public int type;

    public Material normalColor;
    public Material enterColor;

    Material mainColor;

    MeshFilter filter;
    MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        filter = GetComponent<MeshFilter>();
        rend = GetComponent<MeshRenderer>();
        mainColor = normalColor;
        PickSprite();
        PickColor();
    }

    void PickSprite()
    {
        if(north)
        {
            if(south)
            {
                if(east)
                {
                    if(west)
                    {
                        filter.mesh = mNESW;
                    }
                    else
                    {
                        filter.mesh = mNES;
                    }
                }
                else if(west)
                {
                    filter.mesh = mNSW;
                }
                else
                {
                    filter.mesh = mNS;
                }
            }
            else
            {
                if(east)
                {
                    if(west)
                    {
                        filter.mesh = mNEW;
                    }
                    else
                    {
                        filter.mesh = mNE;
                    }
                }
                else if(west)
                {
                    filter.mesh = mNW;
                }
                else
                {
                    filter.mesh = mN;
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
                    filter.mesh = mESW;
                }
                else
                {
                    filter.mesh = mSE;
                }
            }
            else if(west)
            {
                filter.mesh = mSW;
            }
            else
            {
                filter.mesh = mS;
            }
        }
        else if(east)
        {
            if(west)
            {
                filter.mesh = mEW;
            }
            else
            {
                filter.mesh = mE;
            }
        }
        else
        {
            filter.mesh = mW;
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

    // Update is called once per frame
    void Update()
    {

    }
}
