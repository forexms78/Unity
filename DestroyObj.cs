using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float deleteTIme = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deleteTIme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
