using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject OnCanvas;
    public TextMeshProUGUI Coin;

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
        FindObjectOfType<AudioManager>().playSound("click");
        SceneManager.LoadScene(1);
    }
    void Update()
    {
        Coin.text = PlayerPrefs.GetInt("Coin").ToString();
    }
}
