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
    DateTime targetTimeBle1;
    DateTime targetTimeBle2;
    DateTime targetTimeBle3;
    public Sprite evolutionBle1;
    float growingTimeBle = 10;

    //specific to apple
    bool applePlanted = false;
    DateTime targetTimeApple1;
    DateTime targetTimeApple2;
    DateTime targetTimeApple3;
    public Sprite evolutionApple1;
    float growingTimeApple = 10;

    //specific to Tomato
    bool tomatoPlanted = false;
    DateTime targetTimeTomato1;
    DateTime targetTimeTomato2;
    DateTime targetTimeTomato3;
    public Sprite evolutionTomato1;
    float growingTimeTomato = 10;

    //specific to Eggplant
    bool eggplantPlanted = false;
    DateTime targetTimeEggplant1;
    DateTime targetTimeEggplant2;
    DateTime targetTimeEggplant3;
    public Sprite evolutionEggplant1;
    float growingTimeEggplant = 10;

    //specific to Pear
    bool pearPlanted = false;
    DateTime targetTimePear1;
    DateTime targetTimePear2;
    DateTime targetTimePear3;
    public Sprite evolutionPear1;
    float growingTimePear = 10;

    //specific to Sunflower
    bool sunflowerPlanted = false;
    DateTime targetTimeSunflower1;
    DateTime targetTimeSunflower2;
    DateTime targetTimeSunflower3;
    public Sprite evolutionSunflower1;
    float growingTimeSunflower = 10;

    //specific to Cherry
    bool cherryPlanted = false;
    DateTime targetTimeCherry1;
    DateTime targetTimeCherry2;
    DateTime targetTimeCherry3;
    public Sprite evolutionCherry1;
    float growingTimeCherry = 10;

    //specific to Avocado
    bool avocadoPlanted = false;
    DateTime targetTimeAvocado1;
    DateTime targetTimeAvocado2;
    DateTime targetTimeAvocado3;
    public Sprite evolutionAvocado1;
    float growingTimeAvocado = 10;

    //specific to Kiwi
    bool kiwiPlanted = false;
    DateTime targetTimeKiwi1;
    DateTime targetTimeKiwi2;
    DateTime targetTimeKiwi3;
    public Sprite evolutionKiwi1;
    float growingTimeKiwi = 10;

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
                        targetTimeBle1 = CurrentTime.AddSeconds(growingTimeBle * (1 / 3));
                        targetTimeBle2 = CurrentTime.AddSeconds(growingTimeBle * (2 / 3));
                        targetTimeBle3 = CurrentTime.AddSeconds(growingTimeBle);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeBle + " seconds");
                        blePlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 2)
                    {
                        targetTimeApple1 = CurrentTime.AddSeconds(growingTimeApple * (1 / 3));
                        targetTimeApple2 = CurrentTime.AddSeconds(growingTimeApple * (2 / 3));
                        targetTimeApple3 = CurrentTime.AddSeconds(growingTimeApple);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeApple + " seconds");
                        applePlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 3)
                    {
                        targetTimeTomato1 = CurrentTime.AddSeconds(growingTimeTomato * (1 / 3));
                        targetTimeTomato2 = CurrentTime.AddSeconds(growingTimeTomato * (2 / 3));
                        targetTimeTomato3 = CurrentTime.AddSeconds(growingTimeTomato);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeTomato + " seconds");
                        tomatoPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 4)
                    {
                        targetTimeEggplant1 = CurrentTime.AddSeconds(growingTimeEggplant * (1 / 3));
                        targetTimeEggplant2 = CurrentTime.AddSeconds(growingTimeEggplant * (2 / 3));
                        targetTimeEggplant3 = CurrentTime.AddSeconds(growingTimeEggplant);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeEggplant + " seconds");
                        eggplantPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 5)
                    {
                        targetTimePear1 = CurrentTime.AddSeconds(growingTimePear * (1 / 3));
                        targetTimePear2 = CurrentTime.AddSeconds(growingTimePear * (2 / 3));
                        targetTimePear3 = CurrentTime.AddSeconds(growingTimePear);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimePear + " seconds");
                        pearPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 6)
                    {
                        targetTimeSunflower1 = CurrentTime.AddSeconds(growingTimeSunflower * (1 / 3));
                        targetTimeSunflower2 = CurrentTime.AddSeconds(growingTimeSunflower * (2 / 3));
                        targetTimeSunflower3 = CurrentTime.AddSeconds(growingTimeSunflower);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeSunflower + " seconds");
                        sunflowerPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 7)
                    {
                        targetTimeCherry1 = CurrentTime.AddSeconds(growingTimeCherry * (1 / 3));
                        targetTimeCherry2 = CurrentTime.AddSeconds(growingTimeCherry * (2 / 3));
                        targetTimeCherry3 = CurrentTime.AddSeconds(growingTimeCherry);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeCherry + " seconds");
                        cherryPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 8)
                    {
                        targetTimeAvocado1 = CurrentTime.AddSeconds(growingTimeAvocado * (1 / 3));
                        targetTimeAvocado2 = CurrentTime.AddSeconds(growingTimeAvocado * (2 / 3));
                        targetTimeAvocado3 = CurrentTime.AddSeconds(growingTimeAvocado);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeAvocado + " seconds");
                        avocadoPlanted = true;
                        gotPlant = true;
                    }

                    if (bagScript.plantingseed == 9)
                    {
                        targetTimeKiwi1 = CurrentTime.AddSeconds(growingTimeKiwi * (1 / 3));
                        targetTimeKiwi2 = CurrentTime.AddSeconds(growingTimeKiwi * (2 / 3));
                        targetTimeKiwi3 = CurrentTime.AddSeconds(growingTimeKiwi);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeKiwi + " seconds");
                        kiwiPlanted = true;
                        gotPlant = true;
                    }
                }
            }
        }

        if(blePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeBle1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionBle1;
                blePlanted = false;
            }
        }

        if (applePlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeApple1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionApple1;
                applePlanted = false;
            }
        }

        if (tomatoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeTomato1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionTomato1;
                tomatoPlanted = false;
            }
        }

        if (eggplantPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeEggplant1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionEggplant1;
                eggplantPlanted = false;
            }
        }

        if (pearPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimePear1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionPear1;
                pearPlanted = false;
            }
        }

        if (sunflowerPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeSunflower1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionSunflower1;
                sunflowerPlanted = false;
            }
        }

        if (cherryPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeCherry1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionCherry1;
                cherryPlanted = false;
            }
        }

        if (avocadoPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeAvocado1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionAvocado1;
                avocadoPlanted = false;
            }
        }

        if (kiwiPlanted)
        {
            if (DateTime.Compare(CurrentTime, targetTimeKiwi1) == 1)
            {
                Debug.Log("Evolution");
                spriteRenderer.sprite = evolutionKiwi1;
                kiwiPlanted = false;
            }
        }
    }
}
