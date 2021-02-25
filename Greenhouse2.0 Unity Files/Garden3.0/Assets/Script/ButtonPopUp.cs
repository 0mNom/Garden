using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ButtonPopUp : MonoBehaviour
{

    public TextMeshProUGUI spendGemsPot1;
    public TextMeshProUGUI spendGemsPot2;
    public TextMeshProUGUI spendGemsPot3;

    public TextMeshProUGUI seedTypePot1;
    public TextMeshProUGUI seedTypePot2;
    public TextMeshProUGUI seedTypePot3;

    public int GemPrice;

    public GameObject particle;

    public GameObject Pot1;
    public GameObject Pot2;
    public GameObject Pot3;

    public Button buttonSkin1;
    public Button buttonSkin2;
    public Button buttonSkin3;
    public Button buttonSkin4;
    public Button buttonSkin5;
    public Button buttonSkin6;
    public Button buttonSkin7;
    public Button buttonSkin8;
    public Button buttonSkin9;
    public Button buttonSkin10;
    public Button buttonSkin11;
    public Button buttonSkin12;
    public Button buttonSkin13;
    public Button buttonSkin14;
    public Button buttonSkin15;
    public Button buttonSkin16;
   

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

    public GameObject nameIn1, nameIn2, nameIn3;

    public TextMeshProUGUI nameText1;
    public TextMeshProUGUI nameText2;
    public TextMeshProUGUI nameText3;
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
                    if (Tag == "4")
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
                    buttonSkin4.onClick.AddListener(potSkins.skin4);
                    buttonSkin5.onClick.AddListener(potSkins.skin5);
                    buttonSkin6.onClick.AddListener(potSkins.skin6);
                    buttonSkin7.onClick.AddListener(potSkins.skin7);
                    buttonSkin8.onClick.AddListener(potSkins.skin8);
                    buttonSkin9.onClick.AddListener(potSkins.skin9);
                    buttonSkin10.onClick.AddListener(potSkins.skin10);
                    buttonSkin11.onClick.AddListener(potSkins.skin11);
                    buttonSkin12.onClick.AddListener(potSkins.skin12);
                    buttonSkin13.onClick.AddListener(potSkins.skin13);
                    buttonSkin14.onClick.AddListener(potSkins.skin14);
                    buttonSkin15.onClick.AddListener(potSkins.skin15);
                    buttonSkin16.onClick.AddListener(potSkins.skin16);
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
            if (clickToPlantScript.canWater == true)
            {
                wateringButton.gameObject.SetActive(true);
            }
            if (clickToPlantScript.canWater == false)
            {
                wateringButton.gameObject.SetActive(false);
            }

            if (!clickToPlantScript.plantFinished)
            {
                // Debug.Log("yess ");
                sellButton.gameObject.SetActive(false);
            }
            
            if (clickToPlantScript.gotPlant)
            {
                if (Tag == "4")
                {
                    Pay2FastButtonPot1.SetActive(true);
                    Pay2FastButtonPot2.SetActive(false);
                    Pay2FastButtonPot3.SetActive(false);
                    seedTypePot1.gameObject.SetActive(true);
                    seedTypePot2.gameObject.SetActive(false);
                    seedTypePot3.gameObject.SetActive(false);

                    if (clickToPlantScript.blePlanted)
                    {
                        seedTypePot1.text = "Wheat is growing";
                    }
                    else if (clickToPlantScript.applePlanted)
                    {
                        seedTypePot1.text = "Apple is growing";
                    }
                    else if (clickToPlantScript.tomatoPlanted)
                    {
                        seedTypePot1.text = "Tomato is growing";
                    }
                    else if (clickToPlantScript.eggplantPlanted)
                    {
                        seedTypePot1.text = "Eggplant is growing";
                    }
                    else if (clickToPlantScript.pearPlanted)
                    {
                        seedTypePot1.text = "Pear is growing";
                    }
                    else if (clickToPlantScript.sunflowerPlanted)
                    {
                        seedTypePot1.text = "Sunflower is growing";
                    }
                    else if (clickToPlantScript.cherryPlanted)
                    {
                        seedTypePot1.text = "Cherry is growing";
                    }
                    else if (clickToPlantScript.avocadoPlanted)
                    {
                        seedTypePot1.text = "Avocado is growing";
                    }
                    else if (clickToPlantScript.kiwiPlanted)
                    {
                        seedTypePot1.text = "Kiwi is growing";
                    }
                }

                Tag = col.tag;
                if (Tag == "2")
                {
                    Pay2FastButtonPot1.SetActive(false);
                    Pay2FastButtonPot2.SetActive(true);
                    Pay2FastButtonPot3.SetActive(false);
                    seedTypePot1.gameObject.SetActive(false);
                    seedTypePot2.gameObject.SetActive(true);
                    seedTypePot3.gameObject.SetActive(false);
                    if (clickToPlantScript.blePlanted)
                    {
                        seedTypePot2.text = "Wheat is growing";
                    }
                    else if (clickToPlantScript.applePlanted)
                    {
                        seedTypePot2.text = "Apple is growing";
                    }
                    else if (clickToPlantScript.tomatoPlanted)
                    {
                        seedTypePot2.text = "Tomato is growing";
                    }
                    else if (clickToPlantScript.eggplantPlanted)
                    {
                        seedTypePot2.text = "Eggplant is growing";
                    }
                    else if (clickToPlantScript.pearPlanted)
                    {
                        seedTypePot2.text = "Pear is growing";
                    }
                    else if (clickToPlantScript.sunflowerPlanted)
                    {
                        seedTypePot2.text = "Sunflower is growing";
                    }
                    else if (clickToPlantScript.cherryPlanted)
                    {
                        seedTypePot2.text = "Cherry is growing";
                    }
                    else if (clickToPlantScript.avocadoPlanted)
                    {
                        seedTypePot2.text = "Avocado is growing";
                    }
                    else if (clickToPlantScript.kiwiPlanted)
                    {
                        seedTypePot2.text = "Kiwi is growing";
                    }
                }

                Tag = col.tag;
                if (Tag == "3")
                {
                    Pay2FastButtonPot1.SetActive(false);
                    Pay2FastButtonPot2.SetActive(false);
                    Pay2FastButtonPot3.SetActive(true);
                    seedTypePot1.gameObject.SetActive(false);
                    seedTypePot2.gameObject.SetActive(false);
                    seedTypePot3.gameObject.SetActive(true);
                    if (clickToPlantScript.blePlanted)
                    {
                        seedTypePot3.text = "Wheat is growing";
                    }
                    else if (clickToPlantScript.applePlanted)
                    {
                        seedTypePot3.text = "Apple is growing";
                    }
                    else if (clickToPlantScript.tomatoPlanted)
                    {
                        seedTypePot3.text = "Tomato is growing";
                    }
                    else if (clickToPlantScript.eggplantPlanted)
                    {
                        seedTypePot3.text = "Eggplant is growing";
                    }
                    else if (clickToPlantScript.pearPlanted)
                    {
                        seedTypePot3.text = "Pear is growing";
                    }
                    else if (clickToPlantScript.sunflowerPlanted)
                    {
                        seedTypePot3.text = "Sunflower is growing";
                    }
                    else if (clickToPlantScript.cherryPlanted)
                    {
                        seedTypePot3.text = "Cherry is growing";
                    }
                    else if (clickToPlantScript.avocadoPlanted)
                    {
                        seedTypePot3.text = "Avocado is growing";
                    }
                    else if (clickToPlantScript.kiwiPlanted)
                    {
                        seedTypePot3.text = "Kiwi is growing";
                    }
                }
            }

            if (clickToPlantScript.gotPlant == false)
            {
                Pay2FastButtonPot1.SetActive(false);
                Pay2FastButtonPot2.SetActive(false);
                Pay2FastButtonPot3.SetActive(false);
            }


                //PAY TO FAST PART
                GemPrice = clickToPlantScript.minutes + (clickToPlantScript.hours*60);
            if (GemPrice == 0 && clickToPlantScript.gotPlant && clickToPlantScript.plantFinished == false)
            {
                GemPrice = 1;
            }
            


            // yessai works
            if (Tag == "4")
            {
                int GemPrice1 = clickToPlantScript.minutes + (clickToPlantScript.hours * 60);
                if (GemPrice1 == 0 && clickToPlantScript.plantFinished == false && clickToPlantScript.plantFinished == false)
                {
                    GemPrice1 = 1;
                }
                Pay2FastButtonPot1.GetComponentInChildren<TMP_Text>().text = "USE " + GemPrice1.ToString() + " AMBERS";
                spendGemsPot1.text = "Do you want to spend " + GemPrice1.ToString() + " amber(s) to speed up the growth?";
            }

            Tag = col.tag;
            if (Tag == "2")
            {
                int GemPrice2 = clickToPlantScript.minutes + (clickToPlantScript.hours * 60);
                if (GemPrice2 == 0 && clickToPlantScript.plantFinished == false && clickToPlantScript.plantFinished == false)
                {
                    GemPrice2 = 1;
                }
                Pay2FastButtonPot2.GetComponentInChildren<TMP_Text>().text = "USE " + GemPrice2.ToString() + " AMBERS";
                spendGemsPot2.text = "Do you want to spend " + GemPrice2.ToString() + " amber(s) to speed up the growth?";
            }

            Tag = col.tag;
            if (Tag == "3")
            {
                int GemPrice3 = clickToPlantScript.minutes + (clickToPlantScript.hours * 60);
                if (GemPrice3 == 0 && clickToPlantScript.plantFinished == false && clickToPlantScript.plantFinished == false)
                {
                    GemPrice3 = 1;
                }
                Pay2FastButtonPot3.GetComponentInChildren<TMP_Text>().text = "USE " + GemPrice3.ToString() + " AMBERS";
                spendGemsPot3.text = "Do you want to spend " + GemPrice3.ToString() + " amber(s) to speed up the growth?";
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
        if (tag == "4") nameIn1.SetActive(true);
        if (tag == "2") nameIn2.SetActive(true);
        if (tag == "3") nameIn3.SetActive(true);


        if (tag == "4" ) nameText1.text = Name1;
        if (tag == "2" ) nameText2.text = Name2;
        if (tag == "3" ) nameText3.text = Name3;


        SpriteRenderer spritePot = gameObject.GetComponent<SpriteRenderer>();
        ImagePotDuPopUp.sprite = spritePot.sprite;
        SpriteRenderer spritePlant = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        ImagePlantDuPopUp.sprite = spritePlant.sprite;

        wateringButton.onClick.AddListener(WaterOnClick);

        DisableBoxColliders();
        //Debug.Log(tag);
    }

    public void name1change(string nom)
    {
        Name1 = nom;
        nameText1.text = Name1;
    }
    public void name2change(string nom)
    {
        Name2 = nom;
        nameText2.text = Name2;
    }
    public void name3change(string nom)
    {
        Name3 = nom;
        nameText3.text = Name3;
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

    public void loadpannelDelayed()
    {
        StartCoroutine("waitpannel");
    }

    IEnumerator waitpannel()
    {
        yield return new WaitForSeconds(0.1f);
        LoadPannel();
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
        buttonSkin4.onClick.RemoveListener(potSkins.skin4);
        buttonSkin5.onClick.RemoveListener(potSkins.skin5);
        buttonSkin6.onClick.RemoveListener(potSkins.skin6);
        buttonSkin7.onClick.RemoveListener(potSkins.skin7);
        buttonSkin8.onClick.RemoveListener(potSkins.skin8);
        buttonSkin9.onClick.RemoveListener(potSkins.skin9);
        buttonSkin10.onClick.RemoveListener(potSkins.skin10);
        buttonSkin11.onClick.RemoveListener(potSkins.skin11);
        buttonSkin12.onClick.RemoveListener(potSkins.skin12);
        buttonSkin13.onClick.RemoveListener(potSkins.skin13);
        buttonSkin14.onClick.RemoveListener(potSkins.skin14);
        buttonSkin15.onClick.RemoveListener(potSkins.skin15);
        buttonSkin16.onClick.RemoveListener(potSkins.skin16);
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

            Instantiate(particle);
            Handheld.Vibrate();


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
