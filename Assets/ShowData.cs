using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PlayerNameText;
    public Text currentScoreText;
    public Text highScoreText;
    public Text missedText;

    private void Awake()
    {
        {
            PlayerNameText.text = "Name: " +
                KeepData.PlayerName;
            currentScoreText.text = "Last score: " +
                KeepData.Currentscore;
            highScoreText.text = "High score: " +
                KeepData.HighScore;
            KeepData.Currentscore = 0;
            missedText.text = "Missed: " +
                KeepData.Missed;
        }
    }

}
