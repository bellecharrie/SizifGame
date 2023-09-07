using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
    public float fallThreshold = -10f; // Порог падения, при котором происходит перезагрузка сцены

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            // Если персонаж упал ниже порога, перезагружаем текущую сцену
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        // Получаем индекс текущей сцены
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Перезагружаем текущую сцену
        SceneManager.LoadScene(currentSceneIndex);
    }
}