using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollide : MonoBehaviour
{
    public PlayerMovement movement;
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Block") {
            movement.enabled = false;
            Invoke("Restart", 2f);
        }
        if (collisionInfo.collider.name == "Block (1)")
        {
            movement.enabled = false;
            Invoke("Restart", 2f);
        }
        if (collisionInfo.collider.name == "Cube")
        {
            movement.enabled = false;
            Invoke("Restart", 2f);
        }
        if (collisionInfo.collider.name == "Ground")
        {
            movement.enabled = false;
            Invoke("Restart", 2f);
        }
    }
}
