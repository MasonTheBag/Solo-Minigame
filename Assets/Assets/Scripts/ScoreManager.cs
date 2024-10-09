using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;

    int score = 0;


    private void Awake()
    {

        instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {

        scoreText.text = score.ToString();

    }
    public void AddScore()
    {

        score = score + 50;
        scoreText.text = score.ToString();

    }
}