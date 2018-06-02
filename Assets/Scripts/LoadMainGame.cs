using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainGame : MonoBehaviour {
    private Controls player;
	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<Controls>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player.lifetime <= 0)
        {
            SceneManager.LoadScene("Main_game");
        }
		
	}
}
