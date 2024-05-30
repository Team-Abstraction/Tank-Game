using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{ 
    GameManager gameManager;
    public LayerMask playerMask;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("столкновение");
        //SceneManager.LoadScene("Menu"); 
        if (((1 << collision.gameObject.layer) & playerMask) != 0)
        {
            Debug.Log("столкновение");
            gameManager.SaveData();
            gameManager.LoadNextLevel();
        }
    }

}
