using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 direction;
    // Start is called before the first frame update
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
}
