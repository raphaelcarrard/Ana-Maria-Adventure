using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game {

    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";

    public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
    public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
    public static string HardDifficultyHighScore = "HardDifficultyHighScore";

    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

    public static string IsMucisOn = "IsMucisOn";


    //IsMusicOn
    public static int GetMusicState()
    {
        return PlayerPrefs.GetInt(Game.IsMucisOn);
    }

    public static void SetMusicState(int state)
    {
        PlayerPrefs.SetInt(Game.IsMucisOn, state);
    }


    //EasyDifficulty
    public static int GetEasyDifficulty()
    {
        return PlayerPrefs.GetInt(Game.EasyDifficulty);
    }

    public static void SetEasyDifficulty( int state)
    {
        PlayerPrefs.SetInt(Game.EasyDifficulty, state);
    }

    public static int GetMediumDifficulty()
    {
        return PlayerPrefs.GetInt(Game.MediumDifficulty);
    }

    public static void SetMediumDifficulty(int state)
    {
        PlayerPrefs.SetInt(Game.MediumDifficulty, state);
    }

    public static int GetHardDifficulty()
    {
        return PlayerPrefs.GetInt(Game.HardDifficulty);
    }

    public static void SetHardDifficulty(int state)
    {
        PlayerPrefs.SetInt(Game.HardDifficulty, state);
    }


    //DifficultyHighScore
    public static int GetEasyDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(Game.EasyDifficultyHighScore);
    }

    public static void SetEasyDifficultyHighScore(int state)
    {
        PlayerPrefs.SetInt(Game.EasyDifficultyHighScore, state);
    }

    public static int GetMediumDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(Game.MediumDifficultyHighScore);
    }

    public static void SetMediumDifficultyHighScore(int state)
    {
        PlayerPrefs.SetInt(Game.MediumDifficultyHighScore, state);
    }

    public static int GetHardDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(Game.HardDifficultyHighScore);
    }

    public static void SetHardDifficultyHighScore(int state)
    {
        PlayerPrefs.SetInt(Game.HardDifficultyHighScore, state);
    }


    //DifficultyCoinScore
    public static int GetEasyDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(Game.EasyDifficultyCoinScore);
    }

    public static void SetEasyDifficultyCoinScore(int state)
    {
        PlayerPrefs.SetInt(Game.EasyDifficultyCoinScore, state);
    }

    public static int GetMediumDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(Game.MediumDifficultyCoinScore);
    }

    public static void SetMediumDifficultyCoinScore(int state)
    {
        PlayerPrefs.SetInt(Game.MediumDifficultyCoinScore, state);
    }

    public static int GetHardDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(Game.HardDifficultyCoinScore);
    }

    public static void SetHardDifficultyCoinScore(int state)
    {
        PlayerPrefs.SetInt(Game.HardDifficultyCoinScore, state);
    }
}