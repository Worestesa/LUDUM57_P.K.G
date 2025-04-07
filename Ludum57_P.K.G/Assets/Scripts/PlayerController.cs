using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speeddown; // скорость движения вниз
    public float Speed;

    void Update()
    {
        Vector3 movement = new Vector3(0f, -speeddown * Time.deltaTime, 0f);
        transform.position += movement;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        }
    }
}
