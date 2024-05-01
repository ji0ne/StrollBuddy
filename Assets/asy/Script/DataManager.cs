using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animals
{
    Cat, Squirrel
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;

        DontDestroyOnLoad(gameObject);
        //씬이 전환되어도 Object 파괴되지 않음
    }

    public Animals currentAnimals;
}
