using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animals
{
    Cat, Squirrel
}

public class DataManager : MonoBehaviour
{
    //싱글폰 패턴 : DataManager 클래스의 인스턴스를 static변수로 생성하여
    //다른 스크립트에서도 instance를 사용하여 DataManger에 만들어져있는 currentAnimals 변수를
    //사용할 수 있게 함 -> DataManager에 만들어져있는 변수, 메서드 등을 instance를 이용해서 접근
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
