using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {
    public float restartDelay = 5f;
    private Controls player;
    Animator anim;
    float restartTimer;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<Controls>();

    }
	
	// Update is called once per frame
	void Update () {
        if (player.lifetime <= 0)
        {
            anim.SetTrigger("GameOver");
            restartTimer += Time.deltaTime;
            if(restartTimer >= restartDelay)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
		
	}
}
