using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUi;
    public Rigidbody playerRB;
    public PlayerMove movement;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            if (SceneManager.GetActiveScene().name == "StartScreen")
            {
                Invoke("resetPlayerPosition", 1f); 
            }
            else
            {
                Invoke("Restart", restartDelay);
            }
            gameHasEnded = true;
        }
    }

    public void completeLevel()
    {
        movement.enabled = false; 
        completeLevelUi.SetActive(true);
    }

    void Restart()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void resetPlayerPosition()
    {
        playerRB.transform.position = (new Vector3(Random.Range(-6.0f,6.0f), 1f, -15f));
        playerRB.transform.rotation = (Quaternion.identity);
        playerRB.velocity = (new Vector3(0f, 0f, 0f));
        gameHasEnded = false;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
