using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public AudioSource keystroke;
    public WordManager wordManager;

    // Update is called once per frame
    void Update()
    {
      foreach (char letter in Input.inputString)
      {
            wordManager.TypeLetter(letter);
            keystroke.Play();
      }
    }
}
