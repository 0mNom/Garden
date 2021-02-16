using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_gain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimation()
    {
        WaitForAnim();
        GetComponent<Animator>().SetBool("isClicked", true);
    }
    public void StopAnimation()
    {
        WaitForAnim();
        GetComponent<Animator>().SetBool("isClicked", false);
    }
    IEnumerator WaitForAnim()
    {
        //Debug.Log("set to false");
        yield return new WaitForSeconds(1);
    }
}
