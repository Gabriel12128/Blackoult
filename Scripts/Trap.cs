using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour
{
    
    [SerializeField]
    private float SlowSpeed;

    [SerializeField]
    private float WaitTemp;
    private float SpeedPlayer;
    
    void Start()
    {
        SpeedPlayer = Player.AcessSpeed;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(WaitTemp);
        Player.AcessSpeed = SpeedPlayer;
        Destroy(gameObject);
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.tag == "Player")
        {
            
            Player.AcessSpeed = CalSpeed();
            StartCoroutine(Wait());
        }
    }

    float CalSpeed()
    {
        return Player.AcessSpeed - SlowSpeed;
    } 
}
