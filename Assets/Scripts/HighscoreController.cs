using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighscoreController : MonoBehaviour
{

    [SerializeField]
    private Text scoreText, coinText;

    void Start()
    {
        SetScoreBaseOnDifficulty();
    }

    void SetScore(int score, int coinScore){
        scoreText.text = score.ToString();
        coinText.text = coinScore.ToString();
    }

    void SetScoreBaseOnDifficulty(){
        if(Game.GetEasyDifficulty() == 1){
            SetScore(Game.GetEasyDifficultyHighScore(), Game.GetEasyDifficultyCoinScore());
        }
        if(Game.GetMediumDifficulty() == 1){
            SetScore(Game.GetMediumDifficultyHighScore(), Game.GetMediumDifficultyCoinScore());
        }
        if(Game.GetHardDifficulty() == 1){
            SetScore(Game.GetHardDifficultyHighScore(), Game.GetHardDifficultyCoinScore());
        }
    }

    public void GoBackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
