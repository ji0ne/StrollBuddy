using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StepCounter : MonoBehaviour
{
    // 걸음 수를 저장할 변수
    private int stepCount = 0;

    // 자이로센서 값을 읽어올 때의 각도 변경 임계값
    public float gyroThreshold = 1.0f;

    // 이전 자이로센서 각도를 저장할 변수
    private Vector3 previousRotation;

    // UI에 걸음 수를 표시할 TextMeshPro Text 요소
    public TextMeshProUGUI stepCountText;

    void Start()
    {
        Input.gyro.enabled = true;
        // 초기 자이로센서 각도 설정
        previousRotation = Input.gyro.rotationRateUnbiased;
    }

    void Update()
    {
        // 현재 자이로센서 각도 읽기
        Vector3 currentRotation = Input.gyro.rotationRateUnbiased;

        // 각도 변화량 계산
        Vector3 deltaRotation = currentRotation - previousRotation;

        // X축 기준으로의 각도 변화가 일정 임계값 이상이면 걸음으로 간주
        if (Mathf.Abs(deltaRotation.x) > gyroThreshold)
        {
            // 걸음 수 증가
            stepCount++;

            // 걸음 수를 화면에 표시
            UpdateStepCountUI();
        }

        // 현재 자이로센서 각도를 이전 각도로 업데이트
        previousRotation = currentRotation;
    }

    // UI에 걸음 수를 업데이트하는 함수
    void UpdateStepCountUI()
    {
        // TextMeshPro Text 요소가 존재하는 경우에만 업데이트
        if (stepCountText != null)
        {
            // 걸음 수를 TextMeshPro Text에 표시
            stepCountText.text = "Step Count: " + stepCount;
        }
    }
}
