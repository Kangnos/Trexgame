using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
    public bool over;
    public GameObject GameoverImage;
    public GameObject restartButton;
    public AudioSource OverSound;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        over = false;
        GameoverImage.SetActive(false);
        restartButton.SetActive(false);
        anim = GetComponent<Animator>();
        OverSound = GetComponent<AudioSource>();
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
            anim.SetBool("isDead", true);
            GameoverImage.SetActive(true);
            restartButton.SetActive(true);
            if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("r")){
                Application.LoadLevel("TREX-GAME");
                Time.timeScale = 1;
                
            }
        }
    }
}
