using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BagScript : MonoBehaviour
{

    public Sounds sound;

    public Slider SliderWheat;
    public Slider SliderApple;
    public Slider SliderTomato;
    public Slider SliderEggplant;
    public Slider SliderPear;
    public Slider SliderSunflower;
    public Slider SliderCherry;
    public Slider SliderAvo;
    public Slider SliderKiwi;
    public TextMeshProUGUI SliderValueWheat;
    public TextMeshProUGUI SliderValueApple;
    public TextMeshProUGUI SliderValueTomato;
    public TextMeshProUGUI SliderValueEggplant;
    public TextMeshProUGUI SliderValuePear;
    public TextMeshProUGUI SliderValueSunflower;
    public TextMeshProUGUI SliderValueCherry;
    public TextMeshProUGUI SliderValueAvo;
    public TextMeshProUGUI SliderValueKiwi;

    public int plantingseed;
    public int wheatprice, appleprice, tomatoprice, eggplantprice, pearprice, sunflowerprice, cherryprice, avoprice, kiwiprice;
    public int wheatseed, appleseed, tomatoseed, eggplantseed, pearseed, sunflowerseed, cherryseed, avoseed, kiwiseed;
    public GameObject error;
    public TMP_Text t_wheat, t_apple, t_tomato, t_eggplant, t_pear, t_sunflower, t_cherry, t_avo, t_kiwi, t_monay, t_gem;
   
    public int pot1, pot2, pot3, pot4, pot5, pot6, pot7;
    public int Monay,Gems;
    public bool canOpenPannel;
    public bool MakePotsShine;

    public DotANIM dot;
    public TMP_Text t_planting;

    // Start is called before the first frame update
    void Start()
    {
        Monay = 30;
        Gems = 5;
        canOpenPannel = true;
        MakePotsShine = false;
        wheatprice = 10;
        appleprice = 30;
        tomatoprice = 60;
        eggplantprice = 120;
        pearprice = 300;
        sunflowerprice = 750;
        cherryprice = 2250;
        avoprice = 7500;
        kiwiprice = 20000;

    }

    public void starterPack()
    {
        Monay += 1250;
        Gems += 250;
        randomseed(20);
    }

    public void Leaves100()
    {
        Monay += 100;
    }
    public void Leaves2500()
    {
        Monay += 2500;
    }
    public void Leaves10000()
    {
        Monay += 10000;
    }

    public void amber70()
    {
        Gems += 35;
    }
    public void amber1000()
    {
        Gems += 500;
    }
    public void amber6000()
    {
        Gems += 3000;
    }

    public void randSeed5()
    {
        if (Gems < 500)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems = Gems - 500;
            randomseed(5);
        }
    }
    public void randSeed30()
    {
        if (Gems < 2665)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems = Gems - 2665;
            randomseed(30);
        }
    }
    public void randSeed50()
    {
        if (Gems < 4300)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems = Gems - 4300;
            randomseed(50);
        }
    }

    public void randomseed(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int rand = Random.Range(1, 10);
            //Debug.Log(rand);

            if (rand == 1) wheatseed++; 
            if (rand == 2) appleseed++; 
            if (rand == 3) tomatoseed++; 
            if (rand == 4) eggplantseed++; 
            if (rand == 5) pearseed++; 
            if (rand == 6) sunflowerseed++; 
            if (rand == 7) cherryseed++; 
            if (rand == 8) avoseed++; 
            if (rand == 9) kiwiseed++; 

        }

    }

    // Update is called once per frame
    void Update()
    {
        SliderValueWheat.text = SliderWheat.value.ToString();
        SliderValueApple.text = SliderApple.value.ToString();
        SliderValueCherry.text = SliderCherry.value.ToString();
        SliderValueTomato.text = SliderTomato.value.ToString();
        SliderValueEggplant.text = SliderEggplant.value.ToString();
        SliderValuePear.text = SliderPear.value.ToString();
        SliderValueSunflower.text = SliderSunflower.value.ToString();
        SliderValueAvo.text = SliderAvo.value.ToString();
        SliderValueKiwi.text = SliderKiwi.value.ToString();

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

   public void stopShine()
    {
        MakePotsShine = false;
        plantingseed = 0;
        canOpenPannel = true;
    }



    //Seed Shop 
    public void buyApple()
    {
        if (Monay < appleprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= appleprice * (int)SliderApple.value;
            appleseed = appleseed + (int)SliderApple.value;
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
            Monay -= wheatprice * (int)SliderWheat.value;
            wheatseed = wheatseed + (int)SliderWheat.value;
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
            Monay -= cherryprice * (int)SliderCherry.value;
            cherryseed = cherryseed + (int)SliderCherry.value;
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
            Monay -= tomatoprice * (int)SliderTomato.value;
            tomatoseed = tomatoseed + (int)SliderTomato.value;
        }
        t_tomato.text = tomatoseed.ToString();
    }
    public void buyeggplant()
    {
        if (Monay < eggplantprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= eggplantprice * (int)SliderEggplant.value;
            eggplantseed = eggplantseed + (int)SliderEggplant.value;
        }
        t_eggplant.text = eggplantseed.ToString();
    }
    public void buypears()
    {
        if (Monay < pearprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= pearprice * (int)SliderPear.value;
            pearseed = pearseed + (int)SliderPear.value;
        }
        t_pear.text = pearseed.ToString();
    }
    public void buysunflower()
    {
        if (Monay < sunflowerprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= sunflowerprice * (int)SliderSunflower.value;
            sunflowerseed = sunflowerseed + (int)SliderSunflower.value;
        }
        t_sunflower.text = sunflowerseed.ToString();
    }
    public void buyavo()
    {
        if (Monay < avoprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= avoprice * (int)SliderAvo.value;
            avoseed = avoseed + (int)SliderAvo.value;
        }
        t_avo.text = avoseed.ToString();
    }
    public void buykiwi()
    {
        if (Monay < kiwiprice)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= kiwiprice * (int)SliderKiwi.value;
            kiwiseed = kiwiseed + (int)SliderKiwi.value; 
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
            t_planting.text = "Now planting an Apple seed!";
            dot.planting();
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
            dot.planting();
            t_planting.text = "Now planting a Wheat seed!";
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
            dot.planting();
            t_planting.text = "Now planting a Cherry seed!";
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
            dot.planting();
            t_planting.text = "Now planting an Tomato seed!";
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
            dot.planting();
            t_planting.text = "Now planting an Eggplant seed!";
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
            dot.planting();
            t_planting.text = "Now planting a Pear seed!";
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
            dot.planting();
            t_planting.text = "Now planting a Sunflower seed!";
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
            dot.planting();
            t_planting.text = "Now planting an Avocado seed!";
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
            dot.planting();
            t_planting.text = "Now planting a Kiwi seed!";
            plantingseed = 9;
            //kiwiseed--;
        }
        t_kiwi.text = kiwiseed.ToString();
    }

    public void WheatSlider()
    {
        SliderWheat.maxValue = Monay; 
        SliderWheat.value = Monay / wheatprice;
        if (SliderWheat.value > 10)
        {
            SliderWheat.maxValue = 10;
            SliderWheat.value = 1;
        }
        else
        {
            SliderWheat.maxValue = SliderWheat.value;
            SliderWheat.value = 1;
        }
        
    }

    public void AppleSlider()
    {
        SliderApple.maxValue = Monay;
        SliderApple.value = Monay / appleprice;
        if (SliderApple.value > 10)
        {
            SliderApple.maxValue = 10;
            SliderApple.value = 1;
        }
        else
        {
            SliderApple.maxValue = SliderApple.value;
            SliderApple.value = 1;
        }
    }

    public void CherrySlider()
    {
        SliderCherry.maxValue = Monay;
        SliderCherry.value = Monay / cherryprice;
        if (SliderCherry.value > 10)
        {
            SliderCherry.maxValue = 10;
            SliderCherry.value = 1;
        }
        else
        {
            SliderCherry.maxValue = SliderCherry.value;
            SliderCherry.value = 1;
        }
    }

    public void SunflowerSlider()
    {
        SliderSunflower.maxValue = Monay;
        SliderSunflower.value = Monay / sunflowerprice;
        if (SliderSunflower.value > 10)
        {
            SliderSunflower.maxValue = 10;
            SliderSunflower.value = 1;
        }
        else
        {
            SliderSunflower.maxValue = SliderSunflower.value;
            SliderSunflower.value = 1;
        }
    }

    public void EggplantSlider()
    {
        SliderEggplant.maxValue = Monay;
        SliderEggplant.value = Monay / eggplantprice;
        if (SliderEggplant.value > 10)
        {
            SliderEggplant.maxValue = 10;
            SliderEggplant.value = 1;
        }
        else
        {
            SliderEggplant.maxValue = SliderEggplant.value;
            SliderEggplant.value = 1;
        }
    }

    public void PearSlider()
    {
        SliderPear.maxValue = Monay;
        SliderPear.value = Monay / pearprice;
        if (SliderPear.value > 10)
        {
            SliderPear.maxValue = 10;
            SliderPear.value = 1;
        }
        else
        {
            SliderPear.maxValue = SliderPear.value;
            SliderPear.value = 1;
        }
    }

    public void KiwiSlider()
    {
        SliderKiwi.maxValue = Monay;
        SliderKiwi.value = Monay / kiwiprice;
        if (SliderKiwi.value > 10)
        {
            SliderKiwi.maxValue = 10;
            SliderKiwi.value = 1;
        }
        else
        {
            SliderKiwi.maxValue = SliderKiwi.value;
            SliderKiwi.value = 1;
        }
    }

    public void AvoSlider()
    {
        SliderAvo.maxValue = Monay;
        SliderAvo.value = Monay / avoprice;
        if (SliderAvo.value > 10)
        {
            SliderAvo.maxValue = 10;
            SliderAvo.value = 1;
        }
        else
        {
            SliderAvo.maxValue = SliderAvo.value;
            SliderAvo.value = 1;
        }
    }

    public void TomatoSlider()
    {
        SliderTomato.maxValue = Monay;
        SliderTomato.value = Monay / tomatoprice;
        if (SliderTomato.value > 10)
        {
            SliderTomato.maxValue = 10;
            SliderTomato.value = 1;
        }
        else
        {
            SliderTomato.maxValue = SliderTomato.value;
            SliderTomato.value = 1;
        }
    }

    public void cancelPlanting()
    {
        plantingseed = 8;
        dot.NOplanting();
    }

    public void stoperror()
    {
        StopCoroutine("errr");
    }

    IEnumerator errr()
    {
        dot.errorOn();
        sound.error();
        yield return new WaitForSeconds(10);
        dot.errorOff();
        dot.seedbagUP();
    }
}
