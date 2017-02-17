using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AmbiantSound : MonoBehaviour
{

    [SerializeField] private AudioClip m_AmbiantSounds;
    [SerializeField] private AudioSource m_AudioSource;


    void Start()
    {
        m_AudioSource.clip = m_AmbiantSounds;
        m_AudioSource.Play();
    }
}