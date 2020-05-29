using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
    public bool over;
    public GameObject GameoverImage;
    public GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {
        over = false;
        GameoverImage.SetActive(false);
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.name == "CloneMaker"){
            Time.timeScale = 0;
            over = true;
        }
    }
    void OnGUI(){
        if(over){
            GameoverImage.SetActive(true);
            restartButton.SetActive(true);
            if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("r")){
                Application.LoadLevel("TREX-GAME");
                Time.timeScale = 1;
                
            }
        }
    }
}
