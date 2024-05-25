using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationController : MonoBehaviour
{
    public NPCConversation[] myConversation;

    public void SelectConversation()
    {
        int n = Random.Range(0,myConversation.Length);
        ConversationManager.Instance.StartConversation(myConversation[n]);
    }
}
