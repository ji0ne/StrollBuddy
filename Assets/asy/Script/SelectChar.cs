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
      
        //�̹� ĳ���Ͱ� ���õǾ� �ִ� ���¸� enum �߿� currentAnimals�� ���� �� �ִٴ� �Ŵϱ�
        //OnSelect �޼��带 �����Ͽ� ���õǾ��ִ� ĳ���͸� ǥ��
        if (DataManager.instance.currentAnimals == animals) OnSelect();
        else OnDeSelect();
    }

   private void Update()
   {
      // �����Ϳ��� ���콺 ��ư Ŭ���� Ȯ���մϴ�.
      if (Input.GetMouseButtonDown(0))
      {
         // ���콺 Ŭ���� ��ư Ŭ������ ó���ϴ� �޼��带 ȣ���մϴ�.
         HandleTouchAsButton(Input.mousePosition);
      }
    // ����� ��ġ���� ��ġ�� Ȯ���մϴ�.
    if (Input.touchCount > 0)
    {
        // ��� ��ġ�� ��ȸ�մϴ�.
        foreach (Touch touch in Input.touches)
        {
            // ��ġ ���°� Ended���� Ȯ���մϴ�.
            if (touch.phase == TouchPhase.Ended)
            {
                // ��ġ�� ��ư Ŭ������ ó���ϴ� �޼��带 ȣ���մϴ�.
                HandleTouchAsButton(touch.position);
            }
        }
    }
   }

   private void HandleTouchAsButton(Vector2 touchPosition)
   {
      // ��ġ ��ġ�� ī�޶󿡼��� �������� ��ȯ�մϴ�.
      Ray ray = Camera.main.ScreenPointToRay(touchPosition);
      RaycastHit hit;

      // ������ � �ݶ��̴��� �ε������� Ȯ���մϴ�.
      if (Physics.Raycast(ray, out hit))
      {
         // �ݶ��̴��� �� ���� ������Ʈ�� ���ϴ��� Ȯ���մϴ�.
         if (hit.collider.gameObject == gameObject)
         {
            // �� ���, ������Ʈ�� Ŭ���� ������ ó���մϴ�.
            DataManager.instance.currentAnimals = animals;
            OnSelect();

            // �ٸ� ĳ���͸� ���� �����մϴ�.
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
   //    //���콺�� Ŭ���ϸ� currentAnimals�� animals(enum)�� ���� ����
   //    //���콺�� Ŭ������ �� �� ĳ������ enum ���� currentAnimals�� ����
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
