﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;
    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        instance = this;
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void Inicio(){

           Time.timeScale = 1;
      
    }
}
