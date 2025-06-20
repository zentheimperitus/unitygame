using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    private bool levelCompleted = false;

    void Update()
    {
        // Restart with R anytime after level complete
        if (levelCompleted && Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

    }
    public void CompleteLevel()     
    {
        levelCompleted = true;

        completeLevelUI.SetActive(true);
        if (Input.GetKey("r"))
        {

            Invoke("Restart", restartDelay);

        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAMEOVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
