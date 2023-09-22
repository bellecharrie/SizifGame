using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreMetr : MonoBehaviour
{
    private Vector3 lastPosition;
    private double distanceTravelled = 0f;
    public Text scoreDisplay;
    public Text HighscoreText;

    int highScore;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ¬ычисл€ем пройденное рассто€ние между текущей позицией и предыдущей позицией по оси X
        float distanceX = transform.position.x - lastPosition.x;

        

        // ≈сли рассто€ние больше нул€, добавл€ем его к общему пройденному рассто€нию
        if (distanceX > 0)
        {
            distanceTravelled += distanceX;
            lastPosition = transform.position;
            scoreDisplay.text = "Score: " + (int)distanceTravelled;
        }

    
        if ( PlayerPrefs.GetInt("score") <= distanceTravelled)
        {
            PlayerPrefs.SetInt("score", highScore);
        }
        HighscoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("score").ToString();

        // ¬ыводим пройденное рассто€ние в консоль
        // Debug.Log("ѕройденное рассто€ние по оси X: " + distanceTravelled);
    }
}