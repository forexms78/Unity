using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;
    GameObject timer;
    public Text timeText;

    public float time;

    // Use this for initialization
    void Start()
    {
        this.hpGauge = GameObject.Find("heartbar");
    }

    void Update()
    {
        // 시간을 재는 타이머
        time += Time.deltaTime;
        timeText.text = string.Format("{0:N2}", time);


        // 하트가 없으면 게임 종료
        if (hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            PlayerPrefs.SetFloat("timescore", time);
            Debug.Log(time);
            Debug.Log("게임오버");
            SceneManager.LoadScene("EndScene");
            DontDestroyOnLoad(timeText);
        }
    }

    // 호박을 맞으면 HP를 감소

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.125f;
    }

    // 사탕에 맞으면 HP 증가

    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.25f;
    }
}
