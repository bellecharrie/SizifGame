using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
    public float fallThreshold = -10f; // ����� �������, ��� ������� ���������� ������������ �����

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            // ���� �������� ���� ���� ������, ������������� ������� �����
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        // �������� ������ ������� �����
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ������������� ������� �����
        SceneManager.LoadScene(currentSceneIndex);
    }
}