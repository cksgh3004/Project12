using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public Animator animator;
    public GameObject window;

    void Update()
    {       // 애니메이터 컨트롤러에서 현재 애니메이터 상태으 이름이 "Close"일때
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // 현재 애니메이션의 진행도가 1보다 크거나 같다면 Window를 비활성화하도록 설계했습니다.
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime>=1)
            {
                window.SetActive(false);
            }
        }
    }
    public void Close()
    {
        animator.SetTrigger("Close");
    }
    public void PopUpOpen()
    {
        window.SetActive(true);
    }
}
