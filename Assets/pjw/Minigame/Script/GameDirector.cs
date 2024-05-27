using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가

public class GameDirector : MonoBehaviour
{
   GameObject hpGauge;

   void Start()
   {
      this.hpGauge = GameObject.Find("hpGauge");
      //Find 할 때 유니티 Object의 이름과 동일하게 적어줘야함
      //대소문자도 구분해서 적어주기
   }

   private void Update()
   {
      maxCount();
   }

   public void DecreaseHp()
   {
      this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
      //fillAmount의 값이 0.1f씩 줄어들면서 게이지가 줄어드는 것처럼 보이게함
   }

   public void maxCount()
   {
      if(GameManager.time > 7.0f) //게이지가 다 줄었을 때 if문 실행되도록 코드 수정
      {
         Time.timeScale = 0; //게임종료
         if (GameManager.time > GameManager.maxCount) 
            //기존의 maxCount보다 time 값이 더 크면 maxCount에 저장
         {
            GameManager.maxCount = GameManager.time;
            GameManager.gameCount++;
         }
      }
   }
}
