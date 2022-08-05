using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public int money;
    public int hat;
    public int stick;

    private void Awake()
    {
        // 최초 생성 이후에 갱신이 안되기 때문에 Awake()함수에서 NULL체크를 합니다.
        if(instance == null)
        {
            // this를 static에 저장해야 꺼내서 사용할수 있습니다.
            instance = this;
        }
        LoadData();
    }
    public void SaveData()
    {
        // 유니티 내부에 key(" ") value( )으로 저장합니다.
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("hat", hat);
        PlayerPrefs.SetInt("stick", stick);
    }

    public void LoadData()
    {
        // 유니티 내부에 저장되어 있는 key(" ")값을 불러옵니다.
        money = PlayerPrefs.GetInt("money");
        hat = PlayerPrefs.GetInt("hat");
        stick = PlayerPrefs.GetInt("stick");
    }

    public void InccreaseMoney()
    {
        money += 100;
        SaveData();
    }
}
