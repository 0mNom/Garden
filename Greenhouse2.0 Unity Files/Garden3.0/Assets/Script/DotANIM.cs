﻿using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;




public class DotANIM : MonoBehaviour
{
    public RectTransform menu, gamePannel, menuCanvus, logo, blackpannel;
    public GameObject conti ;

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

    public void punch()
    {
        this.transform.DOPunchScale(new Vector3(1, 1, 1), 1f, 2, 1);
    }

    public void buttonshake()
    {
        // this.DOShakeAnchorPos(1f, 1f, 2, 0.8f, false, false);
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
        menuCanvus.DOAnchorPos(new Vector2(-1200, 0), 0.25f);
        conti.SetActive(true);
        gamePannel.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void exit()
    {
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
        menuCanvus.DOAnchorPos(Vector2.zero, 0.25f);
       // ahh.SetActive(true);
    }

   
}
