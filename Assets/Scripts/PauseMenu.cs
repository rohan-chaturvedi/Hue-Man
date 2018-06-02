using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool isPaused = false;
    public GameObject PauseMenuCanvas;
    //public GameObject UICanvas;
    

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update ()
    {
        if (isPaused)
        {
            PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }

        else
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

    }

    public void Resume()
    {
        isPaused = false;

    }

    public void Pause()
    {
        isPaused = true;

    }

    public void Restart()
    {
        SceneManager.LoadScene("Main_game");

    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
