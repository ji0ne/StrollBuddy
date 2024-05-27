using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
     float miniGameTime;

     private void Update()
     {
        miniGameTime = Time.deltaTime;

        if (miniGameTime > 5f)
        {
           GameManager.gameCount++;
           Debug.Log(GameManager.gameCount);
        }
     }
}
