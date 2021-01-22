using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickToPlant : MonoBehaviour
{
    //changes by courtney 
    public bool isActive = false;
    public float plantInPot = 0f;
    public PotPlaces potPlace;


    //the end 

    public bool plantFinished = false;
    public int sellingPrice;

    public GameObject bagObject;
    public SpriteRenderer spriteRenderer;
    Collider2D col;
    DateTime CurrentTime;
    public bool gotPlant;

    //specific to ble
    bool blePlanted = false;
    DateTime targetTimeBle1;
    DateTime targetTimeBle2;
    float growingTimeBle = 20;
    public bool finishedBle = false;

    //specific to apple
    bool applePlanted = false;
    DateTime targetTimeApple1;
    DateTime targetTimeApple2;
    float growingTimeApple = 20;
    public bool finishedApple = false;

    //specific to Tomato
    bool tomatoPlanted = false;
    DateTime targetTimeTomato1;
    DateTime targetTimeTomato2;
    float growingTimeTomato = 20;
    public bool finishedTomato = false;

    //specific to Eggplant
    bool eggplantPlanted = false;
    DateTime targetTimeEggplant1;
    DateTime targetTimeEggplant2;
    float growingTimeEggplant = 20;
    public bool finishedEggplant = false;

    //specific to Pear
    bool pearPlanted = false;
    DateTime targetTimePear1;
    DateTime targetTimePear2;
    float growingTimePear = 10;
    public bool finishedPear = false;

    //specific to Sunflower
    bool sunflowerPlanted = false;
    DateTime targetTimeSunflower1;
    DateTime targetTimeSunflower2;
    float growingTimeSunflower = 10;
    public bool finishedSunflower = false;

    //specific to Cherry
    bool cherryPlanted = false;
    DateTime targetTimeCherry1;
    DateTime targetTimeCherry2;
    float growingTimeCherry = 10;
    public bool finishedCherry = false;

    //specific to Avocado
    bool avocadoPlanted = false;
    DateTime targetTimeAvocado1;
    DateTime targetTimeAvocado2;
    float growingTimeAvocado = 10;
    public bool finishedAvocado = false;

    //specific to Kiwi
    bool kiwiPlanted = false;
    DateTime targetTimeKiwi1;
    DateTime targetTimeKiwi2;
    float growingTimeKiwi = 10;
    public bool finishedKiwi = false;

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = DateTime.Now;
       
       
        

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
                    Debug.Log(tag);


                    if (bagScript1.plantingseed == 1)
                    {
                        plantInPot = 1f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeBle1 = CurrentTime.AddSeconds(growingTimeBle/2);
                        targetTimeBle2 = CurrentTime.AddSeconds(growingTimeBle);
                        blePlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 2)
                    {
                        plantInPot = 2f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeApple1 = CurrentTime.AddSeconds(growingTimeApple/2);
                        targetTimeApple2 = CurrentTime.AddSeconds(growingTimeApple);
                      
                        applePlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 3)
                    {
                        plantInPot = 3f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeTomato1 = CurrentTime.AddSeconds(growingTimeTomato/2);
                        targetTimeTomato2 = CurrentTime.AddSeconds(growingTimeTomato);
                        tomatoPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 4)
                    {
                        plantInPot = 4f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeEggplant1 = CurrentTime.AddSeconds(growingTimeEggplant/2);
                        targetTimeEggplant2 = CurrentTime.AddSeconds(growingTimeEggplant);
                        eggplantPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 5)
                    {
                        plantInPot = 5f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimePear1 = CurrentTime.AddSeconds(growingTimePear/2);
                        targetTimePear2 = CurrentTime.AddSeconds(growingTimePear);
                        pearPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 6)
                    {
                        plantInPot = 6f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeSunflower1 = CurrentTime.AddSeconds(growingTimeSunflower/2);
                        targetTimeSunflower2 = CurrentTime.AddSeconds(growingTimeSunflower);
                        sunflowerPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 7)
                    {
                        plantInPot = 7f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeCherry1 = CurrentTime.AddSeconds(growingTimeCherry/2);
                        targetTimeCherry2 = CurrentTime.AddSeconds(growingTimeCherry);
                        cherryPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 8)
                    {
                        plantInPot = 8f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeAvocado1 = CurrentTime.AddSeconds(growingTimeAvocado/2);
                        targetTimeAvocado2 = CurrentTime.AddSeconds(growingTimeAvocado);
                        avocadoPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    if (bagScript1.plantingseed == 9)
                    {

                        plantInPot = 9f;
                        EnvoyerVariable(tag);
                        potPlace.loadplants();
                        targetTimeKiwi1 = CurrentTime.AddSeconds(growingTimeKiwi/2);
                        targetTimeKiwi2 = CurrentTime.AddSeconds(growingTimeKiwi);
                        kiwiPlanted = true;
                        gotPlant = true;
                        bagScript1.plantingseed = 0;
                        StartCoroutine("WaitForOpenPannel");
                    }

                    Debug.Log(tag);
                }
            }

            
        }

        

       




        if (blePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeBle1) == 1)
            {
               
                plantInPot = 1.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
              
            }

            else if (DateTime.Compare(CurrentTime, targetTimeBle2) == 1 )
            {
               
                sellingPrice = 10;
                plantInPot = 1.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
                plantFinished = true;
                blePlanted = false;
            }

        }

        if (applePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeApple1) == 1)
            {
              
                plantInPot = 2.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
             
            }
            else if (DateTime.Compare(CurrentTime, targetTimeApple2) == 1 )
            {
               
                sellingPrice = 20;
                plantInPot = 2.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
                plantFinished = true;
                applePlanted = false;
            }
            
        }

        if (tomatoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeTomato1) == 1)
            {
               
                plantInPot = 3.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
            }
            else if (DateTime.Compare(CurrentTime, targetTimeTomato2) == 1)
            {
               
                sellingPrice = 10;
                plantInPot = 3.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
                plantFinished = true;
                tomatoPlanted = false;
            }
        }

        if (eggplantPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeEggplant1) == 1)
            {
               
                plantInPot = 4.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
            }
            else if (DateTime.Compare(CurrentTime, targetTimeEggplant2) == 1 )
            {
               
                sellingPrice = 10;
                plantInPot = 4.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
                plantFinished = true;
                eggplantPlanted = false;
            }
        }

        if (pearPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimePear1) == 1 )
            {
               
                plantInPot = 5.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
              
            }
            else if(DateTime.Compare(CurrentTime, targetTimePear2) == 1 )
            {
               
                sellingPrice = 10;
                plantInPot = 5.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
              
                plantFinished = true;
                pearPlanted = false;
            }
        }

        if (sunflowerPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeSunflower1) == 1)
            {
               
                plantInPot = 6.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
              
            }
            else if (DateTime.Compare(CurrentTime, targetTimeSunflower2) == 1)
            {
               
                sellingPrice = 20;
                plantInPot = 6.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
                plantFinished = true;
                sunflowerPlanted = false;
            }
        }

        if (cherryPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeCherry1) == 1)// && spriteRenderer.sprite == spritePlantedSeed)
            {
               // Debug.Log("Evolution");
                plantInPot = 7.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               // spriteRenderer.sprite = evolutionCherry1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeCherry2) == 1 )//&& spriteRenderer.sprite == evolutionCherry1)
            {
               // Debug.Log("Evolution 2");
                sellingPrice = 10;
                plantInPot = 7.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                //spriteRenderer.sprite = evolutionCherry2;
                plantFinished = true;
                cherryPlanted = false;
            }
        }

        if (avocadoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeAvocado1) == 1)
            {
               
                plantInPot = 8.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               
            }
            else if (DateTime.Compare(CurrentTime, targetTimeAvocado2) == 1)
            {
                
                sellingPrice = 10;
                plantInPot = 8.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                
                plantFinished = true;
                avocadoPlanted = false;
            }
        }

        if (kiwiPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeKiwi1) == 1)// && spriteRenderer.sprite == spritePlantedSeed)
            {
                //Debug.Log("Evolution");
                plantInPot = 9.1f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
                //spriteRenderer.sprite = evolutionKiwi1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeKiwi2) == 1 )//&& spriteRenderer.sprite == evolutionKiwi1)
            {
               // Debug.Log("Evolution 2");
                sellingPrice = 10;
                plantInPot = 9.2f;
                EnvoyerVariable(tag);
                potPlace.loadplants();
               // spriteRenderer.sprite = evolutionKiwi2;
                plantFinished = true;
                kiwiPlanted = false;
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
}
