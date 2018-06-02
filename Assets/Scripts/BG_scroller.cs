using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_scroller : MonoBehaviour
{
    public float scrollSpeed = 5.0f;
    Renderer bg;

	// Use this for initialization
	void Start ()
    {
        bg = GetComponent<Renderer>();
               
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        bg = GetComponent<Renderer>();
        float offset = Time.time * scrollSpeed;
        bg.material.mainTextureOffset = new Vector2(offset, 0);


    }
}

