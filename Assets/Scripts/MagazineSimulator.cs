using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MagazineSimulator : MonoBehaviour, IVirtualButtonEventHandler
{


    private int curPageIndex = 0;

    private GameObject magNonCover;
    private GameObject magCover;
    public Texture2D[] framesNonCover;
    public Texture2D[] framesCover;
    public GameObject next;
    public GameObject prev;


    // Use this for initialization
    void Start () {
        magCover = GameObject.Find("MagazineImage2");
        magNonCover = GameObject.Find("MagazineImage1");
        next = GameObject.Find("Next");
        next.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        prev = GameObject.Find("Previous");
        prev.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {


        if (curPageIndex == 0) // display cover only
        {
            //magNonCover.GetComponent<Renderer>().material.mainTexture = null;
           // magCover.GetComponent<Renderer>().material.mainTexture = framesCover[curPageIndex];
        }
        else
        {
           // magCover.GetComponent<Renderer>().material.mainTexture = framesCover[curPageIndex];
           // magNonCover.GetComponent<Renderer>().material.mainTexture = framesNonCover[curPageIndex];
        }

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.gameObject.name == "Next")
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
