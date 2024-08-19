using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pausepanel;
    public void Pause()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1; 
    }
    public void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        
    }
}
