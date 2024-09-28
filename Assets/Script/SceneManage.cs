using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManage : MonoBehaviour
{
    public Text highScoreText;
    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }

    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
