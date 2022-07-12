using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 필드
    // c#은 파스칼표기법과 카멜 표기법을 사용합니다.
    // 변수 선언
    int health;
    int countIndex;

    void Start()
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()       // 유니티에서 제공되는 함수
    {
        
    }
}
