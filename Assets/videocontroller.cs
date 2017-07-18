using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videocontroller : MonoBehaviour {

    public GameObject screen;
    public VideoClip clip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            screen.GetComponent<VideoPlayer>().clip = clip;
            screen.GetComponent<VideoPlayer>().isLooping = false;
            screen.GetComponent<VideoPlayer>().Play();
            
        }
		
	}
}
