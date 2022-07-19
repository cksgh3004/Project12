using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlandAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

   void Update()
   {                               // ���� ���ϴ� �Է������� �־���ߵ�
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
