using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickToPlant : MonoBehaviour
{
    public GameObject bagObject;
    SpriteRenderer spriteRenderer;
    public Sprite potVide;
    Collider2D col;
    DateTime CurrentTime;

    //specific to 1 seed
    bool blePlanted;
    DateTime targetTimeBle;
    public Sprite evolutionBle1;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
                if (col == touchedCollider && spriteRenderer.sprite == potVide && bagScript.seed != 0)
                {
                    targetTimeBle = CurrentTime.AddSeconds(10);
                    bagScript.seed = 0;
                    Debug.Log("Evolving in 10 seconds");
                    blePlanted = true;
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
    }
}
