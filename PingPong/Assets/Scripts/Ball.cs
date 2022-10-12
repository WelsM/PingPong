using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 10.0f;
    public float cSpeed;
    public Vector2 direction;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(-1.0f,1.0f),Random.Range(-1.0f,1.0f));
        cSpeed  = speed;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position+direction*cSpeed*Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Limit"){
            direction = new Vector2(direction.x, -direction.y);
        }
        else{
            direction = new Vector2(-direction.x,Random.Range(-1.0f,1.0f));
            cSpeed+=1;
        }
    }

    public void Point(){
        cSpeed = speed;
        rb.position = new Vector2(0,0);
        direction = new Vector2(Random.Range(-1.0f,1.0f),Random.Range(-1.0f,1.0f));
    }
}
