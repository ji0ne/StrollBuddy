using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰�

public class GameDirector : MonoBehaviour
{
   GameObject hpGauge;

   void Start()
   {
      this.hpGauge = GameObject.Find("hpGauge");
      //Find �� �� ����Ƽ Object�� �̸��� �����ϰ� ���������
      //��ҹ��ڵ� �����ؼ� �����ֱ�
   }

   public void DecreaseHp()
   {
      this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
      //fillAmount�� ���� 0.1f�� �پ��鼭 �������� �پ��� ��ó�� ���̰���
   }
}
