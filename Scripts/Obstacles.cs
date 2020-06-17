using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {
    public GameObject[] ob;
    public Transform campos;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleMaker();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed")*Time.deltaTime);
        GameObject cs = GameObject.Find("CloneMaker");
        if(campos.position.x - cs.transform.position.x > 12){
            Destroy(cs);
        }
    }
    void ObstacleMaker(){
        GameObject clone = (GameObject)Instantiate (ob[Random.Range(3, ob.Length)], transform.position, Quaternion.identity);
        clone.name = "CloneMaker";
        clone.AddComponent<BoxCollider2D>();
        clone.GetComponent<BoxCollider2D>().isTrigger = true;
        float xx = Random.Range(1, ob.Length - 1); 
        Invoke("ObstacleMaker", xx);
    }
}
