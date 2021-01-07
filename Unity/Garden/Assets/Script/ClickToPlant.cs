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


    public GameObject bagObject;
    public SpriteRenderer spriteRenderer;
    public Sprite potVide;
    Collider2D col;
    DateTime CurrentTime;
    public bool gotPlant;
    public Sprite spritePlantedSeed;

    //specific to ble
    bool blePlanted = false;
    DateTime targetTimeBle1;
    DateTime targetTimeBle2;
    public Sprite evolutionBle1;
    public Sprite evolutionBle2;
    float growingTimeBle = 20;

    //specific to apple
    bool applePlanted = false;
    DateTime targetTimeApple1;
    DateTime targetTimeApple2;
    public Sprite evolutionApple1;
    public Sprite evolutionApple2;
    float growingTimeApple = 20;

    //specific to Tomato
    bool tomatoPlanted = false;
    DateTime targetTimeTomato1;
    DateTime targetTimeTomato2;
    public Sprite evolutionTomato1;
    public Sprite evolutionTomato2;
    float growingTimeTomato = 20;

    //specific to Eggplant
    bool eggplantPlanted = false;
    DateTime targetTimeEggplant1;
    DateTime targetTimeEggplant2;
    public Sprite evolutionEggplant1;
    public Sprite evolutionEggplant2;
    float growingTimeEggplant = 20;

    //specific to Pear
    bool pearPlanted = false;
    DateTime targetTimePear1;
    DateTime targetTimePear2;
    public Sprite evolutionPear1;
    public Sprite evolutionPear2;
    float growingTimePear = 10;

    //specific to Sunflower
    bool sunflowerPlanted = false;
    DateTime targetTimeSunflower1;
    DateTime targetTimeSunflower2;
    public Sprite evolutionSunflower1;
    public Sprite evolutionSunflower2;
    float growingTimeSunflower = 10;

    //specific to Cherry
    bool cherryPlanted = false;
    DateTime targetTimeCherry1;
    DateTime targetTimeCherry2;
    public Sprite evolutionCherry1;
    public Sprite evolutionCherry2;
    float growingTimeCherry = 10;

    //specific to Avocado
    bool avocadoPlanted = false;
    DateTime targetTimeAvocado1;
    DateTime targetTimeAvocado2;
    public Sprite evolutionAvocado1;
    public Sprite evolutionAvocado2;
    float growingTimeAvocado = 10;

    //specific to Kiwi
    bool kiwiPlanted = false;
    DateTime targetTimeKiwi1;
    DateTime targetTimeKiwi2;
    public Sprite evolutionKiwi1;
    public Sprite evolutionKiwi2;
    float growingTimeKiwi = 10;

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
                BagScript bagScript = bagObject.GetComponent<BagScript>();
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

                

                if (col == touchedCollider && bagScript.plantingseed != 0 && gotPlant == false)
                {
                    String tag = col.tag;
                    Debug.Log(tag);


                    if (bagScript.plantingseed == 1)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 1f;
                        targetTimeBle1 = CurrentTime.AddSeconds(growingTimeBle/2);
                        targetTimeBle2 = CurrentTime.AddSeconds(growingTimeBle);
                        bagScript.plantingseed = 0;
                        //Debug.Log("Evolving in " + growingTimeBle + " seconds");
                        blePlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 2)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 2f;
                        targetTimeApple1 = CurrentTime.AddSeconds(growingTimeApple/2);
                        targetTimeApple2 = CurrentTime.AddSeconds(growingTimeApple);
                        bagScript.plantingseed = 0;
                       // Debug.Log("Evolving in " + growingTimeApple + " seconds");
                        applePlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 3)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 3f;
                        targetTimeTomato1 = CurrentTime.AddSeconds(growingTimeTomato/2);
                        targetTimeTomato2 = CurrentTime.AddSeconds(growingTimeTomato);
                        bagScript.plantingseed = 0;
                        //Debug.Log("Evolving in " + growingTimeTomato + " seconds");
                        tomatoPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 4)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 4f;
                        targetTimeEggplant1 = CurrentTime.AddSeconds(growingTimeEggplant/2);
                        targetTimeEggplant2 = CurrentTime.AddSeconds(growingTimeEggplant);
                        Debug.Log(targetTimeEggplant1);
                        Debug.Log(targetTimeEggplant2);
                        bagScript.plantingseed = 0;
                       // Debug.Log("Evolving in " + growingTimeEggplant + " seconds");
                        eggplantPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 5)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 5f;
                        targetTimePear1 = CurrentTime.AddSeconds(growingTimePear/2);
                        targetTimePear2 = CurrentTime.AddSeconds(growingTimePear);
                        bagScript.plantingseed = 0;
                       // Debug.Log("Evolving in " + growingTimePear + " seconds");
                        pearPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 6)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 6f;
                        targetTimeSunflower1 = CurrentTime.AddSeconds(growingTimeSunflower/2);
                        targetTimeSunflower2 = CurrentTime.AddSeconds(growingTimeSunflower);
                        bagScript.plantingseed = 0;
                       // Debug.Log("Evolving in " + growingTimeSunflower + " seconds");
                        sunflowerPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 7)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 7f;
                        targetTimeCherry1 = CurrentTime.AddSeconds(growingTimeCherry/2);
                        targetTimeCherry2 = CurrentTime.AddSeconds(growingTimeCherry);
                       // Debug.Log("Evolving in " + growingTimeCherry + " seconds");
                        cherryPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 8)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 8f;
                        targetTimeAvocado1 = CurrentTime.AddSeconds(growingTimeAvocado/2);
                        targetTimeAvocado2 = CurrentTime.AddSeconds(growingTimeAvocado);
                        bagScript.plantingseed = 0;
                       // Debug.Log("Evolving in " + growingTimeAvocado + " seconds");
                        avocadoPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 9)
                    {
                        spriteRenderer.sprite = spritePlantedSeed;
                        plantInPot = 9f;
                        targetTimeKiwi1 = CurrentTime.AddSeconds(growingTimeKiwi/2);
                        targetTimeKiwi2 = CurrentTime.AddSeconds(growingTimeKiwi);
                        bagScript.plantingseed = 0;
                        //Debug.Log("Evolving in " + growingTimeKiwi + " seconds");
                        kiwiPlanted = true;
                        gotPlant = true;
                    }
                }
            }

            

        }


        if (tag == "1") potPlace.pp1 = plantInPot;
        // if (tag == "1") Debug.Log("POT 1");
        if (tag == "2") potPlace.pp2 = plantInPot;
        //if (tag == "2") Debug.Log("POT 2");
        if (tag == "3") potPlace.pp3 = plantInPot;
        // if (tag == "3") Debug.Log("POT 3");

       




        if (blePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeBle1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
                //Debug.Log("Evolution");
                plantInPot = 1.1f;
                spriteRenderer.sprite = evolutionBle1;
            }

            else if (DateTime.Compare(CurrentTime, targetTimeBle2) == 1 && spriteRenderer.sprite == evolutionBle1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 1.2f;
                spriteRenderer.sprite = evolutionBle2;
                blePlanted = false;
            }
        }

        if (applePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeApple1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
               // Debug.Log("Evolution");
                plantInPot = 2.1f;
                spriteRenderer.sprite = evolutionApple1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeApple2) == 1 && spriteRenderer.sprite == evolutionApple1)
            {
                //Debug.Log("Evolution 2");
                plantInPot = 2.2f;
                spriteRenderer.sprite = evolutionApple2;
                applePlanted = false;
            }
            
        }

        if (tomatoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeTomato1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
                //Debug.Log("Evolution");
                plantInPot = 3.1f;
                spriteRenderer.sprite = evolutionTomato1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeTomato2) == 1 && spriteRenderer.sprite == evolutionTomato1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 3.2f;
                spriteRenderer.sprite = evolutionTomato2;
                tomatoPlanted = false;
            }
        }

        if (eggplantPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeEggplant1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
               // Debug.Log("Evolution");
                plantInPot = 4.1f;
                spriteRenderer.sprite = evolutionEggplant1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeEggplant2) == 1 && spriteRenderer.sprite == evolutionEggplant1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 4.2f;
                spriteRenderer.sprite = evolutionEggplant2;
                eggplantPlanted = false;
            }
        }

        if (pearPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimePear1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
                //Debug.Log("Evolution");
                plantInPot = 5.1f;
                spriteRenderer.sprite = evolutionPear1;
            }
            else if(DateTime.Compare(CurrentTime, targetTimePear2) == 1 && spriteRenderer.sprite == evolutionPear1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 5.2f;
                spriteRenderer.sprite = evolutionPear2;
                pearPlanted = false;
            }
        }

        if (sunflowerPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeSunflower1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
               // Debug.Log("Evolution");
                plantInPot = 6.1f;
                spriteRenderer.sprite = evolutionSunflower1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeSunflower2) == 1 && spriteRenderer.sprite == evolutionSunflower1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 6.2f;
                spriteRenderer.sprite = evolutionSunflower2;
                sunflowerPlanted = false;
            }
        }

        if (cherryPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeCherry1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
               // Debug.Log("Evolution");
                plantInPot = 7.1f;
                spriteRenderer.sprite = evolutionCherry1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeCherry2) == 1 && spriteRenderer.sprite == evolutionCherry1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 7.2f;
                spriteRenderer.sprite = evolutionCherry2;
                cherryPlanted = false;
            }
        }

        if (avocadoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeAvocado1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
               // Debug.Log("Evolution");
                plantInPot = 8.1f;
                spriteRenderer.sprite = evolutionAvocado1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeAvocado2) == 1 && spriteRenderer.sprite == evolutionAvocado1)
            {
                //Debug.Log("Evolution 2");
                plantInPot = 8.2f;
                spriteRenderer.sprite = evolutionAvocado2;
                avocadoPlanted = false;
            }
        }

        if (kiwiPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeKiwi1) == 1 && spriteRenderer.sprite == spritePlantedSeed)
            {
                //Debug.Log("Evolution");
                plantInPot = 9.1f;
                spriteRenderer.sprite = evolutionKiwi1;
            }
            else if (DateTime.Compare(CurrentTime, targetTimeKiwi2) == 1 && spriteRenderer.sprite == evolutionKiwi1)
            {
               // Debug.Log("Evolution 2");
                plantInPot = 9.2f;
                spriteRenderer.sprite = evolutionKiwi2;
                kiwiPlanted = false;
            }
        }
    }
}
