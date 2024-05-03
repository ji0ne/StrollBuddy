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
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.transform.position);
        Debug.Log(player);
        Debug.Log(transform.position);
        transform.position = new Vector3(-player.transform.position.x,player.transform.position.y,player.transform.position.z) + offSet;
    }
}
