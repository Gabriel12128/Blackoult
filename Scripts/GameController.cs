using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField]
    private GameObject gameOver;

     [SerializeField]
    private GameObject WinG;

    [SerializeField]
    private Text Score;

    private float SpeedPlayer;

    public bool gameActive = true;
    
    void Start()
    {
        instance = this;
        SpeedPlayer = Player.AcessSpeed;
    }

   
    void Update()
    {
        if(GameObject.FindWithTag("Ball") != null)
        {
            UpdateScore(Player.AcessScore);
        }
        else
        {
            GameOver();
        }

        if(Player.AcessScore >= 90)
        {
            Win();
        }
    }

    void GameOver()
    {
        gameActive = false;
        gameOver.SetActive(true);
        Player.AcessScore = 0;
        Player.AcessSpeed = SpeedPlayer;
    }

    void Win()
    {
        gameActive = false;
        WinG.SetActive(true);
        Player.AcessScore = 0;
        Player.AcessSpeed = SpeedPlayer;
    }

    void UpdateScore(int score)
    {
        Score.text = "Score " + score.ToString();
    }

    public void Reload(string Levelname)
    {   
        
        gameActive = true;
        gameOver.SetActive(false);
        WinG.SetActive(false);
        SceneManager.LoadScene(Levelname);
    }
}
