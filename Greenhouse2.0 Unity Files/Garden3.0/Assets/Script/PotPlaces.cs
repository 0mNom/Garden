using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPlaces : MonoBehaviour
{
    // Start is called before the first frame update
    public bool p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 = true ;  //POSSIBLE POT PLACES AND IF THEY HAVE BEEN ACTIVED:BOUGHT
    public int sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10; //skins on the active pots 
    public float pp1, pp2, pp3, pp4, pp5, pp6, pp7, pp8, pp9, pp10; //pot planted in x pot
    public Sprite pousseBle, evolutionBle1, evolutionBle2, evolutionBle3;
    public Sprite pousseApple, evolutionApple1, evolutionApple2, evolutionApple3;
    public Sprite pousseTomato, evolutionTomato1, evolutionTomato2, evolutionTomato3;
    public Sprite pousseEgg, evolutionEggplant1, evolutionEggplant2, evolutionEggplant3;
    public Sprite poussePear, evolutionPear1, evolutionPear2, evolutionPear3;
    public Sprite pousseSun, evolutionSun1, evolutionSun2, evolutionSun3;
    public Sprite pousseCherry, evolutionCherry1, evolutionCherry2, evolutionCherry3;
    public Sprite pousseAvo, evolutionAvo1, evolutionAvo2, evolutionAvo3;
    public Sprite pousseKiwi, evolutionKiwi1, evolutionKiwi2, evolutionKiwi3;
    public Sprite Skin1, Skin2, Skin3, Skin4, Skin5, Skin6, Skin7, Skin8, Skin9, Skin10, Skin11, Skin12, Skin13, Skin14, Skin15, Skin16;
    public Sprite Skin1Shine, Skin2Shine, Skin3Shine, Skin4Shine, Skin5Shine, Skin6Shine, Skin7Shine, Skin8Shine, Skin9Shine, Skin10Shine, Skin11Shine, Skin12Shine, Skin13Shine, Skin14Shine, Skin15Shine, Skin16Shine;
    public SpriteRenderer spriteRendererP1,spriteRendererP2, spriteRendererP3;
    public SpriteRenderer spriteRendererPot1, spriteRendererPot2, spriteRendererPot3;
    public SpriteRenderer spriteRendererPot1Shine, spriteRendererPot2Shine, spriteRendererPot3Shine;
    public Animator potAnim;

    public string TT1P1, TT2P1, TT3P1, TT1P2, TT2P2, TT3P2, TT1P3, TT2P3, TT3P3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadpot(string tag)
    {
        if( tag == "4")
        {
            potAnim = GameObject.FindGameObjectWithTag(tag).GetComponent<Animator>();
            potAnim.SetTrigger("POP");

            if (sp1 == 1)
            {
                spriteRendererPot1.sprite = Skin1;
                spriteRendererPot1Shine.sprite = Skin1Shine;
            }
            if (sp1 == 2) 
            {
                spriteRendererPot1.sprite = Skin2;
                spriteRendererPot1Shine.sprite = Skin2Shine;
            }
            if (sp1 == 3)
            {
                spriteRendererPot1.sprite = Skin3;
                spriteRendererPot1Shine.sprite= Skin3Shine;
            }
            if (sp1 == 4)
            {
                spriteRendererPot1.sprite = Skin4;
                spriteRendererPot1Shine.sprite = Skin4Shine;
            }
            if (sp1 == 5)
            {
                spriteRendererPot1.sprite = Skin5;
                spriteRendererPot1Shine.sprite = Skin5Shine;
            }
            if (sp1 == 6)
            {
                spriteRendererPot1.sprite = Skin6;
                spriteRendererPot1Shine.sprite = Skin6Shine;
            }
            if (sp1 == 7)
            {
                spriteRendererPot1.sprite = Skin7;
                spriteRendererPot1Shine.sprite = Skin7Shine;
            }
            if (sp1 == 8)
            {
                spriteRendererPot1.sprite = Skin8;
                spriteRendererPot1Shine.sprite = Skin8Shine;
            }
            if (sp1 == 9)
            {
                spriteRendererPot1.sprite = Skin9;
                spriteRendererPot1Shine.sprite = Skin9Shine;
            }
            if (sp1 == 10)
            {
                spriteRendererPot1.sprite = Skin10;
                spriteRendererPot1Shine.sprite = Skin10Shine;
            }
            if (sp1 == 11)
            {
                spriteRendererPot1.sprite = Skin11;
                spriteRendererPot1Shine.sprite = Skin11Shine;
            }
            if (sp1 == 12)
            {
                spriteRendererPot1.sprite = Skin12;
                spriteRendererPot1Shine.sprite = Skin12Shine;
            }
            if (sp1 == 13)
            {
                spriteRendererPot1.sprite = Skin13;
                spriteRendererPot1Shine.sprite = Skin13Shine;
            }
            if (sp1 == 14)
            {
                spriteRendererPot1.sprite = Skin14;
                spriteRendererPot1Shine.sprite = Skin14Shine;
            }
            if (sp1 == 15)
            {
                spriteRendererPot1.sprite = Skin15;
                spriteRendererPot1Shine.sprite = Skin15Shine;
            }
            if (sp1 == 16)
            {
                spriteRendererPot1.sprite = Skin16;
                spriteRendererPot1Shine.sprite = Skin16Shine;
            }
        }


        if (tag == "2")
        {
            potAnim = GameObject.FindGameObjectWithTag(tag).GetComponent<Animator>();
            potAnim.SetTrigger("POP");
            if (sp2 == 1)
            {
                spriteRendererPot2.sprite = Skin1;
                spriteRendererPot1Shine.sprite = Skin1Shine;
            }
            if (sp2 == 2)
            {
                spriteRendererPot2.sprite = Skin2;
                spriteRendererPot1Shine.sprite = Skin2Shine;
            }
            if (sp2 == 3)
            {
                spriteRendererPot2.sprite = Skin3;
                spriteRendererPot1Shine.sprite = Skin3Shine;
            }
            if (sp2 == 4)
            {
                spriteRendererPot2.sprite = Skin4;
                spriteRendererPot1Shine.sprite = Skin4Shine;
            }
            if (sp2 == 5)
            {
                spriteRendererPot2.sprite = Skin5;
                spriteRendererPot2Shine.sprite = Skin5Shine;
            }
            if (sp2 == 6)
            {
                spriteRendererPot2.sprite = Skin6;
                spriteRendererPot2Shine.sprite = Skin6Shine;
            }
            if (sp2 == 7)
            {
                spriteRendererPot2.sprite = Skin7;
                spriteRendererPot2Shine.sprite = Skin7Shine;
            }
            if (sp2 == 8)
            {
                spriteRendererPot2.sprite = Skin8;
                spriteRendererPot2Shine.sprite = Skin8Shine;
            }
            if (sp2 == 9)
            {
                spriteRendererPot2.sprite = Skin9;
                spriteRendererPot2Shine.sprite = Skin9Shine;
            }
            if (sp2 == 10)
            {
                spriteRendererPot2.sprite = Skin10;
                spriteRendererPot2Shine.sprite = Skin10Shine;
            }
            if (sp2 == 11)
            {
                spriteRendererPot2.sprite = Skin11;
                spriteRendererPot2Shine.sprite = Skin11Shine;
            }
            if (sp2 == 12)
            {
                spriteRendererPot2.sprite = Skin12;
                spriteRendererPot2Shine.sprite = Skin12Shine;
            }
            if (sp2 == 13)
            {
                spriteRendererPot2.sprite = Skin13;
                spriteRendererPot2Shine.sprite = Skin13Shine;
            }
            if (sp2 == 14)
            {
                spriteRendererPot2.sprite = Skin14;
                spriteRendererPot2Shine.sprite = Skin14Shine;
            }
            if (sp2 == 15)
            {
                spriteRendererPot2.sprite = Skin15;
                spriteRendererPot2Shine.sprite = Skin15Shine;
            }
            if (sp2 == 16)
            {
                spriteRendererPot2.sprite = Skin16;
                spriteRendererPot2Shine.sprite = Skin16Shine;
            }
        }


        if (tag == "3")
        {
            potAnim = GameObject.FindGameObjectWithTag(tag).GetComponent<Animator>();
            potAnim.SetTrigger("POP");
            if (sp3 == 1)
            {
                spriteRendererPot3.sprite = Skin1;
                spriteRendererPot3Shine.sprite = Skin1Shine;
            }
            if (sp3 == 2)
            {
                spriteRendererPot3.sprite = Skin2;
                spriteRendererPot3Shine.sprite = Skin2Shine;
            }
            if (sp3 == 3)
            {
                spriteRendererPot3.sprite = Skin3;
                spriteRendererPot3Shine.sprite = Skin3Shine;
            }
            if (sp3 == 4)
            {
                spriteRendererPot3.sprite = Skin4;
                spriteRendererPot3Shine.sprite = Skin4Shine;
            }
            if (sp3 == 5)
            {
                spriteRendererPot3.sprite = Skin5;
                spriteRendererPot3Shine.sprite = Skin5Shine;
            }
            if (sp3 == 6)
            {
                spriteRendererPot3.sprite = Skin6;
                spriteRendererPot3Shine.sprite = Skin6Shine;
            }
            if (sp3 == 7)
            {
                spriteRendererPot3.sprite = Skin7;
                spriteRendererPot3Shine.sprite = Skin7Shine;
            }
            if (sp3 == 8)
            {
                spriteRendererPot3.sprite = Skin8;
                spriteRendererPot3Shine.sprite = Skin8Shine;
            }
            if (sp3 == 9)
            {
                spriteRendererPot3.sprite = Skin9;
                spriteRendererPot3Shine.sprite = Skin9Shine;
            }
            if (sp3 == 10)
            {
                spriteRendererPot3.sprite = Skin10;
                spriteRendererPot3Shine.sprite = Skin10Shine;
            }
            if (sp3 == 11)
            {
                spriteRendererPot3.sprite = Skin11;
                spriteRendererPot3Shine.sprite = Skin11Shine;
            }
            if (sp3 == 12)
            {
                spriteRendererPot3.sprite = Skin12;
                spriteRendererPot3Shine.sprite = Skin12Shine;
            }
            if (sp3 == 13)
            {
                spriteRendererPot3.sprite = Skin13;
                spriteRendererPot3Shine.sprite = Skin13Shine;
            }
            if (sp3 == 14)
            {
                spriteRendererPot3.sprite = Skin14;
                spriteRendererPot3Shine.sprite = Skin14Shine;
            }
            if (sp3 == 15)
            {
                spriteRendererPot3.sprite = Skin15;
                spriteRendererPot3Shine.sprite = Skin15Shine;
            }
            if (sp3 == 16)
            {
                spriteRendererPot3.sprite = Skin16;
                spriteRendererPot3Shine.sprite = Skin16Shine;
            }
        }



     }

    public void loadpots()
    {

        //-----------------pot1------------------------
        if (sp1 == 1) spriteRendererPot1.sprite = Skin1;
        if (sp1 == 2) spriteRendererPot1.sprite = Skin2;
        if (sp1 == 3) spriteRendererPot1.sprite = Skin3;
        if (sp1 == 4) spriteRendererPot1.sprite = Skin4;
        if (sp1 == 5) spriteRendererPot1.sprite = Skin5;
        if (sp1 == 6) spriteRendererPot1.sprite = Skin6;
        if (sp1 == 7) spriteRendererPot1.sprite = Skin7;
        if (sp1 == 8) spriteRendererPot1.sprite = Skin8;
        if (sp1 == 9) spriteRendererPot1.sprite = Skin9;
        if (sp1 == 10) spriteRendererPot1.sprite = Skin10;
        if (sp1 == 11) spriteRendererPot1.sprite = Skin11;
        if (sp1 == 12) spriteRendererPot1.sprite = Skin12;
        if (sp1 == 13) spriteRendererPot1.sprite = Skin13;
        if (sp1 == 14) spriteRendererPot1.sprite = Skin14;
        if (sp1 == 15) spriteRendererPot1.sprite = Skin15;
        if (sp1 == 16) spriteRendererPot1.sprite = Skin16;


        //-----------------pot2------------------------
        if (sp2 == 1) spriteRendererPot2.sprite = Skin1;
        if (sp2 == 2) spriteRendererPot2.sprite = Skin2;
        if (sp2 == 3) spriteRendererPot2.sprite = Skin3;
        if (sp2 == 4) spriteRendererPot2.sprite = Skin4;
        if (sp2 == 5) spriteRendererPot2.sprite = Skin5;
        if (sp2 == 6) spriteRendererPot2.sprite = Skin6;
        if (sp2 == 7) spriteRendererPot2.sprite = Skin7;
        if (sp2 == 8) spriteRendererPot1.sprite = Skin8;
        if (sp2 == 9) spriteRendererPot1.sprite = Skin9;
        if (sp2 == 10) spriteRendererPot1.sprite = Skin10;
        if (sp2 == 11) spriteRendererPot1.sprite = Skin11;
        if (sp2 == 12) spriteRendererPot1.sprite = Skin12;
        if (sp2 == 13) spriteRendererPot1.sprite = Skin13;
        if (sp2 == 14) spriteRendererPot1.sprite = Skin14;
        if (sp2 == 15) spriteRendererPot1.sprite = Skin15;
        if (sp2 == 16) spriteRendererPot1.sprite = Skin16;


        //-----------------pot3------------------------
        if (sp3 == 1) spriteRendererPot3.sprite = Skin1;
        if (sp3 == 2) spriteRendererPot3.sprite = Skin2;
        if (sp3 == 3) spriteRendererPot3.sprite = Skin3;
        if (sp3 == 4) spriteRendererPot3.sprite = Skin4;
        if (sp3 == 5) spriteRendererPot3.sprite = Skin5;
        if (sp3 == 6) spriteRendererPot3.sprite = Skin6;
        if (sp3 == 7) spriteRendererPot3.sprite = Skin7;
        if (sp3 == 8) spriteRendererPot1.sprite = Skin8;
        if (sp3 == 9) spriteRendererPot1.sprite = Skin9;
        if (sp3 == 10) spriteRendererPot1.sprite = Skin10;
        if (sp3 == 11) spriteRendererPot1.sprite = Skin11;
        if (sp3 == 12) spriteRendererPot1.sprite = Skin12;
        if (sp3 == 13) spriteRendererPot1.sprite = Skin13;
        if (sp3 == 14) spriteRendererPot1.sprite = Skin14;
        if (sp3 == 15) spriteRendererPot1.sprite = Skin15;
        if (sp3 == 16) spriteRendererPot1.sprite = Skin16;
    }


    public void loadplants()
    {
        //----------------------------Pot 1------------------------------

        if (p1)
        {
            //Ble
            if (pp1 == 1f)
            {
                spriteRendererP1.sprite = pousseBle;

            }
            if (pp1 == 1.1f)
            {
                spriteRendererP1.sprite = evolutionBle1;

            }
            if (pp1 == 1.2f)
            {
                spriteRendererP1.sprite = evolutionBle2;

            }
            if (pp1 == 1.3f)
            {
                spriteRendererP1.sprite = evolutionBle3;

            }

            //Apple
            if (pp1 == 2f)
            {
                spriteRendererP1.sprite = pousseApple;

            }
            if (pp1 == 2.1f)
            {
                spriteRendererP1.sprite = evolutionApple1;

            }
            if (pp1 == 2.2f)
            {
                spriteRendererP1.sprite = evolutionApple2;

            }
            if (pp1 == 2.3f)
            {
                spriteRendererP1.sprite = evolutionApple3;

            }

            //Tomato
            if (pp1 == 3f)
            {
                spriteRendererP1.sprite = pousseTomato;

            }
            if (pp1 == 3.1f)
            {
                spriteRendererP1.sprite = evolutionTomato1;

            }
            if (pp1 == 3.2f)
            {
                spriteRendererP1.sprite = evolutionTomato2;

            }
            if (pp1 == 3.3f)
            {
                spriteRendererP1.sprite = evolutionTomato3;

            }

            //Eggplant
            if (pp1 == 4f)
            {
                spriteRendererP1.sprite = pousseEgg;

            }
            if (pp1 == 4.1f)
            {
                spriteRendererP1.sprite = evolutionEggplant1;

            }
            if (pp1 == 4.2f)
            {
                spriteRendererP1.sprite = evolutionEggplant2;

            }
            if (pp1 == 4.3f)
            {
                spriteRendererP1.sprite = evolutionEggplant3;

            }

            //Pear
            if (pp1 == 5f)
            {
                spriteRendererP1.sprite = poussePear;

            }
            if (pp1 == 5.1f)
            {
                spriteRendererP1.sprite = evolutionPear1;

            }
            if (pp1 == 5.2f)
            {
                spriteRendererP1.sprite = evolutionPear2;

            }
            if (pp1 == 5.3f)
            {
                spriteRendererP1.sprite = evolutionPear3;

            }

            //Sunflower
            if (pp1 == 6f)
            {
                spriteRendererP1.sprite = pousseSun;

            }
            if (pp1 == 6.1f)
            {
                spriteRendererP1.sprite = evolutionSun1;

            }
            if (pp1 == 6.2f)
            {
                spriteRendererP1.sprite = evolutionSun2;

            }
            if (pp1 == 6.3f)
            {
                spriteRendererP1.sprite = evolutionSun3;

            }

            //cherry
            if (pp1 == 7f)
            {
                spriteRendererP1.sprite = pousseCherry;

            }
            if (pp1 == 7.1f)
            {
                spriteRendererP1.sprite = evolutionCherry1;

            }
            if (pp1 == 7.2f)
            {
                spriteRendererP1.sprite = evolutionCherry2;

            }
            if (pp1 == 7.3f)
            {
                spriteRendererP1.sprite = evolutionCherry3;

            }


            //Avo
            if (pp1 == 8f)
            {
                spriteRendererP1.sprite = pousseAvo;

            }
            if (pp1 == 8.1f)
            {
                spriteRendererP1.sprite = evolutionAvo1;

            }
            if (pp1 == 8.2f)
            {
                spriteRendererP1.sprite = evolutionAvo2;

            }
            if (pp1 == 8.3f)
            {
                spriteRendererP1.sprite = evolutionAvo3;

            }

            //Kiwi
            if (pp1 == 9f)
            {
                spriteRendererP1.sprite = pousseKiwi;

            }
            if (pp1 == 9.1f)
            {
                spriteRendererP1.sprite = evolutionKiwi1;

            }
            if (pp1 == 9.2f)
            {
                spriteRendererP1.sprite = evolutionKiwi2;

            }
            if (pp1 == 9.3f)
            {
                spriteRendererP1.sprite = evolutionKiwi3;

            }
        }




        //----------------------------Pot 2------------------------------

        if (p2)
        {
            //Ble
            if (pp2 == 1f)
            {
                spriteRendererP2.sprite = pousseBle;

            }
            if (pp2 == 1.1f)
            {
                spriteRendererP2.sprite = evolutionBle1;

            }
            if (pp2 == 1.2f)
            {
                spriteRendererP2.sprite = evolutionBle2;

            }
            if (pp2 == 1.3f)
            {
                spriteRendererP2.sprite = evolutionBle3;

            }

            //Apple
            if (pp2 == 2f)
            {
                spriteRendererP2.sprite = pousseApple;
               
            }
            if (pp2 == 2.1f)
            {
                spriteRendererP2.sprite = evolutionApple1;
               
            }
            if (pp2 == 2.2f)
            {
                spriteRendererP2.sprite = evolutionApple2;
               
            }
            if (pp2 == 2.3f)
            {
                spriteRendererP2.sprite = evolutionApple3;
               
            }
            
            //Tomato
            if (pp2 == 3f)
            {
                spriteRendererP2.sprite = pousseTomato;
               
            }
            if (pp2 == 3.1f)
            {
                spriteRendererP2.sprite = evolutionTomato1;
               
            }
            if (pp2 == 3.2f)
            {
                spriteRendererP2.sprite = evolutionTomato2;
               
            }
            if (pp2 == 3.3f)
            {
                spriteRendererP2.sprite = evolutionTomato3;
               
            }

            //Eggplant
            if (pp2 == 4f)
            {
                spriteRendererP2.sprite = pousseEgg;
               
            }
            if (pp2 == 4.1f)
            {
                spriteRendererP2.sprite = evolutionEggplant1;
                
            }
            if (pp2 == 4.2f)
            {
                spriteRendererP2.sprite = evolutionEggplant2;
               
            }
            if (pp2 == 4.3f)
            {
                spriteRendererP2.sprite = evolutionEggplant3;
               
            }

            //Pear
            if (pp2 == 5f)
            {
                spriteRendererP2.sprite = poussePear;

            }
            if (pp2 == 5.1f)
            {
                spriteRendererP2.sprite = evolutionPear1;

            }
            if (pp2 == 5.2f)
            {
                spriteRendererP2.sprite = evolutionPear2;

            }
            if (pp2 == 5.3f)
            {
                spriteRendererP2.sprite = evolutionPear3;

            }

            //Sunflower
            if (pp2 == 6f)
            {
                spriteRendererP2.sprite = pousseSun;

            }
            if (pp2 == 6.1f)
            {
                spriteRendererP2.sprite = evolutionSun1;

            }
            if (pp2 == 6.2f)
            {
                spriteRendererP2.sprite = evolutionSun2;

            }
            if (pp2 == 6.3f)
            {
                spriteRendererP2.sprite = evolutionSun3;

            }

            //cherry
            if (pp2 == 7f)
            {
                spriteRendererP2.sprite = pousseCherry;

            }
            if (pp2 == 7.1f)
            {
                spriteRendererP2.sprite = evolutionCherry1;

            }
            if (pp2 == 7.2f)
            {
                spriteRendererP2.sprite = evolutionCherry2;

            }
            if (pp2 == 7.3f)
            {
                spriteRendererP2.sprite = evolutionCherry3;

            }


            //Avo
            if (pp2 == 8f)
            {
                spriteRendererP2.sprite = pousseAvo;

            }
            if (pp2 == 8.1f)
            {
                spriteRendererP2.sprite = evolutionAvo1;

            }
            if (pp2 == 8.2f)
            {
                spriteRendererP2.sprite = evolutionAvo2;

            }
            if (pp2 == 8.3f)
            {
                spriteRendererP2.sprite = evolutionAvo3;

            }

            //Kiwi
            if (pp2 == 9f)
            {
                spriteRendererP2.sprite = pousseKiwi;

            }
            if (pp2 == 9.1f)
            {
                spriteRendererP2.sprite = evolutionKiwi1;

            }
            if (pp2 == 9.2f)
            {
                spriteRendererP2.sprite = evolutionKiwi2;

            }
            if (pp2 == 9.3f)
            {
                spriteRendererP2.sprite = evolutionKiwi3;

            }
        }

        //----------------------------Pot 3------------------------------

        if (p3)
        {
            //Ble
            if (pp3 == 1f)
            {
                spriteRendererP3.sprite = pousseBle;

            }
            if (pp3 == 1.1f)
            {
                spriteRendererP3.sprite = evolutionBle1;

            }
            if (pp3 == 1.2f)
            {
                spriteRendererP3.sprite = evolutionBle2;

            }
            if (pp3 == 1.3f)
            {
                spriteRendererP3.sprite = evolutionBle3;

            }

            //Apple
            if (pp3 == 2f)
            {
                spriteRendererP3.sprite = pousseApple;

            }
            if (pp3 == 2.1f)
            {
                spriteRendererP3.sprite = evolutionApple1;

            }
            if (pp3 == 2.2f)
            {
                spriteRendererP3.sprite = evolutionApple2;

            }
            if (pp3 == 2.3f)
            {
                spriteRendererP3.sprite = evolutionApple3;

            }

            //Tomato
            if (pp3 == 3f)
            {
                spriteRendererP3.sprite = pousseTomato;

            }
            if (pp3 == 3.1f)
            {
                spriteRendererP3.sprite = evolutionTomato1;

            }
            if (pp3 == 3.2f)
            {
                spriteRendererP3.sprite = evolutionTomato2;

            }
            if (pp3 == 3.3f)
            {
                spriteRendererP3.sprite = evolutionTomato3;

            }

            //Eggplant
            if (pp3 == 4f)
            {
                spriteRendererP3.sprite = pousseEgg;

            }
            if (pp3 == 4.1f)
            {
                spriteRendererP3.sprite = evolutionEggplant1;

            }
            if (pp3 == 4.2f)
            {
                spriteRendererP3.sprite = evolutionEggplant2;

            }
            if (pp3 == 4.3f)
            {
                spriteRendererP3.sprite = evolutionEggplant3;

            }

            //Pear
            if (pp3 == 5f)
            {
                spriteRendererP3.sprite = poussePear;

            }
            if (pp3 == 5.1f)
            {
                spriteRendererP3.sprite = evolutionPear1;

            }
            if (pp3 == 5.2f)
            {
                spriteRendererP3.sprite = evolutionPear2;

            }
            if (pp3 == 5.3f)
            {
                spriteRendererP3.sprite = evolutionPear3;

            }

            //Sunflower
            if (pp3 == 6f)
            {
                spriteRendererP3.sprite = pousseSun;

            }
            if (pp3 == 6.1f)
            {
                spriteRendererP3.sprite = evolutionSun1;

            }
            if (pp3 == 6.2f)
            {
                spriteRendererP3.sprite = evolutionSun2;

            }
            if (pp3 == 6.3f)
            {
                spriteRendererP3.sprite = evolutionSun3;

            }

            //cherry
            if (pp3 == 7f)
            {
                spriteRendererP3.sprite = pousseCherry;

            }
            if (pp3 == 7.1f)
            {
                spriteRendererP3.sprite = evolutionCherry1;

            }
            if (pp3 == 7.2f)
            {
                spriteRendererP3.sprite = evolutionCherry2;

            }
            if (pp3 == 7.3f)
            {
                spriteRendererP3.sprite = evolutionCherry3;

            }


            //Avo
            if (pp3 == 8f)
            {
                spriteRendererP3.sprite = pousseAvo;

            }
            if (pp3 == 8.1f)
            {
                spriteRendererP3.sprite = evolutionAvo1;

            }
            if (pp3 == 8.2f)
            {
                spriteRendererP3.sprite = evolutionAvo2;

            }
            if (pp3 == 8.3f)
            {
                spriteRendererP3.sprite = evolutionAvo3;

            }

            //Kiwi
            if (pp3 == 9f)
            {
                spriteRendererP3.sprite = pousseKiwi;

            }
            if (pp3 == 9.1f)
            {
                spriteRendererP3.sprite = evolutionKiwi1;

            }
            if (pp3 == 9.2f)
            {
                spriteRendererP3.sprite = evolutionKiwi2;

            }
            if (pp3 == 9.3f)
            {
                spriteRendererP3.sprite = evolutionKiwi3;

            }


        }

    }
}
