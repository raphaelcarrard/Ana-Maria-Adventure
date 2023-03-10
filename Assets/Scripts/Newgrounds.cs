using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newgrounds : MonoBehaviour
{

    public io.newgrounds.core ngio_core;

    public static Newgrounds instance;

    // Start is called before the first frame update
    void Awake() {
        if(instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void NGSubmitScore(int score_id, int score){
        io.newgrounds.components.ScoreBoard.postScore submit_score = new io.newgrounds.components.ScoreBoard.postScore();
        submit_score.id = score_id;
        submit_score.value = score;
        submit_score.callWith(ngio_core);
        Debug.Log("Score Added!");
    }
}
