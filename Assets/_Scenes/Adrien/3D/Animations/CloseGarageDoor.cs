using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGarageDoor : MonoBehaviour {

    public Animator GarageDoorAnimator;
    public AnimationClip GarageDoorClosingCiip;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            GarageDoorAnimator.SetBool("Closing", true);
        }
    }

}
