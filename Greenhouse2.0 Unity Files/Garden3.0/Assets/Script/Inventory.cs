﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public Sounds sound;

    public int pot1, pot2, pot3, pot4, pot5, pot6, pot7, pot8, pot9, pot10, pot11, pot12, pot13, pot14, pot15, pot16; //number of each kind of pot
    public BagScript bag;
    public GameObject error;
    public DotANIM dot;
    public TMP_Text t_pot1, t_pot2, t_pot3, t_pot4, t_pot5, t_pot6, t_pot7, t_pot8, t_pot9, t_pot10, t_pot11, t_pot12, t_pot13, t_pot14, t_pot15, t_pot16;

    void Start()
    {
        
    }

    public void loadinv()
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
        t_pot8.text = pot8.ToString();
        t_pot9.text = pot9.ToString();
        t_pot10.text = pot10.ToString();
        t_pot11.text = pot11.ToString();
        t_pot12.text = pot12.ToString();
        t_pot13.text = pot13.ToString();
        t_pot14.text = pot14.ToString();
        t_pot15.text = pot15.ToString();
        t_pot16.text = pot16.ToString();
    }
    public void buyP1()
    {
        if (bag.Gems < 200)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 200;
            pot1++;
        }
    }
    public void buyP2()
    {
        if (bag.Gems < 200)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 200;
            pot2++;
        }
    }
    public void buyP3()
    {
        if (bag.Gems < 350)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 350;
            pot3++;
        }
    }
    public void buyP4()
    {
        if (bag.Gems < 350)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 350;
            pot4++;
        }
    }
    public void buyP5()
    {
        if (bag.Gems < 500)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 500;
            pot5++;
        }
    }
    public void buyP6()
    {
        if (bag.Gems < 350)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 350;
            pot6++;
        }
    }
    public void buyP7()
    {
        if (bag.Gems < 350)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 350;
            pot7++;
        }
    }
     public void buyP8()
    {
        if (bag.Gems < 500)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 500;
            pot8++;
        }
    }
     public void buyP9()
    {
        if (bag.Gems < 500)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 500;
            pot9++;
        }
    }
     public void buyP10()
    {
        if (bag.Gems < 200)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 200;
            pot10++;
        }
    }
     public void buyP11()
    {
        if (bag.Gems < 200)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 200;
            pot11++;
        }
    }
     public void buyP12()
    {
        if (bag.Gems < 750)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 750;
            pot12++;
        }
    }
     public void buyP13()
    {
        if (bag.Gems < 750)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 750;
            pot13++;
        }
    }
     public void buyP14()
    {
        if (bag.Gems < 750)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 750;
            pot14++;
        }
    }
     public void buyP15()
    {
        if (bag.Gems < 500)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 500;
            pot15++;
        }
    }
     public void buyP16()
    {
        if (bag.Gems < 750)
        {
            StartCoroutine("errr");
        }
        else
        {
            bag.Gems -= 750;
            pot16++;
        }
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
    }
}
