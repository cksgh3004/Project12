using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    public LayerMask layer;
    private RaycastHit hit;

    void Update()
    {
        // GetMouseButton(0) = 마우스 왼쪽 버튼을 클릭했을 때 
        if(Input.GetMouseButton(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);

            // 광선을 발사한 다음 광선과 충돌한 게임 오브젝트가 있다면 hit 변수에 데이터를 저장합니다.
            if(Physics.Raycast(ray, out hit, layer))
            {
                hit.collider.gameObject.GetComponent<Renderer>().material = Resources.Load<Material>("Ice");
            }
        }
    }
}
