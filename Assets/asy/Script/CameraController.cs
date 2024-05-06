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
        //ĳ���� ��ġ - ī�޶� ��ġ�ؼ� ī�޶��� ��ġ�� ��������
        Vector3 desiredPosition = new Vector3(
            target.position.x - offset.x,
            offset.y,
            target.position.z - offset.z + 1
            );
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
