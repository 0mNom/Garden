using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlant : MonoBehaviour
{
    public GameObject bagObject;
    SpriteRenderer spriteRenderer;
    public Sprite evolution1;
    public Sprite potVide;
    Collider2D col;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
                    bagScript.seed = 0;
                    spriteRenderer.sprite = evolution1;
                }
            }
        }
    }
}
