using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGShift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D collider){
        float width=((BoxCollider2D)collider).size.x; // 가로길이 
        Vector3 pos = collider.transform.position;
        pos.x += width* 1.7f; // 만약 그것과 만나면 위치를 바꾼다.
        if(collider.gameObject.tag == "BG1"){
            collider.transform.position = pos;
        }
        if(collider.gameObject.tag == "BG2"){
            collider.transform.position = pos;
        }
    }
}
