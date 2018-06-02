using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOrb : MonoBehaviour {
    private Controls player;
    private int orbcolor;//0123 - RYBG
    //public AudioSource soundCue;
    public GameObject plus3;
    public GameObject minus2;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Controls>();
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    private int getOrbColor(GameObject orb)
    {
        switch (orb.tag)
        {
            case "R":
                orbcolor = 0;
                break;
            case "Y":
                orbcolor = 1;
                break;
            case "B":
                orbcolor = 2;
                break;
            case "G":
                orbcolor = 3;
                break;
       }
        return orbcolor;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bounds")
        {
            Destroy(gameObject);
            
        }

        if (other.tag == "Player")
        {
            
            if(player.color == getOrbColor(gameObject))
            {
                player.score++;
                player.lifetime += 3;
                Instantiate(plus3, player.transform.position, player.transform.rotation);
                Destroy(gameObject);
                
                //soundCue.Play();
            }
            else if (player.color != getOrbColor(gameObject))
            {
                Instantiate(minus2, player.transform.position, player.transform.rotation);
                player.lifetime -= 2;
                Destroy(gameObject);
            }
            
            

        }
    }
}
