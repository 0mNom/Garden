using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;




public class DotANIM : MonoBehaviour
{

    public tutoSound sound;

    public RectTransform paymentpannel, gemshop, gemshopB;

    public GameObject tutorial;
    public RectTransform welcome, T1, T2, wheatarrow, T3,T31, T4, T5, T6,nameArrow,gemarrow, waterArrow,potArrow,sellArrow,GemArrow, marketarrow;
    public Text txt1, btxt1, txt2, btxt2, txt3, btxt3, txt4, btxt4, txt5, btxt5, txt6, btxt6, txt7, btxt7, txt8, btxt8;

    public ButtonPopUp pot1;

    public RectTransform gem1, gem2, gem3, wow, menu, gamePannel, menuCanvus, logo, blackpannel, seedBag, seeds,marketButton, market, Pmarket, PmarketButton, nowP, error, inv, invbutton;
    public GameObject conti,popUp ;

    

    public RectTransform WheatScreen, AppleScreen, TomatoScreen, EggplantScreen, PearScreen, SunflowerScreen, CherryScreen, AvoScreen, KiwiScreen;
    public RectTransform p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16;


    public void payin()
    {
        paymentpannel.DOAnchorPos(new Vector2(-12, 0), 0.25f);
    }
    public void payout()
    {
        paymentpannel.DOAnchorPos(new Vector2(-3000, 0), 0.25f);
    }

    public void gemshopin()
    {
        gemshopB.DOAnchorPos(new Vector2(-120, 120), 0.25f);
        gemshop.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void gemshopout()
    {
        gemshopB.DOAnchorPos(new Vector2(120, 120), 0.25f);
        gemshop.DOAnchorPos(new Vector2(-3000, 0), 0.25f);
        paymentpannel.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    public void destroytuto()
    {
        Destroy(tutorial);
    }

    public void tuto1()
    {
        StartCoroutine("tut1");

    }

    IEnumerator tut1()
    {
        if (tutorial == null) yield break;
        sound.tutPlay();

        welcome.DOAnchorPos(new Vector2(0, 593), 0.25f);
        txt1.DOText("Welcome to your greenhouse. " , 3f, false, ScrambleMode.None, null);
        btxt1.DOText("Welcome to your greenhouse. ", 3f, false, ScrambleMode.None, null);
        yield return new WaitForSeconds(3f);
        sound.tutPause();
        if (tutorial == null) yield break;
        txt1.DOText("Welcome to your greenhouse. " +
            "Here you can watch your plants grow and look after them ", 10f, false, ScrambleMode.None, null);
        btxt1.DOText("Welcome to your greenhouse. " +
            "Here you can watch your plants grow and look after them ", 10f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(2f);
        sound.tutPlay();
        yield return new WaitForSeconds(8f);
        sound.tutPause();
        yield return new WaitForSeconds(1f);
        if (tutorial == null) yield break;
        welcome.DOAnchorPos(new Vector2(1500, 593), 0.25f);
        if (tutorial == null) yield break;
        T1.DOAnchorPos(new Vector2(-265 , -285), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt2.DOText("Here you can buy seeds to plant in your pots.", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt2.DOText("Here you can buy seeds to plant in your pots.", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(5f);
        sound.tutPause();
        yield return new WaitForSeconds(1f);
        if (tutorial == null) yield break;
        //T1.DOAnchorPos(new Vector2(1400, 685), 0.25f);
        T2.DOAnchorPos(new Vector2(-363, 289), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt3.DOText("This is where your seeds are stored for easy acess and for planting, try opening it", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt3.DOText("This is where your seeds are stored for easy acess and for planting, try opening it", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(5f);
        sound.tutPause();
        yield return new WaitForSeconds(1f);
        if (tutorial == null) yield break;
        //T1.DOAnchorPos(new Vector2(1400, 685), 0.25f);

    }

    public void tuto2()
    {
        StartCoroutine("tut2");
    }

    IEnumerator tut2()
    {
        StopCoroutine("tut1");
        if (tutorial == null) yield break;
        seedbagOpen();
        if (tutorial == null) yield break;
        T1.DOAnchorPos(new Vector2(1400, 685), 0.25f);
        T2.DOAnchorPos(new Vector2(-3063, 289), 0.25f);
        if (tutorial == null) yield break;
        T3.DOAnchorPos(new Vector2(-140, 97.6f), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt4.DOText("to plant simply select a seed in your bag and then on a glowing pot.", 5f, false, ScrambleMode.None, null);
        btxt4.DOText("to plant simply select a seed in your bag and then on a glowing pot.", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(5f);
        sound.tutPause();
        if (tutorial == null) yield break;
        
        txt4.DOText("to plant simply select a seed in your bag and then on a glowing pot. Try now with this apple seed.", 5f, false, ScrambleMode.None, null);
        btxt4.DOText("to plant simply select a seed in your bag and then on a glowing pot. Try now with this apple seed.", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(1f);
        
        if (tutorial == null) yield break;
        wheatarrow.DOAnchorPos(new Vector2(101.82f, 382.5f), 0.25f);
        yield return new WaitForSeconds(1f);
        sound.tutPlay();
        yield return new WaitForSeconds(3f);

        sound.tutPause();
        if (tutorial == null) yield break;

    }

    public void tut31()
    {
        StartCoroutine("tuto31");
        }

    IEnumerator tuto31()
    {
        StopCoroutine("tut2");
        wheatarrow.DOAnchorPos(new Vector2(101.82f, 382.5f), 0.25f);
        T31.DOAnchorPos(new Vector2(-140, 97.6f), 0.25f);
        sound.tutPlay();
        txt8.DOText("now that you have a seed in your hand you can click on a glowing pot to plant it.", 5f, false, ScrambleMode.None, null);
        btxt8.DOText("now that you have a seed in your hand you can click on a glowing pot to plant it.", 5f, false, ScrambleMode.None, null);
        yield return new WaitForSeconds(5f);
        sound.tutPause();
    }
    public void tutoEnd1()
    {
       
        
        T31.DOAnchorPos(new Vector2(-1400, -497.6f), 0.25f);

    }

    public void tutoEnd()
    {
        wheatarrow.gameObject.transform.DOScale(0, 0.25f);
        wheatarrow.DOAnchorPos(new Vector2(901.82f, 382.5f), 0.25f);
        T3.DOAnchorPos(new Vector2(-1400, -497.6f), 0.25f);
       
    }
    public void tuto3()
    {
        StartCoroutine("tut3");

    }
    IEnumerator tut3()
    {
        StopCoroutine("tuto31");

        Debug.Log("stttoooppppp tuto31");

        if (tutorial == null) yield break;
        T4.DOAnchorPos(new Vector2(29.7f, 193), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt5.DOText("Nice, now that you've planted your first plant you can tap it to see him close up!", 5f, false, ScrambleMode.None, null);
        btxt5.DOText("Nice, now that you've planted your first plant you can tap it to see him close up!", 5f, false, ScrambleMode.None, null);
        Debug.Log("i restaredddd");
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(5f);
        sound.tutPause();



    }
    public void tuto4()
    {
        StartCoroutine("tut4");

    }
    IEnumerator tut4()
    {
        if (tutorial == null) yield break;
        StopCoroutine("tut3");
        T4.DOAnchorPos(new Vector2(1400, 593), 0.25f);
        if (tutorial == null) yield break;
      
        if (tutorial == null) yield break;
        T5.DOAnchorPos(new Vector2(0, -770), 0.25f);
        sound.tutPlay();
        txt6.DOText("Here you can find a whole bunch of information like how long you plant will take to grow.", 5f, false, ScrambleMode.None, null);
        btxt6.DOText("Here you can find a whole bunch of information like how long you plant will take to grow.", 5f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(5f);
        sound.tutPause();
    }
    public void tuto41()
    {
        StartCoroutine("tut41");

    }
    IEnumerator tut41()
    {
        if (tutorial == null) yield break;
        StopCoroutine("tut4");
        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
      
        if (tutorial == null) yield break;
        
        if (tutorial == null) yield break;
        gemarrow.DOAnchorPos(new Vector2(-98, 720), 0.25f);
        sound.tutPlay();
        txt6.DOText("you can speed up the growing process by using your amber.", 4f, false, ScrambleMode.None, null);
        btxt6.DOText("you can speed up the growing process by using your amber.", 4f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(4f);
        sound.tutPause();
    }

        public void tuto5()
    {
        StartCoroutine("tut5");

    }
    IEnumerator tut5()
    {
        gemarrow.gameObject.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        gemarrow.gameObject.SetActive(false);
        StopCoroutine("tut41");
        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        waterArrow.DOAnchorPos(new Vector2(-58, 870), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt6.DOText("Twice per plant growth you will have the chance to water your plant...", 6f, false, ScrambleMode.None, null);
        btxt6.DOText("Twice per plant growth you will have the chance to water your plant...", 6f, false, ScrambleMode.None, null);
        yield return new WaitForSeconds(6f);
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        
        txt6.DOText("this will make its selling price higher so come and check on them often.", 5f, false, ScrambleMode.None, null);
        btxt6.DOText("this will make its selling price higher so come and check on them often.", 5f, false, ScrambleMode.None, null);
        yield return new WaitForSeconds(5f);
        sound.tutPause();
        if (tutorial == null) yield break;
    }
    public void tuto6()
    {
        StartCoroutine("tut6");

    }
    IEnumerator tut6()
    {
        StopCoroutine("tut5");
        waterArrow.gameObject.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        waterArrow.gameObject.SetActive(false);

        if (tutorial == null) yield break;
       
        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        potArrow.DOAnchorPos(new Vector2(-498, 1050), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt6.DOText("this button is the store room of pots that you buy up here...", 5f, false, ScrambleMode.None, null);
        btxt6.DOText("this button is the store room of pots that you buy up here...", 5f, false, ScrambleMode.None, null);

        if (tutorial == null) yield break;
        yield return new WaitForSeconds(2f);
        if (tutorial == null) yield break;
        marketarrow.DOAnchorPos(new Vector2(-287.8f, -381.6f), 0.25f);
        yield return new WaitForSeconds(6f);
        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
       
        txt6.DOText("to change a pot, open the store room and selet the pot you want to use.", 5f, false, ScrambleMode.None, null);
        btxt6.DOText("to change a pot, open the store room and selet the pot you want to use.", 5f, false, ScrambleMode.None, null);
        yield return new WaitForSeconds(5f);
        sound.tutPause();
    }
    public void tuto7()
    {
        StartCoroutine("tut7");

    }
    IEnumerator tut7()
    {
        StopCoroutine("tut6");
      

        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt6.DOText("Attention, once a pot has been placed you cannot put it back in the store room.", 4f, false, ScrambleMode.None, null);
        btxt6.DOText("Attention, once a pot has been placed you cannot put it back in the store room.", 4f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(4f);
        sound.tutPause();
    }
    public void tuto8()
    {
        StartCoroutine("tut8");

    }
    IEnumerator tut8()
    {
        StopCoroutine("tut7");
        marketarrow.gameObject.transform.DOScale(0, 0.5f);
        potArrow.gameObject.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        marketarrow.gameObject.SetActive(false);
        potArrow.gameObject.SetActive(false);

        if (tutorial == null) yield break;
       
        
        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        sellArrow.DOAnchorPos(new Vector2(254, 425), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt6.DOText("When the plant has finished growing you can sell it to gain leaves to spend buying more seeds...", 4f, false, ScrambleMode.None, null);
        btxt6.DOText("When the plant has finished growing you can sell it to gain leaves to spend buying more seeds...", 4f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(4f);
        sound.tutPause();
    }
    public void tuto9()
    {
        StartCoroutine("tut9");

    }
    IEnumerator tut9()
    {
        StopCoroutine("tut8");
        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt6.DOText("or you can leave it in the pot to make your greenhouse look good", 3f, false, ScrambleMode.None, null);
        btxt6.DOText("or you can leave it in the pot to make your greenhouse look good", 3f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(3f);
        sound.tutPause();
    }
    public void tuto10()
    {
        StartCoroutine("tut10");

    }
    IEnumerator tut10()
    {
        StopCoroutine("tut9");
        if (tutorial == null) yield break;
        sellArrow.gameObject.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        sellArrow.gameObject.SetActive(false);

        if (tutorial == null) yield break;
        txt6.DOText("", 1f, false, ScrambleMode.None, null);
        btxt6.DOText("", 1f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        nameArrow.DOAnchorPos(new Vector2(-12, 1090), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt6.DOText("and finally you can change the name of your plant by tapping on the name up top.", 3f, false, ScrambleMode.None, null);
        btxt6.DOText("and finally you can change the name of your plant by tapping on the name up top.", 3f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(3f);
        sound.tutPause();
    }
    public void tuto11()
    {
        StartCoroutine("tut11");

    }
    IEnumerator tut11()
    {
        StopCoroutine("tut10");
        if (tutorial == null) yield break;
        if (tutorial == null) yield break;
        nameArrow.gameObject.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(0.5f);
        nameArrow.gameObject.SetActive(false);

        if (tutorial == null) yield break;
        pot1.ClosePanel();
        if (tutorial == null) yield break;
        T5.DOAnchorPos(new Vector2(0, -2500), 0.25f);
        if (tutorial == null) yield break;
        T6.DOAnchorPos(new Vector2(0, 620), 0.25f);
        if (tutorial == null) yield break;
        sound.tutPlay();
        txt7.DOText("now you can do it all! have fun using those green thumbs of yours", 3f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        btxt7.DOText("now you can do it all! have fun using those green thumbs of yours", 3f, false, ScrambleMode.None, null);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(3f);
        sound.tutPause();
        if (tutorial == null) yield break;
        if (tutorial == null) yield break;
        T6.DOAnchorPos(new Vector2(0, 1500), 0.25f);
        if (tutorial == null) yield break;
        yield return new WaitForSeconds(0.5f);
        Destroy(tutorial);


    }


    void Start()
    {
        // menu.DOAnchorPos(Vector2.zero,0.25f);

        // logo.DOAnchorPos(Vector2.zero,0.25f);
        // logo.DOShakeAnchorPos(5f, 50f, 5, 60, false, true);
        StartCoroutine("logoshaker");
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                menuback();
                Debug.Log("back");
                return;
            }
        }*/
    }


    /// <summary>
    /// start of pot market pannel pop up anims
    /// </summary>
    public void p1in()
    {
        p1.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p1out()
    {
        p1.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p2in()
    {
        p2.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p2out()
    {
        p2.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
     public void p3in()
    {
        p3.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p3out()
    {
        p3.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p4in()
    {
        p4.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p4out()
    {
        p4.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }

    public void p5in()
    {
        p5.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p5out()
    {
        p5.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p6in()
    {
        p6.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p6out()
    {
        p6.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
     public void p7in()
    {
        p7.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p7out()
    {
        p7.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p8in()
    {
        p8.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p8out()
    {
        p8.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }

    public void p9in()
    {
        p9.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p9out()
    {
        p9.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p10in()
    {
        p10.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p10out()
    {
        p10.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
     public void p11in()
    {
        p11.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p11out()
    {
        p11.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p12in()
    {
        p12.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p12out()
    {
        p12.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }

    public void p13in()
    {
        p13.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p13out()
    {
        p13.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p14in()
    {
        p14.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p14out()
    {
        p14.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }

    public void p15in()
    {
        p15.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p15out()
    {
        p15.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }
    public void p16in()
    {
        p16.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void p16out()
    {
        p16.DOAnchorPos(new Vector2(0, -2000), 0.4f);
    }

    /// <summary>
    /// start of plant pannel pop up anims
    /// </summary>
    public void wheatin()
    {
        WheatScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void wheatout()
    {
        WheatScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    public void applein()
    {
        AppleScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void appleout()
    {
        AppleScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    
    public void tomin()
    {
        TomatoScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void tomout()
    {
        TomatoScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    public void eggin()
    {
        EggplantScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void eggout()
    {
        EggplantScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }


    
    public void pearin()
    {
        PearScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void pearout()
    {
        PearScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    public void sunin()
    {
        SunflowerScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void sunout()
    {
        SunflowerScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    
    public void cherrtin()
    {
        CherryScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void cherryout()
    {
        CherryScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }

    public void avoin()
    {
        AvoScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void avoout()
    {
        AvoScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }
    public void kiwiin()
    {
        KiwiScreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void kiwiout()
    {
       KiwiScreen.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }



    /// <summary>
    /// start of other anims
    /// </summary>




    public void errorOn()
    {
        error.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void errorOff()
    {
        error.DOAnchorPos(new Vector2(2000, 0), 0.25f);
    }

    public void seedbagOpen()
    {
        seeds.gameObject.SetActive(true);
        seedBag.DOAnchorPos(new Vector2(-120,-250), 0.25f);
        seedBag.gameObject.SetActive(false);
        seeds.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void seedbagUP()
    {
        seedBag.gameObject.SetActive(true);
        seedBag.DOAnchorPos(new Vector2(-120, 120), 0.25f);
    }
    
    public void seedbagClose()
    {
        

        StartCoroutine("closebag");

    }

    IEnumerator closebag()
    {
        seeds.DOAnchorPos(new Vector2(320, 0), 0.25f);
       
        yield return new WaitForSeconds(0.25f);
        popUp.SetActive(true);
        seeds.gameObject.SetActive(false);
    }

    public void marketOpen()
    {
        marketButton.DOAnchorPos(new Vector2(-120, 120), 0.25f);
        marketButton.gameObject.SetActive(false);
        market.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    
    public void marketClose()
    {
        StartCoroutine("closeMarket");
    }

    IEnumerator closeMarket()
    {
      
        marketButton.DOAnchorPos(new Vector2(-120, -120), 0.25f);
        market.DOAnchorPos(new Vector2(00, 4000), 0.25f);
        yield return new WaitForSeconds(0.25f);
        marketButton.gameObject.SetActive(true);
        market.gameObject.SetActive(false);

    }

    public void pmarketOpen()
    {
        PmarketButton.DOAnchorPos(new Vector2(-120, 120), 0.25f);
        Pmarket.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pmarketClose()
    {
        StartCoroutine("pcloseMarket");
    }

    IEnumerator pcloseMarket()
    {
        PmarketButton.DOAnchorPos(new Vector2(-120, -280), 0.25f);
        Pmarket.DOAnchorPos(new Vector2(2500,0 ), 0.25f);
        yield return new WaitForSeconds(0.25f);
        Pmarket.gameObject.SetActive(false);

    }

    public void planting()
    {
        nowP.DOAnchorPos(new Vector2(0,-350), 0.5f);
    }
    public void NOplanting()
    {
        nowP.DOAnchorPos(new Vector2(0, 350), 0.5f);
    }

    public void startermenu()
    {
        blackpannel.DOAnchorPos(new Vector2(0, -3500), 0.25f);
        menu.DOAnchorPos(Vector2.zero, 0.25f);

    }

    public void menustartpos()
    {
        menuCanvus.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void offmenu()
    {
        popUp.SetActive(true);
        menuCanvus.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        conti.SetActive(true);

        gamePannel.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void exit()
    {
        menuCanvus.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        blackpannel.DOAnchorPos(new Vector2(0, 0), 0.5f);
        StartCoroutine("bye");


    }

    IEnumerator bye()
    {
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }

    IEnumerator logoshaker()
    {
        logo.DOAnchorPos(Vector2.zero, 0.5f);
        yield return new WaitForSeconds(0.5f);
       // logo.DOShakeAnchorPos(5f, 50f, 5, 60, false, true);
        yield return new WaitForSeconds(1.6f);
        menustartpos();
        yield return new WaitForSeconds(0.25f);
        startermenu();
    }

    public void menuback()
    {
        gamePannel.DOAnchorPos(new Vector2(3000, 0), 0.25f);
        popUp.SetActive(false);
        menuCanvus.DOAnchorPos(Vector2.zero, 0.25f);
       // ahh.SetActive(true);
    }


    public void wowBig()
    {


        StartCoroutine("woow");
    }
    IEnumerator woow()
    {
        wow.DOAnchorPos(new Vector2(0, 620), 1f);
        yield return new WaitForSeconds(2f);
        wow.DOAnchorPos(new Vector2(0, 1860), 1f);
    }

    public void invin()
    {
        inv.DOAnchorPos(new Vector2(0, 160), 1f);
    }

    public void invout()
    {
        inv.DOAnchorPos(new Vector2(-2000, 160), 1f);
    }

    public void invBin()
    {
        invbutton.gameObject.SetActive(true);
        invbutton.DOAnchorPos(new Vector2(190, -440), 1f);
    }

    public void invBout()
    {
        invbutton.gameObject.SetActive(false);
        invbutton.DOAnchorPos(new Vector2(-1000, -440), 1f);
    }
    public void gem1in()
    {
        gem1.DOAnchorPos(new Vector2(176, 45), 1f);
    }

    public void gem1out()
    {
        gem1.DOAnchorPos(new Vector2(1000, 45), 1f);
    }

    public void gem2in()
    {
        gem2.DOAnchorPos(new Vector2(176, 45), 1f);
    }

    public void gem2out()
    {
        gem2.DOAnchorPos(new Vector2(1000, 45), 1f);
    }

    public void gem3in()
    {
        gem3.DOAnchorPos(new Vector2(176, 45), 1f);
    }

    public void gem3out()
    {
        gem3.DOAnchorPos(new Vector2(1000, 45), 1f);
    }



}
