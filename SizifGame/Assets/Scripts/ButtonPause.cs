using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    public GameObject panelPause;

    public void Pause()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ContinueGame()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1f;
    }
}
