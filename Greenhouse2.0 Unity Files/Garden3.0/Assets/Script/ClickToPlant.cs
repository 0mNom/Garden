using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ClickToPlant : MonoBehaviour
{
    //changes by courtney 
    public bool isActive = false;
    public float plantInPot = 0f;
    public PotPlaces potPlace;

    public Animator potAnim;


    //watering
    //public Watering water;
    public bool canWater = false;
    public bool canWaterFirstEvo = false;
    public bool canWaterSecondEvo = false;
    //public float waterIncrease = 1.1f;

    //the end 

    public GameObject ShineSprite;

    public bool plantFinished = false;
    public int sellingPrice = 1;

    public GameObject bagObject;
    public SpriteRenderer spriteRenderer;
    Collider2D col;
    DateTime CurrentTime;
    public bool gotPlant;
    public TimeSpan remainingTime;
    public TextMeshProUGUI timeRemainingText;


    //specific to ble
    bool blePlanted = false;
    DateTime targetTimeBle1;
    DateTime targetTimeBle2;
    DateTime targetTimeBle3;
    float growingTimeBle = 300;
    public bool finishedBle = false;

    //specific to apple
    bool applePlanted = false;
    DateTime targetTimeApple1;
    DateTime targetTimeApple2;
    DateTime targetTimeApple3;
    float growingTimeApple = 9;
    public bool finishedApple = false;

    //specific to Tomato
    bool tomatoPlanted = false;
    DateTime targetTimeTomato1;
    DateTime targetTimeTomato2;
    DateTime targetTimeTomato3;
    float growingTimeTomato = 9;
    public bool finishedTomato = false;

    //specific to Eggplant
    bool eggplantPlanted = false;
    DateTime targetTimeEggplant1;
    DateTime targetTimeEggplant2;
    DateTime targetTimeEggplant3;
    float growingTimeEggplant = 9;
    public bool finishedEggplant = false;

    //specific to Pear
    bool pearPlanted = false;
    DateTime targetTimePear1;
    DateTime targetTimePear2;
    DateTime targetTimePear3;
    float growingTimePear = 90;
    public bool finishedPear = false;

    //specific to Sunflower
    bool sunflowerPlanted = false;
    DateTime targetTimeSunflower1;
    DateTime targetTimeSunflower2;
    DateTime targetTimeSunflower3;
    float growingTimeSunflower = 9;
    public bool finishedSunflower = false;

    //specific to Cherry
    bool cherryPlanted = false;
    DateTime targetTimeCherry1;
    DateTime targetTimeCherry2;
    DateTime targetTimeCherry3;
    float growingTimeCherry = 9;
    public bool finishedCherry = false;

    //specific to Avocado
    bool avocadoPlanted = false;
    DateTime targetTimeAvocado1;
    DateTime targetTimeAvocado2;
    DateTime targetTimeAvocado3;
    float growingTimeAvocado = 9;
    public bool finishedAvocado = false;

    //specific to Kiwi
    bool kiwiPlanted = false;
    DateTime targetTimeKiwi1;
    DateTime targetTimeKiwi2;
    DateTime targetTimeKiwi3;
    float growingTimeKiwi = 9;
    public bool finishedKiwi = false;

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = DateTime.Now;
        BagScript bagScript2 = bagObject.GetComponent<BagScript>();
        if (bagScript2.MakePotsShine)
        {
            if (gotPlant == false)
            {
                ShineSprite.SetActive(true);
            }
            else if (gotPlant)
            {
                ShineSprite.SetActive(false);
            }
        }

        if (bagScript2.MakePotsShine == false)
        {
            ShineSprite.SetActive(false);
        }



            if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

           

            if (touch.phase == TouchPhase.Began)
            {
                BagScript bagScript1 = bagObject.GetComponent<BagScript>();
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

                if (col == touchedCollider && bagScript1.plantingseed != 0 && gotPlant == false)
                {
                    String tag = col.tag;
                    //Debug.Log(tag);

                    potAnim = GameObject.FindGameObjectWithTag(tag).GetComponent<Animator>();
                    potAnim.SetTrigger("POP");



                    if (bagScript1.plantingseed == 1)
                    {
                        plantInPot = 1f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeBle1 = CurrentTime.AddSeconds(growingTimeBle/3);
                        targetTimeBle2 = CurrentTime.AddSeconds(growingTimeBle * 2 / 3);
                        targetTimeBle3 = CurrentTime.AddSeconds(growingTimeBle);
                        blePlanted = true;
                        gotPlant = true;
                        bagScript1.wheatseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 15;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 2)
                    {
                        plantInPot = 2f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeApple1 = CurrentTime.AddSeconds(growingTimeApple/3);
                        targetTimeApple2 = CurrentTime.AddSeconds(growingTimeApple * 2 / 3);
                        targetTimeApple3 = CurrentTime.AddSeconds(growingTimeApple);
                      
                        applePlanted = true;
                        gotPlant = true;
                        bagScript1.appleseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 45;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 3)
                    {
                        plantInPot = 3f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeTomato1 = CurrentTime.AddSeconds(growingTimeTomato/3);
                        targetTimeTomato2 = CurrentTime.AddSeconds(growingTimeTomato * 2 / 3);
                        targetTimeTomato3 = CurrentTime.AddSeconds(growingTimeTomato);
                        tomatoPlanted = true;
                        gotPlant = true;
                        bagScript1.tomatoseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");

                        sellingPrice = 90;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 4)
                    {
                        plantInPot = 4f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeEggplant1 = CurrentTime.AddSeconds(growingTimeEggplant/3);
                        targetTimeEggplant2 = CurrentTime.AddSeconds(growingTimeEggplant * 2 / 3);
                        targetTimeEggplant3 = CurrentTime.AddSeconds(growingTimeEggplant);
                        eggplantPlanted = true;
                        gotPlant = true;
                        bagScript1.eggplantseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 200;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 5)
                    {
                        plantInPot = 5f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimePear1 = CurrentTime.AddSeconds(growingTimePear/3);
                        targetTimePear2 = CurrentTime.AddSeconds(growingTimePear * 2 / 3);
                        targetTimePear3 = CurrentTime.AddSeconds(growingTimePear);
                        pearPlanted = true;
                        gotPlant = true;
                        bagScript1.pearseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 500;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 6)
                    {
                        plantInPot = 6f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeSunflower1 = CurrentTime.AddSeconds(growingTimeSunflower/3);
                        targetTimeSunflower2 = CurrentTime.AddSeconds(growingTimeSunflower * 2 / 3);
                        targetTimeSunflower3 = CurrentTime.AddSeconds(growingTimeSunflower);
                        sunflowerPlanted = true;
                        gotPlant = true;
                        bagScript1.sunflowerseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 1500;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 7)
                    {
                        plantInPot = 7f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeCherry1 = CurrentTime.AddSeconds(growingTimeCherry/3);
                        targetTimeCherry2 = CurrentTime.AddSeconds(growingTimeCherry * 2 / 3);
                        targetTimeCherry3 = CurrentTime.AddSeconds(growingTimeCherry);
                        cherryPlanted = true;
                        gotPlant = true;
                        bagScript1.cherryseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 4000;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 8)
                    {
                        plantInPot = 8f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeAvocado1 = CurrentTime.AddSeconds(growingTimeAvocado/3);
                        targetTimeAvocado2 = CurrentTime.AddSeconds(growingTimeAvocado * 2 / 3);
                        targetTimeAvocado3 = CurrentTime.AddSeconds(growingTimeAvocado);
                        avocadoPlanted = true;
                        gotPlant = true;
                        bagScript1.avoseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 12300;
                        bagScript1.MakePotsShine = false;
                    }

                    else if (bagScript1.plantingseed == 9)
                    {

                        plantInPot = 9f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeKiwi1 = CurrentTime.AddSeconds(growingTimeKiwi/3);
                        targetTimeKiwi2 = CurrentTime.AddSeconds(growingTimeKiwi * 2 / 3);
                        targetTimeKiwi3 = CurrentTime.AddSeconds(growingTimeKiwi);
                        kiwiPlanted = true;
                        gotPlant = true;
                        bagScript1.kiwiseed--;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                        sellingPrice = 35000;
                        bagScript1.MakePotsShine = false;
                    }

                    //Debug.Log(tag);
                    canWaterFirstEvo = true;
                    canWaterSecondEvo = true;
                    //Debug.Log(canWaterFirstEvo);
                    //Debug.Log(canWaterSecondEvo);
                }
            }
        }

        

       




        if (blePlanted)
        {
            //Debug.Log(targetTimeBle3 - CurrentTime);
            remainingTime = targetTimeBle3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";

            if (DateTime.Compare(CurrentTime, targetTimeBle3) == 1)
            {
                canWater = false;
                plantInPot = 1.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                plantFinished = true;
                blePlanted = false;
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            else if (DateTime.Compare(CurrentTime, targetTimeBle2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 1.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
            }
            else if (DateTime.Compare(CurrentTime, targetTimeBle1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
                plantInPot = 1.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
              
            }

             

        }

        if (applePlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeApple3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeApple3) == 1)
            {
                canWater = false;
                plantInPot = 2.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

                plantFinished = true;
                applePlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeApple2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 2.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            else if (DateTime.Compare(CurrentTime, targetTimeApple1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 2.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
             
            
        }

        if (tomatoPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeTomato3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeTomato3) == 1)
            {
                canWater = false;
                plantInPot = 3.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

                plantFinished = true;
                tomatoPlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeTomato2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 3.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            else if (DateTime.Compare(CurrentTime, targetTimeTomato1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 3.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            
        }

        if (eggplantPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeEggplant3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeEggplant3) == 1)
            {
                canWater = false;
                plantInPot = 4.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

                plantFinished = true;
                eggplantPlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeEggplant2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 4.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            else if (DateTime.Compare(CurrentTime, targetTimeEggplant1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 4.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            
            
            
        }

        if (pearPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimePear3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimePear3) == 1)
            {
                canWater = false;
                plantInPot = 5.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

                plantFinished = true;
                pearPlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimePear2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 5.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            else if (DateTime.Compare(CurrentTime, targetTimePear1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 5.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            
             
            
        }

        if (sunflowerPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeSunflower3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeSunflower3) == 1)
            {
                canWater = false;
                plantInPot = 6.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

                plantFinished = true;
                sunflowerPlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeSunflower2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 6.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            else if (DateTime.Compare(CurrentTime, targetTimeSunflower1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 6.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }            
        }

        if (cherryPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeCherry3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeCherry3) == 1)
           {
                canWater = false;
                plantInPot = 7.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
                plantFinished = true;
                cherryPlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeCherry2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 7.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
            }
            else if (DateTime.Compare(CurrentTime, targetTimeCherry1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 7.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
            }            
        }

        if (avocadoPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeAvocado3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeAvocado3) == 1)
            {
                canWater = false;
                plantInPot = 8.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

                plantFinished = true;
                avocadoPlanted = false;

            }
            else if (DateTime.Compare(CurrentTime, targetTimeAvocado2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 8.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel(); 
               
            }
            else if (DateTime.Compare(CurrentTime, targetTimeAvocado1) == 1)
            {
                if(canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 8.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();

            }
            
        }

        if (kiwiPlanted)
        {
            //Debug.Log(remainingTime);
            remainingTime = targetTimeKiwi3 - CurrentTime;
            timeRemainingText.text = remainingTime.Hours.ToString() + "h : " + remainingTime.Minutes.ToString() + "m : " + remainingTime.Seconds.ToString() + "s";
            if (DateTime.Compare(CurrentTime, targetTimeKiwi3) == 1)
            {
                canWater = false;
                plantInPot = 9.3f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
                plantFinished = true;
                kiwiPlanted = false;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeKiwi2) == 1)
            {
                if (canWaterSecondEvo == true)
                {
                    canWater = true;
                    canWaterSecondEvo = false;
                }
                //canWater = true;
                plantInPot = 9.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
            }
            else if (DateTime.Compare(CurrentTime, targetTimeKiwi1) == 1)
            {
                if (canWaterFirstEvo == true)
                {
                    canWater = true;
                    canWaterFirstEvo = false;
                }
                //canWater = true;
                plantInPot = 9.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
                buttonPopUpScript.LoadPannel();
            }
        }
    }

    public void EnvoyerVariable(String tag)
    {
        if (tag == "1") potPlace.pp1 = plantInPot;
        // if (tag == "1") Debug.Log("POT 1");
        if (tag == "2") potPlace.pp2 = plantInPot;
        //if (tag == "2") Debug.Log("POT 2");
        if (tag == "3") potPlace.pp3 = plantInPot;
        // if (tag == "3") Debug.Log("POT 3");
    }

    IEnumerator WaitForOpenPannel()
    {
        yield return new WaitForSeconds(1);
        BagScript bagScript = bagObject.GetComponent<BagScript>();
        bagScript.canOpenPannel = true;
    }
    
    public void PayedToFinishPlant()
    {
        ButtonPopUp buttonPopUpScript = gameObject.GetComponent<ButtonPopUp>();
        //Debug.Log(buttonPopUpScript.GemPrice);
        BagScript bagScript = bagObject.GetComponent<BagScript>();
        bagScript.Gems = bagScript.Gems - buttonPopUpScript.GemPrice;
        targetTimeApple3 = CurrentTime;
        targetTimeAvocado3 = CurrentTime;
        targetTimeBle3 = CurrentTime;
        targetTimeCherry3 = CurrentTime;
        targetTimeEggplant3 = CurrentTime;
        targetTimeKiwi3 = CurrentTime;
        targetTimePear3 = CurrentTime;
        targetTimeSunflower3 = CurrentTime;
        targetTimeTomato3 = CurrentTime;
    }
}
