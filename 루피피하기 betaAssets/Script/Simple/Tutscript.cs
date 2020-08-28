using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Tutscript : MonoBehaviour{

    public float speed;
    private float amountToMove;

    SerialPort sp = new SerialPort("COM3", 9600);

    public bool LeftMove = false;
    public bool RightMove = false;


    // Use this for initialization
    void Start ()
    {
        sp.Open();
        sp.ReadTimeout = 1;

    }

   

    // Update is called once per frame
    void Update ()
    {
        //        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        //
        // if (pos.x < 0f) pos.x = 0f;
        //   if (pos.x > 1f) pos.x = 1f;
        //     if (pos.y < 0f) pos.y = 0f;
        //       if (pos.y > 1f) pos.y = 1f;
        //
        //        transform.position = Camera.main.ViewportToWorldPoint(pos);


        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position); //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos); //다시 월드 좌표로 변환한다.
        transform.position = worldPos; //좌표를 적용한다.


        amountToMove = speed * Time.deltaTime;

        if (sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch(System.Exception)
            {
               
            }
        }

        if (RightMove)
        {
            amountToMove = (speed * Time.deltaTime) / 2;
            transform.Translate(Vector3.left * amountToMove, Space.World);
            transform.localScale = new Vector3(-0.4f, 0.4f, 1);
        }
        if (LeftMove)
        {
            amountToMove = (speed * Time.deltaTime) / 2;
            transform.Translate(Vector3.right * amountToMove, Space.World);
            transform.localScale = new Vector3(0.4f, 0.4f, 1);
        }
	}

    void MoveObject(int Direction)
    {
        if(Direction == 1)
        {
            transform.Translate(Vector3.left * amountToMove, Space.World);
            transform.localScale = new Vector3(-0.4f, 0.4f, 1);
        }
        if(Direction == 2)
        {
            transform.Translate(Vector3.right * amountToMove, Space.World);
            transform.localScale = new Vector3(0.4f, 0.4f, 1);
        }
    }
    public void LButtonDown()
    {
        transform.Translate(Vector3.left * amountToMove, Space.World);
        transform.localScale = new Vector3(-0.4f, 0.4f, 1);
    }
    public void RButtonDown()
    {
        transform.Translate(Vector3.right * amountToMove, Space.World);
        transform.localScale = new Vector3(0.4f, 0.4f, 1);
    }


}

