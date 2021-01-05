using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonPopUp : MonoBehaviour
{
    
    Collider2D col;
    public string Name;
    public TextMeshProUGUI nameText;
    public Animator animator;

    void Start()
    {
        col = GetComponent<Collider2D>();
        nameText.text = Name;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    //FAIRE CE QUE TU VEUX AVEC LE CLICK ICI
                    OpenPanel();

                }
            }
        }
    }

    public void OpenPanel()
    {
        animator.SetBool("IsOpen", true);
    }

    public void ClosePanel()
    {
        animator.SetBool("IsOpen", false);
    }
}
