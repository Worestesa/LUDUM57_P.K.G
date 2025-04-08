using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class InvetkaKosmos : MonoBehaviour
{
    private float HP = 100f;
    public float damageAmount;
    private float timer = 0f;
    public float intervalDamage = 1f;
    public Image Bar;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Plaen")
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
    }
    private void Update()
    {
        Color colorInvetka = Bar.color;
        colorInvetka.a = 1 - HP / 100;
        Bar.color = colorInvetka;
    }
}
