using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{

    public GameObject target; // 카메라가 따라갈 대상
    public float moveSpeed; // 카메라가 따라갈 속도
    private Vector3 targetPosition; // 대상의 현재 위치
    public float start;
    public float end;

    // Update is called once per frame
    void Update()
    {
        {
            if (target.transform.position.x <= start) targetPosition.Set(start, this.transform.position.y, this.transform.position.z);
            else if (target.transform.position.x >= end) targetPosition.Set(end, this.transform.position.y, this.transform.position.z);
            else targetPosition.Set(target.transform.position.x, this.transform.position.y, this.transform.position.z);
            // vectorA -> B까지 T의 속도로 이동
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}