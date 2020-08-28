using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO.Ports;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour {

    SerialPort sp = new SerialPort("COM3", 9600);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update () {

        if (sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }

        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("GameScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }


    void MoveObject(int Direction)
    {
        if (Direction == 1)
        {
            SceneManager.LoadScene("StartScene");
        }
        if (Direction == 2)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
