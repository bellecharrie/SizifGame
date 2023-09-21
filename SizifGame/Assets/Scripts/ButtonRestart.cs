using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonRestart : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(Restart);
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
