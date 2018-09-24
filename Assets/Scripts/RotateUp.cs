using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUp : MonoBehaviour
{

    public float rotationSpeedMultiplier;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeedMultiplier);
    }
}
