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

        // 충돌 판정
        Vector2 p1 = transform.position;              // 화살 중심 좌표
        Vector2 p2 = this.player.transform.position;  // 플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;  // 화살 반경
        float r2 = 0.7f;  // 플레이어 반경

        if (d < r1 + r2)
        {
            Destroy(gameObject);
            Debug.Log("충돌");
        }

    } 

}
