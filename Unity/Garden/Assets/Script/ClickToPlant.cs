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
                if (col == touchedCollider && spriteRenderer.sprite == potVide && bagScript.plantingseed != 0)
                {
                    if(bagScript.plantingseed == 1)
                    {
                        targetTimeBle = CurrentTime.AddSeconds(growingTimeBle);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeBle + " seconds");
                        blePlanted = true;
                    }

                    if (bagScript.plantingseed == 2)
                    {
                        targetTimeApple = CurrentTime.AddSeconds(growingTimeApple);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeApple + " seconds");
                        applePlanted = true;
                    }

                    if (bagScript.plantingseed == 3)
                    {
                        targetTimeTomato = CurrentTime.AddSeconds(growingTimeTomato);
                        bagScript.plantingseed = 0;
                        Debug.Log("Evolving in " + growingTimeTomato + " seconds");
                        tomatoPlanted = true;
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



    }
}
