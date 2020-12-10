using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    public GameObject bagObject;
    public GameObject ble;
    // Start is called before the first frame update
    void Start()
    {
        
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
                if (touchedCollider == ble.GetComponent<Collider2D>())
                {
                    Debug.Log("Ble");
                    AddWeat();
                }
            }
        }
    }

    public void AddWeat()
    {
        BagScript bagScript = bagObject.GetComponent<BagScript>();
        bagScript.seed = 1;
    }
}
