using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemySpawn : MonoBehaviour
{
    public GameObject shootingEnemy;

    private int enemies = 0;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
         if(enemies == 0)
        {
            transform.rotation = Quaternion.Euler(0 , 0 , 180);
            transform.position = new Vector3(0 , 3, -22);
            Instantiate(shootingEnemy,transform.position, transform.rotation);
            enemies += 1; 
        }
        if(enemies == 1)
        {
            transform.rotation = Quaternion.Euler(0 , 0 , -135);
            transform.position = new Vector3(-7 , 3, -22);
            Instantiate(shootingEnemy,transform.position, transform.rotation);
            enemies += 1; 
        }
        if(enemies == 2)
        {
            transform.rotation = Quaternion.Euler(0 , 0 , 135);
            transform.position = new Vector3(7 , 3, -22);
            Instantiate(shootingEnemy,transform.position, transform.rotation);
            enemies += 1; 
        }
    }
}
