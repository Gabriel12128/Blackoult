using UnityEngine;

public class MultBall : MonoBehaviour
{
    
    [SerializeField]
    private GameObject Ball;

    [SerializeField]
    private int Amount;


    void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.tag == "Player")
        {
            InstanceBall();
        }
    }

    void InstanceBall()
    {
        for(int i = 0; i < Amount; i++)
        {
            Instantiate(Ball);
            Ball.transform.position = transform.position;
        }
        Destroy(gameObject);
        
    }
}
