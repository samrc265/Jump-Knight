using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject OnCanvas;

    void Start()
    {
        gameOverCanvas.SetActive(false);

    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);

    }
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
    void Update()
    {
        
    }
}
