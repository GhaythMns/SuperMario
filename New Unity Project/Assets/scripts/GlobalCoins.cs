using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{

    public GameObject CoinDisplay;//the apparence of the number of coins
    public int CoinCount;
    public int InternalCoin;

    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplay.GetComponent<UnityEngine.UI.Text>().text = "Coins: " + CoinCount;
    } 
    public void AddCoins()
    {
        CoinCount += 1;
    }

}