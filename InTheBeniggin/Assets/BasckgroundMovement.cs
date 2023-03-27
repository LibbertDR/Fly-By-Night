using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasckgroundMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed; 
    static float deadZone = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * moveSpeed) * Time.deltaTime;
        if (transform.position.y < deadZone)
        {
        Destroy(gameObject);
        }
    }
}
