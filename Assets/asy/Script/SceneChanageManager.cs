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
}

