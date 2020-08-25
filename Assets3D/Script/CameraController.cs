using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject targetCamera;
    public GameObject targetObject;

    private Vector3 offset; // 카메라와 타겟 사이의 거리

    // Start is called before the first frame update
    void Start()    // 시작할 때 선언
    {
        offset = targetCamera.transform.position - targetObject.transform.position;
        // 거리 = 타겟카메라의 트랜스폼의 포지션(위치) 뺴기 타겟오브젝트의 트랜스폼의 위치
    }

    // Update is called once per frame
    void Update()
    {
        targetCamera.transform.position = offset + targetObject.transform.position;
        // 타겟 카메라 위치 설정 ( 거리 + 타겟 오브젝트 위치)
    }
}
