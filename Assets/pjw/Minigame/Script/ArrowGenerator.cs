using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
   public GameObject arrowPrefab;
   //Prefab 변수 이름 지정할 때는 유니티에서 지정한 Prefab 이름과
   //동일하게 적어줘야함
   float span = 1.0f; //1.0f는 1초로 생각
   float delta = 0;

   void Update()
   {
      this.delta += Time.deltaTime;
      //deltaTime은 프레임과 프레임 사이의 시간
      //1초에 1000번 돌면 프레임과 프레임 사이의 시간은 0.001초
      if (this.delta > this.span) //this.delta가 1초가 되면
      {
         this.delta = 0; //delta를 0으로 셋팅 -> 1초마다 계속 반복되게
         GameObject go = Instantiate(arrowPrefab);      
         int px = Random.Range(-3, 3);
         go.transform.position = new Vector3(px, 7, 0);
      }
   }
}
