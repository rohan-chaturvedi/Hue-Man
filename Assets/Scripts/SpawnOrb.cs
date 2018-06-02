using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOrb : MonoBehaviour {

    public Transform[] spawnPoints;//will hold all spawnpoints
    public float spawnDelay = 1.5f;
    public GameObject[] Orbs;//will hold all possible colors of orbs
    
    // Use this for initialization
	void Start ()
    {
        InvokeRepeating("spawnOrbs", spawnDelay, spawnDelay);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void spawnOrbs()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);//gets random spawn point from array
        int orbColorIndex = Random.Range(0, Orbs.Length);//gets random index from spawnarray
        Instantiate(Orbs[orbColorIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
