using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class O2Bar : MonoBehaviour
{
    private float HP = 100f;
    public Image Bar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (transform.position.y > collision.transform.position.y)
            {
                HP -= 5;
                Bar.fillAmount = HP / 100;
            }
        }
    }
}
