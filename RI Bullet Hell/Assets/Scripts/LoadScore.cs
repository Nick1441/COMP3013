using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    public Text ScoreText;
    public Text LevelText;

    string ScoreString = "Enemies Killed - ";
    string LevelString = "Levels Complted - ";

    int Score;
    int Levels;

    void Start()
    {
        Score = PlayerPrefs.GetInt("TotalEnemiesKilled");
        Levels = PlayerPrefs.GetInt("ResetNo");

        string NewScore = ScoreString + Score.ToString();
        string NewLevel = LevelString + Levels.ToString();

        ScoreText.text = NewScore;
        LevelText.text = NewLevel;
    }
}
