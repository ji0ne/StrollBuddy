using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StepCounter : MonoBehaviour
{
    private int stepCount = 0;

    // ���̷μ��� ���� �о�� ���� ���� ���� �Ӱ谪
    public float gyroThreshold = 4.0f;

    private Vector3 previousRotation;

    public TextMeshProUGUI stepCountText;

    Vector3 deltaRotation;
    void Start()
    {
        Input.gyro.enabled = true;
        // �ʱ� ���̷μ��� ���� ����
        previousRotation = Input.gyro.rotationRateUnbiased;
        StartCoroutine(StepCountUpdate());
    }

    void Update()
    {
        // ���� ���̷μ��� ���� �б�
        Vector3 currentRotation = Input.gyro.rotationRateUnbiased;

        // ���� ��ȭ�� ���
        deltaRotation = currentRotation - previousRotation;
        
        //���� ���̷� ���� ���� ���� �Ҵ�(���̷ΰ� ������Ʈ)
        previousRotation = currentRotation;
    }

    //�ڷ�ƾ �޼���� ���� 0.5�� �����θ� ���� �����ϵ��� ��
    IEnumerator StepCountUpdate()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(0.3f);

            // X�� ���������� ���� ��ȭ�� ���� �Ӱ谪 �̻��̸� �������� ����
            if (Mathf.Abs(deltaRotation.x) > gyroThreshold)
            {
                stepCount++;
                UpdateStepCountUI();
            }
            Debug.Log("�ڷ�ƾ�׽�Ʈ");
        }
    }


    // UI ���� �� ������Ʈ
    void UpdateStepCountUI()
    {
        if (stepCountText != null) stepCountText.text = ""+stepCount;
        
    }
}
