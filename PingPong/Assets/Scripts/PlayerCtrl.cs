using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    Rigidbody2D rbP;
    float vert;
    public float speedP;
    Vector2 PlayerMove;
    private void Awake()
    {
        rbP = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vert = Input.GetAxisRaw("Vertical");
        rbP.velocity = new Vector2(0,vert)*speedP*Time.fixedDeltaTime;
    }
}
