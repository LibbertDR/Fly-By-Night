using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsBehaviour : MonoBehaviour {

    public GameObject player;
    float bulletsSpeed = 7f;
    
    Rigidbody2D rb;

    propulsion target;
    Vector2 moveDirection;

// Use this for initialization
    void Start() 
{
    rb = GetComponent<Rigidbody2D>();
    Invoke(nameof(movingBullets), 0.5f);
    Destroy(gameObject, 3f);
}

void movingBullets(){
    target = GameObject.FindObjectOfType<propulsion>();
    moveDirection = (target.transform.position - transform.position).normalized * bulletsSpeed;
    rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }
}