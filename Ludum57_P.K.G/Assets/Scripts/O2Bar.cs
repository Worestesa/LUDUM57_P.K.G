using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class O2Bar : MonoBehaviour
{
    private float HP = 100f;
    public Image Bar;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            HP -= 5;
            Bar.fillAmount = HP / 100;
        }
    }
}
