using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    [HideInInspector]
    public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDied;

    [HideInInspector]
    public int score, coinScore, lifeScore;

    private void Awake()
    {
        MakeSingleton();
    }

    void Start()
    {
        InitializeVariables();
    }

    void OnLevelWasLoaded()  {
        if (Application.loadedLevelName == "Game")
        {
            if (gameRestartedAfterPlayerDied)
            {
                GameplayController.instance.SetScore(score);
                GameplayController.instance.SetCoinScore(coinScore);
                GameplayController.instance.SetLifeScore(lifeScore);

                PlayerScore.scoreCount = score;
                PlayerScore.coinCount = coinScore;
                PlayerScore.lifeCount = lifeScore;

            }else if(gameStartedFromMainMenu) {
                PlayerScore.scoreCount = 0;
                PlayerScore.coinCount = 0;
                PlayerScore.lifeCount = 2;

                GameplayController.instance.SetScore(0);
                GameplayController.instance.SetCoinScore(0);
                GameplayController.instance.SetLifeScore(2);
            }
        }
    }

    void InitializeVariables()
    {
        if (!PlayerPrefs.HasKey("Game Initialized"))
        {
            Game.SetEasyDifficulty(0);
            Game.SetEasyDifficultyCoinScore(0);
            Game.SetEasyDifficultyHighScore(0);

            Game.SetMediumDifficulty(1);
            Game.SetMediumDifficultyCoinScore(0);
            Game.SetMediumDifficultyHighScore(0);

            Game.SetHardDifficulty(0);
            Game.SetHardDifficultyCoinScore(0);
            Game.SetHardDifficultyHighScore(0);

            Game.SetMusicState(0);

            PlayerPrefs.SetInt("Game Initialized", 123);
        }
    }

    void MakeSingleton () {
	    if (instance != null)
        {
            Destroy(gameObject);
        }else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }	
	}
	
    public void CheckGameStatus(int score, int coinScore, int lifeScore) {
        if(lifeScore < 0)
        {
            if(Game.GetEasyDifficulty() == 1)
            {
                int highScore = Game.GetEasyDifficultyHighScore();
                int coinHighScore = Game.GetEasyDifficultyCoinScore();

                if (highScore < score)
                    Newgrounds.instance.NGSubmitScore(12596, score);
                    Game.SetEasyDifficultyHighScore(score);

                if (coinHighScore < coinScore)
                    Game.SetEasyDifficultyCoinScore(coinScore);
            }

            if (Game.GetMediumDifficulty() == 1)
            {
                int highScore = Game.GetMediumDifficultyHighScore();
                int coinHighScore = Game.GetMediumDifficultyCoinScore();

                if (highScore < score)
                    Newgrounds.instance.NGSubmitScore(12597, score);
                    Game.SetMediumDifficultyHighScore(score);

                if (coinHighScore < coinScore)
                    Game.SetMediumDifficultyCoinScore(coinScore);
            }

            if (Game.GetHardDifficulty() == 1)
            {
                int highScore = Game.GetHardDifficultyHighScore();
                int coinHighScore = Game.GetHardDifficultyCoinScore();

                if (highScore < score)
                    Newgrounds.instance.NGSubmitScore(12598, score);
                    Game.SetHardDifficultyHighScore(score);

                if (coinHighScore < coinScore)
                    Game.SetHardDifficultyCoinScore(coinScore);
            }

            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDied = false;

            GameplayController.instance.GameOverShowPanel(score, coinScore);

        }else {
            this.score = score;
            this.coinScore = coinScore;
            this.lifeScore = lifeScore;

            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDied = true;

            GameplayController.instance.PlayerDiedRestartTheGame();
        }
    }
}
