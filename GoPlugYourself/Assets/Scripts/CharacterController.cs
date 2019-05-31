using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    enum Facing { Down, Up, Left, Right}

    private Facing currentDirection;
    private float moveSpeed;
    private Vector3 updatedPosition;
    private Quaternion updatedRotation;

    public GameObject wireSegment;
    public GameObject wireStart;


    void Start()
    {
        moveSpeed = 0.031f;
        updatedPosition = new Vector2(0.0f,0.0f);
        updatedRotation = Quaternion.Euler(0,0,0);
        currentDirection = Facing.Up;
    }

    void FixedUpdate()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKey(KeyCode.DownArrow) && currentDirection != Facing.Up)
        {
            UpdatePosition(transform.position.x, transform.position.y - (moveSpeed));
            UpdateRotation(0,0,180);
            currentDirection = Facing.Down;
            Instantiate(wireSegment, new Vector3(wireStart.transform.position.x, wireStart.transform.position.y, 0), Quaternion.Euler(0, 0, 0));
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow) && currentDirection != Facing.Down)
        {
            UpdatePosition(transform.position.x, transform.position.y + (moveSpeed));
            UpdateRotation(0,0,0);
            currentDirection = Facing.Up;
            Instantiate(wireSegment, new Vector3(wireStart.transform.position.x, wireStart.transform.position.y, 0), Quaternion.Euler(0, 0, 0));
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && currentDirection != Facing.Right)
        {
            UpdatePosition(transform.position.x - (moveSpeed), transform.position.y);
            UpdateRotation(0,0,90);
            currentDirection = Facing.Left;
            Instantiate(wireSegment, new Vector3(wireStart.transform.position.x, wireStart.transform.position.y, 0), Quaternion.Euler(0, 0, 0));
            return;
        }
        if (Input.GetKey(KeyCode.RightArrow) && currentDirection != Facing.Left)
        {
            UpdatePosition(transform.position.x + (moveSpeed), transform.position.y);
            UpdateRotation(0,0,270);
            currentDirection = Facing.Right;
            Instantiate(wireSegment, new Vector3(wireStart.transform.position.x, wireStart.transform.position.y, 0), Quaternion.Euler(0, 0, 0));
            return;
        }
    }

    private void UpdatePosition(float x, float y)
    {
        updatedPosition = new Vector2(x, y);
        transform.position = updatedPosition;
    }

    private void UpdateRotation(float x, float y, float z)
    {
        updatedRotation = Quaternion.Euler(x,y,z);
        transform.rotation = updatedRotation;
    }
}
