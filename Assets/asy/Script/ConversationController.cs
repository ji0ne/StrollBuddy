using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using TMPro;

public class ConversationController : MonoBehaviour
{
    public NPCConversation[] myConversation;
    GameObject conversationText; //��ȭ Ƚ��

    private void Start()
    {
        conversationText = GameObject.Find("ConversationCount");

        //��ȭ �Ǵ��� �׽�Ʈ �ϱ� ���ؼ� ��ȭ Ƚ�� 1�� ���� -> ���Ŀ� �����ؾ��� !!
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
