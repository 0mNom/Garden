using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlant : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite evolution1;
    public Sprite potVide;
    Collider2D col;
    float seed = 0;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider && spriteRenderer.sprite == potVide && seed != 0)
                {
                    seed = 0;
                    spriteRenderer.sprite = evolution1;
                }
            }
        }
    }
}
