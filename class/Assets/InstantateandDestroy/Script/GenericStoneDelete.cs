using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericStoneDelete : MonoBehaviour
{
    Rigidbody rigid;
    private void Start()
    {
        rigid=GetComponent<Rigidbody>();
    }

    // OnBecameInvisible(): 카메라가 렌더링하는 시야 범위로 벗어났을때 호출되는 함수입니다.
    private void OnBecameInvisible()
    {
        if(gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject);
        }
        else if(gameObject.name=="Stone_5(Clone)")
        {
            rigid.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(0,5,0);

            ObjectPool.objPool.InsertQueue(gameObject);
        }
    }
}
