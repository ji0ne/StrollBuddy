using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface GameManager
{
    static int affinity {  set; get; } //ȣ����
    static float maxCount {  set; get; } //�ִ� ����
    static int conversationCount { set; get; } //��ȭ Ƚ��
    static int gameCount { set; get; } //�̴� ���� Ƚ��
   static float time {  set; get; } //�̴ϰ��� ��
}


