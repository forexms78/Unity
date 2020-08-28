using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour {

    GameObject player;
    float speed = -6f;

    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, speed * Time.deltaTime, 0);
        //transform.Translate(0, speed, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌판정 추가

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.7f;    //새로범위
        float r2 = 0.5f;    //가로범위

        if (d < r1 + r2)
        {
            // 감독이 스크립트에 플레이어와 화실이 충돌했다고 전달한다.
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();
            // 충돌했다면 화살을 소멸시킨다.
            Destroy(gameObject);
        }

    }
}

