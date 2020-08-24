using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;

    // Use this for initialization
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    void Update()
    {
        if(hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            Debug.Log("게임오버");
            SceneManager.LoadScene("EndScene");
        }
    }

    // 호박을 맞으면 HP를 감소

    public void DecreaseHp() {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // 사탕에 맞으면 HP 증가

    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.2f;
    }
}
