using UnityEngine;

public class SocketHoleController : MonoBehaviour
{
    public Countdown timer;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //win the level
            timer.isPaused = true;
            collision.gameObject.GetComponent<PlugController>().LockMovement();
            timer.winLoseManager.won = true;
        }
    }
}
