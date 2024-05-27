using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGameCount : MonoBehaviour
{
    GameObject gameCountText;
    GameObject MiniGameTime;
    int min;
    float sec;

    private void Start()
    {
        gameCountText = GameObject.Find("GameCount");
        MiniGameTime = GameObject.Find("MiniGameTime");
        sec = 0;
        min = 0;
    }

    void Update()
    {
        sec += Time.deltaTime;

        if(sec >= 60f)
        {
            min += 1;
            sec = 0;
        }

        MiniGameTime.GetComponent<TextMeshProUGUI>().text = string.Format("{0:D2}:{1:D2}", min, (int)sec);

        if (sec > 10) //나중에 2분으로 값 수정 min > 2
        {
            //min = 0;
            sec = 0;
            GameManager.gameCount += 1;            
            gameCountText.GetComponent<TextMeshProUGUI>().text = GameManager.gameCount.ToString();
        }
    }
}
