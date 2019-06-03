using UnityEngine;

public class SocketHoleControllerFreePlay : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //win the level
            collision.gameObject.GetComponent<PlugController>().LockMovement();
        }
    }
}
