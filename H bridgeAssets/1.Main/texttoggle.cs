using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class texttoggle : MonoBehaviour
{

    public float interval = 0.5f;

    // Use this for initialization
    void Start()
    {

        Toggle();

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SecondScenes");
        }
    }

    void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        Invoke("Toggle", interval);
    }
}