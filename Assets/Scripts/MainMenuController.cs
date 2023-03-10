using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    [SerializeField]
    private Button musicBtn;

    [SerializeField]
    private Sprite[] musicIcons;

    void Start(){
        CheckToPlayMusic();
    }

    void CheckToPlayMusic(){
        if(Game.GetMusicState() == 1){
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[0];
        }else{
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[1];
        }
    }

    public void StartGame(){
        GameManager.instance.gameStartedFromMainMenu = true;
        SceneManager.LoadScene("Game");
    }

    public void HighscoreMenu(){
        SceneManager.LoadScene("Highscore");
    }

    public void DifficultyMenu(){
        SceneManager.LoadScene("Difficulty");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void MusicButton(){
        if(Game.GetMusicState() == 0){
            Game.SetMusicState(1);
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[0];
        }else if(Game.GetMusicState() == 1){
            Game.SetMusicState(0);
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[1];
        }
    }
}
