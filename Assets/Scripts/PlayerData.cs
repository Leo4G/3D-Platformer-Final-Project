using UnityEngine;

public class PlayerData : MonoBehaviour
{
   public int coinsCollected;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinsCollected += 1;
            
            other.gameObject.SetActive(false);
        }
    
    }
}
