using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SporEnemy : MonoBehaviour
{
    private float HP = 100f;
    public float damageAmount;
    public float damageHeal;
    private float timer = 0f;
    public float intervalDamage = 1f;
    public float intervalHeal = 2f;

    public Image Bar;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Spor")
        {
            timer += Time.deltaTime;
            if (timer >= intervalDamage)
            {
                HP -= damageAmount;
                timer = 0f;
                Bar.fillAmount = HP / 100;
                if (HP < 0)
                {
                    HP = 0;
                }
            }

        }
        if (collision.transform.tag == "Plaen")
        {
            timer += Time.deltaTime;
            if (timer >= intervalHeal && HP < 100)
            {
                HP += damageHeal;
                timer = 0f;
                Bar.fillAmount = HP / 100;
                if( HP > 100)
                {
                    HP = 100;
                }
            }
        }
    }
    private void Update()
    {
        Color colorInvetka = Bar.color;
        colorInvetka.a = 1 - HP / 100;
        Bar.color = colorInvetka;
    }
}
