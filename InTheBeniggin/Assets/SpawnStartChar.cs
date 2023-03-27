using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStartChar : MonoBehaviour
{
    public GameObject polygon;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0 , 0 , -20);
        Instantiate(polygon, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    { 

       
    }
}
