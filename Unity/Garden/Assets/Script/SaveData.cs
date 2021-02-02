using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SaveData 
{
   


    public int s_Money, s_Gems; // currency/bank
    public int s_wheat, s_apple, s_tomato, s_eggplant, s_pear, s_sunflower, s_cherry, s_avo, s_kiwi; //number of seeds in bag
    
    
   /* public int s_pot1, s_pot2, s_pot3, s_pot4, s_pot5, s_pot6, s_pot7; //number of each kind of pot
    public bool s_p1, s_p2, s_p3, s_p4, s_p5, s_p6, s_p7, s_p8, s_p9, s_p10; //pot places activated
    public int s_sp1, s_sp2, s_sp3, s_sp4, s_sp5, s_sp6, s_sp7, s_sp8, s_sp9, s_sp10; //skins on the active pots 
    public int s_pp1, s_pp2, s_pp3, s_pp4, s_pp5, s_pp6, s_pp7, s_pp8, s_pp9, s_pp10; //Plant in active pot */
    
   

    public SaveData(BagScript bag)
    {

        //back collection
        s_Money = bag.Monay;
        s_Gems = bag.Gems;

        //Seed number collection
        s_wheat = bag.wheatseed;
        s_apple = bag.appleseed;
        s_tomato = bag.tomatoseed;
        s_eggplant = bag.eggplantseed;
        s_pear = bag.pearseed;
        s_sunflower = bag.sunflowerseed;
        s_cherry = bag.cherryseed;
        s_avo = bag.avoseed;
        s_kiwi = bag.kiwiseed;
/*
        //object inventory colleection
        s_pot1 = invent.pot1;
        s_pot2 = invent.pot2;
        s_pot3 = invent.pot3;
        s_pot4 = invent.pot4;
        s_pot5 = invent.pot5;
        s_pot6 = invent.pot6;
        s_pot7 = invent.pot7;

        //active pots? collectioin
        s_p1 = places.p1;
        s_p2 = places.p2;
        s_p3 = places.p3;
        s_p4 = places.p4;
        s_p5 = places.p5;
        s_p6 = places.p6;
        s_p7 = places.p7;
        s_p8 = places.p8;
        s_p9 = places.p9;
        s_p10 = places.p10;

        //if the pot has been activated, what pot skin and which plant
        if (s_p1)
        {
            s_sp1 = places.sp1;
            s_pp1 = places.pp1;
        }
        if (s_p2)
        {
            s_sp2 = places.sp2;
            s_pp2 = places.pp2;
        }
        if (s_p3)
        {
            s_sp3 = places.sp3;
            s_pp3 = places.pp3;
        }
        if (s_p4)
        {
            s_sp4 = places.sp4;
            s_pp4 = places.pp4;
        }
        if (s_p5)
        {
            s_sp5 = places.sp5;
            s_pp5 = places.pp5;
        }
        if (s_p6)
        {
            s_sp6 = places.sp6;
            s_pp6 = places.pp6;
        }
        if (s_p7)
        {
            s_sp7 = places.sp7;
            s_pp7 = places.pp7;
        }
        if (s_p8)
        {
            s_sp8 = places.sp8;
            s_pp8 = places.pp8;
        }
        if (s_p9)
        {
            s_sp9 = places.sp9;
            s_pp9 = places.pp9;
        }
        if (s_p10)
        {
            s_sp10 = places.sp10;
            s_pp10 = places.pp10;
        }
        */

    }

  /*  public void Load()
    {

        //bank collection load
        bag.Monay = s_Money;
        bag.Gems = s_Gems;

        //Seed numbers load
        bag.wheatseed = s_wheat;
        bag.appleseed = s_apple;
        bag.tomatoseed = s_tomato;
        bag.eggplantseed = s_eggplant;
        bag.pearseed = s_pear;
        bag.sunflowerseed = s_sunflower;
        bag.cherryseed = s_cherry;
        bag.avoseed = s_avo;
        bag.kiwiseed = s_kiwi;

        //object inventory colleection load
        invent.pot1 = s_pot1;
        invent.pot2 = s_pot2;
        invent.pot3 = s_pot3;
        invent.pot4 = s_pot4;
        invent.pot5 = s_pot5;
        invent.pot6 = s_pot6;
        invent.pot7 = s_pot7;

        //active pots? collectioin load
        places.p1 = s_p1;
        places.p2 = s_p2;
        places.p3 = s_p3;
        places.p4 = s_p4;
        places.p5 = s_p5;
        places.p6 = s_p6;
        places.p7 = s_p7;
        places.p8 = s_p8;
        places.p9 = s_p9;
        places.p10 = s_p10;

        //if the pot has been activated, what pot skin and which plant load
        if (s_p1)
        {
            places.sp1 = s_sp1;
            places.pp1 = s_pp1;
        }
        if (s_p2)
        {
            places.sp2 = s_sp2;
            places.pp2 = s_pp2;
        }
        if (s_p3)
        {
            places.sp3 = s_sp3;
            places.pp3 = s_pp3;
        }
        if (s_p4)
        {
            places.sp4 = s_sp4;
            places.pp4 = s_pp4;
        }
        if (s_p5)
        {
            places.sp5 = s_sp5;
            places.pp5 = s_pp5;
        }
        if (s_p6)
        {
            places.sp6 = s_sp6;
            places.pp6 = s_pp6;
        }
        if (s_p7)
        {
            places.sp7 = s_sp7;
            places.pp7 = s_pp7;
        }
        if (s_p8)
        {
            places.sp8 = s_sp8;
            places.pp8 = s_pp8;
        }
        if (s_p9)
        {
            places.sp9 = s_sp9;
            places.pp9 = s_pp9;
        }
        if (s_p10)
        {
            places.sp10 = s_sp10;
            places.pp10 = s_pp10;
        }



    }*/
}
