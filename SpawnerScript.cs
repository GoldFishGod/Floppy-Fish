using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public double spawnRate = 1.3;
    private double timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
       
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(transform.position.y + (float)4.5, transform.position.y - (float)4.5), 0), transform.rotation);
    }
        
}
