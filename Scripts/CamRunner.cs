using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRunner : MonoBehaviour
{
    public int sc;
    public float sco;
    public int high;
    public GUIStyle style1;

    // Start is called before the first frame update
    void Start()
    {
        sco = 0;    
        PlayerPrefs.SetInt("high", 0);
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);

        sco += Time.deltaTime * 10; // 시간이 지남에 따라 10배 
        sc = (int)sco;
        if (high < sco){
            PlayerPrefs.SetInt("high", sc); // 최고 기록 수정
        }
    }
    
    void OnGUI(){
        string hi = high.ToString (); // 최고 점수를 string 형태로 나타내기
        string score = sc.ToString(); // 점수를 string 형태로 나타내기
        
        GUI.Label (new Rect(Screen.width*0.9f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height*0.05f),score, style1);
        GUI.Label (new Rect(Screen.width*0.55f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height *0.05f),"High Score: " + hi, style1);
    }
}
