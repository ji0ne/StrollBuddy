using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        this.player = GameObject.Find("player");
    }
    void Update()
    {
        transform.Translate(0, -0.015f, 0);

        if (transform.position.y < -5.0f) Destroy(gameObject);

        // �浹 ����
        Vector2 p1 = transform.position;              // ȭ�� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;  // �÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;  // ȭ�� �ݰ�
        float r2 = 0.7f;  // �÷��̾� �ݰ�

        if (d < r1 + r2)
        {
            Destroy(gameObject);
            Debug.Log("�浹");
        }

    } 

}
