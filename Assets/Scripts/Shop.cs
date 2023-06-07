using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public int hasJump = 0;

    public void BuyDoubleJump()
    {
        hasJump = 1;
    }

    public void Reset()
    {
        hasJump = 0;
    }

    public void SaveShop()
    {
        SaveSystem.SaveShop(this);
    }

    public void LoadShop()
    {
        ShopData data = SaveSystem.LoadShop();
        hasJump = data.hasJump;

        if(hasJump == 1)
        {
            Debug.Log("This is what I want to read");
        }
        else
        {
            Debug.Log("D'oh!");
        }
        SceneManager.LoadScene("Level 1");
    }
}
