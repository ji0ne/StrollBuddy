using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int affinity {  set; get; } //ȣ����
    static int maxCount {  set; get; } //�ִ� ����
    static int conversationCount { set; get; } //��ȭ Ƚ��
    static int gameCount { set; get; } //�̴� ���� Ƚ��
}

