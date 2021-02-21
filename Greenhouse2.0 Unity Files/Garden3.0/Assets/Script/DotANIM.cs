using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;




public class DotANIM : MonoBehaviour
{
    public RectTransform menu, gamePannel, menuCanvus;
    void Start()
    {
        menu.DOAnchorPos(Vector2.zero,0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void punch()
    {
        this.transform.DOPunchScale(new Vector3 ( 1,1,1), 1f,2,1);
    }

    public void buttonshake()
    {
       // this.DOShakeAnchorPos(1f, 1f, 2, 0.8f, false, false);
    }

    public void offmenu()
    {
        menuCanvus.DOAnchorPos(new Vector2(-1200, 0), 0.25f);
        gamePannel.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
}
