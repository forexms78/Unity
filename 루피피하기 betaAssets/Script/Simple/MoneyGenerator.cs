using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyGenerator : MonoBehaviour {

    public GameObject moneyPrefab;
    //public GameObject round;

    public float span = 5.0f;

    private float TimeLeft = 2.0f;
    private float nextTime = 0.0f;

    float delta = 0;

    // 택스트를 변경연결
    void Start()
    {
        //this.round = GameObject.Find("round");
        //this.round.GetComponent<Text>().text = "하늘에서 떨어지는 눈사람을 피해요";
    }

    void MoveMoles()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            MoveMoles();
        }
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(moneyPrefab) as GameObject;
            int px = Random.Range(-9, 9);
            go.transform.position = new Vector3(px, 7, 0);
            Debug.Log(span);

        }

    }
}
