using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonPopUp : MonoBehaviour
{
    public GameObject bagObject;
    Collider2D col;
    public string Name1, Name2, Name3;
    public TextMeshProUGUI nameText;
    public Animator animator;

    public Button sellButton;

    public SpriteRenderer ImagePotDuPopUp;
    public SpriteRenderer ImagePlantDuPopUp;

    public string tag;

    bool canSell;

    void Start()
    {
        col = GetComponent<Collider2D>();
       
        canSell = true;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                BagScript bagScript = bagObject.GetComponent<BagScript>();
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider && bagScript.canOpenPannel == true)
                {
                    tag = touchedCollider.tag;

                    OpenPanel(tag);
                   
                }
            }
        }

        ClickToPlant clickToPlantScript = gameObject.GetComponent<ClickToPlant>();

        if (clickToPlantScript.plantFinished)
        {
            sellButton.gameObject.SetActive(true);

            Button btn = sellButton.GetComponent<Button>();
            btn.onClick.AddListener(SellPlant);
        }

        if(clickToPlantScript.plantFinished == false)
        {
            sellButton.gameObject.SetActive(false);
        }

    }

    public void OpenPanel(string tag)
    {
        animator.SetBool("IsOpen", true);
 
        if (tag == "1" ) nameText.text = Name1;
        if (tag == "2" ) nameText.text = Name2;
        if (tag == "3" ) nameText.text = Name3;


        SpriteRenderer spritePot = gameObject.GetComponent<SpriteRenderer>();
        ImagePotDuPopUp.sprite = spritePot.sprite;
        SpriteRenderer spritePlant = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        ImagePlantDuPopUp.sprite = spritePlant.sprite;
    }

    public void ClosePanel()
    {
        ImagePotDuPopUp.sprite = null;
        ImagePlantDuPopUp.sprite = null;
        animator.SetBool("IsOpen", false);
    }

    public void SellPlant()
    {
        if(canSell)
        {
            //what type of plant is sold
            ClickToPlant clickToPlantScript = gameObject.GetComponent<ClickToPlant>();
            int addedMoney = clickToPlantScript.sellingPrice;

            // add money
            BagScript bagScript = bagObject.GetComponent<BagScript>();
            bagScript.Monay = bagScript.Monay + addedMoney;


            // delete the plant
            clickToPlantScript.spriteRenderer.sprite = null;
            clickToPlantScript.gotPlant = false;
            clickToPlantScript.plantFinished = false;
            clickToPlantScript.plantInPot = 0f;
            ImagePlantDuPopUp.sprite = null;

            canSell = false;
            StartCoroutine("WaitForSellingTime");
        }
    }

    IEnumerator WaitForSellingTime()
    {
        yield return new WaitForSeconds(3);

        canSell = true;
    }
}
