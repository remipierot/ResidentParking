using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGarageDoor : MonoBehaviour {

    public Animator GarageDoorAnimator;
    public AnimationClip GarageDoorClosingCiip;
    
    [SerializeField] private AudioClip m_AmbiantSounds;
    [SerializeField] private AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource.clip = m_AmbiantSounds;

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            GarageDoorAnimator.SetBool("Closing", true);
            m_AudioSource.Play();
        }
    }

}
