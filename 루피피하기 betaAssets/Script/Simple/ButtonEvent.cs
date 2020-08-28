using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour {

    GameObject player;
    Tutscript tutscript;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        tutscript = player.GetComponent<Tutscript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LeftBtnDown()
    {
        tutscript.RightMove = true;
    }
    public void LeftBtnup()
    {
        tutscript.RightMove = false;
    }
    public void RightBtnDown()
    {
        tutscript.LeftMove = true;
    }
    public void RightBtnUp()
    {
        tutscript.LeftMove = false;
    }
}
