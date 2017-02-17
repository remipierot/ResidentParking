using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour {
	public AudioClip OpeningSound;
	public AudioClip ClosingSound;

	private Animator _Animator;
	private AudioSource _Sound;
	private bool _AbleToOpen;
	private bool _DoorOpened;

	void Start ()
	{
		_Animator = GetComponent<Animator>();
		_Sound = GetComponent<AudioSource>();
		_AbleToOpen = false;
		_DoorOpened = false;
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.E) && _AbleToOpen && !_DoorOpened)
		{
			OpenDoor();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		_AbleToOpen = true && !_DoorOpened;
	}

	private void OnTriggerExit(Collider other)
	{
		_AbleToOpen = false;

        if (_DoorOpened)
        {
            CloseDoor();
        }
	}

	void OpenDoor()
	{
		_Animator.SetBool("Open", true);
		_Animator.SetBool("Standby", false);
		_Sound.PlayOneShot(OpeningSound);
		_DoorOpened = true;
	}

	void CloseDoor()
	{
		_Animator.SetBool("Open", false);
		_Animator.SetBool("Standby", false);
		_Sound.PlayOneShot(ClosingSound);
	}

	void GoStandby()
	{
		_Animator.SetBool("Standby", true);
	}
}
