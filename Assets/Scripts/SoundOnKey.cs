using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundOnKey : MonoBehaviour
{

    [SerializeField]
    private AudioClip m_AmbiantSounds;
    [SerializeField]
    private AudioSource m_AudioSource;


    void Start()
    {
        m_AudioSource.clip = m_AmbiantSounds;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            m_AudioSource.Play();
        }
    }
}
