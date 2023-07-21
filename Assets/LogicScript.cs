using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
#if UNITY_EDITOR
using UnityEditor.Experimental.GraphView;
#endif
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    
    public Text scoreText;

    public GameObject gameOverScreen;

    public AudioSource AudioSource;

    
    public void AddScore()
    {
        AudioSource.Play();
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

