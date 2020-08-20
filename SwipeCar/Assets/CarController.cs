using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;
    Vector2 startPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;

            // 끌어당긴 방향으로 출발
            float swipeLength = (endPos.x - this.startPos.x);

            // 학창시절 고무줄처럼 끌어당긴 방향 반대 방향으로 전진
            //float swipeLength = (startPos.x - endPos.x);

            this.speed = swipeLength / 500.0f;

            Debug.Log(speed);
            Debug.Log(swipeLength);

            GetComponent<AudioSource>().Play();

        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
		
	}
}
