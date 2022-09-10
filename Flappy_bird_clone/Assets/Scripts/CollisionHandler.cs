using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    Score scorescript;
    private void Start()
    {
        scorescript = FindObjectOfType<Score>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
        if (other.gameObject.name == "scoreUpdate")
        {
            scorescript.UpdateScore();
        }
    }
}
