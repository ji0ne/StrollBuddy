using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StepCounter : MonoBehaviour
{
    private int stepCount = 0;

    // 자이로센서 값을 읽어올 때의 각도 변경 임계값
    public float gyroThreshold = 4.0f;

    private Vector3 previousRotation;

    public TextMeshProUGUI stepCountText;

    Vector3 deltaRotation;
    void Start()
    {
        Input.gyro.enabled = true;
        // 초기 자이로센서 각도 설정
        previousRotation = Input.gyro.rotationRateUnbiased;
        StartCoroutine(StepCountUpdate());
    }

    void Update()
    {
        // 현재 자이로센서 각도 읽기
        Vector3 currentRotation = Input.gyro.rotationRateUnbiased;

        // 각도 변화량 계산
        deltaRotation = currentRotation - previousRotation;
        
        //현재 자이로 값을 이전 값에 할당(자이로값 업데이트)
        previousRotation = currentRotation;
    }

    //코루틴 메서드로 빼서 0.5초 단위로만 걸음 측정하도록 함
    IEnumerator StepCountUpdate()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(0.3f);

            // X축 기준으로의 각도 변화가 일정 임계값 이상이면 걸음으로 간주
            if (Mathf.Abs(deltaRotation.x) > gyroThreshold)
            {
                stepCount++;
                UpdateStepCountUI();
            }
            Debug.Log("코루틴테스트");
        }
    }


    // UI 걸음 수 업데이트
    void UpdateStepCountUI()
    {
        if (stepCountText != null) stepCountText.text = ""+stepCount;
        
    }
}
