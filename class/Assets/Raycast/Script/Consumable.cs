using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    [SerializeField] Image boader;
    [SerializeField] Image picture;
    [SerializeField] Image purchasePicture;

    [SerializeField] Text price;

    [SerializeField] Item1 item;
    void Start()
    {
        boader.sprite = item.itemBoader;
        picture.sprite = item.itemPicture;
        purchasePicture.sprite = item.PurchasePicture;

        price.text=item.price.ToString();
    }
}
