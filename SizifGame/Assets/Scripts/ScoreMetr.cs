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
 
        // ������� ���������� ���������� � �������
        // Debug.Log("���������� ���������� �� ��� X: " + distanceTravelled);
    }
}