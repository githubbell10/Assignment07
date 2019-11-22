using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "default name";
    public static bool OversizedBall = true;
    public static int RoundsToPlay =3;
    public static float PlayerSpeedMultiplier = 1.0f;
    public static int Currentscore = 0;
    public static int HighScore = 0;
    public static int TargetRotationSpeedMultiplier;
    public static Color ColorOption = Color.white;

    public InputField playerName;
    public Toggle ballSize;
    public Dropdown colorOfWord;
    public Slider playerSpeedMultiplier;
    public Slider targetRotationSlider;
    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()    //updates on input change for input field
    {
        PlayerName = playerName.text;
    }
    public void BigBall (bool newValue)
    {
        OversizedBall = newValue;
    }

    
    
    public void setColorOfWord()
    {
        switch (colorOfWord.value)
        {
            case 1:
                ColorOption = Color.white;
                break;
            case 2:
                ColorOption = Color.blue;
                break;
            case 3:
                ColorOption = Color.yellow;
                break;
            
            default:
                ColorOption = Color.green;
                break;
        }
    }
    public void SetPlayerSpeedMultiplier()
    {
        PlayerSpeedMultiplier = playerSpeedMultiplier.value;    // value of the slider
    }
}