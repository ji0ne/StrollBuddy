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

    private void OnMouseUpAsButton()
    {
        //���콺�� Ŭ���ϸ� currentAnimals�� animals(enum)�� ���� ����
        //���콺�� Ŭ������ �� �� ĳ������ enum ���� currentAnimals�� ����
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
