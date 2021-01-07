using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPlaces : MonoBehaviour
{
    // Start is called before the first frame update
    public bool p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 = true ;  //POSSIBLE POT PLACES AND IF THEY HAVE BEEN ACTIVED:BOUGHT
    public int sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10; //skins on the active pots 
    public float pp1, pp2, pp3, pp4, pp5, pp6, pp7, pp8, pp9, pp10; //pot planted in x pot
    public Sprite pousse, evolutionEggplant1, evolutionEggplant2;
    public SpriteRenderer spriteRenderer1;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadplants()
    {
        if (p1)
        {
            if (pp1 == 4f)
            {
                spriteRenderer1.sprite = pousse;
                Debug.Log("baby");
            }
            if (pp1 == 4.1f)
            {
                spriteRenderer1.sprite = evolutionEggplant1;
                Debug.Log("Egg1");
            }
            if (pp1 == 4.2f)
            {
                spriteRenderer1.sprite = evolutionEggplant2;
                Debug.Log("Egg2");
            }
        }
       

    }
}
