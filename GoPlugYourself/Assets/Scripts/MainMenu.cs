using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public PlugGenerator plugLeft;
    public PlugGenerator plugRight;
    public Button playButton;

    private Rigidbody2D rb2dLeft;
    private Rigidbody2D rb2dRight;

    public void ClickPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void ClickOptions()
    {
        rb2dLeft = plugLeft.GetComponent<Rigidbody2D>();
        rb2dRight = plugRight.GetComponent<Rigidbody2D>();
        rb2dLeft.MovePosition(rb2dLeft.transform.position + new Vector3(1,0));
        rb2dRight.MovePosition(rb2dRight.transform.position + new Vector3(-1, 0));
    }

    public void ClickQuit()
    {
        Application.Quit();
    }
}
