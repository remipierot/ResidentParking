using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class TimerSoundPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioClip m_Sound;
    [SerializeField]
    private AudioSource m_AudioSource;
    [SerializeField]
    private int seconde = 2;

    void Start()
    {
        m_AudioSource.clip = m_Sound;
        Invoke("PlaySound", 2);        
    }

    void PlaySound()
    {
        m_AudioSource.Play();
    }
}