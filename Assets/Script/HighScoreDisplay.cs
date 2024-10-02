using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    private Text highScoreText;

    void Start()
    {
        highScoreText = GetComponent<Text>();

        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        highScoreText.text = Mathf.FloorToInt(highScore).ToString();
    }

    void Update()
    {
        int currentScore = int.Parse(scoreText.text);
        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        if (currentScore > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", currentScore);
            highScoreText.text = currentScore.ToString();
        }
    }
}
