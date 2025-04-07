using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class O2Bar : MonoBehaviour
{
    private float HP = 100f;
    public float damageAmount = 10f;
    public float damageHeal = 10f;
    private float timer = 0f;
    public float interval = 1f;
    public Image Bar;

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval) 
        {
            HP -= damageAmount;
            timer = 0f;
            Bar.fillAmount = HP / 100;
        }
        if(HP <= 0f )
        {
            Debug.Log("Вы проиграли!");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ballon")
        {
            HP += damageHeal;
            Bar.fillAmount = HP / 100;

        }
    }


}
