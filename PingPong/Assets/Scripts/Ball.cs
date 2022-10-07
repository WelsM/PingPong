using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 direction;
    private void Start() {
        
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(1,Random.Range(-1.0f,1.0f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position+direction*speed*Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Limit"){
            direction = new Vector2(direction.x, -direction.y);
        }
        else{
            direction = new Vector2(-direction.x,Random.Range(-1.0f,1.0f));
            speed+=1;
        }
    }
}
