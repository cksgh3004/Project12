using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data
{
    // 기본 접근 지정자= private
    public int price;
    public string name;
    public Sprite sprite;
    // 기본 생성자
    // 생성자를 선언하지 않으면 자동으로 기본 생성자를 생성시켜줍니다.
}



public class LifeCycle : MonoBehaviour
{

    // 유니티에서는 소멸자가 존재하지 않음

    public Data [] data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    private void Awake()
    { 
       for (int i = 0; i < data.Length; i++)
        {
            priceUI[i].text = data[i].price.ToString();
            nameUI[i].text = data[i].name;
            spriteUI[i].sprite=data[i].sprite;
        }
    }

    void Start()
    {
        Debug.Log("Tiger Start");
    }

    private void OnEnable()
    {
        Debug.Log("Tiger OnEnable");
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }

    private void Update()
    {
        
    }

    private void OnDisable()       // 게임 오브젝트가 비활성화 될때마다 호출되는 함수입니다.
    {
        Debug.Log("Tiger Ondisable");
    }

    private void OnDestroy()       // 게임 오브젝트가 파괴되는 순간 호출되는 함수입니다.
    {
        
    }
}
