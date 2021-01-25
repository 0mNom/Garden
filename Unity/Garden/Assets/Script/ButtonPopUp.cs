using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonPopUp : MonoBehaviour
{
    public bool pannelActive;
    public GameObject bagObject;
    public GameObject thePotClicked;
    Collider2D col;
    public string Name1, Name2, Name3;
    public TextMeshProUGUI nameText;
    public Animator animator;

    public Button sellButton;

    public SpriteRenderer ImagePotDuPopUp;
    public SpriteRenderer ImagePlantDuPopUp;

    public string Tag;

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

                    Tag = col.tag;

                    Debug.Log(Tag);

                    OpenPanel(Tag);

                    /*
                    ClickToPlant clickToPlantScript = GameObject.FindGameObjectWithTag(Tag).GetComponent<ClickToPlant>();

                    
                    if (clickToPlantScript.plantFinished && pannelActive == true)
                    {
                       // Debug.Log(Tag);
                        sellButton.gameObject.SetActive(true);
                        //Debug.Log(gameObject);
                        Button btn = sellButton.GetComponent<Button>();

                        btn.onClick.AddListener(SellPlant);
                    }

                    if (!clickToPlantScript.plantFinished && pannelActive == true)
                    {
                       // Debug.Log("yess ");
                        sellButton.gameObject.SetActive(false);
                    }*/

                }
            }
        }
        Debug.Log(pannelActive);
        if (pannelActive == true)
        {
            ClickToPlant clickToPlantScript = GameObject.FindGameObjectWithTag(Tag).GetComponent<ClickToPlant>();
            if (clickToPlantScript.plantFinished)
            {
                // Debug.Log(Tag);
                sellButton.gameObject.SetActive(true);
                //Debug.Log(gameObject);
                Button btn = sellButton.GetComponent<Button>();

                btn.onClick.AddListener(SellPlant);
            }

            if (!clickToPlantScript.plantFinished)
            {
                // Debug.Log("yess ");
                sellButton.gameObject.SetActive(false);
            }
        }
        


    }

    

    public void OpenPanel(string tag)
    {
        
        animator.SetBool("IsOpen", true);
        pannelActive = true;
        if (tag == "1" ) nameText.text = Name1;
        if (tag == "2" ) nameText.text = Name2;
        if (tag == "3" ) nameText.text = Name3;


        SpriteRenderer spritePot = gameObject.GetComponent<SpriteRenderer>();
        ImagePotDuPopUp.sprite = spritePot.sprite;
        SpriteRenderer spritePlant = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        ImagePlantDuPopUp.sprite = spritePlant.sprite;
       //Debug.Log(tag);
    }

    public void LoadPannel()
    {
        if(pannelActive)
        {
            SpriteRenderer spritePot = gameObject.GetComponent<SpriteRenderer>();
            ImagePotDuPopUp.sprite = spritePot.sprite;
            SpriteRenderer spritePlant = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
            ImagePlantDuPopUp.sprite = spritePlant.sprite;
        }
        
    }

    public void ClosePanel()
    {
        ImagePotDuPopUp.sprite = null;
        ImagePlantDuPopUp.sprite = null;
        animator.SetBool("IsOpen", false);
        pannelActive = false;
        Tag = null;
        Debug.Log("pannelactive = " + pannelActive);
        Debug.Log(Tag);
    }


    public void SellPlant()
    {
        if(canSell)
        {
           // Debug.Log(tag);
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
            clickToPlantScript.EnvoyerVariable(Tag);
            

            canSell = false;
            Tag = null;
            StartCoroutine("WaitForSellingTime");
        }
    }

    IEnumerator WaitForSellingTime()
    {
        yield return new WaitForSeconds(3);

        canSell = true;
    }

    public void resetTag()
    {
        Tag = null;
    }
}
