using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class GameObserver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public AudioSource pointSoud;
    private void Start()
    {
        if(ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged += HandleScoreChanged;
        }
    }
    // Start is called before the first frame update
    private void HandleScoreChanged(int newScore)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + newScore.ToString();
        }
        if (pointSoud != null)
        {
            pointSoud.Play();
        }}
        private void OnDestroy()
        {
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.OnScoreChanged -= HandleScoreChanged;
            }
        } 
    }
