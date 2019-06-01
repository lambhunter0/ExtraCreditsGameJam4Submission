using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketHoleController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("GG");
            //win the level
            collision.gameObject.GetComponent<PlugController>().LockMovement();
        }
    }
}
