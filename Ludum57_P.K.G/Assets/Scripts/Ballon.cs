using UnityEngine;

public class Ballon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        { 
            Destroy(gameObject);
        }
    }
}
