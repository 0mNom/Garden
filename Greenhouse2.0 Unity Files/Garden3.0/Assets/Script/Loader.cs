using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public BagScript bag;
    public Inventory invent;
    public PotPlaces places;

    public bool auto = false;

    public void Start()
    {
       // auto = true; 
    }

    public void Update()
    {

        //StartCoroutine("Start");
       // if (!auto) StartCoroutine("AutoSave");

    }




    public void LoadGame()
    {
        SaveData data = SaveManager.LoadGame();
        SaveDataPots dataP = SaveManager.LoadGameP();
        SaveDataInv dataI = SaveManager.LoadGameI();

        invent.pot1= dataI.s_pot1;
        invent.pot2= dataI.s_pot2;
        invent.pot3 = dataI.s_pot3;
        invent.pot4 = dataI.s_pot4;
        invent.pot5 = dataI.s_pot5;
        invent.pot6 = dataI.s_pot6;
        invent.pot7 = dataI.s_pot7;
        invent.pot8 = dataI.s_pot8;
        invent.pot9 = dataI.s_pot9;
        invent.pot10 = dataI.s_pot10;

        invent.pot11 = dataI.s_pot11;
        invent.pot12 = dataI.s_pot12;
        invent.pot13 = dataI.s_pot13;
        invent.pot14 = dataI.s_pot14;
        invent.pot15 = dataI.s_pot15;
        invent.pot16 = dataI.s_pot16;


        //Bag,money and Seeds
        bag.Monay = data.s_Money;
        bag.Gems = data.s_Gems;

        bag.wheatseed = data.s_wheat;
        bag.appleseed = data.s_apple;
        bag.tomatoseed = data.s_tomato;
        bag.eggplantseed = data.s_eggplant;
        bag.pearseed = data.s_pear;
        bag.sunflowerseed = data.s_sunflower;
        bag.cherryseed = data.s_cherry;
        bag.avoseed = data.s_avo;
        bag.kiwiseed = data.s_kiwi;

        //Pot places 

        //gotPlant
        places.got1 = dataP.s_got1;
        places.got2 = dataP.s_got2;
        places.got3 = dataP.s_got3;

        //plants 
        places.ble1 = dataP.s_ble1;
        places.apple1 = dataP.s_apple1;
        places.tomato1 = dataP.s_tomato1 ;
        places.eggplant1 = dataP.s_eggplant1;
        places.pear1 = dataP.s_pear1;
        places.sunflower1 = dataP.s_sunflower1;
        places.cherry1 = dataP.s_cherry1;
        places.avocado1 = dataP.s_avocado1;
        places.kiwi1 = dataP.s_kiwi1;


        places.ble2 = dataP.s_ble2;
        places.apple2 = dataP.s_apple2;
        places.tomato2 = dataP.s_tomato2;
        places.eggplant2 = dataP.s_eggplant2;
        places.pear2 = dataP.s_pear2;
        places.sunflower2 = dataP.s_sunflower2;
        places.cherry2 = dataP.s_cherry2;
        places.avocado2 = dataP.s_avocado2;
        places.kiwi2 = dataP.s_kiwi2;



        places.ble3 = dataP.s_ble3;
        places.apple3 = dataP.s_apple3;
        places.tomato3 =dataP.s_tomato3;
        places.eggplant3 = dataP.s_eggplant3;
        places.pear3 = dataP.s_pear3;
        places.sunflower3 = dataP.s_sunflower3;
        places.cherry3 = dataP.s_cherry3;
        places.avocado3 = dataP.s_avocado3;
        places.kiwi3 = dataP.s_kiwi3;


      

        places.PF1 = dataP.s_PF1;
        places.PF2 = dataP.s_PF2;
        places.PF3 = dataP.s_PF3;




        //load date time 
        places.TT1P1 = dataP.s_TT1P1;
        places.TT2P1 = dataP.s_TT2P1;
        places.TT3P1 = dataP.s_TT3P1;
        //Debug.Log(places.TT1P1);

        places.TT1P2 = dataP.s_TT1P2;
        places.TT2P2 = dataP.s_TT2P2;
        places.TT3P2 = dataP.s_TT3P2;
        //Debug.Log(places.TT1P2);

        places.TT1P3 = dataP.s_TT1P3;
        places.TT2P3 = dataP.s_TT2P3;
        places.TT3P3 = dataP.s_TT3P3;
        //Debug.Log(places.TT1P3);

        //selling price

        places.sell1 = dataP.s_sell1;
        places.sell2 = dataP.s_sell2;
        places.sell3 = dataP.s_sell3;

        places.lvl = dataP.s_lvl;




        //active pots? collectioin load

        places.p1 = dataP.s_p1;
        places.p2 = dataP.s_p2;
        places.p3 = dataP.s_p3;
        places.p4 = dataP.s_p4;
        places.p5 = dataP.s_p5;
        places.p6 = dataP.s_p6;
        places.p7 = dataP.s_p7;
        places.p8 = dataP.s_p8;
        places.p9 = dataP.s_p9;
        places.p10 = dataP.s_p10;

        //if the pot has been activated, what pot skin and which plant load
        if (dataP.s_p1)
        {
            places.sp1 = dataP.s_sp1;
            places.pp1 = dataP.s_pp1;
        }
        if (dataP.s_p2)
        {
            places.sp2 = dataP.s_sp2;
            places.pp2 = dataP.s_pp2;
        }
        if (dataP.s_p3)
        {
            places.sp3 = dataP.s_sp3;
            places.pp3 = dataP.s_pp3;
        }
        if (dataP.s_p4)
        {
            places.sp4 = dataP.s_sp4;
            places.pp4 = dataP.s_pp4;
        }
        if (dataP.s_p5)
        {
            places.sp5 = dataP.s_sp5;
            places.pp5 = dataP.s_pp5;
        }
        if (dataP.s_p6)
        {
            places.sp6 = dataP.s_sp6;
            places.pp6 = dataP.s_pp6;
        }
        if (dataP.s_p7)
        {
            places.sp7 = dataP.s_sp7;
            places.pp7 = dataP.s_pp7;
        }
        if (dataP.s_p8)
        {
            places.sp8 = dataP.s_sp8;
            places.pp8 = dataP.s_pp8;
        }
        if (dataP.s_p9)
        {
            places.sp9 = dataP.s_sp9;
            places.pp9 = dataP.s_pp9;
        }
        if (dataP.s_p10)
        {
            places.sp10 = dataP.s_sp10;
            places.pp10 = dataP.s_pp10;
        }
        places.loadplants();
        //Debug.Log("Pots loaded");
    }

    public void SaveGame()
    {
        SaveManager.SaveGame(bag);
        SaveManager.SaveGameP(places);
        SaveManager.SaveGameI(invent);

    }

    IEnumerator start()
    {
        yield return new WaitForSeconds(30f);
    }

    IEnumerator AutoSave()
    {
        auto = true;
        SaveGame();
        Debug.Log("Saved");
        yield return new WaitForSeconds(30f);
        auto = false;
    }
}
