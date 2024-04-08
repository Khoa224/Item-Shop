using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ShopMenu", menuName = "Scriptable Objects/New Shop Item", order =1)]
public class ShopItemSO : ScriptableObject
{
    public string title;
    public string description;
    public int baseCost;
    // private Sprite image;
    // public Sprite Image
    // {
    //     get { return image; }
    //     set { image = value; }
    // }
    //test
}
