using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Text text;
    private Controls player;
    
    // Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "Score: " + player.score;
		
	}
}
