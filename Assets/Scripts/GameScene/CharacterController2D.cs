using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    
    public float speed = 1000f;
    private float horizontal;

    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed * Time.deltaTime,rb.velocity.y);

        Vector2 newScale = transform.localScale;

        if(horizontal < 0){
            newScale.x = -1;
        }       

        else{
            newScale.x = 1;
        }

        transform.localScale = newScale;
    }
}
