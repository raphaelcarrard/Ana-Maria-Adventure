using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultyController : MonoBehaviour
{

    [SerializeField]
    private GameObject easySign, mediumSign, hardSign;

    void Start()
    {
        SetTheDifficulty();
    }

    void SetInitialDifficulty(string difficulty)
    {
        switch(difficulty){
            case "easy":
                mediumSign.SetActive(false);
                hardSign.SetActive(false);
                break;
            case "medium":
                easySign.SetActive(false);
                hardSign.SetActive(false);
                break;
            case "hard":
                easySign.SetActive(false);
                mediumSign.SetActive(false);
                break;
        }
    }

    void SetTheDifficulty(){
        if(Game.GetEasyDifficulty() == 1){
            SetInitialDifficulty("easy");
        }
        if(Game.GetMediumDifficulty() == 1){
            SetInitialDifficulty("medium");
        }
        if(Game.GetHardDifficulty() == 1){
            SetInitialDifficulty("hard");
        }
    }

    public void easyDifficulty(){
        Game.SetEasyDifficulty(1);
        Game.SetMediumDifficulty(0);
        Game.SetHardDifficulty(0);
        easySign.SetActive(true);
        mediumSign.SetActive(false);
        hardSign.SetActive(false);
    }

    public void mediumDifficulty(){
        Game.SetEasyDifficulty(0);
        Game.SetMediumDifficulty(1);
        Game.SetHardDifficulty(0);
        easySign.SetActive(false);
        mediumSign.SetActive(true);
        hardSign.SetActive(false);
    }

    public void hardDifficulty(){
        Game.SetEasyDifficulty(0);
        Game.SetMediumDifficulty(0);
        Game.SetHardDifficulty(1);
        easySign.SetActive(false);
        mediumSign.SetActive(false);
        hardSign.SetActive(true);
    }

    public void GoBackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
