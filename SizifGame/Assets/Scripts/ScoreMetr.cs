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
        // ��������� ���������� ���������� ����� ������� �������� � ���������� �������� �� ��� X
        float distanceX = transform.position.x - lastPosition.x;

        

        // ���� ���������� ������ ����, ��������� ��� � ������ ����������� ����������
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

        // ������� ���������� ���������� � �������
        // Debug.Log("���������� ���������� �� ��� X: " + distanceTravelled);
    }
}