using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanageManager : MonoBehaviour
{
    public void ClickCharButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Select");
    }

    public void ClickStartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
    
    public void ClickMiniGameButton()
    {        
        if(GameManager.gameCount > 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("ArrowGame");
        }else if(GameManager.gameCount <= 0)
        {
            Debug.Log("게임 횟수 없음");
        }
    }

    public void ClickStrollButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Stroll");
    }
}

