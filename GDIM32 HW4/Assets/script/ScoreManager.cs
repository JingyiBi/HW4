using System;

using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance{ get; private set; }
    public event Action<int> OnScoreChanged;
    private int score = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;}
            else
            {
                Destroy(gameObject);
            }
            
        }
        public void AddPoint()
        {
            score++;
            OnScoreChanged?.Invoke(score);
        }
}
