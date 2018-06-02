using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbMove : MonoBehaviour {

    public float movespeed;
    private float modifiedSpeed;
    private Controls player;
    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<Controls>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        modifiedSpeed = (movespeed * 1 + (player.playtime / 45));
        transform.Translate(-Vector2.right * modifiedSpeed  * Time.deltaTime);
		
	}
}
