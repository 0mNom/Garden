using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPlaces : MonoBehaviour
{
    // Start is called before the first frame update
    public bool p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 = true ;  //POSSIBLE POT PLACES AND IF THEY HAVE BEEN ACTIVED:BOUGHT
    public int sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10; //skins on the active pots 
    public float pp1, pp2, pp3, pp4, pp5, pp6, pp7, pp8, pp9, pp10; //pot planted in x pot
    public Sprite pousseBle, evolutionBle1, evolutionBle2;
    public Sprite pousseApple, evolutionApple1, evolutionApple2;
    public Sprite pousseTomato, evolutionTomato1, evolutionTomato2;
    public Sprite pousseEgg, evolutionEggplant1, evolutionEggplant2;
    public Sprite poussePear, evolutionPear1, evolutionPear2;
    public Sprite pousseSun, evolutionSun1, evolutionSun2;
    public Sprite pousseCherry, evolutionCherry1, evolutionCherry2;
    public Sprite pousseAvo, evolutionAvo1, evolutionAvo2;
    public Sprite pousseKiwi, evolutionKiwi1, evolutionKiwi2;
    public SpriteRenderer spriteRendererP1,spriteRendererP2, spriteRendererP3;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadplants()
    {
        //----------------------------Pot 1------------------------------

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
        }
    }
}
