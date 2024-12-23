using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneManage : MonoBehaviour
{
    public Text highScoreText;
    [SerializeField] private TextMeshProUGUI CoinText;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }
    private void Update()
    {
        CoinText.text = PlayerPrefs.GetInt("Coin").ToString();
    }

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().playSound("click");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().playSound("click");
        Application.Quit();
    }
}
