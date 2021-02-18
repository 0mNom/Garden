using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ButtonPopUp : MonoBehaviour
{
    public int GemPrice;

    public GameObject Pot1;
    public GameObject Pot2;
    public GameObject Pot3;

    public Button buttonSkin1;
    public Button buttonSkin2;
    public Button buttonSkin3;
    PotSkins potSkins;
    public GameObject timeTextPot1;
    public GameObject timeTextPot2;
    public GameObject timeTextPot3;

    public GameObject Pay2FastButtonPot1;
    public GameObject Pay2FastButtonPot2;
    public GameObject Pay2FastButtonPot3;
    //public GameObject Pay2FastButtonPot;
    //public GameObject timeTextPot4;
    //public GameObject timeTextPot5;
    //public GameObject timeTextPot6;
    //public GameObject timeTextPot7;
    //public GameObject timeTextPot8;
    //public GameObject timeTextPot9;
    //public GameObject timeTextPot10;


    //watering
    public Watering water;
    public float waterIncrease = 1.1f;


    public bool pannelActive;
    public GameObject bagObject;
    public GameObject thePotClicked;
    Collider2D col;
    public string Name1, Name2, Name3;
    public TextMeshProUGUI nameText;
    public Animator animator;

    public Button sellButton;

    public SpriteRenderer ImagePotDuPopUp;
    public SpriteRenderer ImagePlantDuPopUp;

    public string Tag;

    bool canSell;

    public Button wateringButton;

    void Start()
    {
        potSkins = gameObject.GetComponent<PotSkins>();
        col = GetComponent<Collider2D>();
       
        canSell = true;
        //wateringButton.onClick.AddListener(delegate { WaterOnClick(clickToPlantScript); });
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                BagScript bagScript = bagObject.GetComponent<BagScript>();
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

                if (col == touchedCollider && bagScript.canOpenPannel == true)
                {
                    Tag = col.tag;
                    if (Tag == "1")
                    {
                        timeTextPot1.SetActive(true);
                        timeTextPot2.SetActive(false);
                        timeTextPot3.SetActive(false);
                    }

                    Tag = col.tag;
                    if (Tag == "2")
                    {
                        timeTextPot1.SetActive(false);
                        timeTextPot2.SetActive(true);
                        timeTextPot3.SetActive(false);
                    }

                    Tag = col.tag;
                    if (Tag == "3")
                    {
                        timeTextPot1.SetActive(false);
                        timeTextPot2.SetActive(false);
                        timeTextPot3.SetActive(true);
                    }

                    //Debug.Log(Tag);

                    OpenPanel(Tag);
                    buttonSkin1.onClick.AddListener(potSkins.skin1);
                    buttonSkin2.onClick.AddListener(potSkins.skin2);
                    buttonSkin3.onClick.AddListener(potSkins.skin3);
                }
            }
        }

        if (pannelActive == true)
        {
            ClickToPlant clickToPlantScript = GameObject.FindGameObjectWithTag(Tag).GetComponent<ClickToPlant>();
            if (clickToPlantScript.plantFinished)
            {
                // Debug.Log(Tag);
                sellButton.gameObject.SetActive(true);
                //Debug.Log(gameObject);
                Button btn = sellButton.GetComponent<Button>();

                    btn.onClick.AddListener(SellPlant);
            }

            if (!clickToPlantScript.plantFinished)
            {
                // Debug.Log("yess ");
                sellButton.gameObject.SetActive(false);
            }
            
            if (clickToPlantScript.gotPlant)
            {
                if (Tag == "1")
                {
                    Pay2FastButtonPot1.SetActive(true);
                    Pay2FastButtonPot2.SetActive(false);
                    Pay2FastButtonPot3.SetActive(false);
                }

                Tag = col.tag;
                if (Tag == "2")
                {
                    Pay2FastButtonPot1.SetActive(false);
                    Pay2FastButtonPot2.SetActive(true);
                    Pay2FastButtonPot3.SetActive(false);
                }

                Tag = col.tag;
                if (Tag == "3")
                {
                    Pay2FastButtonPot1.SetActive(false);
                    Pay2FastButtonPot2.SetActive(false);
                    Pay2FastButtonPot3.SetActive(true);
                }
            }

            if (clickToPlantScript.gotPlant == false)
            {
                Pay2FastButtonPot1.SetActive(false);
                Pay2FastButtonPot2.SetActive(false);
                Pay2FastButtonPot3.SetActive(false);
            }


                //PAY TO FAST PART
                GemPrice = clickToPlantScript.remainingTime.Minutes;
            if (GemPrice == 0 && clickToPlantScript.gotPlant && clickToPlantScript.plantFinished == false)
            {
                GemPrice = 1;
            }
            


            // yessai works
            if (Tag == "1")
            {
                int GemPrice1 = clickToPlantScript.remainingTime.Minutes;
                if (GemPrice1 == 0 && clickToPlantScript.plantFinished == false && clickToPlantScript.plantFinished == false)
                {
                    GemPrice1 = 1;
                }
                Pay2FastButtonPot1.GetComponentInChildren<TMP_Text>().text = "USE " + GemPrice1.ToString() + " GEMS";
            }

            Tag = col.tag;
            if (Tag == "2")
            {
                int GemPrice2 = clickToPlantScript.remainingTime.Minutes;
                if (GemPrice2 == 0 && clickToPlantScript.plantFinished == false && clickToPlantScript.plantFinished == false)
                {
                    GemPrice2 = 1;
                }
                Pay2FastButtonPot2.GetComponentInChildren<TMP_Text>().text = "USE " + GemPrice2.ToString() + " GEMS";
            }

            Tag = col.tag;
            if (Tag == "3")
            {
                int GemPrice3 = clickToPlantScript.remainingTime.Minutes;
                if (GemPrice3 == 0 && clickToPlantScript.plantFinished == false && clickToPlantScript.plantFinished == false)
                {
                    GemPrice3 = 1;
                }
                Pay2FastButtonPot3.GetComponentInChildren<TMP_Text>().text = "USE " + GemPrice3.ToString() + " GEMS";
            }
        }
        


    }

    

    public void OpenPanel(string tag)
    {
        ClickToPlant clickToPlantScript = GameObject.FindGameObjectWithTag(Tag).GetComponent<ClickToPlant>();
        if (clickToPlantScript.plantFinished)
        {
            //Debug.Log(Tag);
            sellButton.gameObject.SetActive(true);
            //Debug.Log(gameObject);
            Button btn = sellButton.GetComponent<Button>();

            btn.onClick.AddListener(SellPlant);

        }
        animator.SetBool("IsOpen", true);
        pannelActive = true;
        Debug.Log(pannelActive);
        if (tag == "1" ) nameText.text = Name1;
        if (tag == "2" ) nameText.text = Name2;
        if (tag == "3" ) nameText.text = Name3;


        SpriteRenderer spritePot = gameObject.GetComponent<SpriteRenderer>();
        ImagePotDuPopUp.sprite = spritePot.sprite;
        SpriteRenderer spritePlant = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        ImagePlantDuPopUp.sprite = spritePlant.sprite;

        wateringButton.onClick.AddListener(WaterOnClick);

        DisableBoxColliders();
        //Debug.Log(tag);
    }

    public void LoadPannel()
    {
        if(pannelActive)
        {
            SpriteRenderer spritePot = gameObject.GetComponent<SpriteRenderer>();
            ImagePotDuPopUp.sprite = spritePot.sprite;
            SpriteRenderer spritePlant = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
            ImagePlantDuPopUp.sprite = spritePlant.sprite;
        }
        
    }

    public void ClosePanel()
    {
        ImagePotDuPopUp.sprite = null;
        ImagePlantDuPopUp.sprite = null;
        animator.SetBool("IsOpen", false);
        pannelActive = false;
        ClickToPlant clickToPlantScript = gameObject.GetComponent<ClickToPlant>();
        wateringButton.onClick.RemoveListener(WaterOnClick);
        Tag = null;
        Button btn = sellButton.GetComponent<Button>();

        btn.onClick.RemoveListener(SellPlant);
        buttonSkin1.onClick.RemoveListener(potSkins.skin1);
        buttonSkin2.onClick.RemoveListener(potSkins.skin2);
        buttonSkin3.onClick.RemoveListener(potSkins.skin3);
        //Debug.Log("pannelactive = " + pannelActive);
        //Debug.Log(Tag);

        EnableBoxCollider();
    }


    public void SellPlant()
    {
        if(canSell)
        {
            // Debug.Log(tag);
            //what type of plant is sold
            ClickToPlant clickToPlantScript = GameObject.FindGameObjectWithTag(Tag).GetComponent<ClickToPlant>();
            int addedMoney = clickToPlantScript.sellingPrice;

            // add money
            BagScript bagScript = bagObject.GetComponent<BagScript>();
            bagScript.Monay = bagScript.Monay + addedMoney;


            // delete the plant
            clickToPlantScript.spriteRenderer.sprite = null;
            clickToPlantScript.gotPlant = false;
            clickToPlantScript.plantFinished = false;
            clickToPlantScript.plantInPot = 0f;
            ImagePlantDuPopUp.sprite = null;
            clickToPlantScript.EnvoyerVariable(Tag);

            //Debug.Log(clickToPlantScript.plantFinished);
            canSell = false;
            Tag = null;
            Button btn = sellButton.GetComponent<Button>();

            btn.onClick.RemoveListener(SellPlant);
            ClosePanel();
            StartCoroutine("WaitForSellingTime");
        }
    }

    IEnumerator WaitForSellingTime()
    {
        yield return new WaitForSeconds(3);

        canSell = true;
    }

    public void resetTag()
    {
        Tag = null;
    }



    void WaterOnClick()
    {
        //Debug.Log(TagObj);
        ClickToPlant clickToPlantScript = GameObject.FindGameObjectWithTag(Tag).GetComponent<ClickToPlant>();
        if (clickToPlantScript.canWater == true)
        {
            //Debug.Log(clickToPlantScript.canWater);
            water.water();
            clickToPlantScript.canWater = false;
            clickToPlantScript.sellingPrice = (int)((float)clickToPlantScript.sellingPrice * 1.1);
        }
        //Debug.Log(clickToPlantScript.canWater);
        //Debug.Log(clickToPlantScript.sellingPrice);
    }

    public void DisableBoxColliders()
    {
        Pot1.GetComponent<BoxCollider2D>().enabled = false;
        Pot2.GetComponent<BoxCollider2D>().enabled = false;
        Pot3.GetComponent<BoxCollider2D>().enabled = false;
    }

    public void EnableBoxCollider()
    {
        Pot1.GetComponent<BoxCollider2D>().enabled = true;
        Pot2.GetComponent<BoxCollider2D>().enabled = true;
        Pot3.GetComponent<BoxCollider2D>().enabled = true;
    }
}
