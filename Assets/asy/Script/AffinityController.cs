using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AffinityController : MonoBehaviour
{
    GameObject affinityScore;  //UI�� ȣ���� ����ϴ��� �׽�Ʈ��

    private void Start()
    {
        affinityScore = GameObject.Find("affinityScore");
    }

    public void Increase10Affinity()
    {
        GameManager.affinity += 10;
        affinityScore.GetComponent<TextMeshProUGUI>().text = GameManager.affinity.ToString();
    }

    public void Increase30Affinity()
    {
        GameManager.affinity += 30;
        affinityScore.GetComponent<TextMeshProUGUI>().text = GameManager.affinity.ToString();
    }

    public void Increase50Affinity()
    {
        GameManager.affinity += 50;
        affinityScore.GetComponent<TextMeshProUGUI>().text = GameManager.affinity.ToString();
    }
}
