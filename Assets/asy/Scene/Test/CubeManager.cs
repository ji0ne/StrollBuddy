using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CubeManager : MonoBehaviour
{
    public NPCConversation myConversation;
    //��ȭ �ý����� �̿��� ������ �������
    //�� ������ ���ؼ� ���� ��ȭ�� �Ҵ��� �� ����

    //Ŭ������ �� ��ȭ�� �����ϴ� �ڵ�
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            //npc�� ���콺 ���� ��ư���� Ŭ���ϸ� ��ȭ�����ڸ� ����ؼ� ��ȭ�� ����
            ConversationManager.Instance.StartConversation(myConversation);
            //myConversation�� ���� ��� ���� ��ȭ�� ��� �ִ� ������ ��
            //StartConversation(myConversation)�� �ϸ� ���� ��ȭ�� ����
        }
    }
}
