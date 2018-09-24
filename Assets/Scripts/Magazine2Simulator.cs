using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Magazine2Simulator : MonoBehaviour, IVirtualButtonEventHandler
{


    private int curPageIndex = 0;

    private GameObject magNonCover;
    private GameObject magCover;
    public Texture2D[] framesNonCover;
    public Texture2D[] framesCover;
    public GameObject next;
    public GameObject prev;


    // Use this for initialization
    void Start()
    {
        magCover = GameObject.Find("MagazineImage3");
        magNonCover = GameObject.Find("MagazineImage1");
        next = GameObject.Find("Next2");
        next.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        prev = GameObject.Find("Previous2");
        prev.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.gameObject.name == "Next2")
        {

            if (curPageIndex < framesCover.Length - 1)
            {
                curPageIndex++;
            }
            //Debug.Log("Button pressed");
            magCover.GetComponent<Renderer>().material.mainTexture = framesCover[curPageIndex];
            magNonCover.GetComponent<Renderer>().material.mainTexture = framesNonCover[curPageIndex];
        }
        else // previous
        {
            if (curPageIndex > 0)
            {
                curPageIndex--;
            }
            //Debug.Log("Button pressed");
            magCover.GetComponent<Renderer>().material.mainTexture = framesCover[curPageIndex];
            magNonCover.GetComponent<Renderer>().material.mainTexture = framesNonCover[curPageIndex];
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }

}
