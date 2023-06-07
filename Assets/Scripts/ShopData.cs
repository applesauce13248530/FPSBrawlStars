using UnityEngine;

[System.Serializable]
public class ShopData
{
    public int hasJump;

    public ShopData(Shop shop)
    {
        hasJump = shop.hasJump;
    }
}
