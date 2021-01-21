using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BagScript : MonoBehaviour
{
    public int plantingseed;
    public int wheatseed, appleseed, tomatoseed, eggplantseed, pearseed, sunflowerseed, cherryseed, avoseed, kiwiseed;
    public GameObject error;
    public TMP_Text t_wheat, t_apple, t_tomato, t_eggplant, t_pear, t_sunflower, t_cherry, t_avo, t_kiwi, t_monay, t_gem;
    public TMP_Text t_pot1, t_pot2, t_pot3, t_pot4, t_pot5, t_pot6, t_pot7;
    public int pot1, pot2, pot3, pot4, pot5, pot6, pot7;
    public int Monay,Gems;
    public bool canOpenPannel;

    // Start is called before the first frame update
    void Start()
    {
        Monay = 748;
        Gems = 5;
        canOpenPannel = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(plantingseed);
        if(plantingseed == 1)
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


        t_pot1.text = pot1.ToString();
        t_pot2.text = pot2.ToString();
        t_pot3.text = pot3.ToString();
        t_pot4.text = pot4.ToString();
        t_pot5.text = pot5.ToString();
        t_pot6.text = pot6.ToString();
        t_pot7.text = pot7.ToString();
    }


   
    //Premium shop 
    //Pot shop 

    public void buyP1()
    {
        if (Gems < 10)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 10;
            pot1++;
        }
    }
    public void buyP2()
    {
        if (Gems < 2)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 2;
            pot2++;
        }
    }
    public void buyP3()
    {
        if (Gems < 12)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 12;
            pot3++;
        }
    }
    public void buyP4()
    {
        if (Gems < 2)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 2;
            pot4++;
        }
    }
    public void buyP5()
    {
        if (Gems < 30)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 30;
            pot5++;
        }
    }
    public void buyP6()
    {
        if (Gems < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 1;
            pot6++;
        }
    }
    public void buyP7()
    {
        if (Gems < 4)
        {
            StartCoroutine("errr");
        }
        else
        {
            Gems -= 4;
            pot7++;
        }
    }



    //Seed Shop 
    public void buyApple()
    {
        if (Monay < 15)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 15;
            appleseed++;
        }

        t_apple.text = appleseed.ToString();

    }
    public void buywheat()
    {
        if (Monay < 5)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 5;
            wheatseed++;
        }
        t_wheat.text = wheatseed.ToString();
    }
    public void buycherry()
    {
        if (Monay < 9)
        {
            StartCoroutine("errr");
        }
        else
        {
            Monay -= 9;
            cherryseed++;
        }
        t_cherry.text = cherryseed.ToString();

    }
    public void buytomato()
    {
        if (Monay < 7)
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
            appleseed--;
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
            plantingseed = 1;
            wheatseed--;
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
            plantingseed = 7;
            cherryseed--;
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
            plantingseed = 3;
            tomatoseed--;
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
            plantingseed = 4;
            eggplantseed--;
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
            plantingseed = 5;
            pearseed--;
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
            plantingseed = 6;
            sunflowerseed--;
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
            plantingseed = 8;
            avoseed--;
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
            plantingseed = 9;
            kiwiseed--;
        }
        t_kiwi.text = kiwiseed.ToString();
    }

    IEnumerator errr()
    {
        error.SetActive(true);
        yield return new WaitForSeconds(5);
        error.SetActive(false);
    }

}
