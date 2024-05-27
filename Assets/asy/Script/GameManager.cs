using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int affinity {  set; get; } //호감도
    static int maxCount {  set; get; } //최대 점수
    static int conversationCount { set; get; } //대화 횟수
    static int gameCount { set; get; } //미니 게임 횟수
}

