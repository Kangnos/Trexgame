using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRunner : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
    }

    
}
