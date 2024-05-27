using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    public Animals animals;
    Animator animator;
    SpriteRenderer SpriteRenderer;
    public SelectChar[] chars;

    void Start()
    {
        animator = GetComponent<Animator>();
      
        //이미 캐릭터가 선택되어 있는 상태면 enum 중에 currentAnimals랑 같은 게 있다는 거니까
        //OnSelect 메서드를 실행하여 선택되어있는 캐릭터를 표시
        if (DataManager.instance.currentAnimals == animals) OnSelect();
        else OnDeSelect();
    }

   private void Update()
   {
      // 에디터에서 마우스 버튼 클릭을 확인합니다.
      if (Input.GetMouseButtonDown(0))
      {
         // 마우스 클릭을 버튼 클릭으로 처리하는 메서드를 호출합니다.
         HandleTouchAsButton(Input.mousePosition);
      }
    // 모바일 장치에서 터치를 확인합니다.
    if (Input.touchCount > 0)
    {
        // 모든 터치를 순회합니다.
        foreach (Touch touch in Input.touches)
        {
            // 터치 상태가 Ended인지 확인합니다.
            if (touch.phase == TouchPhase.Ended)
            {
                // 터치를 버튼 클릭으로 처리하는 메서드를 호출합니다.
                HandleTouchAsButton(touch.position);
            }
        }
    }
   }

   private void HandleTouchAsButton(Vector2 touchPosition)
   {
      // 터치 위치를 카메라에서의 광선으로 변환합니다.
      Ray ray = Camera.main.ScreenPointToRay(touchPosition);
      RaycastHit hit;

      // 광선이 어떤 콜라이더에 부딪혔는지 확인합니다.
      if (Physics.Raycast(ray, out hit))
      {
         // 콜라이더가 이 게임 오브젝트에 속하는지 확인합니다.
         if (hit.collider.gameObject == gameObject)
         {
            // 이 경우, 오브젝트가 클릭된 것으로 처리합니다.
            DataManager.instance.currentAnimals = animals;
            OnSelect();

            // 다른 캐릭터를 선택 해제합니다.
            foreach (var character in chars)
            {
               if (character != this)
               {
                  character.OnDeSelect();
               }
            }
         }
      }
   }

   //private void OnMouseUpAsButton()
   //{
   //    //마우스로 클릭하면 currentAnimals에 animals(enum)의 값을 저장
   //    //마우스로 클랙했을 때 그 캐릭터의 enum 값이 currentAnimals에 저장
   //    DataManager.instance.currentAnimals = animals;
   //    OnSelect();

   //    for(int i=0; i<chars.Length; i++)
   //    {
   //        if (chars[i] != this) chars[i].OnDeSelect();
   //    }
   //}

   void OnDeSelect()
    {
        animator.SetBool("jump", false);
    }

    void OnSelect()
    {
        animator.SetBool("jump", true);
    }
}
