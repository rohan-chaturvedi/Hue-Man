using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {
    private Controls player;

	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<Controls>();
		
	}

    public void changeColorRed()
    {
        player.color = 0;
        

    }
    public void changeColorYellow()
    {
        player.color = 1;
        
    }
    public void changeColorBlue()
    {
        player.color = 2;
        
    }
    public void changeColorGreen()
    {
        player.color = 3;
       
    }

    // Update is called once per frame
    void Update () {
		
	}
}
