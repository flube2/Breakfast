using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference - https://answers.unity.com/questions/429697/how-will-i-get-animated-gif-images-in-scene.html
public class GIFSimulator : MonoBehaviour {

    public Texture2D[] frames;
    public float fps = 10.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        var index = Time.time * fps;
        int frameNumber = (int)index % frames.Length;
        GetComponent<Renderer>().material.mainTexture = frames[frameNumber];
    }
}
