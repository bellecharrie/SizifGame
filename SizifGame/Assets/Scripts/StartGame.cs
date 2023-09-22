using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public void StartSyzif()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitSyzif()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
