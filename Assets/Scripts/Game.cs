using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public List<GameObject> players;
    public GameObject ball;

    public Button startButton;

    public bool isPaused;
    public bool hasGameStarted;

    public float gameTimer;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = true;
        hasGameStarted = false;
        gameTimer = 0.0f;

        
        startButton.onClick.AddListener(OnStartButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPaused)
        {
            gameTimer += Time.deltaTime;
        }
    }

    void StartGame()
    {
        //spawn ball in center of screen - coords (0,0)
        Instantiate(ball, new Vector2(0, 0), Quaternion.identity);
        //choose random direction for ball
        int randomDirection = Random.Range(0, 2);
        //start game timer
        isPaused = false;
    }

    void OnStartButtonClick()
    {
        GameObject buttonToHide = GameObject.Find("StartButton");
        //remove start button
        buttonToHide.SetActive(false);
        
        StartGame();
    }

    public void PauseToggle()
    {
        if(!isPaused)
        {
            isPaused = true;
            Time.timeScale = 0f;
        } else
        {
            isPaused = false;
            Time.timeScale = 1f;
        }
    }

    
}
