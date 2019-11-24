using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void StartPlay()
    {
        WordDisplay.Score = 0;
        WordDisplay.MissedScore = 0;
        SceneManager.LoadScene("Main");
    }
    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }



    // Update is called once per frame
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
