using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    //game timer
    
    private int seconds = 0;
    private int minutes = 0;
    //life timer
    
    private int lifeseconds = 0;
    private int lifeminutes = 0;
    Text text;
    private Controls player;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();
        player.lifetime = 10;
        player.playtime = 0;
        StartCoroutine("gameTimer");
        lifeseconds = player.lifetime % 60;
        lifeminutes = (player.lifetime / 60) % 60;

    }

    private IEnumerator gameTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            player.playtime += 1;
            seconds = player.playtime % 60;
            minutes = (player.playtime / 60) % 60;

            player.lifetime -= 1;
            lifeseconds = player.lifetime % 60;
            lifeminutes = (player.lifetime / 60) % 60;
        }
    }
	
    
	// Update is called once per frame
	void Update ()
    {
        text.text = "Time: " + lifeminutes + ":" + lifeseconds;
		
	}
}
