using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highScore;
    public Text score;
    public Text FinalScore;
    public Transform Player;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {
        int DistanceTravelled = (int)Player.position.y + 4;
        score.text = DistanceTravelled.ToString();
        FinalScore.text = DistanceTravelled.ToString();

        if (DistanceTravelled > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", DistanceTravelled);
            highScore.text = DistanceTravelled.ToString();
        }
    }
}
