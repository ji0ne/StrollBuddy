using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    //GameObject player;
    //public Vector3 offSet;
    //Vector3 playerPos;

    //void Start()
    //{
    //    //transform.position = offSet;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    player = GameObject.FindWithTag("chars");
    //    playerPos = player.transform.position;
    //    transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
    //}

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        target = GameObject.FindWithTag("chars").transform;
        Vector3 desiredPosition = new Vector3(
            target.position.x - offset.x,
            offset.y,
            target.position.z - offset.z + 1
            );
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(target);
    }
}
