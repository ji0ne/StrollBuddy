using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StepCounter : MonoBehaviour
{
    // ���� ���� ������ ����
    private int stepCount = 0;

    // ���̷μ��� ���� �о�� ���� ���� ���� �Ӱ谪
    public float gyroThreshold = 1.0f;

    // ���� ���̷μ��� ������ ������ ����
    private Vector3 previousRotation;

    // UI�� ���� ���� ǥ���� TextMeshPro Text ���
    public TextMeshProUGUI stepCountText;

    void Start()
    {
        Input.gyro.enabled = true;
        // �ʱ� ���̷μ��� ���� ����
        previousRotation = Input.gyro.rotationRateUnbiased;
    }

    void Update()
    {
        // ���� ���̷μ��� ���� �б�
        Vector3 currentRotation = Input.gyro.rotationRateUnbiased;

        // ���� ��ȭ�� ���
        Vector3 deltaRotation = currentRotation - previousRotation;

        // X�� ���������� ���� ��ȭ�� ���� �Ӱ谪 �̻��̸� �������� ����
        if (Mathf.Abs(deltaRotation.x) > gyroThreshold)
        {
            // ���� �� ����
            stepCount++;

            // ���� ���� ȭ�鿡 ǥ��
            UpdateStepCountUI();
        }

        // ���� ���̷μ��� ������ ���� ������ ������Ʈ
        previousRotation = currentRotation;
    }

    // UI�� ���� ���� ������Ʈ�ϴ� �Լ�
    void UpdateStepCountUI()
    {
        // TextMeshPro Text ��Ұ� �����ϴ� ��쿡�� ������Ʈ
        if (stepCountText != null)
        {
            // ���� ���� TextMeshPro Text�� ǥ��
            stepCountText.text = "Step Count: " + stepCount;
        }
    }
}
