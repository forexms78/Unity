using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyGenerator : MonoBehaviour {

    public GameObject candyPrefab;

    float span = 5.0f;
    float delta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;

        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(candyPrefab) as GameObject;
            int px = Random.Range(-9, 9);
            go.transform.position = new Vector2(px, 7);
            
        }
	}
}
