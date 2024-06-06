using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using TMPro;

public class ConversationController : MonoBehaviour
{
    public NPCConversation[] myConversation;
    GameObject conversationText; //대화 횟수

    private void Start()
    {
        conversationText = GameObject.Find("ConversationCount");

        //대화 되는지 테스트 하기 위해서 대화 횟수 1로 설정 -> 추후에 삭제해야함 !!
        GameManager.conversationCount = 1;
    }

    private void Update()
    {
        conversationText.GetComponent<TextMeshProUGUI>().text = GameManager.conversationCount.ToString();
    }

    public void SelectConversation()
    {        
        if (GameManager.conversationCount > 0)
        {
            int n = Random.Range(0, myConversation.Length);
            ConversationManager.Instance.StartConversation(myConversation[n]);
            GameManager.conversationCount -= 1;
        }
    }
}
