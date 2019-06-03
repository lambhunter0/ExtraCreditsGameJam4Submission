using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    private float startingTime;
    private float timerTime;
    public Text timer;
    public PlugController player;
    // Start is called before the first frame update
    void Start()
    {
        startingTime = 2.0f;
        timerTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTime > 0.0f)
        {
            timerTime -= Time.deltaTime;
            timer.text = timerTime.ToString();
        }
        else
        {
            timer.text = "0.00000";
            player.isDead = true;
            player.LockMovement();
        }
    }
}
