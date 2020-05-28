using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {
    public GameObject[] ob;
    public Transform campos;
    public float composplayerdistance;
    private GameObject cs;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleMaker();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed")*Time.deltaTime);
        cs = GameObject.Find("CloneMaker");
        if(campos.position.x - cs.transform.position.x > composplayerdistance){
            Destroy(cs);
        }
    }
    void ObstacleMaker(){
        GameObject clone = (GameObject)Instantiate (ob[Random.Range(0, ob.Length)], transform.position, Quaternion.identity);
        clone.name = "CloneMaker";
        clone.AddComponent<BoxCollider2D>();
        clone.GetComponent<BoxCollider2D>().isTrigger = true;
        float xx = Random.Range(1, 3);
        Invoke("ObstacleMaker", xx);
    }
}
