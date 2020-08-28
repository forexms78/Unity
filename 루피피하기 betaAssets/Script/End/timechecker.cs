using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timechecker : MonoBehaviour {

    public Text Text_time;

    // Use this for initialization
    void Start () {
       float a = PlayerPrefs.GetFloat("timescore");
        Text_time.text = a.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
