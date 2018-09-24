using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameObject : MonoBehaviour {

    public float bounceMultiplier = 1.0f;
    public float rotationSpeedMultiplier = 1.0f;
   

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeedMultiplier);
        transform.Translate(Vector3.right * Time.deltaTime * bounceMultiplier);
	}
}
