using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animals
{
    Cat, Squirrel
}

public class DataManager : MonoBehaviour
{
    //�̱��� ���� : DataManager Ŭ������ �ν��Ͻ��� static������ �����Ͽ�
    //�ٸ� ��ũ��Ʈ������ instance�� ����Ͽ� DataManger�� ��������ִ� currentAnimals ������
    //����� �� �ְ� �� -> DataManager�� ��������ִ� ����, �޼��� ���� instance�� �̿��ؼ� ����
    public static DataManager instance;
    
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;

        DontDestroyOnLoad(gameObject);
        //���� ��ȯ�Ǿ Object �ı����� ����
    }

    public Animals currentAnimals;
}
