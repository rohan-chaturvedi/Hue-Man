using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {
    private ParticleSystem ps1;
	// Use this for initialization
	void Start ()
    {
        ps1 = GetComponent<ParticleSystem>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ps1.isPlaying)
        {
            return;
        }
        Destroy(gameObject);
		
	}
}
