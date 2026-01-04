
using UnityEngine;

public class Ball : MonoBehaviour
{
   
    private Rigidbody2D rig;

    [SerializeField]
    private   float Vertical;

    [SerializeField]
    private  float Horizontal;

    [SerializeField]
    private float Speed;

    
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
       Movement();
    }

    void Movement()
    {
        Vector2 direction = new Vector2(Horizontal, Vertical).normalized;
        rig.linearVelocity = direction * Speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3  || collision.gameObject.tag == "Player")
        {
            Vertical = -Vertical;
        }

       if(collision.gameObject.layer == 6)
        {
            Horizontal = -Horizontal;
        }
    }
}
