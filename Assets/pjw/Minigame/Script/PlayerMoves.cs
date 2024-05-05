using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    void Update()
    {
        if(Input.touchCount == 1 )
        {
            if(Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                if (Input.GetTouch(0).position.x > (Screen.width / 2) && transform.position.x < 3)
                {
                    transform.Translate(0.2f, 0, 0);
                }
                else if(Input.GetTouch(0).position.x < (Screen.width/2) && transform.position.x > -3)
                {
                    transform.Translate(-0.2f, 0, 0);
                }
            }    
            
        }

    }
}
