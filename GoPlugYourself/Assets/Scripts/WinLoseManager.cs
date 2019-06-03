using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseManager : MonoBehaviour
{
    public bool timeRanOut;
    public bool won;
    private bool winMessage = false;
    public GameObject timeRanOutPrefab;
    public GameObject winLevel1;
    public GameObject winLevel2;
    public GameObject winLevel3;
    public GameObject winLevel4;
    public GameObject winLevelFree;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
        timeRanOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRanOut)
        {
            //instantiate a thingy
            Instantiate(timeRanOutPrefab, transform);
        }
        if (won)
        {
            //instantiate a thingy
            if (!winMessage)
            {
                winMessage = true;
                switch (SceneManager.GetActiveScene().buildIndex)
                {
                    case 1:
                        Instantiate(winLevel1);
                        break;
                    case 2:
                        Instantiate(winLevelFree, transform);
                        break;
                    case 3:
                        Instantiate(winLevel2, transform);
                        break;
                    case 4:
                        Instantiate(winLevel3, transform);
                        break;
                    case 5:
                        Instantiate(winLevel4, transform);
                        break;
                    default: break;
                }
            }
        }
    }
}
