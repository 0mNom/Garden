using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotSkins : MonoBehaviour
{
    public Button buttonSkin1;
    public Button buttonSkin2;
    public Button buttonSkin3;
    // public string tag;
    public PotPlaces places;
    ButtonPopUp popUp;
    public Inventory inv;


    void Start()
    {
        buttonSkin1.onClick.AddListener(skin1);
        buttonSkin2.onClick.AddListener(skin2);
        buttonSkin3.onClick.AddListener(skin3);
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


            if (popUp.Tag == "1") places.sp1 = 1;
            if (popUp.Tag == "2") places.sp2 = 1;
            if (popUp.Tag == "3") places.sp3 = 1;
            if (popUp.Tag == "4") places.sp4 = 1;
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

            if (popUp.Tag == "1") places.sp1 = 2;
            if (popUp.Tag == "2") places.sp2 = 2;
            if (popUp.Tag == "3") places.sp3 = 2;
            if (popUp.Tag == "4") places.sp4 = 2;
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

            if (popUp.Tag == "1") places.sp1 = 3;
            if (popUp.Tag == "2") places.sp2 = 3;
            if (popUp.Tag == "3") places.sp3 = 3;
            if (popUp.Tag == "4") places.sp4 = 3;
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
        if (popUp.Tag == "1") places.sp1 = 4;
        if (popUp.Tag == "2") places.sp2 = 4;
        if (popUp.Tag == "3") places.sp3 = 4;
        if (popUp.Tag == "4") places.sp4 = 4;
        if (popUp.Tag == "5") places.sp5 = 4;
        if (popUp.Tag == "6") places.sp6 = 4;
        if (popUp.Tag == "7") places.sp7 = 4;
        if (popUp.Tag == "8") places.sp8 = 4;
        if (popUp.Tag == "9") places.sp9 = 4;
        if (popUp.Tag == "10") places.sp10 = 4;
        sendinfo();


    }
    public void sendinfo()
    {
        //if (popUp.Tag == "1") places.loadpot("1");
            places.loadpot(popUp.Tag);
    }

}
