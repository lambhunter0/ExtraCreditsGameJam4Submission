using UnityEngine;

public class PlugController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float rotateSpeed;
    private float moveSpeed;

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        rotateSpeed = 100.0f;
        moveSpeed = 500.0f;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.AddForce(transform.up*moveSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.AddForce(-transform.up*moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.MoveRotation(rb2d.rotation + rotateSpeed * Time.deltaTime);
            //rb2d.AddForce(-transform.right*rotateSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.MoveRotation(rb2d.rotation - rotateSpeed * Time.deltaTime);
            //rb2d.AddForce(transform.right * rotateSpeed);

        }
    }
}
