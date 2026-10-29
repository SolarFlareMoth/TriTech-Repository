using UnityEngine;
using TMPro;

public class UpgradeYourSword : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SwordLevelUp();
    }

    // Update is called once per frame
    void Update()
    {
        SwordLevelUp();
    }

    public int coins = 0;
    public int swordlvl = 1;
    public TMP_Text coinText;

    void SwordLevelUp()
    {
        //string name for editing the sword to make different references
        //so far, Gjallarhorn, Sw-orb of destruction, Australium Frying pan, Pain Train, & Australian Danger Noodle have been names
        string weaponName = "Austrailian Danger Noodle";
        if (coins >=50)
        {
            swordlvl++;
            coins -= 50;
            Debug.Log("You have " + coins + " coins remaining!"); 
            Debug.Log("Your " + weaponName + " is now masterworked to level " + swordlvl + "!");
            coinText.text = "Coins: " + coins;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Coin")
        {
            coins++;
            Debug.Log("You got " + coins + " coins!");
            coinText.text = "Coins: " + coins;

        }
        if (collision.gameObject.tag == "BigCoin")
        {
            coins += 5;
            Debug.Log("you got " + coins + " Coins!");
            coinText.text = "Coins: " + coins;

        }
    }
}
