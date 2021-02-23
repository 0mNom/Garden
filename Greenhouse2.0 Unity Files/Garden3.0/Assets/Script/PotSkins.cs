using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotSkins : MonoBehaviour
{
    public DotANIM dot;
    public PotPlaces places;
    ButtonPopUp popUp;
    public Inventory inv;


    void Start()
    {
        /* buttonSkin1.onClick.AddListener(skin1);
        buttonSkin2.onClick.AddListener(skin2);
        buttonSkin3.onClick.AddListener(skin3);*/
    }

    // Update is called once per frame
    void Update()
    {
        popUp = gameObject.GetComponent<ButtonPopUp>();
    }

    public void skin1()
    {
        if (inv.pot1 < 1)
        {
            inv.StartCoroutine("errr");

        }
        else
        {
            inv.pot1--;

            Debug.Log(popUp.Tag);
            if (popUp.Tag == "4") places.sp1 = 1;
            if (popUp.Tag == "2") places.sp2 = 1;
            if (popUp.Tag == "3") places.sp3 = 1;
            if (popUp.Tag == "14") places.sp4 = 1;
            if (popUp.Tag == "5") places.sp5 = 1;
            if (popUp.Tag == "6") places.sp6 = 1;
            if (popUp.Tag == "7") places.sp7 = 1;
            if (popUp.Tag == "8") places.sp8 = 1;
            if (popUp.Tag == "9") places.sp9 = 1;
            if (popUp.Tag == "10") places.sp10 = 1;
            sendinfo();
        }
        




    }
    public void skin2()
    {

        if (inv.pot2 < 1)
        {
            inv.StartCoroutine("errr");

        }
        else
        {
            inv.pot2--;

            Debug.Log(popUp.Tag);
            if (popUp.Tag == "4") places.sp1 = 2;
            if (popUp.Tag == "2") places.sp2 = 2;
            if (popUp.Tag == "3") places.sp3 = 2;
            if (popUp.Tag == "14") places.sp4 = 2;
            if (popUp.Tag == "5") places.sp5 = 2;
            if (popUp.Tag == "6") places.sp6 = 2;
            if (popUp.Tag == "7") places.sp7 = 2;
            if (popUp.Tag == "8") places.sp8 = 2;
            if (popUp.Tag == "9") places.sp9 = 2;
            if (popUp.Tag == "10") places.sp10 = 2;
            sendinfo();
        }
       

        

    }
    public void skin3()
    {
        if (inv.pot3 < 1)
        {

            inv.StartCoroutine("errr");


        }
        else
        {
            inv.pot3--;

            Debug.Log(popUp.Tag);
            if (popUp.Tag == "4") places.sp1 = 3;
            if (popUp.Tag == "2") places.sp2 = 3;
            if (popUp.Tag == "3") places.sp3 = 3;
            if (popUp.Tag == "14") places.sp4 = 3;
            if (popUp.Tag == "5") places.sp5 = 3;
            if (popUp.Tag == "6") places.sp6 = 3;
            if (popUp.Tag == "7") places.sp7 = 3;
            if (popUp.Tag == "8") places.sp8 = 3;
            if (popUp.Tag == "9") places.sp9 = 3;
            if (popUp.Tag == "10") places.sp10 = 3;
            sendinfo();
        }


    }
     public void skin4()
    {
        if (popUp.Tag == "4") places.sp1 = 4;
        if (popUp.Tag == "2") places.sp2 = 4;
        if (popUp.Tag == "3") places.sp3 = 4;
        if (popUp.Tag == "14") places.sp4 = 4;
        if (popUp.Tag == "5") places.sp5 = 4;
        if (popUp.Tag == "6") places.sp6 = 4;
        if (popUp.Tag == "7") places.sp7 = 4;
        if (popUp.Tag == "8") places.sp8 = 4;
        if (popUp.Tag == "9") places.sp9 = 4;
        if (popUp.Tag == "10") places.sp10 = 4;
        sendinfo();


    } 

    public void skin5()
    {
        if (popUp.Tag == "1") places.sp1 = 5;
        if (popUp.Tag == "2") places.sp2 = 5;
        if (popUp.Tag == "3") places.sp3 = 5;
        if (popUp.Tag == "4") places.sp4 = 5;
        if (popUp.Tag == "5") places.sp5 = 5;
        if (popUp.Tag == "6") places.sp6 = 5;
        if (popUp.Tag == "7") places.sp7 = 5;
        if (popUp.Tag == "8") places.sp8 = 5;
        if (popUp.Tag == "9") places.sp9 = 5;
        if (popUp.Tag == "10") places.sp10 = 5;
        sendinfo();


    }
    public void skin6()
    {
        if (popUp.Tag == "1") places.sp1 = 6;
        if (popUp.Tag == "2") places.sp2 = 6;
        if (popUp.Tag == "3") places.sp3 = 6;
        if (popUp.Tag == "4") places.sp4 = 6;
        if (popUp.Tag == "5") places.sp5 = 6;
        if (popUp.Tag == "6") places.sp6 = 6;
        if (popUp.Tag == "7") places.sp7 = 6;
        if (popUp.Tag == "8") places.sp8 = 6;
        if (popUp.Tag == "9") places.sp9 = 6;
        if (popUp.Tag == "10") places.sp10 = 6;
        sendinfo();


    }

    public void skin7()
    {
        if (popUp.Tag == "1") places.sp1 = 7;
        if (popUp.Tag == "2") places.sp2 = 7;
        if (popUp.Tag == "3") places.sp3 = 7;
        if (popUp.Tag == "4") places.sp4 = 7;
        if (popUp.Tag == "5") places.sp5 = 7;
        if (popUp.Tag == "6") places.sp6 = 7;
        if (popUp.Tag == "7") places.sp7 = 7;
        if (popUp.Tag == "8") places.sp8 = 7;
        if (popUp.Tag == "9") places.sp9 = 7;
        if (popUp.Tag == "10") places.sp10 = 7;
        sendinfo();


    }
    public void skin8()
    {
        if (popUp.Tag == "1") places.sp1 = 8;
        if (popUp.Tag == "2") places.sp2 = 8;
        if (popUp.Tag == "3") places.sp3 = 8;
        if (popUp.Tag == "4") places.sp4 = 8;
        if (popUp.Tag == "5") places.sp5 = 8;
        if (popUp.Tag == "6") places.sp6 = 8;
        if (popUp.Tag == "7") places.sp7 = 8;
        if (popUp.Tag == "8") places.sp8 = 8;
        if (popUp.Tag == "9") places.sp9 = 8;
        if (popUp.Tag == "10") places.sp10 = 8;
        sendinfo();


    }
    public void skin9()
    {
        if (popUp.Tag == "1") places.sp1 = 9;
        if (popUp.Tag == "2") places.sp2 = 9;
        if (popUp.Tag == "3") places.sp3 = 9;
        if (popUp.Tag == "4") places.sp4 = 9;
        if (popUp.Tag == "5") places.sp5 = 9;
        if (popUp.Tag == "6") places.sp6 = 9;
        if (popUp.Tag == "7") places.sp7 = 9;
        if (popUp.Tag == "8") places.sp8 = 9;
        if (popUp.Tag == "9") places.sp9 = 9;
        if (popUp.Tag == "10") places.sp10 = 9;
        sendinfo();


    }
    public void skin10()
    {
        if (popUp.Tag == "1") places.sp1 = 10;
        if (popUp.Tag == "2") places.sp2 = 10;
        if (popUp.Tag == "3") places.sp3 = 10;
        if (popUp.Tag == "4") places.sp4 = 10;
        if (popUp.Tag == "5") places.sp5 = 10;
        if (popUp.Tag == "6") places.sp6 = 10;
        if (popUp.Tag == "7") places.sp7 = 10;
        if (popUp.Tag == "8") places.sp8 = 10;
        if (popUp.Tag == "9") places.sp9 = 10;
        if (popUp.Tag == "10") places.sp10 = 10;
        sendinfo();


    }



    public void skin11()
    {
        if (inv.pot1 < 1)
        {
            inv.StartCoroutine("errr");

        }
        else
        {
            inv.pot11--;

            Debug.Log(popUp.Tag);
            if (popUp.Tag == "1") places.sp1 = 11;
            if (popUp.Tag == "2") places.sp2 = 11;
            if (popUp.Tag == "3") places.sp3 = 11;
            if (popUp.Tag == "4") places.sp4 = 11;
            if (popUp.Tag == "5") places.sp5 = 11;
            if (popUp.Tag == "6") places.sp6 = 11;
            if (popUp.Tag == "7") places.sp7 = 11;
            if (popUp.Tag == "8") places.sp8 = 11;
            if (popUp.Tag == "9") places.sp9 = 11;
            if (popUp.Tag == "10") places.sp10 = 11;
            sendinfo();
        }
        




    }
    public void skin12()
    {

        if (inv.pot2 < 1)
        {
            inv.StartCoroutine("errr");

        }
        else
        {
            inv.pot12--;

            Debug.Log(popUp.Tag);
            if (popUp.Tag == "1") places.sp1 = 12;
            if (popUp.Tag == "2") places.sp2 = 12;
            if (popUp.Tag == "3") places.sp3 = 12;
            if (popUp.Tag == "4") places.sp4 = 12;
            if (popUp.Tag == "5") places.sp5 = 12;
            if (popUp.Tag == "6") places.sp6 = 12;
            if (popUp.Tag == "7") places.sp7 = 12;
            if (popUp.Tag == "8") places.sp8 = 12;
            if (popUp.Tag == "9") places.sp9 = 12;
            if (popUp.Tag == "10") places.sp10 = 12;
            sendinfo();
        }
       

        

    }
    public void skin13()
    {
        if (inv.pot3 < 1)
        {

            inv.StartCoroutine("errr");


        }
        else
        {
            inv.pot13--;

            Debug.Log(popUp.Tag);
            if (popUp.Tag == "1") places.sp1 = 13;
            if (popUp.Tag == "2") places.sp2 = 13;
            if (popUp.Tag == "3") places.sp3 = 13;
            if (popUp.Tag == "4") places.sp4 = 13;
            if (popUp.Tag == "5") places.sp5 = 13;
            if (popUp.Tag == "6") places.sp6 = 13;
            if (popUp.Tag == "7") places.sp7 = 13;
            if (popUp.Tag == "8") places.sp8 = 13;
            if (popUp.Tag == "9") places.sp9 = 13;
            if (popUp.Tag == "10") places.sp10 = 13;
            sendinfo();
        }


    }
     public void skin14()
    {
        if (popUp.Tag == "1") places.sp1 = 14;
        if (popUp.Tag == "2") places.sp2 = 14;
        if (popUp.Tag == "3") places.sp3 = 14;
        if (popUp.Tag == "4") places.sp4 = 14;
        if (popUp.Tag == "5") places.sp5 = 14;
        if (popUp.Tag == "6") places.sp6 = 14;
        if (popUp.Tag == "7") places.sp7 = 14;
        if (popUp.Tag == "8") places.sp8 = 14;
        if (popUp.Tag == "9") places.sp9 = 14;
        if (popUp.Tag == "10") places.sp10 = 14;
        sendinfo();


    } 

    public void skin15()
    {
        if (popUp.Tag == "1") places.sp1 = 15;
        if (popUp.Tag == "2") places.sp2 = 15;
        if (popUp.Tag == "3") places.sp3 = 15;
        if (popUp.Tag == "4") places.sp4 = 15;
        if (popUp.Tag == "5") places.sp5 = 15;
        if (popUp.Tag == "6") places.sp6 = 15;
        if (popUp.Tag == "7") places.sp7 = 15;
        if (popUp.Tag == "8") places.sp8 = 15;
        if (popUp.Tag == "9") places.sp9 = 15;
        if (popUp.Tag == "10") places.sp10 = 15;
        sendinfo();


    }
    public void skin16()
    {
        if (popUp.Tag == "1") places.sp1 = 16;
        if (popUp.Tag == "2") places.sp2 = 16;
        if (popUp.Tag == "3") places.sp3 = 16;
        if (popUp.Tag == "4") places.sp4 = 16;
        if (popUp.Tag == "5") places.sp5 = 16;
        if (popUp.Tag == "6") places.sp6 = 16;
        if (popUp.Tag == "7") places.sp7 = 16;
        if (popUp.Tag == "8") places.sp8 = 16;
        if (popUp.Tag == "9") places.sp9 = 16;
        if (popUp.Tag == "10") places.sp10 = 16;
        sendinfo();


    }
    


    public void sendinfo()
    {
        //if (popUp.Tag == "1") places.loadpot("1");
            places.loadpot(popUp.Tag);
    }

}
