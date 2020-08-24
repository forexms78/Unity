using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefeb;
    public GameObject round;
    public static ArrowGenerator AG;
    public float speed = -0.007f;
    public float span = 2.0f;
    float delta = 0;

    // 택스트를 변경연결
    void Start()
    {
        AG = this;
        this.round = GameObject.Find("round");
        this.round.GetComponent<Text>().text = "하늘에서 떨어지는 호박을 피해요";
    }

    // Update is called once per frame
    void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefeb) as GameObject;
            int px = Random.Range(-9, 9);
            go.transform.position = new Vector3(px,7,0);
            Debug.Log(span);
            
            if (span >= 0.1f)
            {
                this.span *= 0.9f;
                this.round.GetComponent<Text>().text = "점점 빨라지는 중!";
            }
            else
            {
                span = 0.09f;
                this.round.GetComponent<Text>().text = "피해 보아요!";
            }
        }
        
	}


}
