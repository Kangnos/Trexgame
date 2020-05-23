using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public LayerMask platformsLayerMask;
    private Rigidbody2D rigidbody2D;
    public float jumpVelocity = 10f;
    private BoxCollider2D boxCollider2d;
    public int speeds;

    void Start(){
        PlayerPrefs.SetInt("speed", speeds);

    }
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update() {
        if (IsGrounded() && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)))
        {
            rigidbody2D.velocity = Vector2.up * jumpVelocity; 
        }
        transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
    }

    private bool IsGrounded(){
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down , .5f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }

}
