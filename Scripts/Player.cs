using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig;

    private static int Score;
    private static float Speed = 10;

    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public static float AcessSpeed
    {
        get{return Speed;}
        set{Speed = value;}
    }

    public static int AcessScore
    {
       get{return Score;}
       set{Score = value;}
    }




    void Update()
    {
        if(GameController.instance.gameActive)
        {
            Move();
        }
    }

    void Move()
    {
        float movement = Input.GetAxis("Horizontal");
        rig.linearVelocity = new Vector2(movement * Speed, rig.linearVelocityY);
    }
}
