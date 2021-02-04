﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BagScript : MonoBehaviour
{
    public Slider WheatSlider;
    public TextMeshProUGUI SliderValue;

    public int plantingseed;
    public int wheatprice, appleprice, tomatoprice, eggplantprice, pearprice, sunflowerprice, cherryprice, avoprice, kiwiprice;
    public int wheatseed, appleseed, tomatoseed, eggplantseed, pearseed, sunflowerseed, cherryseed, avoseed, kiwiseed;
    public GameObject error;
    public TMP_Text t_wheat, t_apple, t_tomato, t_eggplant, t_pear, t_sunflower, t_cherry, t_avo, t_kiwi, t_monay, t_gem;
   
    public int pot1, pot2, pot3, pot4, pot5, pot6, pot7;
    public int Monay,Gems;
    public bool canOpenPannel;
    public bool MakePotsShine;

    // Start is called before the first frame update
    void Start()
    {
        Monay = 748;
        Gems = 100;
        canOpenPannel = true;
        MakePotsShine = false;
        wheatprice = 5;
        appleprice = 15;
        tomatoprice = 7;
        eggplantprice = 5;
        pearprice = 5;
        sunflowerprice = 10;
        cherryprice = 9;
        avoprice = 3;
        kiwiprice = 3;
       

    }

    // Update is called once per frame
    void Update()
    {
        SliderValue.text = WheatSlider.value.ToString();

        //Debug.Log(plantingseed);
        if (plantingseed == 1)
        {

        }

        t_monay.text = Monay.ToString();
        t_gem.text = Gems.ToString();
        t_apple.text = appleseed.ToString();
        t_wheat.text = wheatseed.ToString();
        t_cherry.text = cherryseed.ToString();
        t_tomato.text = tomatoseed.ToString();
        t_eggplant.text = eggplantseed.ToString();
        t_pear.text = pearseed.ToString();
        t_sunflower.text = sunflowerseed.ToString();
        t_avo.text = avoseed.ToString();
        t_kiwi.text = kiwiseed.ToString();


        
    }


   
    //Premium shop 
    //Pot shop 

   



    //Seed Shop 
    public void buyApple()
    {
        if (Monay < appleprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= appleprice;
            appleseed++;
        }

        t_apple.text = appleseed.ToString();

    }
    public void buywheat()
    {
        if (Monay < wheatprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= wheatprice * (int)WheatSlider.value;
            wheatseed = wheatseed + (int)WheatSlider.value;
        }
        t_wheat.text = wheatseed.ToString();
    }
    public void buycherry()
    {
        if (Monay < cherryprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= cherryprice;
            cherryseed++;
        }
        t_cherry.text = cherryseed.ToString();

    }
    public void buytomato()
    {
        if (Monay < tomatoprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 7;
            tomatoseed++;
        }
        t_tomato.text = tomatoseed.ToString();
    }
    public void buyeggplant()
    {
        if (Monay < 5)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 5;
            eggplantseed++;
        }
        t_eggplant.text = eggplantseed.ToString();
    }
    public void buypears()
    {
        if (Monay < 5)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 5;
            pearseed++;
        }
        t_pear.text = pearseed.ToString();
    }
    public void buysunflower()
    {
        if (Monay < 10)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 10;
            sunflowerseed++;
        }
        t_sunflower.text = sunflowerseed.ToString();
    }
    public void buyavo()
    {
        if (Monay < 3)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 3;
            avoseed++;
        }
        t_avo.text = avoseed.ToString();
    }
    public void buykiwi()
    {
        if (Monay < 3)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 3;
            kiwiseed++;
        }
        t_kiwi.text = kiwiseed.ToString();
    }



    //planting

    public void plantApple()
    {
        if (appleseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            //appleseed--;
            plantingseed = 2;
        }

        t_apple.text = appleseed.ToString();

    }
    public void plantWheat()
    {
        if (wheatseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 1;
            //wheatseed--;
        }
        t_wheat.text = wheatseed.ToString();
    }
    public void plantcherry()
    {
        if (cherryseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 7;
            //cherryseed--;
        }
        t_cherry.text = cherryseed.ToString();

    }
    public void plantTomato()
    {
        if (tomatoseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 3;
            //tomatoseed--;
        }
        t_tomato.text = tomatoseed.ToString();
    }
    public void planteggplant()
    {
        if (eggplantseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 4;
            //eggplantseed--;
        }
        t_eggplant.text = eggplantseed.ToString();
    }
    public void plantpear()
    {
        if (pearseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 5;
            //pearseed--;
        }
        t_pear.text = pearseed.ToString();
    }
    public void plantsunflower()
    {
        if (sunflowerseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 6;
            //sunflowerseed--;
        }
        t_sunflower.text = sunflowerseed.ToString();
    }
    public void plantavo()
    {
        if (avoseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 8;
            //avoseed--;
        }
        t_avo.text = avoseed.ToString();
    }
    public void plantkiwi()
    {
        if (kiwiseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            canOpenPannel = false;
            MakePotsShine = true;
            plantingseed = 9;
            //kiwiseed--;
        }
        t_kiwi.text = kiwiseed.ToString();
    }

    public void Sliderwheat()
    {
        WheatSlider.maxValue = Monay;
        WheatSlider.value = Monay / wheatprice;
        WheatSlider.maxValue = WheatSlider.value;
    }

    IEnumerator errr()
    {
        error.SetActive(true);
        yield return new WaitForSeconds(5);
        error.SetActive(false);
    }
}
