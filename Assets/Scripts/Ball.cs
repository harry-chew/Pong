using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public Vector2 initialBallDirection;

    public Vector2 currentBallDirection;
    public float moveSpeed;
    public int x_axis;
    public void Start()
    {
        x_axis = 0;
        //pick random direction to move in
        int direction = Random.Range(0, 2);
        if(direction == 0)
        {
            x_axis = -1;
            Debug.Log("Left");
        } else
        {
            x_axis = 1;
            Debug.Log("Right");
        }

        initialBallDirection = new Vector2(x_axis, 0);

        currentBallDirection = initialBallDirection;
    }

    private void Update()
    {
        MoveBall(currentBallDirection);
    }

    public void MoveBall(Vector2 direction)
    {
        currentBallDirection = new Vector3(direction.x, direction.y, 0);
        transform.Translate(currentBallDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        //reverse direction of ball
        currentBallDirection = new Vector2(-currentBallDirection.x, currentBallDirection.y);
    }
}
