using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProgressionSystem : MonoBehaviour
{
    public GameObject NoMoneyToLvlUpPanel;
    public GameObject bagObject;

    public int playerLevel;

    public bool canBuyTomato;
    public bool canBuyEggplant;
    public bool canBuyPear;
    public bool canBuySunflower;
    public bool canBuyCherry;
    public bool canBuyAvocado;
    public bool canBuyKiwi;

    public TextMeshProUGUI playerLevelText;
    public TextMeshProUGUI priceToLevelUpText;

    // Start is called before the first frame update
    void Start()
    {
        playerLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLevel == 1)
        {
            playerLevelText.text = "Level 1";
            priceToLevelUpText.text = "Spend 250 leaves to level up and get a new pot, access to the Tomato seed, and 10 free amber?";
            canBuyTomato = false;
            canBuyEggplant = false;
            canBuyPear = false;
            canBuySunflower = false;
            canBuyCherry = false;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }

        if (playerLevel == 2)
        {
            playerLevelText.text = "Level 2";
            priceToLevelUpText.text = "Spend 750 leaves to level up and get a new pot, access to the Eggplant seed and 20 free amber?";
            canBuyTomato = true;
            canBuyEggplant = false;
            canBuyPear = false;
            canBuySunflower = false;
            canBuyCherry = false;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }
        else if (playerLevel == 3)
        {
            playerLevelText.text = "Level 3";
            priceToLevelUpText.text = "Spend 1500 leaves to level up and get access to the Eggplant seed and 30 free amber?";
            canBuyTomato = true;
            canBuyEggplant = false;
            canBuyPear = false;
            canBuySunflower = false;
            canBuyCherry = false;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }
        else if (playerLevel == 4)
        {
            playerLevelText.text = "Level 4";
            priceToLevelUpText.text = "Spend 3500 leaves to level up and get access to the Pear seed and 40 free amber?";
            canBuyTomato = true;
            canBuyEggplant = true;
            canBuyPear = false;
            canBuySunflower = false;
            canBuyCherry = false;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }
        else if (playerLevel == 5)
        {
            playerLevelText.text = "Level 5";
            priceToLevelUpText.text = "Spend 7500 leaves to level up and get access to the Sunflower seed and 50 free amber?";
            canBuyTomato = true;
            canBuyEggplant = true;
            canBuyPear = true;
            canBuySunflower = false;
            canBuyCherry = false;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }
        else if (playerLevel == 6)
        {
            playerLevelText.text = "Level 6";
            priceToLevelUpText.text = "Spend 15000 leaves to level up and get access to the Cherry seed and 60 free amber?";
            canBuyTomato = true;
            canBuyEggplant = true;
            canBuyPear = true;
            canBuySunflower = true;
            canBuyCherry = false;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }
        else if (playerLevel == 7)
        {
            playerLevelText.text = "Level 7";
            priceToLevelUpText.text = "Spend 22500 leaves to level up and get access to the Avocado seed and 70 free amber?";
            canBuyTomato = true;
            canBuyEggplant = true;
            canBuyPear = true;
            canBuySunflower = true;
            canBuyCherry = true;
            canBuyAvocado = false;
            canBuyKiwi = false;
        }
        else if (playerLevel == 8)
        {
            playerLevelText.text = "Level 8";
            priceToLevelUpText.text = "Spend 55000 leaves to level up and get access to the Kiwi seed and 80 free amber?";
            canBuyTomato = true;
            canBuyEggplant = true;
            canBuyPear = true;
            canBuySunflower = true;
            canBuyCherry = true;
            canBuyAvocado = true;
            canBuyKiwi = false;
        }
        else if (playerLevel == 9)
        {
            playerLevelText.text = "Level 9";
            canBuyTomato = true;
            canBuyEggplant = true;
            canBuyPear = true;
            canBuyPear = true;
            canBuySunflower = true;
            canBuyCherry = true;
            canBuyAvocado = true;
            canBuyKiwi = true;
        }
    }


    public void BuyLevel()
    {
        BagScript bagScript = bagObject.GetComponent<BagScript>();
        
        if (playerLevel == 1)
        {
            if (bagScript.Monay >= 250)
            {
                playerLevel = 2;
                bagScript.Gems = bagScript.Gems + 10;
                bagScript.Monay = bagScript.Monay - 250;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 2)
        {
            if (bagScript.Monay >= 750)
            {
                playerLevel = 3;
                bagScript.Gems = bagScript.Gems + 20;
                bagScript.Monay = bagScript.Monay - 750;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 3)
        {
            if (bagScript.Monay >= 1500)
            {
                playerLevel = 4;
                bagScript.Gems = bagScript.Gems + 30;
                bagScript.Monay = bagScript.Monay - 1500;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 4)
        {
            if (bagScript.Monay >= 3500)
            {
                playerLevel = 5;
                bagScript.Gems = bagScript.Gems + 40;
                bagScript.Monay = bagScript.Monay - 3500;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 5)
        {
            if (bagScript.Monay >= 7500)
            {
                playerLevel = 6;
                bagScript.Gems = bagScript.Gems + 50;
                bagScript.Monay = bagScript.Monay - 7500;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 6)
        {
            if (bagScript.Monay >= 15000)
            {
                playerLevel = 7;
                bagScript.Gems = bagScript.Gems + 60;
                bagScript.Monay = bagScript.Monay - 15000;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 7)
        {
            if (bagScript.Monay >= 22500)
            {
                playerLevel = 8;
                bagScript.Gems = bagScript.Gems + 70;
                bagScript.Monay = bagScript.Monay - 22500;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
        else if (playerLevel == 8)
        {
            if (bagScript.Monay >= 55000)
            {
                playerLevel = 9;
                bagScript.Gems = bagScript.Gems + 80;
                bagScript.Monay = bagScript.Monay - 55000;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
    }
}
