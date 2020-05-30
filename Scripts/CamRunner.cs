using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamRunner : MonoBehaviour
{

    public float score;
    public int highscore;
    public int intscore;

    public Text ScoreText;
    public Text highScoreText;


    void Awake(){
        score = 0;
        intscore = 0;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
        score += Time.deltaTime * 10;
        intscore = (int) score;
        ScoreText.text = "Score: " + intscore.ToString();

        if (intscore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", intscore);
        }
    }
    
}
