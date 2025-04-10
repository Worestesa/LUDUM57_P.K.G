using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class O2Bar : MonoBehaviour
{
    private float HP = 100f;
    public float damageAmount;
    public float damageHeal;
    private float timer = 0f;
    public float interval = 1f;
    public int sceneNumber;
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
            SceneManager.LoadScene(sceneNumber);
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
