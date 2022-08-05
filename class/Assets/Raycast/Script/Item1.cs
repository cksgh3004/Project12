using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "Scriptable Objext/Item", order=0)]
public class Item1 : ScriptableObject
{
    public int price;
    public Sprite PurchasePicture;
    public Sprite itemBoader;
    public Sprite itemPicture;
}
