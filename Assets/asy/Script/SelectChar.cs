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

    private void OnMouseUpAsButton()
    {
        //마우스로 클릭하면 currentAnimals에 animals(enum)의 값을 저장
        //마우스로 클랙했을 때 그 캐릭터의 enum 값이 currentAnimals에 저장
        DataManager.instance.currentAnimals = animals;
        OnSelect();

        for(int i=0; i<chars.Length; i++)
        {
            if (chars[i] != this) chars[i].OnDeSelect();
        }
    }

    void OnDeSelect()
    {
        animator.SetBool("jump", false);
    }

    void OnSelect()
    {
        animator.SetBool("jump", true);
    }
}
