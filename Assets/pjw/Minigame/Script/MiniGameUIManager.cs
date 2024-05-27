using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGameUIManager : MonoBehaviour
{
   GameObject count;
   int time;

    void Start()
    {
      count = GameObject.Find("Count");       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
