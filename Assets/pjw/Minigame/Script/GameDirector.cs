using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        // Find 할 때 유니티 Object의 이름과 동일하게 적어줘야함
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        // fillAmount의 값이 0.1f씩 줄어들면서 게이지가 줄어드는 것처럼 보이게함
    }

    private void Update()
    {
        if (hpGauge.GetComponent<Image>().fillAmount <= 0) // 정확히 0과 비교 대신 작은지 확인
        {
            Time.timeScale = 0;
            GameManager.gameCount -= 1;
            if (GameManager.time > GameManager.maxCount)
            {
                string timeString = GameManager.time.ToString("F0");
                GameManager.maxCount = float.Parse(timeString);
                GameManager.conversationCount += 1;
                GameManager.time = 0;
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene("Play"); // 한 번만 호출하도록 수정
            GameManager.time = 0;
            Time.timeScale = 1;
        }
    }
}
