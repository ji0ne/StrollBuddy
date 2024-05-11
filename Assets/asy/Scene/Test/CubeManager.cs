using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CubeManager : MonoBehaviour
{
    public NPCConversation myConversation;
    //대화 시스템을 이용할 변수를 만들어줌
    //이 변수를 통해서 개별 대화를 할당할 수 있음

    //클릭했을 때 대화를 시작하는 코드
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            //npc를 마우스 왼쪽 버튼으로 클릭하면 대화관리자를 사용해서 대화를 시작
            ConversationManager.Instance.StartConversation(myConversation);
            //myConversation이 내가 방금 만든 대화를 담고 있는 변수인 듯
            //StartConversation(myConversation)을 하면 만든 대화를 실행
        }
    }
}
