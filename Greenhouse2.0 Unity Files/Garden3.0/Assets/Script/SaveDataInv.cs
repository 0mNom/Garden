using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveDataInv
{
    public int s_pot1, s_pot2, s_pot3, s_pot4, s_pot5, s_pot6, s_pot7, s_pot11, s_pot10, s_pot9, s_pot8, s_pot12, s_pot13, s_pot14, s_pot15, s_pot16; //number of each kind of pot


    public SaveDataInv(Inventory invent)
    {
        //object inventory colleection
        s_pot1 = invent.pot1;
        s_pot2 = invent.pot2;
        s_pot3 = invent.pot3;
        s_pot4 = invent.pot4;
        s_pot5 = invent.pot5;
        s_pot6 = invent.pot6;
        s_pot7 = invent.pot7;
        s_pot8 = invent.pot8;
        s_pot9 = invent.pot9;
        s_pot10 = invent.pot10;
        s_pot11 = invent.pot11;
        s_pot12 = invent.pot12;
        s_pot13 = invent.pot13;
        s_pot14 = invent.pot14;
        s_pot15 = invent.pot15;
        s_pot16 = invent.pot16;

    }
}
