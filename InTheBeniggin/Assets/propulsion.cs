using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class propulsion : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotation;

    static float deadZoneUp = 5; 
    static float deadZoneDown = -5; 
    static float deadZoneRight = 9;
    static float deadZoneLeft = -9;

    public GameObject polygon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float horizontalInput = Input.GetAxis ("Horizontal");
    float verticalInput = Input.GetAxis ("Vertical");

    Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
    float inputMagnitude = Mathf.Clamp01 (movementDirection.magnitude) ;
    movementDirection.Normalize();

    transform. Translate (movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

    if(movementDirection != Vector2.zero){

    Quaternion toRotation = Quaternion. LookRotation(Vector3.forward, movementDirection);
    transform.rotation = Quaternion. RotateTowards (transform.rotation, toRotation, rotation * Time.deltaTime) ;
        }
    if(transform.position.x < deadZoneLeft || transform.position.x > deadZoneRight || 
            transform.position.y < deadZoneDown || transform.position.y > deadZoneUp)
        {
            Debug.Log("Out of border");
            transform.position = new Vector3(0 , 0 , -20);

        }
    }

    void OnCollisionEnter2D(Collision2D col)
{
    if (col.gameObject.name.Equals("Laser(Clone)")) {
    Debug.Log("Hit!");
    Destroy(gameObject);
    SceneManager.LoadScene(2);
        }
  }
}
