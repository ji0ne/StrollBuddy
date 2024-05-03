using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] chars;
    static public GameObject player;
    float speed = 1.0f;
    Animator animator;

    void Start()
    {
        Application.targetFrameRate = 60;

        player = Instantiate(chars[(int)DataManager.instance.currentAnimals]);
        player.transform.position = transform.position;

        animator = player.GetComponent<Animator>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 moveVec = new Vector3(-x/60, 0, z/60);

        player.transform.position += moveVec * speed;

        if (x != 0 || z != 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        player.transform.LookAt(player.transform.position + moveVec);
    }

}
