using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeauScript : MonoBehaviour {

    public AudioSource mAudioSource;
    public AudioClip[] soundsSeau;

	// Use this for initialization
	void Start () {
        mAudioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
        Debug.Log("COUCOUZZZ");

        int r = Random.Range(0, 1);
        mAudioSource.clip = soundsSeau[r];

        if (col.gameObject.tag.Equals("Player") && !mAudioSource.isPlaying)
        {
            mAudioSource.Play();
        }
    }
}
