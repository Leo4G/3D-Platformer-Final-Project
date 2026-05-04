using UnityEngine;
using TMPro;

public class CoinCounterUI : MonoBehaviour
{
    public TMP_Text coinCounter;
    public PlayerData player;


    void Update()
    {
        coinCounter.text = "Coins Collected" + player.coinsCollected;
    }
}
