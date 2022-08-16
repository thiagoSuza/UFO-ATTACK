using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassicScoreController : MonoBehaviour
{
    public static ClassicScoreController instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private int scoreNumber,highScoreNumber;
    public Text score,winHighScore,loseHighScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        score.text = scoreNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreUpdater();
    }

    public void ScoreUp(int amountScore)
    {
        scoreNumber += amountScore;
        score.text = scoreNumber.ToString();
    }

    public void highScoreUpdater()
    {
        if(scoreNumber > PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", scoreNumber);
        }
        winHighScore.text = PlayerPrefs.GetInt("MaxScore").ToString();
        loseHighScore.text = PlayerPrefs.GetInt("MaxScore").ToString();
    }
}
