using UnityEngine;

public class CoinCollectionSystem : MonoBehaviour
{
    public int Coin = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Coin")
        {
            Coin++;
            Debug.Log("You got " + Coin + " coins!");
        }
        if(collision.gameObject.tag == "BigCoin")
        {
            Coin += 5;
            Debug.Log("you got " + Coin + " Coins!");
        }
    }

}
