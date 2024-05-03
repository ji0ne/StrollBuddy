using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject MainCamera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Spawn.player.transform.position + MainCamera.transform.position;
    }
}
