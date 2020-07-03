using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    public static GM instance = null;

    public int Lives = 6;


    public GameObject PauseMenu;

    //Text items and the like
    public GameObject gameOver;
    public Text LivesText;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1;

    }

    public void DestroyMob()
    {

    }

    private void CheckGameOver()
    {
        if (Lives < 1)
        {
            GameOver();
     
        }
    }


    private void GameOver()
    {
        gameOver.SetActive(true);
        Invoke("EndGame", 1);

      
    }

    private void timeFreeze()
    {
        Time.timeScale = 0;
    }


    void EndGame()
    {
        SceneManager.LoadScene("Title");
    }



    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PausedMenu();
        }
    }

    private void PausedMenu()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void UnPauseMenu()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Done()
    {
        SceneManager.LoadScene("Title");
    }

    public void LooseLife()
    {
        Lives--;
        LivesText.text = "Lives: " + Lives;
        CheckGameOver();
    }



}
