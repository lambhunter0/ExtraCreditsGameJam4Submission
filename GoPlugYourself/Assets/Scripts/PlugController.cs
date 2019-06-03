using UnityEngine;

public class PlugController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float rotateSpeed;
    private float moveSpeed;
    public bool isDead;

    void Start()
    {
        isDead = false;
        rb2d = this.GetComponent<Rigidbody2D>();
        rotateSpeed = 50.0f;
        moveSpeed = 500.0f;
    }

    void Update()
    {
        if (!isDead)
        {
            Move();
        }
    }

    private void Move()
    {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb2d.AddForce(transform.up * moveSpeed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb2d.AddForce(-transform.up * (moveSpeed / 1.5f));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb2d.MoveRotation(rb2d.rotation + rotateSpeed * Time.deltaTime * 2.0f);
                //rb2d.AddForce(-transform.right*rotateSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb2d.MoveRotation(rb2d.rotation - rotateSpeed * Time.deltaTime * 2.0f);
                //rb2d.AddForce(transform.right * rotateSpeed);

            }
    }

    public void LockMovement()
    {
        rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
    }
}
