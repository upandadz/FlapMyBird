using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    
    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    
    private int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        currentScoreText.text = score.ToString();
        
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScoreText.text = score.ToString();
        UpdateHighScore();
    }
}
