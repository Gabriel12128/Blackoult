using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7 && GameController.instance.gameActive)
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.layer == 7)
        {
            Destroy(collision.gameObject);
        }
    }
}
