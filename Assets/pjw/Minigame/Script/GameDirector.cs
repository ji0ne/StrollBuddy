using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰�
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        // Find �� �� ����Ƽ Object�� �̸��� �����ϰ� ���������
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        // fillAmount�� ���� 0.1f�� �پ��鼭 �������� �پ��� ��ó�� ���̰���
    }

    private void Update()
    {
        if (hpGauge.GetComponent<Image>().fillAmount <= 0) // ��Ȯ�� 0�� �� ��� ������ Ȯ��
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
            UnityEngine.SceneManagement.SceneManager.LoadScene("Play"); // �� ���� ȣ���ϵ��� ����
            GameManager.time = 0;
            Time.timeScale = 1;
        }
    }
}
