using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        // 자기 위치와 target의 위치가 5보다 작으면 대상을 바라보도록 설정합니다.
        if(Vector3.Distance(transform.position, target.transform.position)<=5)
        {
            transform.LookAt(target.transform);
        }
        else    // 그렇지 않다면 회전값을 15,90,0으로 돌려놓습니다.

        {
            transform.rotation= Quaternion.Euler(15,90,0);
        }
    }
}
