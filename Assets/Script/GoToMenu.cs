using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public void GoToMM()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }
    public void replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
    }
}
