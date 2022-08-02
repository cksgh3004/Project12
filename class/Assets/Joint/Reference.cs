using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int value = 10;
        int variable = 20;

        value = variable;

        // 참조타입
        Item hat = new Item();
        Item sword = new Item();
       
 

        hat.Information(1000, 10);
        sword.Information(5000, 10);

        hat = sword;
        Debug.Log("Hat의 가격: " + hat.price + "Hat의크기: " + hat.size);
        Debug.Log("Sword의 가격: " + hat.price + "Sword의크기: " + hat.size);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Item
{
    public int price;
    public int size;

    public void Information(int price, int size)
    {
        this.price = price;
        this.size = size;

    }

}
