using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;



public class DotANIM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void punch()
    {
        this.transform.DOPunchScale(new Vector3 ( 1,1,1), 1f,2,1);
    }
}
