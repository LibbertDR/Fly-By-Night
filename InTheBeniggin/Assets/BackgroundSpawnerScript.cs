using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawnerScript : MonoBehaviour
{
    public GameObject background;
    public float spawnRate = 4;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnBackground();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer +=  Time.deltaTime;
        }
        else{
        spawnBackground();
        timer = 0; 
        }
    }

    void spawnBackground() 
    {
    transform.rotation = Random.rotation;
    Instantiate(background, transform.position, transform.rotation);
    }
}
