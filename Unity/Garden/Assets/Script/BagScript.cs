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
    public int Monay,Gems;

    // Start is called before the first frame update
    void Start()
    {
        Monay = 748;
        Gems = 5;
    }

    // Update is called once per frame
    void Update()
    {
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
    }


    public void LoadGame()
    {
        SaveData data = SaveManager.LoadGame();

        Monay = data.s_Money;
        Gems = data.s_Gems;

    }

    public void SaveGame()
    {
        SaveManager.SaveGame(this);
    }


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
    public void plantApple()
    {
        if (appleseed < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
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
