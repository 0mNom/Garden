using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int pot1, pot2, pot3, pot4, pot5, pot6, pot7; //number of each kind of pot
    public BagScript bag;
    public GameObject error;
    public TMP_Text t_pot1, t_pot2, t_pot3, t_pot4, t_pot5, t_pot6, t_pot7;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_pot1.text = pot1.ToString();
        t_pot2.text = pot2.ToString();
        t_pot3.text = pot3.ToString();
        t_pot4.text = pot4.ToString();
        t_pot5.text = pot5.ToString();
        t_pot6.text = pot6.ToString();
        t_pot7.text = pot7.ToString();
    }
    public void buyP1()
    {
        if (bag.Gems < 10)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 10;
            pot1++;
        }
    }
    public void buyP2()
    {
        if (bag.Gems < 2)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 2;
            pot2++;
        }
    }
    public void buyP3()
    {
        if (bag.Gems < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 1;
            pot3++;
        }
    }
    public void buyP4()
    {
        if (bag.Gems < 2)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 2;
            pot4++;
        }
    }
    public void buyP5()
    {
        if (bag.Gems < 30)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 30;
            pot5++;
        }
    }
    public void buyP6()
    {
        if (bag.Gems < 1)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 1;
            pot6++;
        }
    }
    public void buyP7()
    {
        if (bag.Gems < 4)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 4;
            pot7++;
        }
    }

    IEnumerator errr()
    {
        error.SetActive(true);
        yield return new WaitForSeconds(5);
        error.SetActive(false);
    }
}
