using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BagScript : MonoBehaviour
{
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

    // Start is called before the first frame update
    void Start()
    {
        Monay = 748;
        Gems = 100;
        canOpenPannel = true;
        MakePotsShine = false;
        wheatprice = 5;
        appleprice = 15;
        cherryprice = 9;
        tomatoprice = 7;
        eggplantprice = 5;
        pearprice = 5;
        sunflowerprice = 10;
        avoprice = 3;
        kiwiprice = 8;

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

    public void WheatSlider()
    {
        SliderWheat.maxValue = Monay; 
        SliderWheat.value = Monay / wheatprice;
        if (SliderWheat.value > 10)
        {
            SliderWheat.maxValue = 10;
        }
        else
        {
            SliderWheat.maxValue = SliderWheat.value;
        }
        
    }

    public void AppleSlider()
    {
        SliderApple.maxValue = Monay;
        SliderApple.value = Monay / appleprice;
        if (SliderApple.value > 10)
        {
            SliderApple.maxValue = 10;
        }
        else
        {
            SliderApple.maxValue = SliderApple.value;
        }
    }

    public void CherrySlider()
    {
        SliderCherry.maxValue = Monay;
        SliderCherry.value = Monay / cherryprice;
        if (SliderCherry.value > 10)
        {
            SliderCherry.maxValue = 10;
        }
        else
        {
            SliderCherry.maxValue = SliderCherry.value;
        }
    }

    public void SunflowerSlider()
    {
        SliderSunflower.maxValue = Monay;
        SliderSunflower.value = Monay / sunflowerprice;
        if (SliderSunflower.value > 10)
        {
            SliderSunflower.maxValue = 10;
        }
        else
        {
            SliderSunflower.maxValue = SliderSunflower.value;
        }
    }

    public void EggplantSlider()
    {
        SliderEggplant.maxValue = Monay;
        SliderEggplant.value = Monay / eggplantprice;
        if (SliderEggplant.value > 10)
        {
            SliderEggplant.maxValue = 10;
        }
        else
        {
            SliderEggplant.maxValue = SliderEggplant.value;
        }
    }

    public void PearSlider()
    {
        SliderPear.maxValue = Monay;
        SliderPear.value = Monay / pearprice;
        if (SliderPear.value > 10)
        {
            SliderPear.maxValue = 10;
        }
        else
        {
            SliderPear.maxValue = SliderPear.value;
        }
    }

    public void KiwiSlider()
    {
        SliderKiwi.maxValue = Monay;
        SliderKiwi.value = Monay / kiwiprice;
        if (SliderKiwi.value > 10)
        {
            SliderKiwi.maxValue = 10;
        }
        else
        {
            SliderKiwi.maxValue = SliderKiwi.value;
        }
    }

    public void AvoSlider()
    {
        SliderAvo.maxValue = Monay;
        SliderAvo.value = Monay / avoprice;
        if (SliderAvo.value > 10)
        {
            SliderAvo.maxValue = 10;
        }
        else
        {
            SliderAvo.maxValue = SliderAvo.value;
        }
    }

    public void TomatoSlider()
    {
        SliderTomato.maxValue = Monay;
        SliderTomato.value = Monay / tomatoprice;
        if (SliderTomato.value > 10)
        {
            SliderTomato.maxValue = 10;
        }
        else
        {
            SliderTomato.maxValue = SliderTomato.value;
        }
    }

    IEnumerator errr()
    {
        error.SetActive(true);
        yield return new WaitForSeconds(5);
        error.SetActive(false);
    }
}
