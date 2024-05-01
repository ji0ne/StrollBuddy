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

        if (DataManager.instance.currentAnimals == animals) OnSelect();
        else OnDeSelect();
    }

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentAnimals = animals;
        OnSelect();

        for(int i=0; i<chars.Length; i++)
        {
            if (chars[i] != this) chars[i].OnDeSelect();
        }
    }

    void OnDeSelect()
    {
        animator.SetBool("run", false);
    }

    void OnSelect()
    {
        animator.SetBool("run", true);
    }
}
