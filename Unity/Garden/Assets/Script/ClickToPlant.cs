using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickToPlant : MonoBehaviour
{
    public GameObject bagObject;
    public SpriteRenderer spriteRenderer;
    public Sprite potVide;
    Collider2D col;
    DateTime CurrentTime;
    public bool gotPlant;

    //specific to ble
    bool blePlanted = false;
    DateTime targetTimeBle;
    public Sprite evolutionBle1;
    int growingTimeBle = 10;

    //specific to apple
    bool applePlanted = false;
    DateTime targetTimeApple;
    public Sprite evolutionApple1;
    int growingTimeApple = 10;

    //specific to Tomato
    bool tomatoPlanted = false;
    DateTime targetTimeTomato;
    public Sprite evolutionTomato1;
    int growingTimeTomato = 10;

    //specific to Eggplant
    bool eggplantPlanted = false;
    DateTime targetTimeEggplant;
    public Sprite evolutionEggplant1;
    int growingTimeEggplant = 10;

    //specific to Pear
    bool pearPlanted = false;
    DateTime targetTimePear;
    public Sprite evolutionPear1;
    int growingTimePear = 10;

    //specific to Sunflower
    bool sunflowerPlanted = false;
    DateTime targetTimeSunflower;
    public Sprite evolutionSunflower1;
    int growingTimeSunflower = 10;

    //specific to Cherry
    bool cherryPlanted = false;
    DateTime targetTimeCherry;
    public Sprite evolutionCherry1;
    int growingTimeCherry = 10;




    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = DateTime.Now;

        BagScript bagScript = bagObject.GetComponent<BagScript>();
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider && bagScript.plantingseed != 0 && gotPlant == false)
                {
                    if(bagScript.plantingseed == 1)
                    {
                        targetTimeBle = CurrentTime.AddSeconds(growingTimeBle);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeBle + " seconds");
                        blePlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 2)
                    {
                        targetTimeApple = CurrentTime.AddSeconds(growingTimeApple);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeApple + " seconds");
                        applePlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 3)
                    {
                        targetTimeTomato = CurrentTime.AddSeconds(growingTimeTomato);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeTomato + " seconds");
                        tomatoPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 4)
                    {
                        targetTimeEggplant = CurrentTime.AddSeconds(growingTimeEggplant);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeEggplant + " seconds");
                        eggplantPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 5)
                    {
                        targetTimePear = CurrentTime.AddSeconds(growingTimePear);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimePear + " seconds");
                        pearPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 6)
                    {
                        targetTimeSunflower = CurrentTime.AddSeconds(growingTimeSunflower);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeSunflower + " seconds");
                        sunflowerPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 7)
                    {
                        targetTimeCherry = CurrentTime.AddSeconds(growingTimeCherry);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeCherry + " seconds");
                        cherryPlanted = true;
                        gotPlant = true;
                    }
                }
            }
        }

        if(blePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeBle) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionBle1;
                blePlanted = false;
            }
        }

        if (applePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeApple) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionApple1;
                applePlanted = false;
            }
        }

        if (tomatoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeTomato) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionTomato1;
                tomatoPlanted = false;
            }
        }

        if (eggplantPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeEggplant) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionEggplant1;
                eggplantPlanted = false;
            }
        }

        if (pearPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimePear) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionPear1;
                pearPlanted = false;
            }
        }

        if (sunflowerPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeSunflower) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionSunflower1;
                sunflowerPlanted = false;
            }
        }

        if (cherryPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeCherry) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionCherry1;
                cherryPlanted = false;
            }
        }
    }
}
