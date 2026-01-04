using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    private GameObject MultBall;

    [SerializeField]
    private GameObject Trap;

    private int chanceMultBall = 10;
    private int chanceTrap = 3;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        int chanceM = Random.Range(0, 101);
        int chanceT = Random.Range(0, 101);

        if(collision.gameObject.CompareTag("Ball"))
        {
            Player.AcessScore += 1;
            if(chanceM < chanceMultBall)
            {
                InstanceMultBall();
                Destroy(gameObject);
            }

            if(chanceT < chanceTrap)
            {
                InstanceTrap();
                Destroy(gameObject);
            }

            Destroy(gameObject);
        }
    }

    void InstanceMultBall()
    {
        Instantiate(MultBall);
        MultBall.transform.position = transform.position;
    }
    
    void InstanceTrap()
    {
        Instantiate(Trap);
        Trap.transform.position = transform.position;
    }
}
