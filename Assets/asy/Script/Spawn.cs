using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] chars;
    public GameObject player;

    void Start()
    {
        player = Instantiate(chars[(int)DataManager.instance.currentAnimals]);
        player.transform.position = transform.position;
    }

}
