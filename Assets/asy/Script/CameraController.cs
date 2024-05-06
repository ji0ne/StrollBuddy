using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{ 
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        target = GameObject.FindWithTag("chars").transform;
        //캐릭터 위치 - 카메라 위치해서 카메라의 위치를 지정해줌
        Vector3 desiredPosition = new Vector3(
            target.position.x - offset.x,
            offset.y,
            target.position.z - offset.z + 1
            );
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
