using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanageManager : MonoBehaviour
{
    public void ClickCharButton()
    {
        SceneManager.LoadScene("Select");
    }

    public void ClickStartButton()
    {
        SceneManager.LoadScene("Play");
    }
    
    public void ClickMiniGameButton()
    {        
        if(GameManager.gameCount > 0)
        {
            SceneManager.LoadScene("ArrowGame");
        }else if(GameManager.gameCount <= 0)
        {
            Debug.Log("게임 횟수 없음");
        }
    }
}

