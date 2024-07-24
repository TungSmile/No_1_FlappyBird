using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigi;
    public float StrengJum;
    public LogicScript logic;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            myRigi.velocity = Vector2.up * StrengJum;
        }
        if (transform.position.y > 17)
        {
            logic.gameOver();
            birdAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logic.gameOver();
        birdAlive = false;
    }
}
