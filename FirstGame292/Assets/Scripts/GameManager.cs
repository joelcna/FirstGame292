using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public bool isGameOver = false;
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void increaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public void gameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
