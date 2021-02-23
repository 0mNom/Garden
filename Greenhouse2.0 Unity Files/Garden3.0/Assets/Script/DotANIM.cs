using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;




public class DotANIM : MonoBehaviour
{
    public RectTransform menu, gamePannel, menuCanvus, logo, blackpannel, seedBag, seeds,marketButton, market, Pmarket, PmarketButton, nowP, error;
    public GameObject conti,popUp ;

    public RectTransform WheatScreen, AppleScreen, TomatoScreen, EggplantScreen, PearScreen, SunflowerScreen, CherryScreen, AvoScreen, KiwiScreen;
    public RectTransform p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16;

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
        seedBag.DOAnchorPos(new Vector2(-120,-250), 0.25f);
        seeds.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void seedbagUP()
    {
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
        market.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    
    public void marketClose()
    {
        StartCoroutine("closeMarket");
    }

    IEnumerator closeMarket()
    {
        marketButton.DOAnchorPos(new Vector2(-120, -120), 0.25f);
        market.DOAnchorPos(new Vector2(00, 3000), 0.25f);
        yield return new WaitForSeconds(0.25f);
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
        logo.DOShakeAnchorPos(5f, 50f, 5, 60, false, true);
        yield return new WaitForSeconds(5f);
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

   
}
