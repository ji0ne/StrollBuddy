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

   private void Update()
   {
      maxCount();
   }

   public void DecreaseHp()
   {
      this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
      //fillAmount�� ���� 0.1f�� �پ��鼭 �������� �پ��� ��ó�� ���̰���
   }

   public void maxCount()
   {
      if(GameManager.time > 7.0f) //�������� �� �پ��� �� if�� ����ǵ��� �ڵ� ����
      {
         Time.timeScale = 0; //��������
         if (GameManager.time > GameManager.maxCount) 
            //������ maxCount���� time ���� �� ũ�� maxCount�� ����
         {
            GameManager.maxCount = GameManager.time;
            GameManager.gameCount++;
         }
      }
   }
}
