using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    public Text ScoreText;
    public Text LevelText;

    string ScoreString = "Score - ";
    string LevelString = "Levels Completed - ";

    int Score;
    int Levels;

    void Start()
    {
        Score = PlayerPrefs.GetInt("Score");
        Levels = PlayerPrefs.GetInt("ResetNo");

        string NewScore = ScoreString + Score.ToString();
        string NewLevel = LevelString + Levels.ToString();

        ScoreText.text = NewScore;
        LevelText.text = NewLevel;
    }
}
