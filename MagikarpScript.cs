using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagikarpScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    int upFactor = 10;
    public LogicScript logic;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdAlive)
            myRigidbody.velocity = Vector2.up * upFactor;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }
}
