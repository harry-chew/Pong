using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector2 moveDirection;
    [SerializeField] private Vector2 moveStop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if neither key is pressed - this will stop the paddle
        moveDirection = moveStop;

        //if W is pressed - set direction to move to UP
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("Up");
            moveDirection = Vector2.up;
        }

        //if S is pressed - set direction to move to DOWN
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Down");
            moveDirection = Vector2.down;
        } 

        //run MOVE function
        Move(moveDirection, moveSpeed);
    }

    //MOVE Function - takes direction and speed
    void Move(Vector2 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
