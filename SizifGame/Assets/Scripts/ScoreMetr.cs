using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreMetr : MonoBehaviour
{
    private Vector3 lastPosition;
    public double distanceTravelled = 0f;
    public Text scoreDisplay;
    public Text HighscoreText;
    public int highScore;

    void Start()
    {
        lastPosition = transform.position;

         highScore = PlayerPrefs.GetInt("score",highScore);
       

    }

 
    void Update()
    {
        // Вычисляем пройденное расстояние между текущей позицией и предыдущей позицией по оси X
        float distanceX = transform.position.x - lastPosition.x;

        

        // Если расстояние больше нуля, добавляем его к общему пройденному расстоянию
        if (distanceX > 0)
        {
            distanceTravelled += distanceX;
            lastPosition = transform.position;
            scoreDisplay.text = "Score: " + (int)distanceTravelled;

           

        }

        if (highScore < (int)distanceTravelled)
        {
                highScore = (int)distanceTravelled;
                PlayerPrefs.SetInt("score",highScore);
        }
        PlayerPrefs.SetInt("score", highScore);
        HighscoreText.text = "HIGH SCORE: " + highScore;
            
    }
}