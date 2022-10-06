using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 direction;
    public float speed;

    // Update is called once per frame
    void Start() {
        direction = new Vector3(UnityEngine.Random.Range(-1f,1),UnityEngine.Random.Range(-1f,1f),0);
    }
    void Update()
    {
        transform.position = direction+=1;
        
    }
}