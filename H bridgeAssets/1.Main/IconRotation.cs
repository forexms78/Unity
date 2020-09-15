using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconRotation : MonoBehaviour
{
    public float turnSpeed = 500;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
