using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

   GameObject player;

   void Start()
   {
      this.player = GameObject.Find("player");
      //Find 뒤에 오는 이름은 Obejct 이름이랑 동일해야함
   }

   void Update()
   {
      // 프레임마다 등속으로 낙하시킨다
      transform.Translate(0, -0.12f, 0);

      // 화면 밖으로 나오면 오브젝트를 소멸시킨다
      if (transform.position.y < -5.0f)
      {
         Destroy(gameObject);
      }

      // 충돌 판정
      Vector2 p1 = transform.position;              // 화살의 중심 좌표
      Vector2 p2 = this.player.transform.position;  // 플레이어의 중심 좌표
      Vector2 dir = p1 - p2;
      float d = dir.magnitude;
      //magnitude는 두 점 사이의 거리를 구해줌
      float r1 = 0.5f;  // 화살의 반경
      float r2 = 1.0f;  // 플레이어의 반경

      if (d < r1 + r2)
      //update문이라서 화살이 계속 떨어지면 거리가 줄어들기 때문에 d 의 값이 점점 줄어듬
      {
         // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다 
         GameObject director = GameObject.Find("GameDirector");
         director.GetComponent<GameDirector>().DecreaseHp();         

         // 충돌한 경우는 화살을 지운다
         Destroy(gameObject);
      }
   }
}
