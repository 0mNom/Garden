using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProgressionSystem : MonoBehaviour
{
    public PotPlaces pot;
     
    public GameObject levelUpButton;
    public GameObject tomatoBuyButton;
    public GameObject eggplantBuyButton;
    public GameObject pearBuyButton;
    public GameObject sunflowerBuyButton;
    public GameObject cherryBuyButton;
    public GameObject avocadoBuyButton;
    public GameObject kiwiBuyButton;

    public GameObject pot2;
    public GameObject pot3;

    public GameObject pot2Shine;
    public GameObject pot3Shine;

    public GameObject NoMoneyToLvlUpPanel;
    public GameObject bagObject;

    public int playerLevel;

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
            priceToLevelUpText.text = "Spend 250 leaves to level up, get a new pot, access to the Tomato seed, 10 ambers and a free Wheat seed?";

            pot2.GetComponent<Collider2D>().enabled = false;
            pot2.GetComponent<SpriteRenderer>().enabled = false;
            pot2Shine.GetComponent<SpriteRenderer>().enabled = false;

            pot3.GetComponent<Collider2D>().enabled = false;
            pot3.GetComponent<SpriteRenderer>().enabled = false;
            pot3Shine.GetComponent<SpriteRenderer>().enabled = false;

            // clickToPlantScriptPot2 = pot2.GetComponent<ClickToPlant>();
            //clickToPlantScriptPot2.gotPlant = true;
            //ClickToPlant clickToPlantScriptPot3 = pot3.GetComponent<ClickToPlant>();
            //clickToPlantScriptPot3.gotPlant = true;

            pot.lvl = 1;

            tomatoBuyButton.GetComponent<Button>().interactable = false;
            eggplantBuyButton.GetComponent<Button>().interactable = false;
            pearBuyButton.GetComponent<Button>().interactable = false;
            sunflowerBuyButton.GetComponent<Button>().interactable = false;
            cherryBuyButton.GetComponent<Button>().interactable = false;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
        }

        if (playerLevel == 2)
        {
            playerLevelText.text = "Level 2";
            priceToLevelUpText.text = "Spend 750 leaves to level up, get a new pot, 15 ambers, and a free Apple seed?";

            pot3.GetComponent<Collider2D>().enabled = false;
            pot3.GetComponent<SpriteRenderer>().enabled = false;
            pot3Shine.GetComponent<SpriteRenderer>().enabled = false;

            //ClickToPlant clickToPlantScriptPot3 = pot3.GetComponent<ClickToPlant>();
            //clickToPlantScriptPot3.gotPlant = true;
            pot.lvl = 2;
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = false;
            pearBuyButton.GetComponent<Button>().interactable = false;
            sunflowerBuyButton.GetComponent<Button>().interactable = false;
            cherryBuyButton.GetComponent<Button>().interactable = false;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
        }
        else if (playerLevel == 3)
        {
            playerLevelText.text = "Level 3";
            priceToLevelUpText.text = "Spend 1500 leaves to level up, get access to the Eggplant seed, 20 ambers, and a free Tomato seed?";
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = false;
            pearBuyButton.GetComponent<Button>().interactable = false;
            sunflowerBuyButton.GetComponent<Button>().interactable = false;
            cherryBuyButton.GetComponent<Button>().interactable = false;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
            pot.lvl = 3;
        }
        else if (playerLevel == 4)
        {
            playerLevelText.text = "Level 4";
            priceToLevelUpText.text = "Spend 3500 leaves to level up, get access to the Pear seed, 25 ambers, and a free Eggplant seed?";
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = true;
            pearBuyButton.GetComponent<Button>().interactable = false;
            sunflowerBuyButton.GetComponent<Button>().interactable = false;
            cherryBuyButton.GetComponent<Button>().interactable = false;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
            pot.lvl = 4;
        }
        else if (playerLevel == 5)
        {
            playerLevelText.text = "Level 5";
            priceToLevelUpText.text = "Spend 7500 leaves to level up, get access to the Sunflower seed, 30 ambers, and a free Pear seed?";
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = true;
            pearBuyButton.GetComponent<Button>().interactable = true;
            sunflowerBuyButton.GetComponent<Button>().interactable = false;
            cherryBuyButton.GetComponent<Button>().interactable = false;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
            pot.lvl = 5;
        }
        else if (playerLevel == 6)
        {
            playerLevelText.text = "Level 6";
            priceToLevelUpText.text = "Spend 15000 leaves to level up, get access to the Cherry seed, 35 ambers, and a free Sunflower seed?";
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = true;
            pearBuyButton.GetComponent<Button>().interactable = true;
            sunflowerBuyButton.GetComponent<Button>().interactable = true;
            cherryBuyButton.GetComponent<Button>().interactable = false;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
            pot.lvl = 6;
        }
        else if (playerLevel == 7)
        {
            playerLevelText.text = "Level 7";
            priceToLevelUpText.text = "Spend 22500 leaves to level up, get access to the Avocado seed, 40 ambers, and a free Cherry seed?";
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = true;
            pearBuyButton.GetComponent<Button>().interactable = true;
            sunflowerBuyButton.GetComponent<Button>().interactable = true;
            cherryBuyButton.GetComponent<Button>().interactable = true;
            avocadoBuyButton.GetComponent<Button>().interactable = false;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
            pot.lvl = 7;
        }
        else if (playerLevel == 8)
        {
            playerLevelText.text = "Level 8";
            priceToLevelUpText.text = "Spend 55000 leaves to level up, get access to the Kiwi seed, 45 ambers, and a free Avocado seed?";
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = true;
            pearBuyButton.GetComponent<Button>().interactable = true;
            sunflowerBuyButton.GetComponent<Button>().interactable = true;
            cherryBuyButton.GetComponent<Button>().interactable = true;
            avocadoBuyButton.GetComponent<Button>().interactable = true;
            kiwiBuyButton.GetComponent<Button>().interactable = false;
            pot.lvl = 8;
        }
        else if (playerLevel == 9)
        {
            playerLevelText.text = "Level 9";
            levelUpButton.SetActive(false);
            tomatoBuyButton.GetComponent<Button>().interactable = true;
            eggplantBuyButton.GetComponent<Button>().interactable = true;
            pearBuyButton.GetComponent<Button>().interactable = true;
            sunflowerBuyButton.GetComponent<Button>().interactable = true;
            cherryBuyButton.GetComponent<Button>().interactable = true;
            avocadoBuyButton.GetComponent<Button>().interactable = true;
            kiwiBuyButton.GetComponent<Button>().interactable = true;
            pot.lvl = 9;
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
                bagScript.wheatseed = bagScript.wheatseed + 1;
                bagScript.Gems = bagScript.Gems + 10;
                bagScript.Monay = bagScript.Monay - 250;
                pot2.GetComponent<Collider2D>().enabled = true;
                pot2.GetComponent<SpriteRenderer>().enabled = true;
                pot2Shine.GetComponent<SpriteRenderer>().enabled = true;
                //ClickToPlant clickToPlantScriptPot2 = pot2.GetComponent<ClickToPlant>();
                //clickToPlantScriptPot2.gotPlant = false;
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
                bagScript.appleseed = bagScript.appleseed + 1;
                bagScript.Gems = bagScript.Gems + 15;
                bagScript.Monay = bagScript.Monay - 750;
                pot3.GetComponent<Collider2D>().enabled = true;
                pot3.GetComponent<SpriteRenderer>().enabled = true;
                pot3Shine.GetComponent<SpriteRenderer>().enabled = true;
                // clickToPlantScriptPot3 = pot3.GetComponent<ClickToPlant>();
                //clickToPlantScriptPot3.gotPlant = false;
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
                bagScript.tomatoseed = bagScript.tomatoseed + 1;
                bagScript.Gems = bagScript.Gems + 20;
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
                bagScript.eggplantseed = bagScript.eggplantseed + 1;
                bagScript.Gems = bagScript.Gems + 25;
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
                bagScript.pearseed = bagScript.pearseed + 1;
                bagScript.Gems = bagScript.Gems + 30;
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
                bagScript.sunflowerseed = bagScript.sunflowerseed + 1;
                bagScript.Gems = bagScript.Gems + 35;
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
                bagScript.cherryseed = bagScript.cherryseed + 1;
                bagScript.Gems = bagScript.Gems + 40;
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
                bagScript.avoseed = bagScript.avoseed + 1;
                bagScript.Gems = bagScript.Gems + 45;
                bagScript.Monay = bagScript.Monay - 55000;
            }
            else
            {
                NoMoneyToLvlUpPanel.SetActive(true);
            }
        }
    }
}
