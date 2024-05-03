using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    GameObject player;
    public Vector3 offSet;

    void Start()
    {
        player = GameObject.Find("DataManager");        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        transform.position = new Vector3(playerPos.x, transform.position.y, playerPos.z);
    }
}
