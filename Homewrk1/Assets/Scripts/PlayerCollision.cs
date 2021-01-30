using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMove movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            if(SceneManager.GetActiveScene().name != "StartScreen")
            {
                movement.enabled = false;
            }
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

   
}